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
            this.buttonClose = new System.Windows.Forms.Button();
            this.panelTopBar = new System.Windows.Forms.Panel();
            this.pictureBoxTopLeftCorner = new System.Windows.Forms.PictureBox();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.pictureBoxZoomCross = new System.Windows.Forms.PictureBox();
            this.pictureBoxMagnifierGlass = new System.Windows.Forms.PictureBox();
            this.labelActualY = new System.Windows.Forms.Label();
            this.labelActualX = new System.Windows.Forms.Label();
            this.pictureBoxArrow = new System.Windows.Forms.PictureBox();
            this.timerPositionXY = new System.Windows.Forms.Timer(this.components);
            this.panelActualColor = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopLeftCorner)).BeginInit();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoomCross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMagnifierGlass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).BeginInit();
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
            this.panelTopBar.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.panelTopBar.Location = new System.Drawing.Point(37, 0);
            this.panelTopBar.Name = "panelTopBar";
            this.panelTopBar.Size = new System.Drawing.Size(363, 20);
            this.panelTopBar.TabIndex = 2;
            this.panelTopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseDown);
            this.panelTopBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseMove);
            this.panelTopBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTopBar_MouseUp);
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
            this.panelBackground.Controls.Add(this.panelActualColor);
            this.panelBackground.Controls.Add(this.pictureBoxZoomCross);
            this.panelBackground.Controls.Add(this.pictureBoxMagnifierGlass);
            this.panelBackground.Controls.Add(this.labelActualY);
            this.panelBackground.Controls.Add(this.labelActualX);
            this.panelBackground.Controls.Add(this.pictureBoxArrow);
            this.panelBackground.Controls.Add(this.pictureBoxTopLeftCorner);
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(400, 200);
            this.panelBackground.TabIndex = 3;
            // 
            // pictureBoxZoomCross
            // 
            this.pictureBoxZoomCross.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxZoomCross.Location = new System.Drawing.Point(37, 75);
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
            this.pictureBoxMagnifierGlass.Location = new System.Drawing.Point(37, 75);
            this.pictureBoxMagnifierGlass.Name = "pictureBoxMagnifierGlass";
            this.pictureBoxMagnifierGlass.Size = new System.Drawing.Size(100, 100);
            this.pictureBoxMagnifierGlass.TabIndex = 6;
            this.pictureBoxMagnifierGlass.TabStop = false;
            // 
            // labelActualY
            // 
            this.labelActualY.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelActualY.Location = new System.Drawing.Point(-2, 103);
            this.labelActualY.Name = "labelActualY";
            this.labelActualY.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelActualY.Size = new System.Drawing.Size(42, 17);
            this.labelActualY.TabIndex = 5;
            this.labelActualY.Text = "1080";
            this.labelActualY.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelActualX
            // 
            this.labelActualX.AutoSize = true;
            this.labelActualX.BackColor = System.Drawing.Color.Transparent;
            this.labelActualX.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelActualX.Location = new System.Drawing.Point(62, 51);
            this.labelActualX.Margin = new System.Windows.Forms.Padding(0);
            this.labelActualX.Name = "labelActualX";
            this.labelActualX.Size = new System.Drawing.Size(35, 15);
            this.labelActualX.TabIndex = 3;
            this.labelActualX.Text = "1920";
            // 
            // pictureBoxArrow
            // 
            this.pictureBoxArrow.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxArrow.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxArrow.Image")));
            this.pictureBoxArrow.Location = new System.Drawing.Point(2, 45);
            this.pictureBoxArrow.Name = "pictureBoxArrow";
            this.pictureBoxArrow.Size = new System.Drawing.Size(62, 59);
            this.pictureBoxArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxArrow.TabIndex = 4;
            this.pictureBoxArrow.TabStop = false;
            // 
            // timerPositionXY
            // 
            this.timerPositionXY.Interval = 10;
            this.timerPositionXY.Tick += new System.EventHandler(this.timerPositionXY_Tick);
            // 
            // panelActualColor
            // 
            this.panelActualColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelActualColor.Location = new System.Drawing.Point(37, 177);
            this.panelActualColor.Name = "panelActualColor";
            this.panelActualColor.Size = new System.Drawing.Size(100, 20);
            this.panelActualColor.TabIndex = 8;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.panelTopBar);
            this.Controls.Add(this.panelBackground);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Desktop Color Picker";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopLeftCorner)).EndInit();
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoomCross)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMagnifierGlass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxArrow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.PictureBox pictureBoxTopLeftCorner;
        private System.Windows.Forms.Panel panelTopBar;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Label labelActualX;
        private System.Windows.Forms.PictureBox pictureBoxArrow;
        private System.Windows.Forms.Timer timerPositionXY;
        private System.Windows.Forms.Label labelActualY;
        private System.Windows.Forms.PictureBox pictureBoxMagnifierGlass;
        private System.Windows.Forms.PictureBox pictureBoxZoomCross;
        private System.Windows.Forms.Panel panelActualColor;
    }
}

