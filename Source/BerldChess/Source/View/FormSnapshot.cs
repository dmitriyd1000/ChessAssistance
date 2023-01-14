using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using BerldChess.Model;
using System.Threading;

namespace BerldChess.View
{
    public partial class FormSnapshot : Form
    {
        #region:::::::::::::::::::::::::::::::::::::::::::Form level declarations:::::::::::::::::::::::::::::::::::::::::::
        public Bitmap boardSnapshot;
        private int oldPosX;
        private int oldPosY;
        private bool mouseDown;

        protected override void OnMouseClick(MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                e = null;
            }

            base.OnMouseClick(e);

        }

        private FormMain m_InstanceRef = null;
        public FormMain InstanceRef
        {
            get
            {
                return m_InstanceRef;
            }
            set
            {
                m_InstanceRef = value;
            }
        }

        #endregion

        #region:::::::::::::::::::::::::::::::::::::::::::Mouse Event Handlers & Drawing Initialization:::::::::::::::::::::::::::::::::::::::::::
        
        public FormSnapshot()
        {
            if (SerializedInfo.Instance.FormSnapshotBounds != null)
            {
                Bounds = (Rectangle)SerializedInfo.Instance.FormSnapshotBounds;
            }
            
            InitializeComponent();
            this.MouseDoubleClick += new MouseEventHandler(mouse_DClick);
        }
        #endregion
        

        public void SaveSelection()
        {
            
            SerializedInfo.Instance.FormSnapshotBounds = WindowState == FormWindowState.Maximized ? RestoreBounds : Bounds;
            Hide();

            //Allow 250 milliseconds for the screen to repaint itself (we don't want to include this form in the capture)
            System.Threading.Thread.Sleep(250);

            //boardSnapshot = new Bitmap(this.Width-18, this.Height);
            //Screen.FromControl(this).
            float scalingFactor = getScalingFactor(Screen.FromControl(this));
            Size s1 = this.Size;
            s1.Width = (int) Math.Round(s1.Width*scalingFactor - 18);
            s1.Height = (int) Math.Round(s1.Height*scalingFactor);
            boardSnapshot = new Bitmap(s1.Width, s1.Height);
            Graphics graphics = Graphics.FromImage(boardSnapshot as Image);
            graphics.CopyFromScreen((int) Math.Round(this.Location.X*scalingFactor+10), 
                (int) Math.Round(this.Location.Y*scalingFactor), 0, 0, s1);
            //boardSnapshot.Save(@"C:\Users\dmytro.dmytriiev\source\repos\BerldChess\Source\BerldChess\Resources\Images\snapshot.bmp");
            /* using (MemoryStream s = new MemoryStream())
            {
                //save graphic variable into memory
                boardSnapshot.Save(s, ImageFormat.Bmp);
                //save snapshot for debug
                boardSnapshot.Save(@"C:\Users\dmytro.dmytriiev\source\repos\BerldChess\Source\BerldChess\Resources\Images\snapshot.bmp");
            } */

            if (boardSnapshot != null)
            {
                Work(boardSnapshot);
            }
        }
        
        private void Work(Bitmap boardBitmap)
        {
            Recognizer.DetectPieces(boardBitmap, FormMain.darknetYolo,  m_InstanceRef);
            if (Recognizer._newChessBoard != null)
            {
                m_InstanceRef.ResetGame(Recognizer._newChessBoard);
            }
        }
        
        private void mouse_DClick(object sender, MouseEventArgs e)
        {
            SaveSelection();
        }
        
        [DllImport("gdi32.dll")]
        static extern IntPtr CreateDC(string lpszDriver, string lpszDevice, string lpszOutput, IntPtr lpInitData);
        
        [DllImport("gdi32.dll")]
        static extern int GetDeviceCaps(IntPtr hdc, int nIndex);
        public enum DeviceCap
        {
            VERTRES = 10,
            DESKTOPVERTRES = 117,

            // http://pinvoke.net/default.aspx/gdi32/GetDeviceCaps.html
        }
        
        private float getScalingFactor(Screen s)
        {
            IntPtr desktop = CreateDC(null,s.DeviceName,null, IntPtr.Zero);
            int LogicalScreenHeight = GetDeviceCaps(desktop, (int)DeviceCap.VERTRES);
            int PhysicalScreenHeight = GetDeviceCaps(desktop, (int)DeviceCap.DESKTOPVERTRES); 

            float ScreenScalingFactor = (float)PhysicalScreenHeight / (float)LogicalScreenHeight;

            return ScreenScalingFactor;
        }

        #region Events

        private void FormSnapshot_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Left = System.Windows.Forms.Cursor.Position.X - oldPosX;
                this.Top = System.Windows.Forms.Cursor.Position.Y - oldPosY;
            }
        }

        private void FormSnapshot_MouseDown(object sender, MouseEventArgs e)
        {
            oldPosX = System.Windows.Forms.Cursor.Position.X - this.Left;
            oldPosY = System.Windows.Forms.Cursor.Position.Y - this.Top;
            mouseDown = true;
            this.Cursor = Cursors.NoMove2D;
        }


        private void FormSnapshot_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
            this.Cursor = Cursors.Arrow;
        }

        #endregion
    }
}