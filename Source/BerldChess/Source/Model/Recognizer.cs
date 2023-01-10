using ChessDotNet;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using DarknetYolo;

namespace BerldChess.Model
{
    public static class Recognizer
    {
        #region Fields

        private const int SideLength = 8;
        private static Bitmap _lastBoardSnap;

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
            private Bitmap bitmap;
            private float  avgGrayColor;
            private string recognPiece;
            private string squareColor;
            private string pieceColor;

            private float CalcAvgGrayColor()
            {
                if (bitmap != null)
                {
                    
                }
            }
        }

        private static Bitmap[] PieceImages { get; set; } = new Bitmap[12];

        #endregion

        #region Methods

        public static void UpdateBoardImage(Bitmap image)
        {
            if (BoardFound)
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
            
            DarknetYOLO darknetYolo = new DarknetYOLO();
            darknetYolo.NMSThreshold = 0.4f;
            darknetYolo.ConfidenceThreshold = 0.5f;
            // split in cells
            for (int row = 0; row < 8; row++)
            {
                startCurrRow = cellSizeHeight * row;
                for (int column = 0; column < 8; column++)
                {
                    startCurrColumn = cellSizeWidth * column;
                                 Rectangle rect =
                                     new Rectangle(startCurrRow, startCurrColumn,
                                                    cellSizeWidth, cellSizeHeight);
                    Bitmap cellImage = _lastBoardSnap.Clone(rect, _lastBoardSnap.PixelFormat);
                    // define 
                    List<YoloPrediction> results = darknetYolo.Predict(cellImage, 512, 512);
                }
            }
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
