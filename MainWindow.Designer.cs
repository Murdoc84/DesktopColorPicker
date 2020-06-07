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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTopLeftCorner)).BeginInit();
            this.panelBackground.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxZoomCross)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMagnifierGlass)).BeginInit();
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
            this.panelBackground.Size = new System.Drawing.Size(400, 170);
            this.panelBackground.TabIndex = 3;
            // 
            // labelActualRGB
            // 
            this.labelActualRGB.BackColor = System.Drawing.Color.Transparent;
            this.labelActualRGB.Font = new System.Drawing.Font("Arial", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelActualRGB.Location = new System.Drawing.Point(166, 87);
            this.labelActualRGB.Margin = new System.Windows.Forms.Padding(0);
            this.labelActualRGB.Name = "labelActualRGB";
            this.labelActualRGB.Size = new System.Drawing.Size(10, 74);
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
            this.panelActualColor.Size = new System.Drawing.Size(100, 20);
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
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(400, 170);
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
    }
}

