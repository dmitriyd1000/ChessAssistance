using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace BerldChess.View
{
    public partial class FormSnapshot : Form
    {
        #region:::::::::::::::::::::::::::::::::::::::::::Form level declarations:::::::::::::::::::::::::::::::::::::::::::

        public Bitmap boardSnapshot;

        protected override void OnMouseClick(MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                e = null;
            }

            base.OnMouseClick(e);

        }

        private Form m_InstanceRef = null;
        public Form InstanceRef
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
            InitializeComponent();
            this.MouseDoubleClick += new MouseEventHandler(mouse_DClick);
        }
        #endregion
        

        public void SaveSelection()
        {
            
            this.Hide();

            //Allow 250 milliseconds for the screen to repaint itself (we don't want to include this form in the capture)
            System.Threading.Thread.Sleep(250);

            //boardSnapshot = new Bitmap(this.Width-18, this.Height);
            float scalingFactor = getScalingFactor();
            Size s1 = this.Size;
            s1.Width = (int) Math.Round(s1.Width*scalingFactor - 18);
            s1.Height = (int) Math.Round(s1.Height*scalingFactor);
            boardSnapshot = new Bitmap(s1.Width, s1.Height);
            Graphics graphics = Graphics.FromImage(boardSnapshot as Image);
            graphics.CopyFromScreen((int) Math.Round(this.Location.X*scalingFactor+10), 
                (int) Math.Round(this.Location.Y*scalingFactor), 0, 0, s1);
            boardSnapshot.Save(@"C:\Users\dmytro.dmytriiev\source\repos\BerldChess\Source\BerldChess\Resources\Images\snapshot.bmp");
            /* using (MemoryStream s = new MemoryStream())
            {
                //save graphic variable into memory
                boardSnapshot.Save(s, ImageFormat.Bmp);
                //save snapshot for debug
                boardSnapshot.Save(@"C:\Users\dmytro.dmytriiev\source\repos\BerldChess\Source\BerldChess\Resources\Images\snapshot.bmp");
            } */ 
            
            this.Hide();
            this.InstanceRef.Activate();
        }
        
        private void mouse_DClick(object sender, MouseEventArgs e)
        {
            SaveSelection();
        }
        
        [DllImport("gdi32.dll")]
        static extern int GetDeviceCaps(IntPtr hdc, int nIndex);
        public enum DeviceCap
        {
            VERTRES = 10,
            DESKTOPVERTRES = 117,

            // http://pinvoke.net/default.aspx/gdi32/GetDeviceCaps.html
        }
        
        private float getScalingFactor()
        {
            Graphics g = Graphics.FromHwnd(this.Handle);
            IntPtr desktop = g.GetHdc();
            int LogicalScreenHeight = GetDeviceCaps(desktop, (int)DeviceCap.VERTRES);
            int PhysicalScreenHeight = GetDeviceCaps(desktop, (int)DeviceCap.DESKTOPVERTRES); 

            float ScreenScalingFactor = (float)PhysicalScreenHeight / (float)LogicalScreenHeight;

            return ScreenScalingFactor; // 1.25 = 125%
        }
    }
}