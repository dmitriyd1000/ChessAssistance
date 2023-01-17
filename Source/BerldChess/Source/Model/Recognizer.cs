﻿using ChessDotNet;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BerldChess.View;
using DarknetYolo;
using ChessDotNet.Pieces;
using System.Text;

namespace BerldChess.Model
{
    public static class Recognizer
    {
        #region Fields

        private const int SideLength = 8;
        public static ChessGame _newChessBoard = null;

        #endregion

        #region Properties

        public static bool BoardFound { get; private set; }
        public static int ScreenIndex { get; private set; } = -1;
        public static int MinimumSize { get; set; } = 32;
        public static Point BoardLocation { get; private set; }
        public static Size BoardSize { get; private set; }
        public static SizeF FieldSize { get; set; }

        private class CellBoard
        {
            public Bitmap _bitmapColor;
            public Bitmap _bitmapGray;
            public double _averageGray;
            public double _varianceGray;
            public string _recognPiece;
            public string _squareColor;
            public string _pieceColor;

            public void Calculate()
            {
                MakeGrayscaleBitmap();
                    // _bitmapGray.Save(@"C:\Users\dmytro.dmytriiev\source\repos\BerldChess\Source\BerldChess\cell_gray.bmp");
                CalcAverageGrayImg();
                CalcVarianceGrayColor();
            }

            private void CalcAverageGrayImg()
            {
                Rectangle rect = new Rectangle(0, 0, _bitmapGray.Width, _bitmapGray.Height);
                BitmapData imageData = _bitmapGray.LockBits(rect, ImageLockMode.ReadWrite, _bitmapGray.PixelFormat);
                IntPtr ptr = imageData.Scan0;
                int bytes = Math.Abs(imageData.Stride) * _bitmapGray.Height;
                byte[] grayValues = new byte[bytes];
                System.Runtime.InteropServices.Marshal.Copy(ptr, grayValues, 0, bytes);
                var sum = 0;
                int w = 1;
                foreach (int x in grayValues)
                {
                    if (w <= _bitmapGray.Width)
                        sum += x;
                    if (w >= imageData.Stride)
                        w = 1;
                    else
                        w++;
                }
                _bitmapGray.UnlockBits(imageData);
                _averageGray = sum / grayValues.Length;
            }

            private void CalcVarianceGrayColor()
            {
                Rectangle rect = new Rectangle(0, 0, _bitmapGray.Width, _bitmapGray.Height);
                BitmapData imageData = _bitmapGray.LockBits(rect, ImageLockMode.ReadWrite, _bitmapGray.PixelFormat);
                IntPtr ptr = imageData.Scan0;
                int bytes = Math.Abs(imageData.Stride) * _bitmapGray.Height;
                byte[] grayValues = new byte[bytes];
                Marshal.Copy(ptr, grayValues, 0, bytes);
                double variance = 0f;
                int w = 1;
                foreach (int x in grayValues)
                {
                    if (w <= _bitmapGray.Width)
                        variance += ((x - _averageGray)/255)*((x - _averageGray)/255);
                    if (w >= imageData.Stride)
                        w = 1;
                    else
                        w++;
                }
                _bitmapGray.UnlockBits(imageData);
                _varianceGray = variance / grayValues.Length;
            }
            
            private void MakeGrayscaleBitmap()
            {
                //Lock bitmap's bits to system memory
                Rectangle rect = new Rectangle(0, 0, _bitmapColor.Width, _bitmapColor.Height);
                BitmapData bmpColorData = _bitmapColor.LockBits(rect, ImageLockMode.ReadWrite, _bitmapColor.PixelFormat);
                _bitmapGray = new Bitmap(_bitmapColor.Width, _bitmapColor.Height, PixelFormat.Format8bppIndexed);
                
                var resultPalette = _bitmapGray.Palette;
                for (int i = 0; i < 256; i++)
                {  resultPalette.Entries[i] = Color.FromArgb(255, i, i, i);  }
                _bitmapGray.Palette = resultPalette;
                
                BitmapData bmpGrayData = _bitmapGray.LockBits(rect, ImageLockMode.ReadWrite, _bitmapGray.PixelFormat);
                IntPtr ptrColor = bmpColorData.Scan0;
                IntPtr ptrGray = bmpGrayData.Scan0;

                //Declare an array in which your RGB values will be stored
                int bytesColor = Math.Abs(bmpColorData.Stride) * _bitmapColor.Height;
                int bytesGray = Math.Abs(bmpGrayData.Stride) * _bitmapGray.Height;
                byte[] rgbValues = new byte[bytesColor];
                byte[] grayValues = new byte[bytesGray];

                //Copy RGB values in that array
                Marshal.Copy(ptrColor, rgbValues, 0, bytesColor);
                byte gray = 0;
                int z = 0;
                int y = 0;
                for (int x = 0; x < _bitmapColor.Height; x += 1)
                {
                    y = 0;
                    while (y < bmpColorData.Stride)
                    {
                        if (y<_bitmapColor.Width*3)
                        {
                            gray = (byte)(rgbValues[x * bmpColorData.Stride + y] * .21 +
                                               rgbValues[x * bmpColorData.Stride + y + 1] * .71 +
                                               rgbValues[x * bmpColorData.Stride + y + 2] * .071);
                            grayValues[z] = gray;
                            y += 3;
                        } else if (y >= _bitmapColor.Width*3) 
                        {
                            while (z < bmpGrayData.Stride*(x+1))
                            {
                                grayValues[z] = rgbValues[x * bmpColorData.Stride + y];
                                z++;
                            }
                            z--;
                            y++;
                        }
                        z++;
                    }
                }

                //Copy changed Gray values back to bitmap
                Marshal.Copy(grayValues, 0, ptrGray, bytesGray);
                
                _bitmapColor.UnlockBits(bmpColorData);
                _bitmapGray.UnlockBits(bmpGrayData);
            }
        }

        private static Bitmap[] PieceImages { get; set; } = new Bitmap[12];

        #endregion

        #region Methods

        public static void DetectPieces(Bitmap boardSnapshot, DarknetYOLO model, FormMain sender)
        {
            if (boardSnapshot == null)
                return;
            var cellSizeWidth = (int) boardSnapshot.Width / 8;
            var cellSizeHeight = (int) boardSnapshot.Height / 8;
            var startCurrRow = 0;
            var startCurrColumn = 0;
            CellBoard[][] cellsBoard = new CellBoard[8][]
            {
                new CellBoard[8], new CellBoard[8], new CellBoard[8], new CellBoard[8], new CellBoard[8],
                new CellBoard[8], new CellBoard[8], new CellBoard[8]
            };
            
            Dictionary<string, ChessPiece> dicRecognPieses = new Dictionary<string, ChessPiece>()
            {
                { "BishopW", new Bishop(ChessPlayer.White) },
                { "KingW", new King(ChessPlayer.White) },
                { "KnightW", new Knight(ChessPlayer.White) },
                { "PawnW", new Pawn(ChessPlayer.White) },
                { "QueenW", new Queen(ChessPlayer.White)  },
                { "RookW", new Rook(ChessPlayer.White) },
                { "BishopB", new Bishop(ChessPlayer.Black) },
                { "KingB", new King(ChessPlayer.Black) },
                { "KnightB", new Knight(ChessPlayer.Black)  },
                { "PawnB", new Pawn(ChessPlayer.Black) },
                { "QueenB", new Queen(ChessPlayer.Black) },
                { "RookB", new Rook(ChessPlayer.Black) }
            };
            
            
            model.NMSThreshold = 0.4f;
            model.ConfidenceThreshold = (float)sender.numbxTolleranceRecogn.Value;

            GameCreationData newData = new GameCreationData();
            newData.WhoseTurn = sender.rbutWhiteTurn.Checked ? ChessPlayer.White : ChessPlayer.Black;
            newData.CanBlackCastleKingSide = sender.chkbxCanBlackCastleKingSide.Checked;
            newData.CanBlackCastleQueenSide = sender.chkbxCanBlackCastleQueenSide.Checked;
            newData.CanWhiteCastleKingSide = sender.chkbxCanWhiteCastleKingSide.Checked;
            newData.CanWhiteCastleQueenSide = sender.chkbxCanWhiteCastleQueenSide.Checked;
            newData.EnPassant = null; // sender.chkbxEnPassant.Checked;
            
            // split in cells
            int bitmapRow = 8;
            int chessRow = 0;

            sender.prgbarRecognition.Value = 0;
            sender.btnCancelRecogn.Enabled = true;
            var timer = new Stopwatch();
            timer.Start();
            while (bitmapRow --> 0)
            {
                startCurrRow = cellSizeHeight * bitmapRow;
                
                for (int column = 0; column < 8; column++)
                {
                    startCurrColumn = cellSizeWidth * column;
                                 Rectangle rect =
                                     new Rectangle(startCurrColumn, startCurrRow,
                                                    cellSizeWidth, cellSizeHeight);
                    cellsBoard[chessRow][column] = new CellBoard
                    {
                        _bitmapColor = boardSnapshot.Clone(rect, PixelFormat.Format24bppRgb)
                    };
                    //cellsBoard[chessRow][column]._bitmapColor
                    //    .Save(@"C:\Users\dmytro.dmytriiev\source\repos\BerldChess\Source\BerldChess\cell.bmp");
                    List<YoloPrediction> results = model.Predict(cellsBoard[chessRow][column]._bitmapColor, 512, 512);
                    if (results.Count > 0)
                        cellsBoard[chessRow][column]._recognPiece = results.First(c => Math.Abs(c.Confidence - results.Max(x => x.Confidence)) < 0.1f).Label;
                    sender.prgbarRecognition.Value = (column+1) + (chessRow)*8;
                }
                chessRow++;
            }
            sender.btnCancelRecogn.Enabled = false;
            timer.Stop();
            TimeSpan timeTaken = timer.Elapsed;
            sender.lbLastRecognTime.Text = timeTaken.ToString(@"m\:ss\.fff");
            //if (sender.cancellationTokenStopRecogntion.IsCancellationRequested)
            //    return;

            ChessPiece[][] board = new ChessPiece[8][];
            bool isWhiteSide = sender._chessPanel.Game.WhoseTurn == ChessPlayer.White && !sender._chessPanel.IsFlipped;
            int r = sender.rbutWhiteTurn.Checked ? 7 :0;
            int step_r = sender.rbutWhiteTurn.Checked ? -1 :1;
            for (int r_dest=0; r_dest < 8; r_dest++)
            {
                ChessPiece[] currentRow = new ChessPiece[8] { null, null, null, null, null, null, null, null };
                int c = sender.rbutWhiteTurn.Checked ? 0 : 7;
                int step_c = sender.rbutWhiteTurn.Checked ? 1 : -1;
                for (int c_dest=0; c_dest < 8; c_dest++)
                {
                    if (cellsBoard[r][c]._recognPiece != null)
                        currentRow[c_dest] = dicRecognPieses.ContainsKey(cellsBoard[r][c]._recognPiece)
                            ? dicRecognPieses[cellsBoard[r][c]._recognPiece]
                            : null;
                    c += step_c;
                } 
                board[r_dest] = currentRow;
                r += step_r;
            }

            sender._menuItemFlipBoard.Checked=isWhiteSide&&newData.WhoseTurn == ChessPlayer.Black;
            newData.Board = board;
            _newChessBoard = new ChessGame(newData);
        }

        public static Bitmap GetBoardSnap()
        {
            if (!BoardFound)
                return null;

            Screen screen = Screen.AllScreens[ScreenIndex];
            Bitmap scrennshot = new Bitmap(BoardSize.Width, BoardSize.Height, PixelFormat.Format24bppRgb);

            using (Graphics g = Graphics.FromImage(scrennshot))
            {
                g.CopyFromScreen(screen.Bounds.X + BoardLocation.X, screen.Bounds.Y + BoardLocation.Y, 0, 0, BoardSize, CopyPixelOperation.SourceCopy);
            }

            return scrennshot;
        }
        
        #endregion
    }
    
    
}
