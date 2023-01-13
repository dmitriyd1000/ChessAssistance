using ChessDotNet;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DarknetYolo;
using ChessDotNet.Pieces;
using ChessDotNet;

namespace BerldChess.Model
{
    public static class Recognizer
    {
        #region Fields

        private const int SideLength = 8;
        private static Bitmap _lastBoardSnap;
        public static ChessGame newChessBoard = null;

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
                _bitmapGray.Save(@"C:\Users\dmytro.dmytriiev\source\repos\BerldChess\Source\BerldChess\cell_gray.bmp");
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
                    if (w > _bitmapGray.Width)
                        sum = sum;
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

        public static void UpdateBoardImage(Bitmap image)
        {
            if (image!=null)
            {
                _lastBoardSnap = image;
            }
        }

        public static void DetectPieces()
        {
            if (_lastBoardSnap == null)
                return;
            var cellSizeWidth = (int) _lastBoardSnap.Width / 8;
            var cellSizeHeight = (int) _lastBoardSnap.Height / 8;
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
            
            DarknetYOLO darknetYolo = new DarknetYOLO();
            darknetYolo.NMSThreshold = 0.4f;
            darknetYolo.ConfidenceThreshold = 0.98f;
            // split in cells
            int bitmapRow = 8;
            int chessRow = 0;
            double minCellGrayVariance = 2;

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
                        _bitmapColor = _lastBoardSnap.Clone(rect, PixelFormat.Format24bppRgb)
                    };
                    //cellsBoard[chessRow][column]._bitmapColor
                    //    .Save(@"C:\Users\dmytro.dmytriiev\source\repos\BerldChess\Source\BerldChess\cell.bmp");
                    List<YoloPrediction> results = darknetYolo.Predict(cellsBoard[chessRow][column]._bitmapColor, 512, 512);
                    if (results.Count > 0)
                        cellsBoard[chessRow][column]._recognPiece = results.First(c => Math.Abs(c.Confidence - results.Max(x => x.Confidence)) < 0.1f).Label;
                    //cellsBoard[chessRow][column].Calculate();
                    //if (minCellGrayVariance < cellsBoard[chessRow][column]._varianceGray)
                    //    minCellGrayVariance = cellsBoard[chessRow][column]._varianceGray;
                }
                chessRow++;
            }

            ChessPiece[][] board = new ChessPiece[8][];
            int l = 7;
            for (int i = 0; i < 8; i++)
            {
                ChessPiece[] currentRow = new ChessPiece[8] { null, null, null, null, null, null, null, null };
                int k = 7;
                for (int j = 0; j < 8; j++)
                {
                    if (cellsBoard[l][j]._recognPiece!=null)
                        currentRow[j] = dicRecognPieses.ContainsKey(cellsBoard[l][j]._recognPiece)
                            ? dicRecognPieses[cellsBoard[l][j]._recognPiece]
                            : null;
                    k--;
                }
                board[i] = currentRow;
                l--;
            }

            GameCreationData newData = new GameCreationData();
            newData.Board = board;
            newData.WhoseTurn = ChessPlayer.White;
            newData.CanBlackCastleKingSide = true;
            newData.CanBlackCastleQueenSide = true;
            newData.CanWhiteCastleKingSide = true;
            newData.EnPassant = null;

            newChessBoard = new ChessGame(newData);
        }

        private static unsafe bool Match(byte* pointer, Color color)
        {
            return pointer[0] == color.B &&
                   pointer[1] == color.G &&
                   pointer[2] == color.R;
        }

        public static GameCreationData GetCurrentState()
        {
            _lastBoardSnap = GetBoardSnap();

            GameCreationData data = new GameCreationData();

            ChessPiece[][] chessPieces = new ChessPiece[8][];

            BitmapData[] pieceData = new BitmapData[12];

            for (int i = 0; i < pieceData.Length; i++)
            {
                pieceData[i] = LockBits(PieceImages[i]);
            }

            for (int y = 0; y < 8; y++)
            {
                chessPieces[y] = new ChessPiece[8];

                for (int x = 0; x < 8; x++)
                {
                    int yOffset = (int)(y * FieldSize.Height) + 1;
                    int xOffset = (int)(x * FieldSize.Width) + 1;

                    for (int pieceI = 0; pieceI < PieceImages.Length; pieceI++)
                    {

                        for (int aY = 0; aY < FieldSize.Height; aY++)
                        {
                            for (int aX = 0; aX < FieldSize.Width; aX++)
                            {


                            }
                        }

                    }
                }
            }

            for (int i = 0; i < pieceData.Length; i++)
            {
                PieceImages[i].UnlockBits(pieceData[i]);
            }

            return data;
        }

        public static Point[] GetChangedSquares(Bitmap boardSnap)
        {
            if (!BoardFound)
                return null;

            double fieldWidth = boardSnap.Width / (double)SideLength;
            double fieldHeight = boardSnap.Height / (double)SideLength;
            var changedSquares = new List<Point>();

            unsafe
            {
                BitmapData snapData = LockBits(boardSnap);
                BitmapData lastSnapData = LockBits(_lastBoardSnap);

                var scan0 = (byte*)snapData.Scan0;
                var lastScan0 = (byte*)lastSnapData.Scan0;

                for (int y = 0; y < SideLength; y++)
                {
                    for (int x = 0; x < SideLength; x++)
                    {
                        Point border = new Point()
                        {
                            X = Round((x * fieldWidth + 4)),
                            Y = Round((y * fieldHeight + 4))
                        };

                        Point center = new Point()
                        {
                            X = Round((x * fieldWidth + (fieldWidth / 2.0))),
                            Y = Round((y * fieldHeight + fieldHeight * 0.73))
                        };

                        int borderColor = GetPixel(scan0, snapData.Stride, border);
                        int centerColor = GetPixel(scan0, snapData.Stride, center);
                        bool same = borderColor == centerColor;

                        int lastBorderColor = GetPixel(lastScan0, lastSnapData.Stride, border);
                        int lastCenterColor = GetPixel(lastScan0, lastSnapData.Stride, center);
                        bool lastSame = lastBorderColor == lastCenterColor;

                        if (same != lastSame)
                        {
                            changedSquares.Add(new Point(x, y));
                        }
                        else if (!same && centerColor != lastCenterColor)
                        {
                            changedSquares.Add(new Point(x, y));
                        }
                    }
                }

                boardSnap.UnlockBits(snapData);
                _lastBoardSnap.UnlockBits(lastSnapData);
            }

            return changedSquares.ToArray();
        }

        private static BitmapData LockBits(Bitmap bitmap)
        {
            return bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadOnly, PixelFormat.Format24bppRgb);
        }

        public static bool CompareBitmaps(Bitmap bitmap1, Bitmap bitmap2)
        {
            try
            {
                bool equals = true;

                Rectangle rect = new Rectangle(0, 0, bitmap1.Width, bitmap1.Height);
                BitmapData bitmapData1 = bitmap1.LockBits(rect, ImageLockMode.ReadOnly, bitmap1.PixelFormat);
                BitmapData bitmapData2 = bitmap2.LockBits(rect, ImageLockMode.ReadOnly, bitmap2.PixelFormat);

                unsafe
                {
                    var pointer1 = (byte*)bitmapData1.Scan0.ToPointer();
                    var pointer2 = (byte*)bitmapData2.Scan0.ToPointer();
                    int width = rect.Width * 3;

                    for (int y = 0; equals && y < rect.Height; y++)
                    {
                        for (int x = 0; x < width; x++)
                        {
                            if (*pointer1 != *pointer2)
                            {
                                equals = false;
                                break;
                            }

                            pointer1++;
                            pointer2++;
                        }

                        pointer1 += bitmapData1.Stride - width;
                        pointer2 += bitmapData2.Stride - width;
                    }
                }

                bitmap1.UnlockBits(bitmapData1);
                bitmap2.UnlockBits(bitmapData2);

                return equals;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }

            return false;
        }

        private static unsafe int GetPixel(byte* scan0, int stride, Point location)
        {
            var pointer = scan0;
            pointer += location.Y * stride + location.X * 3;
            return pointer[0] * 255 * 255 + pointer[1] * 255 + pointer[2];
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

        private static bool IsSameColor(Color color1, Color color2, int tolerance)
        {
            return tolerance >= Math.Abs(color1.R - color2.R) + Math.Abs(color1.G - color2.G) + Math.Abs(color1.B - color2.B);
        }

        private static int Round(double number)
        {
            return (int)Math.Round(number, 0);
        }

        #endregion
    }
}
