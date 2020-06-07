using DesktopColorPicker.common;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Microsoft.VisualBasic;

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
        private Color pickedColor;
        private int pickedX;
        private int pickedY;

        private Config config = new Config();
        private GetColorFromXY getColor = new GetColorFromXY();

        public MainWindow()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Int32.Parse(config.Get("StartPositionX")), Int32.Parse(config.Get("StartPositionY")));
            pictureBoxTopLeftCorner.Parent = panelBackground;
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
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
            // Actual cursor position
            labelActualX.Text = Cursor.Position.X.ToString();
            labelActualY.Text = Cursor.Position.Y.ToString();
            // Magnifier
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
            // Actual color under cursor
            Color actualColor = getColor.GetColorAt(MousePosition.X, MousePosition.Y);
            panelActualColor.BackColor = actualColor;
            labelActualA.Text = actualColor.A.ToString();
            labelActualR.Text = actualColor.R.ToString();
            labelActualG.Text = actualColor.G.ToString();
            labelActualB.Text = actualColor.B.ToString();
            labelActualRGB.Text = "#" + actualColor.R.ToString("X2") + actualColor.G.ToString("X2") + actualColor.B.ToString("X2");
        }

        private void pictureBoxZoomCross_Paint(object sender, PaintEventArgs e)
        {
            Graphics cross = pictureBoxMagnifierGlass.CreateGraphics();
            Brush red = new SolidBrush(Color.Red);
            Pen redPen = new Pen(red, 1);
            cross.DrawLine(redPen, pictureBoxMagnifierGlass.Width / 2, 0, pictureBoxMagnifierGlass.Height / 2, (pictureBoxMagnifierGlass.Height - sizeMagnifierGlass + 1) / 2);
            cross.DrawLine(redPen, pictureBoxMagnifierGlass.Width / 2, (pictureBoxMagnifierGlass.Height + sizeMagnifierGlass + 1) / 2, pictureBoxMagnifierGlass.Height / 2, pictureBoxMagnifierGlass.Height);
            cross.DrawLine(redPen, 0, pictureBoxMagnifierGlass.Height / 2, (pictureBoxMagnifierGlass.Width - sizeMagnifierGlass + 1) / 2, pictureBoxMagnifierGlass.Height / 2);
            cross.DrawLine(redPen, (pictureBoxMagnifierGlass.Width + sizeMagnifierGlass + 1) / 2, pictureBoxMagnifierGlass.Height / 2, pictureBoxMagnifierGlass.Width, pictureBoxMagnifierGlass.Height / 2);
        }

        private void checkBoxAlwaysOnTop_Click(object sender, EventArgs e)
        {
            if (checkBoxAlwaysOnTop.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void textBoxSetX_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                e.Handled = true;
            }
        }

        private void textBoxSetY_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void buttonPickColorFromXY_Click(object sender, EventArgs e)
        {
            pickedX = Int32.Parse(textBoxSetX.Text);
            pickedY = Int32.Parse(textBoxSetY.Text);
            pickedColor = getColor.GetColorAt(pickedX, pickedY);
            SetPickedValues();
        }

        private void panelShowHide_MouseClick(object sender, MouseEventArgs e)
        {
            ShowSavedPanel();
        }

        private void labelShowHide_MouseClick(object sender, MouseEventArgs e)
        {
            ShowSavedPanel();
        }
        private void ShowSavedPanel()
        {
            if (labelShowHide.Text.Equals("SHOW"))
            {
                labelShowHide.Text = "HIDE";
                panelSaved.Visible = true;
            }
            else
            {
                labelShowHide.Text = "SHOW";
                panelSaved.Visible = false;
            }
        }
        private void SetPickedValues()
        {
            textBoxPickedX.Text = pickedX.ToString();
            textBoxPickedY.Text = pickedY.ToString();
            textBoxPickedA.Text = pickedColor.A.ToString();
            textBoxPickedR.Text = pickedColor.R.ToString();
            textBoxPickedG.Text = pickedColor.G.ToString();
            textBoxPickedB.Text = pickedColor.B.ToString();
            pictureBoxPicketColor.BackColor = pickedColor;
        }

        private void pictureBoxPicketColor_MouseClick(object sender, MouseEventArgs e)
        {
            string textColor = $"Color.FromArgb({pickedColor.A.ToString()}, {pickedColor.R.ToString()}, {pickedColor.G.ToString()}, {pickedColor.B.ToString()})";
            Clipboard.SetText(textColor);
            MessageBox.Show($"Clipboard: {textColor}");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string saveAs = Interaction.InputBox("Save picked color as ...", "Save As ...", "");
        }
    }
}