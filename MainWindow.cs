using System;
using System.Drawing;
using System.Windows.Forms;

namespace DesktopColorPicker
{
    public partial class MainWindow : Form
    {
        bool moveWindow;
        int moveWindowX;
        int moveWindowY;
        public MainWindow()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
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
    }
}
