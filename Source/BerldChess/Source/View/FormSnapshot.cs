using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using BerldChess.Model;
using BerldChess.View;

namespace BerldChess.Source.View
{
    public partial class FormSnapshot : Form
    {
        #region:::::::::::::::::::::::::::::::::::::::::::Form level declarations:::::::::::::::::::::::::::::::::::::::::::
        public Bitmap _boardSnapshot;
        private int _oldPosX;
        private int _oldPosY;
        private bool _mouseDown;

        private FormMain _mInstanceRef;
        public FormMain InstanceRef
        {
            get => _mInstanceRef;
            set => _mInstanceRef = value;
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
        }
        #endregion


        internal  Bitmap GetScreenshot(FormSnapshot form)
        {
            //Allow 250 milliseconds for the screen to repaint itself (we don't want to include this form in the capture)
            System.Threading.Thread.Sleep(250);
            float scalingFactor = GetScalingFactor(Screen.FromControl(form));
            Size s1 =  form.Size;
            s1.Width = (int) Math.Round(s1.Width*scalingFactor - 18);
            s1.Height = (int) Math.Round(s1.Height*scalingFactor);
            _boardSnapshot = new Bitmap(s1.Width, s1.Height);
            Graphics graphics = Graphics.FromImage(_boardSnapshot);
            graphics.CopyFromScreen((int) Math.Round(form.Location.X*scalingFactor+10), 
                (int) Math.Round(form.Location.Y*scalingFactor), 0, 0, s1);
            //boardSnapshot.Save(@"C:\Users\dmytro.dmytriiev\source\repos\BerldChess\Source\BerldChess\Resources\Images\snapshot.bmp");
            return _boardSnapshot;
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
        
        private static float GetScalingFactor(Screen s)
        {
            IntPtr desktop = CreateDC(null,s.DeviceName,null, IntPtr.Zero);
            int logicalScreenHeight = GetDeviceCaps(desktop, (int)DeviceCap.VERTRES);
            int physicalScreenHeight = GetDeviceCaps(desktop, (int)DeviceCap.DESKTOPVERTRES); 

            return (float) physicalScreenHeight / logicalScreenHeight;
        }

        #region Events

        private void FormSnapshot_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseDown)
            {
                this.Left = Cursor.Position.X - _oldPosX;
                this.Top = Cursor.Position.Y - _oldPosY;
            }
        }

        private void FormSnapshot_MouseDown(object sender, MouseEventArgs e)
        {
            _oldPosX = Cursor.Position.X - this.Left;
            _oldPosY = Cursor.Position.Y - this.Top;
            _mouseDown = true;
            this.Cursor = Cursors.NoMove2D;
        }


        private void FormSnapshot_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseDown = false;
            this.Cursor = Cursors.Arrow;
        }

        #endregion

        private void FormSnapshot_Load(object sender, EventArgs e)
        {
            if (SerializedInfo.Instance.FormSnapshotBounds != null)
            {
                Bounds = (Rectangle)SerializedInfo.Instance.FormSnapshotBounds;
            }
        }

        private void FormSnapshot_DoubleClick(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Default;
            SerializedInfo.Instance.FormSnapshotBounds = WindowState == FormWindowState.Maximized ? RestoreBounds : Bounds;
            Hide();
            _boardSnapshot = GetScreenshot(this);
            if (_boardSnapshot != null)
            {
                InstanceRef.SerializeInfo();
                InstanceRef.btnCancelRecogn.Enabled = true;
                Dictionary<string, object> arguments = new Dictionary<string, object>();
                arguments.Add("formSnapshot._boardSnapshot", _boardSnapshot);
                arguments.Add("_chessPanel.Game.WhoseTurn", InstanceRef._chessPanel.Game.WhoseTurn);
                arguments.Add("_chessPanel.IsFlipped", InstanceRef._chessPanel.IsFlipped);
                arguments.Add("backgrndDetectPieces", InstanceRef.backgrndDetectPieces);
                InstanceRef.backgrndDetectPieces.RunWorkerAsync(arguments);
                
                /*arguments.Add("numbxTolleranceRecogn.Value", InstanceRef.numbxTolleranceRecogn.Value);
                arguments.Add("chkbxCanBlackCastleKingSide.Checked", InstanceRef.chkbxCanBlackCastleKingSide.Checked);
                arguments.Add("chkbxCanBlackCastleQueenSide.Checked", InstanceRef.chkbxCanBlackCastleQueenSide.Checked);
                arguments.Add("chkbxCanWhiteCastleKingSide.Checked", InstanceRef.chkbxCanWhiteCastleKingSide.Checked);
                arguments.Add("chkbxCanWhiteCastleQueenSide.Checked", InstanceRef.chkbxCanWhiteCastleQueenSide.Checked);
                */
            }
        }
    }
}