using DesktopColorPicker.common;
using NHotkey;
using NHotkey.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

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
        private Files files = new Files();
        private Templates templates = new Templates();
        private GetColorFromXY getColor = new GetColorFromXY();

        public MainWindow()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            HotkeyManager.Current.AddOrReplace("Pick", Keys.Alt | Keys.G, PickColor);
            HotkeyManager.Current.AddOrReplace("PickAndSaveAs", Keys.Control | Keys.Alt | Keys.G, PickColorAndSaveAs);
            InitializeComponent();
        }

        #region Actions

        private void MainWindow_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Int32.Parse(config.Get("StartPositionX")), Int32.Parse(config.Get("StartPositionY")));
            pictureBoxTopLeftCorner.Parent = panelBackground;
            this.TransparencyKey = Color.Turquoise;
            this.BackColor = Color.Turquoise;
            pictureBoxZoomCross.Parent = pictureBoxMagnifierGlass;
            timerPositionXY.Start();
            timerPositionXY.Interval = 1;
            RefreshComboBoxTemplate();
            comboBoxTemplates.SelectedItem = config.Get("StartTemplate");
        }

        private DialogResult InputBox(string title, string promptText, ref string value)
        {
            Form form = new Form();
            Label label = new Label();
            TextBox textBox = new TextBox();
            Button buttonOk = new Button();
            Button buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            DialogResult dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
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
            if (checkBoxLive.Checked && pickedX != null)
            {
                pickedColor = getColor.GetColorAt(pickedX, pickedY);
                textBoxPickedX.Text = pickedX.ToString();
                textBoxPickedY.Text = pickedY.ToString();
                textBoxPickedA.Text = pickedColor.A.ToString();
                textBoxPickedR.Text = pickedColor.R.ToString();
                textBoxPickedG.Text = pickedColor.G.ToString();
                textBoxPickedB.Text = pickedColor.B.ToString();
                pictureBoxPicketColor.BackColor = pickedColor;
            }
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
            SetPickedValues(pickedX, pickedY);
        }

        private void panelShowHide_MouseClick(object sender, MouseEventArgs e)
        {
            ShowSavedPanel();
        }

        private void labelShowHide_MouseClick(object sender, MouseEventArgs e)
        {
            ShowSavedPanel();
        }

        private void pictureBoxPicketColor_MouseClick(object sender, MouseEventArgs e)
        {
            string textColor = $"Color.FromArgb({pickedColor.A}, {pickedColor.R}, {pickedColor.G}, {pickedColor.B})";
            Clipboard.SetText(textColor);
            MessageBox.Show($"Clipboard: {textColor}");
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            files.DeleteRow(dataGridViewSavedData.CurrentRow.Index);
            ReadCsv();
        }

        private void dataGridViewSavedData_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewSavedData.CurrentRow.Selected)
            {
                buttonDelete.Enabled = true;
                buttonCopyToClipboard.Enabled = true;
                buttonRead.Enabled = true;
                buttonUpdate.Enabled = true;
                buttonMoveUp.Enabled = true;
                buttonMoveDown.Enabled = true;
            }
            else
            {
                buttonDelete.Enabled = false;
                buttonCopyToClipboard.Enabled = false;
                buttonRead.Enabled = false;
                buttonUpdate.Enabled = false;
                buttonMoveUp.Enabled = false;
                buttonMoveDown.Enabled = false;
            }
        }

        private void comboBoxTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            config.Set("StartTemplate", comboBoxTemplates.Text);
        }

        private void buttonCopyToClipboard_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            Clipboard.SetText(templates.BuildFromTemplate(files.ReadLine(dataGridViewSavedData.CurrentRow.Index), comboBoxTemplates.Text));
        }

        private void comboBoxTemplates_Click(object sender, EventArgs e)
        {
            RefreshComboBoxTemplate();
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            List<string> list = files.ReadLine(dataGridViewSavedData.CurrentRow.Index);
            pickedX = Int32.Parse(list[1]);
            pickedY = Int32.Parse(list[2]);
            pickedColor = Color.FromArgb(Int32.Parse(list[3]), Int32.Parse(list[4]), Int32.Parse(list[5]), Int32.Parse(list[6]));
            SetPickedValues(pickedX, pickedY, false);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            int row = dataGridViewSavedData.CurrentRow.Index;
            SaveAs(false, row);
            ReadCsv();
            SelectRow(row);
        }

        private void buttonMoveUp_Click(object sender, EventArgs e)
        {
            int row = dataGridViewSavedData.CurrentRow.Index;
            files.MoveRowUp(row);
            ReadCsv();
            SelectRow(row - 1);
        }

        private void buttonMoveDown_Click(object sender, EventArgs e)
        {
            int row = dataGridViewSavedData.CurrentRow.Index;
            files.MoveRowDown(row);
            ReadCsv();
            SelectRow(row + 1);
        }

        #endregion Actions

        private void ShowSavedPanel()
        {
            if (labelShowHide.Text.Equals("SHOW"))
            {
                labelShowHide.Text = "HIDE";
                panelSaved.Visible = true;
                ReadCsv();
            }
            else
            {
                labelShowHide.Text = "SHOW";
                panelSaved.Visible = false;
            }
        }

        private void SetPickedValues(int x, int y, bool pickColor = true)
        {
            pickedX = x;
            pickedY = y;
            textBoxSetX.Text = x.ToString();
            textBoxSetY.Text = y.ToString();
            if (pickColor)
            {
                pickedColor = getColor.GetColorAt(x, y);
            }
            textBoxPickedX.Text = pickedX.ToString();
            textBoxPickedY.Text = pickedY.ToString();
            textBoxPickedA.Text = pickedColor.A.ToString();
            textBoxPickedR.Text = pickedColor.R.ToString();
            textBoxPickedG.Text = pickedColor.G.ToString();
            textBoxPickedB.Text = pickedColor.B.ToString();
            pictureBoxPicketColor.BackColor = pickedColor;
            buttonSave.Enabled = true;
        }

        private void SaveAs(bool newItem = true, int row = 0)
        {
            this.Activate();
            string saveAs = "";
            bool dialogOK = (InputBox("Save As ...", "Save picked data as:", ref saveAs) == DialogResult.OK) ? true : false;
            if (!string.IsNullOrEmpty(saveAs) && dialogOK)
            {
                if (!newItem)
                {
                    files.UpdateRow(row, files.PrepareStream(saveAs, pickedX, pickedY, pickedColor));
                }
                else
                {
                    files.PrepareAndAppendToCsv(files.PrepareStream(saveAs, pickedX, pickedY, pickedColor));
                }
                if (panelSaved.Visible)
                {
                    ReadCsv();
                }
            }
        }

        private void ReadCsv()
        {
            dataGridViewSavedData.DataSource = files.ReadCsv();
            foreach (DataGridViewColumn column in dataGridViewSavedData.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
                if (column.Width > 78)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    column.Width = 78;
                }
                if (column.HeaderText == "Name")
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }

        private void PickColorAndSaveAs(object sender, HotkeyEventArgs e)
        {
            SetPickedValues(MousePosition.X, MousePosition.Y);
            SaveAs();
        }

        private void PickColor(object sender, HotkeyEventArgs e)
        {
            SetPickedValues(MousePosition.X, MousePosition.Y);
        }

        private void RefreshComboBoxTemplate()
        {
            comboBoxTemplates.Items.Clear();
            string[] files = Directory.GetFiles("templates");
            foreach (var file in files)
            {
                comboBoxTemplates.Items.Add(Path.GetFileNameWithoutExtension(file));
            }
        }

        private void SelectRow(int row)
        {
            dataGridViewSavedData.ClearSelection();
            dataGridViewSavedData.CurrentCell = dataGridViewSavedData.Rows[row].Cells[0];
            dataGridViewSavedData.Rows[row].Selected = true;
        }
    }
}