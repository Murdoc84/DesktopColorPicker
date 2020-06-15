namespace DesktopColorPicker
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.checkBoxAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.pictureBoxTopLeftCorner = new System.Windows.Forms.PictureBox();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.checkBoxLive = new System.Windows.Forms.CheckBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.pictureBoxPicketColor = new System.Windows.Forms.PictureBox();
            this.textBoxPickedB = new System.Windows.Forms.TextBox();
            this.textBoxPickedG = new System.Windows.Forms.TextBox();
            this.textBoxPickedR = new System.Windows.Forms.TextBox();
            this.textBoxPickedA = new System.Windows.Forms.TextBox();
            this.textBoxPickedY = new System.Windows.Forms.TextBox();
            this.textBoxPickedX = new System.Windows.Forms.TextBox();
            this.labelBG = new System.Windows.Forms.Label();
            this.labelGG = new System.Windows.Forms.Label();
            this.labelRG = new System.Windows.Forms.Label();
            this.labelAG = new System.Windows.Forms.Label();
            this.labelYG = new System.Windows.Forms.Label();
            this.labelXG = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonPickColorFromXY = new System.Windows.Forms.Button();
            this.labelSetY = new System.Windows.Forms.Label();
            this.labelSetX = new System.Windows.Forms.Label();
            this.textBoxSetY = new System.Windows.Forms.TextBox();
            this.textBoxSetX = new System.Windows.Forms.TextBox();
            this.labelActualRGB = new System.Windows.Forms.Label();
            this.labelActualB = new System.Windows.Forms.Label();
            this.labelActualG = new System.Windows.Forms.Label();
            this.labelActualR = new System.Windows.Forms.Label();
            this.labelActualA = new System.Windows.Forms.Label();
            this.labelActualY = new System.Windows.Forms.Label();
            this.labelActual = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.panelActualColor = new System.Windows.Forms.Panel();
            this.pictureBoxZoomCross = new System.Windows.Forms.PictureBox();
            this.pictureBoxMagnifierGlass = new System.Windows.Forms.PictureBox();
            this.labelActualX = new System.Windows.Forms.Label();
            this.timerPositionXY = new System.Windows.Forms.Timer(this.components);
            this.panelShowHide = new System.Windows.Forms.Panel();
            this.labelShowHide = new System.Windows.Forms.Label();
            this.panelSaved = new System.Windows.Forms.Panel();
            this.buttonMoveUp = new System.Windows.Forms.Button();
            this.buttonMoveDown = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonCopyToClipboard = new System.Windows.Forms.Button();
            this.comboBoxTemplates = new System.Windows.Forms.ComboBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.dataGridViewSavedData = new System.Windows.Forms.DataGridView();
            this.panelTopBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopLeftCorner)).BeginInit();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPicketColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoomCross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMagnifierGlass)).BeginInit();
            this.panelShowHide.SuspendLayout();
            this.panelSaved.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSavedData)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Red;
            this.buttonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(382, 2);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(16, 16);
            this.buttonClose.TabIndex = 0;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panelTopBar
            // 
            this.panelTopBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(115)))));
            this.panelTopBar.Controls.Add(this.checkBoxAlwaysOnTop);
            this.panelTopBar.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panelTopBar.Location = new System.Drawing.Point(37, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(363, 20);
            this.panelTopBar.TabIndex = 2;
            this.panelTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseDown);
            this.panelTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseMove);
            this.panelTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseUp);
            // 
            // checkBoxAlwaysOnTop
            // 
            this.checkBoxAlwaysOnTop.AutoSize = true;
            this.checkBoxAlwaysOnTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxAlwaysOnTop.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxAlwaysOnTop.ForeColor = System.Drawing.SystemColors.Control;
            this.checkBoxAlwaysOnTop.Location = new System.Drawing.Point(227, 2);
            this.checkBoxAlwaysOnTop.Name = "checkBoxAlwaysOnTop";
            this.checkBoxAlwaysOnTop.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxAlwaysOnTop.Size = new System.Drawing.Size(105, 19);
            this.checkBoxAlwaysOnTop.TabIndex = 0;
            this.checkBoxAlwaysOnTop.Text = "Always on top";
            this.checkBoxAlwaysOnTop.UseVisualStyleBackColor = true;
            this.checkBoxAlwaysOnTop.Click += new System.EventHandler(this.checkBoxAlwaysOnTop_Click);
            // 
            // pictureBoxTopLeftCorner
            // 
            this.pictureBoxTopLeftCorner.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxTopLeftCorner.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBoxTopLeftCorner.Enabled = false;
            this.pictureBoxTopLeftCorner.ErrorImage = null;
            this.pictureBoxTopLeftCorner.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTopLeftCorner.Image")));
            this.pictureBoxTopLeftCorner.InitialImage = null;
            this.pictureBoxTopLeftCorner.Location = new System.Drawing.Point(-15, -15);
            this.pictureBoxTopLeftCorner.Name = "pictureBoxTopLeftCorner";
            this.pictureBoxTopLeftCorner.Size = new System.Drawing.Size(60, 60);
            this.pictureBoxTopLeftCorner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxTopLeftCorner.TabIndex = 1;
            this.pictureBoxTopLeftCorner.TabStop = false;
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.Gainsboro;
            this.panelBackground.Controls.Add(this.checkBoxLive);
            this.panelBackground.Controls.Add(this.buttonSave);
            this.panelBackground.Controls.Add(this.pictureBoxPicketColor);
            this.panelBackground.Controls.Add(this.textBoxPickedB);
            this.panelBackground.Controls.Add(this.textBoxPickedG);
            this.panelBackground.Controls.Add(this.textBoxPickedR);
            this.panelBackground.Controls.Add(this.textBoxPickedA);
            this.panelBackground.Controls.Add(this.textBoxPickedY);
            this.panelBackground.Controls.Add(this.textBoxPickedX);
            this.panelBackground.Controls.Add(this.labelBG);
            this.panelBackground.Controls.Add(this.labelGG);
            this.panelBackground.Controls.Add(this.labelRG);
            this.panelBackground.Controls.Add(this.labelAG);
            this.panelBackground.Controls.Add(this.labelYG);
            this.panelBackground.Controls.Add(this.labelXG);
            this.panelBackground.Controls.Add(this.label1);
            this.panelBackground.Controls.Add(this.buttonPickColorFromXY);
            this.panelBackground.Controls.Add(this.labelSetY);
            this.panelBackground.Controls.Add(this.labelSetX);
            this.panelBackground.Controls.Add(this.textBoxSetY);
            this.panelBackground.Controls.Add(this.textBoxSetX);
            this.panelBackground.Controls.Add(this.labelActualRGB);
            this.panelBackground.Controls.Add(this.labelActualB);
            this.panelBackground.Controls.Add(this.labelActualG);
            this.panelBackground.Controls.Add(this.labelActualR);
            this.panelBackground.Controls.Add(this.labelActualA);
            this.panelBackground.Controls.Add(this.labelActualY);
            this.panelBackground.Controls.Add(this.labelActual);
            this.panelBackground.Controls.Add(this.labelB);
            this.panelBackground.Controls.Add(this.labelG);
            this.panelBackground.Controls.Add(this.labelR);
            this.panelBackground.Controls.Add(this.labelA);
            this.panelBackground.Controls.Add(this.labelY);
            this.panelBackground.Controls.Add(this.labelX);
            this.panelBackground.Controls.Add(this.panelActualColor);
            this.panelBackground.Controls.Add(this.pictureBoxZoomCross);
            this.panelBackground.Controls.Add(this.pictureBoxMagnifierGlass);
            this.panelBackground.Controls.Add(this.labelActualX);
            this.panelBackground.Controls.Add(this.pictureBoxTopLeftCorner);
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(400, 195);
            this.panelBackground.TabIndex = 3;
            // 
            // checkBoxLive
            // 
            this.checkBoxLive.AutoSize = true;
            this.checkBoxLive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxLive.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.checkBoxLive.ForeColor = System.Drawing.SystemColors.Desktop;
            this.checkBoxLive.Location = new System.Drawing.Point(352, 50);
            this.checkBoxLive.Name = "checkBoxLive";
            this.checkBoxLive.Size = new System.Drawing.Size(45, 19);
            this.checkBoxLive.TabIndex = 1;
            this.checkBoxLive.Text = "live";
            this.checkBoxLive.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonSave.Location = new System.Drawing.Point(197, 166);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(191, 23);
            this.buttonSave.TabIndex = 41;
            this.buttonSave.Text = "Save data as ...";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // pictureBoxPicketColor
            // 
            this.pictureBoxPicketColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxPicketColor.Location = new System.Drawing.Point(335, 106);
            this.pictureBoxPicketColor.Name = "pictureBoxPicketColor";
            this.pictureBoxPicketColor.Size = new System.Drawing.Size(56, 55);
            this.pictureBoxPicketColor.TabIndex = 40;
            this.pictureBoxPicketColor.TabStop = false;
            this.pictureBoxPicketColor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPicketColor_MouseClick);
            // 
            // textBoxPickedB
            // 
            this.textBoxPickedB.Location = new System.Drawing.Point(285, 144);
            this.textBoxPickedB.Name = "textBoxPickedB";
            this.textBoxPickedB.ReadOnly = true;
            this.textBoxPickedB.Size = new System.Drawing.Size(46, 20);
            this.textBoxPickedB.TabIndex = 39;
            // 
            // textBoxPickedG
            // 
            this.textBoxPickedG.Location = new System.Drawing.Point(285, 124);
            this.textBoxPickedG.Name = "textBoxPickedG";
            this.textBoxPickedG.ReadOnly = true;
            this.textBoxPickedG.Size = new System.Drawing.Size(46, 20);
            this.textBoxPickedG.TabIndex = 38;
            // 
            // textBoxPickedR
            // 
            this.textBoxPickedR.Location = new System.Drawing.Point(285, 104);
            this.textBoxPickedR.Name = "textBoxPickedR";
            this.textBoxPickedR.ReadOnly = true;
            this.textBoxPickedR.Size = new System.Drawing.Size(46, 20);
            this.textBoxPickedR.TabIndex = 37;
            // 
            // textBoxPickedA
            // 
            this.textBoxPickedA.Location = new System.Drawing.Point(211, 144);
            this.textBoxPickedA.Name = "textBoxPickedA";
            this.textBoxPickedA.ReadOnly = true;
            this.textBoxPickedA.Size = new System.Drawing.Size(46, 20);
            this.textBoxPickedA.TabIndex = 36;
            // 
            // textBoxPickedY
            // 
            this.textBoxPickedY.Location = new System.Drawing.Point(211, 124);
            this.textBoxPickedY.Name = "textBoxPickedY";
            this.textBoxPickedY.ReadOnly = true;
            this.textBoxPickedY.Size = new System.Drawing.Size(46, 20);
            this.textBoxPickedY.TabIndex = 35;
            // 
            // textBoxPickedX
            // 
            this.textBoxPickedX.Location = new System.Drawing.Point(211, 104);
            this.textBoxPickedX.Name = "textBoxPickedX";
            this.textBoxPickedX.ReadOnly = true;
            this.textBoxPickedX.Size = new System.Drawing.Size(46, 20);
            this.textBoxPickedX.TabIndex = 34;
            // 
            // labelBG
            // 
            this.labelBG.AutoSize = true;
            this.labelBG.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelBG.Location = new System.Drawing.Point(263, 147);
            this.labelBG.Name = "labelBG";
            this.labelBG.Size = new System.Drawing.Size(21, 15);
            this.labelBG.TabIndex = 33;
            this.labelBG.Text = "B: ";
            // 
            // labelGG
            // 
            this.labelGG.AutoSize = true;
            this.labelGG.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelGG.Location = new System.Drawing.Point(263, 127);
            this.labelGG.Name = "labelGG";
            this.labelGG.Size = new System.Drawing.Size(21, 15);
            this.labelGG.TabIndex = 32;
            this.labelGG.Text = "G: ";
            // 
            // labelRG
            // 
            this.labelRG.AutoSize = true;
            this.labelRG.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRG.Location = new System.Drawing.Point(263, 107);
            this.labelRG.Name = "labelRG";
            this.labelRG.Size = new System.Drawing.Size(21, 15);
            this.labelRG.TabIndex = 31;
            this.labelRG.Text = "R: ";
            // 
            // labelAG
            // 
            this.labelAG.AutoSize = true;
            this.labelAG.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAG.Location = new System.Drawing.Point(191, 147);
            this.labelAG.Name = "labelAG";
            this.labelAG.Size = new System.Drawing.Size(21, 15);
            this.labelAG.TabIndex = 30;
            this.labelAG.Text = "A: ";
            // 
            // labelYG
            // 
            this.labelYG.AutoSize = true;
            this.labelYG.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelYG.Location = new System.Drawing.Point(191, 127);
            this.labelYG.Name = "labelYG";
            this.labelYG.Size = new System.Drawing.Size(19, 15);
            this.labelYG.TabIndex = 29;
            this.labelYG.Text = "Y: ";
            // 
            // labelXG
            // 
            this.labelXG.AutoSize = true;
            this.labelXG.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelXG.Location = new System.Drawing.Point(191, 107);
            this.labelXG.Name = "labelXG";
            this.labelXG.Size = new System.Drawing.Size(21, 15);
            this.labelXG.TabIndex = 28;
            this.labelXG.Text = "X: ";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(218, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 30);
            this.label1.TabIndex = 27;
            this.label1.Text = "Alt+G for pick cursor location\r\nCtrl+Alt+G for pick and save";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonPickColorFromXY
            // 
            this.buttonPickColorFromXY.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPickColorFromXY.Location = new System.Drawing.Point(197, 47);
            this.buttonPickColorFromXY.Name = "buttonPickColorFromXY";
            this.buttonPickColorFromXY.Size = new System.Drawing.Size(149, 23);
            this.buttonPickColorFromXY.TabIndex = 26;
            this.buttonPickColorFromXY.Text = "Pick color from X Y";
            this.buttonPickColorFromXY.UseVisualStyleBackColor = true;
            this.buttonPickColorFromXY.Click += new System.EventHandler(this.buttonPickColorFromXY_Click);
            // 
            // labelSetY
            // 
            this.labelSetY.AutoSize = true;
            this.labelSetY.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSetY.Location = new System.Drawing.Point(292, 27);
            this.labelSetY.Name = "labelSetY";
            this.labelSetY.Size = new System.Drawing.Size(16, 15);
            this.labelSetY.TabIndex = 25;
            this.labelSetY.Text = "Y:";
            // 
            // labelSetX
            // 
            this.labelSetX.AutoSize = true;
            this.labelSetX.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSetX.Location = new System.Drawing.Point(194, 27);
            this.labelSetX.Name = "labelSetX";
            this.labelSetX.Size = new System.Drawing.Size(18, 15);
            this.labelSetX.TabIndex = 24;
            this.labelSetX.Text = "X:";
            // 
            // textBoxSetY
            // 
            this.textBoxSetY.Location = new System.Drawing.Point(310, 25);
            this.textBoxSetY.Name = "textBoxSetY";
            this.textBoxSetY.Size = new System.Drawing.Size(75, 20);
            this.textBoxSetY.TabIndex = 23;
            this.textBoxSetY.Text = "0";
            this.textBoxSetY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSetY_KeyPress);
            // 
            // textBoxSetX
            // 
            this.textBoxSetX.Location = new System.Drawing.Point(213, 25);
            this.textBoxSetX.Name = "textBoxSetX";
            this.textBoxSetX.Size = new System.Drawing.Size(75, 20);
            this.textBoxSetX.TabIndex = 22;
            this.textBoxSetX.Text = "0";
            this.textBoxSetX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxSetX_KeyPress);
            // 
            // labelActualRGB
            // 
            this.labelActualRGB.AutoSize = true;
            this.labelActualRGB.BackColor = System.Drawing.Color.Transparent;
            this.labelActualRGB.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelActualRGB.Location = new System.Drawing.Point(112, 166);
            this.labelActualRGB.Margin = new System.Windows.Forms.Padding(0);
            this.labelActualRGB.Name = "labelActualRGB";
            this.labelActualRGB.Size = new System.Drawing.Size(50, 15);
            this.labelActualRGB.TabIndex = 21;
            this.labelActualRGB.Text = "#FFFFFF";
            this.labelActualRGB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelActualB
            // 
            this.labelActualB.AutoSize = true;
            this.labelActualB.BackColor = System.Drawing.Color.Transparent;
            this.labelActualB.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelActualB.Location = new System.Drawing.Point(136, 147);
            this.labelActualB.Margin = new System.Windows.Forms.Padding(0);
            this.labelActualB.Name = "labelActualB";
            this.labelActualB.Size = new System.Drawing.Size(28, 15);
            this.labelActualB.TabIndex = 20;
            this.labelActualB.Text = "255";
            this.labelActualB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelActualG
            // 
            this.labelActualG.AutoSize = true;
            this.labelActualG.BackColor = System.Drawing.Color.Transparent;
            this.labelActualG.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelActualG.Location = new System.Drawing.Point(136, 127);
            this.labelActualG.Margin = new System.Windows.Forms.Padding(0);
            this.labelActualG.Name = "labelActualG";
            this.labelActualG.Size = new System.Drawing.Size(28, 15);
            this.labelActualG.TabIndex = 19;
            this.labelActualG.Text = "255";
            this.labelActualG.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelActualR
            // 
            this.labelActualR.AutoSize = true;
            this.labelActualR.BackColor = System.Drawing.Color.Transparent;
            this.labelActualR.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelActualR.Location = new System.Drawing.Point(136, 107);
            this.labelActualR.Margin = new System.Windows.Forms.Padding(0);
            this.labelActualR.Name = "labelActualR";
            this.labelActualR.Size = new System.Drawing.Size(28, 15);
            this.labelActualR.TabIndex = 18;
            this.labelActualR.Text = "255";
            this.labelActualR.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelActualA
            // 
            this.labelActualA.AutoSize = true;
            this.labelActualA.BackColor = System.Drawing.Color.Transparent;
            this.labelActualA.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelActualA.Location = new System.Drawing.Point(136, 87);
            this.labelActualA.Margin = new System.Windows.Forms.Padding(0);
            this.labelActualA.Name = "labelActualA";
            this.labelActualA.Size = new System.Drawing.Size(28, 15);
            this.labelActualA.TabIndex = 17;
            this.labelActualA.Text = "255";
            this.labelActualA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelActualY
            // 
            this.labelActualY.AutoSize = true;
            this.labelActualY.BackColor = System.Drawing.Color.Transparent;
            this.labelActualY.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelActualY.Location = new System.Drawing.Point(136, 67);
            this.labelActualY.Margin = new System.Windows.Forms.Padding(0);
            this.labelActualY.Name = "labelActualY";
            this.labelActualY.Size = new System.Drawing.Size(35, 15);
            this.labelActualY.TabIndex = 16;
            this.labelActualY.Text = "1080";
            this.labelActualY.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelActual
            // 
            this.labelActual.AutoSize = true;
            this.labelActual.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelActual.Location = new System.Drawing.Point(112, 27);
            this.labelActual.Name = "labelActual";
            this.labelActual.Size = new System.Drawing.Size(46, 15);
            this.labelActual.TabIndex = 15;
            this.labelActual.Text = "Actual:";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelB.Location = new System.Drawing.Point(112, 147);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(21, 15);
            this.labelB.TabIndex = 14;
            this.labelB.Text = "B: ";
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelG.Location = new System.Drawing.Point(112, 127);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(21, 15);
            this.labelG.TabIndex = 13;
            this.labelG.Text = "G: ";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelR.Location = new System.Drawing.Point(112, 107);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(21, 15);
            this.labelR.TabIndex = 12;
            this.labelR.Text = "R: ";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelA.Location = new System.Drawing.Point(112, 87);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(21, 15);
            this.labelA.TabIndex = 11;
            this.labelA.Text = "A: ";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelY.Location = new System.Drawing.Point(112, 67);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(19, 15);
            this.labelY.TabIndex = 10;
            this.labelY.Text = "Y: ";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelX.Location = new System.Drawing.Point(112, 47);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(21, 15);
            this.labelX.TabIndex = 9;
            this.labelX.Text = "X: ";
            // 
            // panelActualColor
            // 
            this.panelActualColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelActualColor.Location = new System.Drawing.Point(3, 148);
            this.panelActualColor.Name = "panelActualColor";
            this.panelActualColor.Size = new System.Drawing.Size(100, 41);
            this.panelActualColor.TabIndex = 8;
            // 
            // pictureBoxZoomCross
            // 
            this.pictureBoxZoomCross.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxZoomCross.Location = new System.Drawing.Point(3, 47);
            this.pictureBoxZoomCross.Name = "pictureBoxZoomCross";
            this.pictureBoxZoomCross.Size = new System.Drawing.Size(1, 1);
            this.pictureBoxZoomCross.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxZoomCross.TabIndex = 7;
            this.pictureBoxZoomCross.TabStop = false;
            this.pictureBoxZoomCross.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxZoomCross_Paint);
            // 
            // pictureBoxMagnifierGlass
            // 
            this.pictureBoxMagnifierGlass.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxMagnifierGlass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxMagnifierGlass.Location = new System.Drawing.Point(3, 46);
            this.pictureBoxMagnifierGlass.Name = "pictureBoxMagnifierGlass";
            this.pictureBoxMagnifierGlass.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxMagnifierGlass.TabIndex = 6;
            this.pictureBoxMagnifierGlass.TabStop = false;
            // 
            // labelActualX
            // 
            this.labelActualX.AutoSize = true;
            this.labelActualX.BackColor = System.Drawing.Color.Transparent;
            this.labelActualX.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelActualX.Location = new System.Drawing.Point(136, 47);
            this.labelActualX.Margin = new System.Windows.Forms.Padding(0);
            this.labelActualX.Name = "labelActualX";
            this.labelActualX.Size = new System.Drawing.Size(35, 15);
            this.labelActualX.TabIndex = 3;
            this.labelActualX.Text = "1920";
            this.labelActualX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerPositionXY
            // 
            this.timerPositionXY.Tick += new System.EventHandler(this.timerPositionXY_Tick);
            // 
            // panelShowHide
            // 
            this.panelShowHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(115)))));
            this.panelShowHide.Controls.Add(this.labelShowHide);
            this.panelShowHide.Cursor = System.Windows.Forms.Cursors.NoMoveVert;
            this.panelShowHide.Location = new System.Drawing.Point(0, 195);
            this.panelShowHide.Name = "panelShowHide";
            this.panelShowHide.Size = new System.Drawing.Size(400, 15);
            this.panelShowHide.TabIndex = 4;
            this.panelShowHide.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelShowHide_MouseClick);
            // 
            // labelShowHide
            // 
            this.labelShowHide.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelShowHide.Location = new System.Drawing.Point(186, 3);
            this.labelShowHide.Name = "labelShowHide";
            this.labelShowHide.Size = new System.Drawing.Size(36, 10);
            this.labelShowHide.TabIndex = 0;
            this.labelShowHide.Text = "SHOW";
            this.labelShowHide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelShowHide.MouseClick += new System.Windows.Forms.MouseEventHandler(this.labelShowHide_MouseClick);
            // 
            // panelSaved
            // 
            this.panelSaved.BackColor = System.Drawing.Color.Gainsboro;
            this.panelSaved.Controls.Add(this.buttonMoveUp);
            this.panelSaved.Controls.Add(this.buttonMoveDown);
            this.panelSaved.Controls.Add(this.buttonRead);
            this.panelSaved.Controls.Add(this.buttonUpdate);
            this.panelSaved.Controls.Add(this.buttonCopyToClipboard);
            this.panelSaved.Controls.Add(this.comboBoxTemplates);
            this.panelSaved.Controls.Add(this.buttonDelete);
            this.panelSaved.Controls.Add(this.dataGridViewSavedData);
            this.panelSaved.Location = new System.Drawing.Point(0, 210);
            this.panelSaved.Name = "panelSaved";
            this.panelSaved.Size = new System.Drawing.Size(400, 400);
            this.panelSaved.TabIndex = 5;
            this.panelSaved.Visible = false;
            // 
            // buttonMoveUp
            // 
            this.buttonMoveUp.Enabled = false;
            this.buttonMoveUp.Location = new System.Drawing.Point(3, 374);
            this.buttonMoveUp.Name = "buttonMoveUp";
            this.buttonMoveUp.Size = new System.Drawing.Size(51, 23);
            this.buttonMoveUp.TabIndex = 7;
            this.buttonMoveUp.Text = "Up";
            this.buttonMoveUp.UseVisualStyleBackColor = true;
            this.buttonMoveUp.Click += new System.EventHandler(this.buttonMoveUp_Click);
            // 
            // buttonMoveDown
            // 
            this.buttonMoveDown.Enabled = false;
            this.buttonMoveDown.Location = new System.Drawing.Point(60, 374);
            this.buttonMoveDown.Name = "buttonMoveDown";
            this.buttonMoveDown.Size = new System.Drawing.Size(51, 23);
            this.buttonMoveDown.TabIndex = 6;
            this.buttonMoveDown.Text = "Down";
            this.buttonMoveDown.UseVisualStyleBackColor = true;
            this.buttonMoveDown.Click += new System.EventHandler(this.buttonMoveDown_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.Enabled = false;
            this.buttonRead.Location = new System.Drawing.Point(232, 374);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(51, 23);
            this.buttonRead.TabIndex = 5;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Enabled = false;
            this.buttonUpdate.Location = new System.Drawing.Point(289, 374);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(51, 23);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Update";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonCopyToClipboard
            // 
            this.buttonCopyToClipboard.Enabled = false;
            this.buttonCopyToClipboard.Location = new System.Drawing.Point(217, 6);
            this.buttonCopyToClipboard.Name = "buttonCopyToClipboard";
            this.buttonCopyToClipboard.Size = new System.Drawing.Size(178, 23);
            this.buttonCopyToClipboard.TabIndex = 3;
            this.buttonCopyToClipboard.Text = "Copy to Clipboard using Template";
            this.buttonCopyToClipboard.UseVisualStyleBackColor = true;
            this.buttonCopyToClipboard.Click += new System.EventHandler(this.buttonCopyToClipboard_Click);
            // 
            // comboBoxTemplates
            // 
            this.comboBoxTemplates.FormattingEnabled = true;
            this.comboBoxTemplates.Location = new System.Drawing.Point(3, 7);
            this.comboBoxTemplates.Name = "comboBoxTemplates";
            this.comboBoxTemplates.Size = new System.Drawing.Size(207, 21);
            this.comboBoxTemplates.TabIndex = 2;
            this.comboBoxTemplates.SelectedIndexChanged += new System.EventHandler(this.comboBoxTemplates_SelectedIndexChanged);
            this.comboBoxTemplates.Click += new System.EventHandler(this.comboBoxTemplates_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Enabled = false;
            this.buttonDelete.Location = new System.Drawing.Point(346, 374);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(51, 23);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // dataGridViewSavedData
            // 
            this.dataGridViewSavedData.AllowUserToAddRows = false;
            this.dataGridViewSavedData.AllowUserToDeleteRows = false;
            this.dataGridViewSavedData.AllowUserToResizeColumns = false;
            this.dataGridViewSavedData.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewSavedData.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewSavedData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewSavedData.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(90)))), ((int)(((byte)(115)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSavedData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewSavedData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSavedData.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewSavedData.Location = new System.Drawing.Point(0, 34);
            this.dataGridViewSavedData.MultiSelect = false;
            this.dataGridViewSavedData.Name = "dataGridViewSavedData";
            this.dataGridViewSavedData.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSavedData.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewSavedData.RowHeadersWidth = 24;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewSavedData.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridViewSavedData.Size = new System.Drawing.Size(400, 334);
            this.dataGridViewSavedData.TabIndex = 0;
            this.dataGridViewSavedData.SelectionChanged += new System.EventHandler(this.dataGridViewSavedData_SelectionChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(400, 610);
            this.Controls.Add(this.panelSaved);
            this.Controls.Add(this.panelShowHide);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelTopBar);
            this.Controls.Add(this.panelBackground);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Desktop Color Picker";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panelTopBar.ResumeLayout(false);
            this.panelTopBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopLeftCorner)).EndInit();
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPicketColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoomCross)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMagnifierGlass)).EndInit();
            this.panelShowHide.ResumeLayout(false);
            this.panelSaved.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSavedData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PictureBox pictureBoxTopLeftCorner;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Label labelActualX;
        private System.Windows.Forms.Timer timerPositionXY;
        private System.Windows.Forms.PictureBox pictureBoxMagnifierGlass;
        private System.Windows.Forms.PictureBox pictureBoxZoomCross;
        private System.Windows.Forms.Panel panelActualColor;
        private System.Windows.Forms.Label labelActual;
        private System.Windows.Forms.Label labelB;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelActualB;
        private System.Windows.Forms.Label labelActualG;
        private System.Windows.Forms.Label labelActualR;
        private System.Windows.Forms.Label labelActualA;
        private System.Windows.Forms.Label labelActualY;
        private System.Windows.Forms.Label labelActualRGB;
        private System.Windows.Forms.CheckBox checkBoxAlwaysOnTop;
        private System.Windows.Forms.Button buttonPickColorFromXY;
        private System.Windows.Forms.Label labelSetY;
        private System.Windows.Forms.Label labelSetX;
        private System.Windows.Forms.TextBox textBoxSetY;
        private System.Windows.Forms.TextBox textBoxSetX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBG;
        private System.Windows.Forms.Label labelGG;
        private System.Windows.Forms.Label labelRG;
        private System.Windows.Forms.Label labelAG;
        private System.Windows.Forms.Label labelYG;
        private System.Windows.Forms.Label labelXG;
        private System.Windows.Forms.Panel panelShowHide;
        private System.Windows.Forms.Label labelShowHide;
        private System.Windows.Forms.Panel panelSaved;
        private System.Windows.Forms.TextBox textBoxPickedB;
        private System.Windows.Forms.TextBox textBoxPickedG;
        private System.Windows.Forms.TextBox textBoxPickedR;
        private System.Windows.Forms.TextBox textBoxPickedA;
        private System.Windows.Forms.TextBox textBoxPickedY;
        private System.Windows.Forms.TextBox textBoxPickedX;
        private System.Windows.Forms.PictureBox pictureBoxPicketColor;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridViewSavedData;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.CheckBox checkBoxLive;
        private System.Windows.Forms.ComboBox comboBoxTemplates;
        private System.Windows.Forms.Button buttonCopyToClipboard;
        private System.Windows.Forms.Button buttonRead;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonMoveUp;
        private System.Windows.Forms.Button buttonMoveDown;
    }
}

