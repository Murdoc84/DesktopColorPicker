using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace DesktopColorPicker
{
    public partial class MainWindow : Form
    {
        bool moveWindow;
        int moveWindowX;
        int moveWindowY;
        Bitmap bitmapMagnifierGlass;
        Graphics graphicsMagnifierGlass;
        int zoomMagnifierGlass = 10;

        public MainWindow()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            pictureBoxTopLeftCorner.Parent = panelBackground;
            timerPositionXY.Start();
            timerPositionXY.Interval = 1;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTopBar_MouseDown(object sender, MouseEventArgs e)
        {
            moveWindow = true;
            moveWindowX = e.X;
            moveWindowY = e.Y;
        }

        private void panelTopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (moveWindow)
            {
                this.SetDesktopLocation(MousePosition.X - moveWindowX, MousePosition.Y - moveWindowY);
            }
        }

        private void panelTopBar_MouseUp(object sender, MouseEventArgs e)
        {
            moveWindow = false;
        }

        private void timerPositionXY_Tick(object sender, EventArgs e)
        {
            labelActualX.Text = Cursor.Position.X.ToString();
            labelActualY.Text = Cursor.Position.Y.ToString();
            bitmapMagnifierGlass = new Bitmap(pictureBoxMagnifierGlass.Width / zoomMagnifierGlass, pictureBoxMagnifierGlass.Height / zoomMagnifierGlass, PixelFormat.Format24bppRgb);
            graphicsMagnifierGlass = Graphics.FromImage(bitmapMagnifierGlass);
            graphicsMagnifierGlass.CopyFromScreen(MousePosition.X - pictureBoxMagnifierGlass.Width / (zoomMagnifierGlass * 2), MousePosition.Y - pictureBoxMagnifierGlass.Height / (zoomMagnifierGlass * 2), 0, 0, pictureBoxMagnifierGlass.Size, CopyPixelOperation.SourceCopy);
            pictureBoxMagnifierGlass.Image = bitmapMagnifierGlass;
        }
    }
}
