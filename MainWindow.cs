using DesktopColorPicker.common;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Configuration;
using System.Collections.Specialized;

namespace DesktopColorPicker
{
    public partial class MainWindow : Form
    {
        private bool moveWindow;
        private int moveWindowX;
        private int moveWindowY;
        private Bitmap bitmapMagnifierGlass;
        private Graphics graphicsMagnifierGlass;
        private int sizeMagnifierGlass = 11;

        Config config = new Config();
        GetColorFromXY getColor = new GetColorFromXY();

        public MainWindow()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Int32.Parse(config.Get("StartPositionX")), Int32.Parse(config.Get("StartPositionY")));
            pictureBoxTopLeftCorner.Parent = panelBackground;
            pictureBoxZoomCross.Parent = pictureBoxMagnifierGlass;
            timerPositionXY.Start();
            timerPositionXY.Interval = 1;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            config.Set("StartPositionX", this.Location.X.ToString());
            config.Set("StartPositionY", this.Location.Y.ToString());
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
            bitmapMagnifierGlass = new Bitmap(sizeMagnifierGlass, sizeMagnifierGlass);
            graphicsMagnifierGlass = Graphics.FromImage(bitmapMagnifierGlass);
            graphicsMagnifierGlass.CopyFromScreen(MousePosition.X - (sizeMagnifierGlass / 2), MousePosition.Y - (sizeMagnifierGlass / 2), 0, 0, new Size(sizeMagnifierGlass, sizeMagnifierGlass));
            Bitmap zoomed = (Bitmap)pictureBoxMagnifierGlass.Image;
            if (zoomed != null) zoomed.Dispose();
            zoomed = new Bitmap(pictureBoxMagnifierGlass.Width + sizeMagnifierGlass, pictureBoxMagnifierGlass.Height + sizeMagnifierGlass);
            using (Graphics g = Graphics.FromImage(zoomed))
            {
                g.InterpolationMode = InterpolationMode.NearestNeighbor;
                g.DrawImage(bitmapMagnifierGlass, new Rectangle(Point.Empty, zoomed.Size));
            }
            pictureBoxMagnifierGlass.Image = zoomed;
            panelActualColor.BackColor = getColor.GetColorAt(MousePosition.X, MousePosition.Y);

        }

        private void pictureBoxZoomCross_Paint(object sender, PaintEventArgs e)
        {
            Graphics cross = pictureBoxMagnifierGlass.CreateGraphics();
            Brush red = new SolidBrush(Color.Red);
            Pen redPen = new Pen(red, 1);

            cross.DrawLine(redPen, pictureBoxMagnifierGlass.Width / 2, 0, pictureBoxMagnifierGlass.Height / 2, (pictureBoxMagnifierGlass.Height - sizeMagnifierGlass + 1) / 2);
            cross.DrawLine(redPen, pictureBoxMagnifierGlass.Width / 2, (pictureBoxMagnifierGlass.Height + sizeMagnifierGlass + 1) / 2, pictureBoxMagnifierGlass.Height / 2, pictureBoxMagnifierGlass.Height);
            cross.DrawLine(redPen, 0, pictureBoxMagnifierGlass.Height/2, (pictureBoxMagnifierGlass.Width - sizeMagnifierGlass + 1) / 2, pictureBoxMagnifierGlass.Height / 2);
            cross.DrawLine(redPen, (pictureBoxMagnifierGlass.Width + sizeMagnifierGlass + 1) / 2, pictureBoxMagnifierGlass.Height / 2, pictureBoxMagnifierGlass.Width, pictureBoxMagnifierGlass.Height / 2);
        }
    }
}
