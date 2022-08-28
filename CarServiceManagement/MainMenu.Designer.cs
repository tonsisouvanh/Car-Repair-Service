namespace CarServiceManagement
{
    partial class MainMenu
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
            this.topPanel = new System.Windows.Forms.Panel();
            this.picMinimize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ImageButtonMaximize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.ImageButtonClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.guna2TileButton1 = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2TileButton2 = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2TileButton3 = new Guna.UI2.WinForms.Guna2TileButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2BottomPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelTimer = new System.Windows.Forms.Label();
            this.Middlepanel = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.topPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.guna2BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.Middlepanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.White;
            this.topPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.topPanel.Controls.Add(this.picMinimize);
            this.topPanel.Controls.Add(this.ImageButtonMaximize);
            this.topPanel.Controls.Add(this.ImageButtonClose);
            this.topPanel.Controls.Add(this.tableLayoutPanel1);
            this.topPanel.Controls.Add(this.panel2);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(5, 5);
            this.topPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1546, 192);
            this.topPanel.TabIndex = 2;
            // 
            // picMinimize
            // 
            this.picMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picMinimize.BackColor = System.Drawing.Color.Transparent;
            this.picMinimize.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.picMinimize.HoverState.ImageSize = new System.Drawing.Size(27, 27);
            this.picMinimize.Image = global::CarServiceManagement.Properties.Resources.minimize_32;
            this.picMinimize.ImageOffset = new System.Drawing.Point(0, 0);
            this.picMinimize.ImageRotate = 0F;
            this.picMinimize.ImageSize = new System.Drawing.Size(23, 23);
            this.picMinimize.Location = new System.Drawing.Point(1449, 6);
            this.picMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picMinimize.Name = "picMinimize";
            this.picMinimize.PressedState.ImageSize = new System.Drawing.Size(27, 27);
            this.picMinimize.Size = new System.Drawing.Size(43, 34);
            this.picMinimize.TabIndex = 13;
            this.picMinimize.UseTransparentBackground = true;
            this.picMinimize.Click += new System.EventHandler(this.picMinimize_Click);
            // 
            // ImageButtonMaximize
            // 
            this.ImageButtonMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageButtonMaximize.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonMaximize.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageButtonMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageButtonMaximize.HoverState.ImageSize = new System.Drawing.Size(27, 27);
            this.ImageButtonMaximize.Image = global::CarServiceManagement.Properties.Resources.maximize_32;
            this.ImageButtonMaximize.ImageOffset = new System.Drawing.Point(0, 0);
            this.ImageButtonMaximize.ImageRotate = 0F;
            this.ImageButtonMaximize.ImageSize = new System.Drawing.Size(23, 23);
            this.ImageButtonMaximize.Location = new System.Drawing.Point(1405, 6);
            this.ImageButtonMaximize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImageButtonMaximize.Name = "ImageButtonMaximize";
            this.ImageButtonMaximize.PressedState.ImageSize = new System.Drawing.Size(27, 27);
            this.ImageButtonMaximize.Size = new System.Drawing.Size(37, 34);
            this.ImageButtonMaximize.TabIndex = 12;
            this.ImageButtonMaximize.Visible = false;
            this.ImageButtonMaximize.Click += new System.EventHandler(this.ImageButtonMaximize_Click);
            // 
            // ImageButtonClose
            // 
            this.ImageButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageButtonClose.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageButtonClose.HoverState.ImageSize = new System.Drawing.Size(27, 27);
            this.ImageButtonClose.Image = global::CarServiceManagement.Properties.Resources.close_32;
            this.ImageButtonClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.ImageButtonClose.ImageRotate = 0F;
            this.ImageButtonClose.ImageSize = new System.Drawing.Size(23, 23);
            this.ImageButtonClose.Location = new System.Drawing.Point(1497, 6);
            this.ImageButtonClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImageButtonClose.Name = "ImageButtonClose";
            this.ImageButtonClose.PressedState.ImageSize = new System.Drawing.Size(27, 27);
            this.ImageButtonClose.Size = new System.Drawing.Size(37, 34);
            this.ImageButtonClose.TabIndex = 11;
            this.ImageButtonClose.Click += new System.EventHandler(this.ImageButtonClose_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.guna2TileButton1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.guna2TileButton2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.guna2TileButton3, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(295, 20);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1082, 150);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // guna2TileButton1
            // 
            this.guna2TileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TileButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2TileButton1.FillColor = System.Drawing.Color.Firebrick;
            this.guna2TileButton1.Font = new System.Drawing.Font("Defago Noto Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton1.Image = global::CarServiceManagement.Properties.Resources.maintenance;
            this.guna2TileButton1.ImageOffset = new System.Drawing.Point(0, 20);
            this.guna2TileButton1.ImageSize = new System.Drawing.Size(70, 70);
            this.guna2TileButton1.Location = new System.Drawing.Point(3, 2);
            this.guna2TileButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2TileButton1.Name = "guna2TileButton1";
            this.guna2TileButton1.Size = new System.Drawing.Size(354, 146);
            this.guna2TileButton1.TabIndex = 7;
            this.guna2TileButton1.Text = "ຈັດການອາໄຫຼ່";
            this.guna2TileButton1.TextOffset = new System.Drawing.Point(0, 10);
            this.guna2TileButton1.Click += new System.EventHandler(this.guna2TileButton1_Click);
            // 
            // guna2TileButton2
            // 
            this.guna2TileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TileButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2TileButton2.FillColor = System.Drawing.Color.Teal;
            this.guna2TileButton2.Font = new System.Drawing.Font("Defago Noto Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TileButton2.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton2.Image = global::CarServiceManagement.Properties.Resources.customer;
            this.guna2TileButton2.ImageOffset = new System.Drawing.Point(0, 20);
            this.guna2TileButton2.ImageSize = new System.Drawing.Size(70, 70);
            this.guna2TileButton2.Location = new System.Drawing.Point(363, 2);
            this.guna2TileButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2TileButton2.Name = "guna2TileButton2";
            this.guna2TileButton2.Size = new System.Drawing.Size(354, 146);
            this.guna2TileButton2.TabIndex = 8;
            this.guna2TileButton2.Text = "ລູກຄ້າ/ລົດ";
            this.guna2TileButton2.TextOffset = new System.Drawing.Point(0, 10);
            this.guna2TileButton2.Click += new System.EventHandler(this.guna2TileButton2_Click);
            // 
            // guna2TileButton3
            // 
            this.guna2TileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TileButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2TileButton3.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.guna2TileButton3.Font = new System.Drawing.Font("Defago Noto Sans", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TileButton3.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton3.Image = global::CarServiceManagement.Properties.Resources.invoice;
            this.guna2TileButton3.ImageOffset = new System.Drawing.Point(0, 20);
            this.guna2TileButton3.ImageSize = new System.Drawing.Size(70, 70);
            this.guna2TileButton3.Location = new System.Drawing.Point(723, 2);
            this.guna2TileButton3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2TileButton3.Name = "guna2TileButton3";
            this.guna2TileButton3.Size = new System.Drawing.Size(356, 146);
            this.guna2TileButton3.TabIndex = 9;
            this.guna2TileButton3.Text = "ຈັດການບິນ";
            this.guna2TileButton3.TextOffset = new System.Drawing.Point(0, 10);
            this.guna2TileButton3.Click += new System.EventHandler(this.guna2TileButton3_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(271, 190);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CarServiceManagement.Properties.Resources.car_repair_white;
            this.pictureBox1.Location = new System.Drawing.Point(59, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(124, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Defago Noto Sans", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-4, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 61);
            this.label2.TabIndex = 1;
            this.label2.Text = "ລວມອາໄຫຼ່ລົດຍົນ";
            // 
            // guna2BottomPanel
            // 
            this.guna2BottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(144)))));
            this.guna2BottomPanel.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.guna2BottomPanel.Controls.Add(this.guna2ImageButton1);
            this.guna2BottomPanel.Controls.Add(this.label3);
            this.guna2BottomPanel.Controls.Add(this.labelName);
            this.guna2BottomPanel.Controls.Add(this.guna2PictureBox2);
            this.guna2BottomPanel.Controls.Add(this.labelTimer);
            this.guna2BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2BottomPanel.Location = new System.Drawing.Point(5, 836);
            this.guna2BottomPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2BottomPanel.Name = "guna2BottomPanel";
            this.guna2BottomPanel.Size = new System.Drawing.Size(1546, 43);
            this.guna2BottomPanel.TabIndex = 6;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(28, 28);
            this.guna2ImageButton1.Image = global::CarServiceManagement.Properties.Resources.logout_triangle;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(29, 29);
            this.guna2ImageButton1.Location = new System.Drawing.Point(8, 5);
            this.guna2ImageButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(28, 28);
            this.guna2ImageButton1.Size = new System.Drawing.Size(43, 31);
            this.guna2ImageButton1.TabIndex = 8;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click_1);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Dosis", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1282, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(238, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Copy right reserved to Dev-Tons";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Defago Noto Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(96, 7);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(0, 29);
            this.labelName.TabIndex = 1;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::CarServiceManagement.Properties.Resources.user;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(65, 7);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(24, 25);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox2.TabIndex = 0;
            this.guna2PictureBox2.TabStop = false;
            // 
            // labelTimer
            // 
            this.labelTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTimer.Font = new System.Drawing.Font("Defago Noto Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.ForeColor = System.Drawing.Color.White;
            this.labelTimer.Location = new System.Drawing.Point(0, 0);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(1546, 43);
            this.labelTimer.TabIndex = 9;
            this.labelTimer.Text = "Time";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Middlepanel
            // 
            this.Middlepanel.BackColor = System.Drawing.Color.White;
            this.Middlepanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Middlepanel.Controls.Add(this.guna2PictureBox1);
            this.Middlepanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Middlepanel.Location = new System.Drawing.Point(5, 197);
            this.Middlepanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Middlepanel.Name = "Middlepanel";
            this.Middlepanel.Padding = new System.Windows.Forms.Padding(20);
            this.Middlepanel.Size = new System.Drawing.Size(1546, 639);
            this.Middlepanel.TabIndex = 7;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2PictureBox1.Image = global::CarServiceManagement.Properties.Resources.car_service_bg;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(20, 20);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(1504, 597);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 884);
            this.Controls.Add(this.Middlepanel);
            this.Controls.Add(this.guna2BottomPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainMenu";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.topPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.guna2BottomPanel.ResumeLayout(false);
            this.guna2BottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.Middlepanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton1;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2BottomPanel;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Panel Middlepanel;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton3;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        public System.Windows.Forms.Label labelName;
        private Guna.UI2.WinForms.Guna2ImageButton picMinimize;
        private Guna.UI2.WinForms.Guna2ImageButton ImageButtonMaximize;
        private Guna.UI2.WinForms.Guna2ImageButton ImageButtonClose;
        private System.Windows.Forms.Label labelTimer;
    }
}