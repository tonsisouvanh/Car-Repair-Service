namespace CarServiceManagement
{
    partial class RepairBill
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnReload = new Guna.UI2.WinForms.Guna2ImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpTo = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtpFrom = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PanelBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.ImageButtonAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            this.gunaDtgvRepairBill = new Guna.UI2.WinForms.Guna2DataGridView();
            this.repairbillID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cust_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.payment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail = new System.Windows.Forms.DataGridViewImageColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2Panel1.SuspendLayout();
            this.guna2PanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDtgvRepairBill)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.btnReload);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.dtpTo);
            this.guna2Panel1.Controls.Add(this.dtpFrom);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.txtSearch);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1083, 60);
            this.guna2Panel1.TabIndex = 12;
            // 
            // btnReload
            // 
            this.btnReload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReload.BackColor = System.Drawing.Color.Transparent;
            this.btnReload.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.HoverState.ImageSize = new System.Drawing.Size(28, 28);
            this.btnReload.Image = global::CarServiceManagement.Properties.Resources.refresh;
            this.btnReload.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnReload.ImageRotate = 0F;
            this.btnReload.ImageSize = new System.Drawing.Size(30, 30);
            this.btnReload.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReload.Location = new System.Drawing.Point(1008, 11);
            this.btnReload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReload.Name = "btnReload";
            this.btnReload.PressedState.ImageSize = new System.Drawing.Size(0, 0);
            this.btnReload.Size = new System.Drawing.Size(59, 38);
            this.btnReload.TabIndex = 8;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(775, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 33);
            this.label3.TabIndex = 7;
            this.label3.Text = "ເຖິງ:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(515, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 33);
            this.label2.TabIndex = 6;
            this.label2.Text = "ຈາກ:";
            // 
            // dtpTo
            // 
            this.dtpTo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpTo.BorderRadius = 2;
            this.dtpTo.Checked = true;
            this.dtpTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpTo.FillColor = System.Drawing.Color.White;
            this.dtpTo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTo.Location = new System.Drawing.Point(829, 11);
            this.dtpTo.Margin = new System.Windows.Forms.Padding(4);
            this.dtpTo.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTo.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTo.Name = "dtpTo";
            this.dtpTo.Size = new System.Drawing.Size(172, 38);
            this.dtpTo.TabIndex = 5;
            this.dtpTo.Value = new System.DateTime(2022, 8, 8, 9, 38, 9, 948);
            // 
            // dtpFrom
            // 
            this.dtpFrom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpFrom.BorderRadius = 2;
            this.dtpFrom.Checked = true;
            this.dtpFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFrom.FillColor = System.Drawing.Color.White;
            this.dtpFrom.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFrom.Location = new System.Drawing.Point(575, 11);
            this.dtpFrom.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFrom.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpFrom.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpFrom.Name = "dtpFrom";
            this.dtpFrom.Size = new System.Drawing.Size(172, 38);
            this.dtpFrom.TabIndex = 4;
            this.dtpFrom.Value = new System.DateTime(2022, 8, 8, 9, 40, 56, 169);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "ຄົ້ນຫາ:";
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 2;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconRight = global::CarServiceManagement.Properties.Resources.search;
            this.txtSearch.Location = new System.Drawing.Point(88, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(279, 39);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // guna2PanelBottom
            // 
            this.guna2PanelBottom.Controls.Add(this.label5);
            this.guna2PanelBottom.Controls.Add(this.label4);
            this.guna2PanelBottom.Controls.Add(this.cbbFilter);
            this.guna2PanelBottom.Controls.Add(this.ImageButtonAdd);
            this.guna2PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2PanelBottom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.guna2PanelBottom.Location = new System.Drawing.Point(0, 490);
            this.guna2PanelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PanelBottom.Name = "guna2PanelBottom";
            this.guna2PanelBottom.Size = new System.Drawing.Size(1083, 58);
            this.guna2PanelBottom.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(909, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 33);
            this.label5.TabIndex = 10;
            this.label5.Text = "ເພີ່ມບິນໃໝ່:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Noto Sans Lao", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(605, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 33);
            this.label4.TabIndex = 9;
            this.label4.Text = "ກອງຂໍ້ມູນບິນ:";
            // 
            // cbbFilter
            // 
            this.cbbFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbbFilter.BorderRadius = 2;
            this.cbbFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbbFilter.Font = new System.Drawing.Font("Dosis", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbbFilter.ItemHeight = 30;
            this.cbbFilter.Items.AddRange(new object[] {
            "all",
            "low - high",
            "high - low",
            "status"});
            this.cbbFilter.Location = new System.Drawing.Point(735, 7);
            this.cbbFilter.Margin = new System.Windows.Forms.Padding(4);
            this.cbbFilter.Name = "cbbFilter";
            this.cbbFilter.Size = new System.Drawing.Size(152, 36);
            this.cbbFilter.TabIndex = 1;
            this.cbbFilter.SelectedIndexChanged += new System.EventHandler(this.cbbFilter_SelectedIndexChanged);
            // 
            // ImageButtonAdd
            // 
            this.ImageButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageButtonAdd.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonAdd.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageButtonAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ImageButtonAdd.HoverState.ImageSize = new System.Drawing.Size(38, 38);
            this.ImageButtonAdd.Image = global::CarServiceManagement.Properties.Resources.plus_green;
            this.ImageButtonAdd.ImageOffset = new System.Drawing.Point(0, 0);
            this.ImageButtonAdd.ImageRotate = 0F;
            this.ImageButtonAdd.ImageSize = new System.Drawing.Size(40, 40);
            this.ImageButtonAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ImageButtonAdd.Location = new System.Drawing.Point(1024, 5);
            this.ImageButtonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImageButtonAdd.Name = "ImageButtonAdd";
            this.ImageButtonAdd.PressedState.ImageSize = new System.Drawing.Size(0, 0);
            this.ImageButtonAdd.Size = new System.Drawing.Size(49, 47);
            this.ImageButtonAdd.TabIndex = 0;
            this.ImageButtonAdd.Click += new System.EventHandler(this.ImageButtonAdd_Click);
            // 
            // gunaDtgvRepairBill
            // 
            this.gunaDtgvRepairBill.AllowUserToAddRows = false;
            this.gunaDtgvRepairBill.AllowUserToDeleteRows = false;
            this.gunaDtgvRepairBill.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.gunaDtgvRepairBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDtgvRepairBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDtgvRepairBill.BackgroundColor = System.Drawing.Color.White;
            this.gunaDtgvRepairBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDtgvRepairBill.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDtgvRepairBill.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Noto Sans Lao SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDtgvRepairBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDtgvRepairBill.ColumnHeadersHeight = 35;
            this.gunaDtgvRepairBill.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.repairbillID,
            this.customerID,
            this.cust_name,
            this.phone,
            this.email,
            this.status,
            this.payment,
            this.total,
            this.descriptions,
            this.created_date,
            this.detail,
            this.edit,
            this.delete});
            this.gunaDtgvRepairBill.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDtgvRepairBill.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDtgvRepairBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaDtgvRepairBill.EnableHeadersVisualStyles = false;
            this.gunaDtgvRepairBill.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDtgvRepairBill.Location = new System.Drawing.Point(0, 60);
            this.gunaDtgvRepairBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaDtgvRepairBill.Name = "gunaDtgvRepairBill";
            this.gunaDtgvRepairBill.ReadOnly = true;
            this.gunaDtgvRepairBill.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Noto Sans Lao", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDtgvRepairBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gunaDtgvRepairBill.RowHeadersVisible = false;
            this.gunaDtgvRepairBill.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            this.gunaDtgvRepairBill.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gunaDtgvRepairBill.RowTemplate.Height = 33;
            this.gunaDtgvRepairBill.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDtgvRepairBill.Size = new System.Drawing.Size(1083, 430);
            this.gunaDtgvRepairBill.TabIndex = 16;
            this.gunaDtgvRepairBill.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDtgvRepairBill.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDtgvRepairBill.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDtgvRepairBill.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDtgvRepairBill.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDtgvRepairBill.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDtgvRepairBill.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDtgvRepairBill.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDtgvRepairBill.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDtgvRepairBill.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDtgvRepairBill.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDtgvRepairBill.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDtgvRepairBill.ThemeStyle.HeaderStyle.Height = 35;
            this.gunaDtgvRepairBill.ThemeStyle.ReadOnly = true;
            this.gunaDtgvRepairBill.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDtgvRepairBill.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDtgvRepairBill.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDtgvRepairBill.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDtgvRepairBill.ThemeStyle.RowsStyle.Height = 33;
            this.gunaDtgvRepairBill.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDtgvRepairBill.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDtgvRepairBill.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDtgvRepairBill_CellContentClick);
            // 
            // repairbillID
            // 
            this.repairbillID.DataPropertyName = "repairbillID";
            this.repairbillID.HeaderText = "repairbillID";
            this.repairbillID.MinimumWidth = 6;
            this.repairbillID.Name = "repairbillID";
            this.repairbillID.ReadOnly = true;
            this.repairbillID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.repairbillID.Visible = false;
            // 
            // customerID
            // 
            this.customerID.DataPropertyName = "customerID";
            this.customerID.HeaderText = "customerID";
            this.customerID.MinimumWidth = 6;
            this.customerID.Name = "customerID";
            this.customerID.ReadOnly = true;
            this.customerID.Visible = false;
            // 
            // cust_name
            // 
            this.cust_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cust_name.DataPropertyName = "cust_name";
            this.cust_name.HeaderText = "ຊື່ລູກຄ້າ";
            this.cust_name.MinimumWidth = 6;
            this.cust_name.Name = "cust_name";
            this.cust_name.ReadOnly = true;
            this.cust_name.Width = 102;
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "ເບີໂທ";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.phone.Width = 84;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "ອີເມວ";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.email.Width = 88;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "ສະຖານະບິນ";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.status.Width = 130;
            // 
            // payment
            // 
            this.payment.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.payment.DataPropertyName = "payment";
            this.payment.HeaderText = "ຊຳລະດ້ວຍ";
            this.payment.MinimumWidth = 6;
            this.payment.Name = "payment";
            this.payment.ReadOnly = true;
            this.payment.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.payment.Width = 120;
            // 
            // total
            // 
            this.total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.total.DataPropertyName = "total";
            this.total.HeaderText = "ລວມເງິນ";
            this.total.MinimumWidth = 6;
            this.total.Name = "total";
            this.total.ReadOnly = true;
            this.total.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.total.Width = 109;
            // 
            // descriptions
            // 
            this.descriptions.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptions.DataPropertyName = "descriptions";
            this.descriptions.HeaderText = "ຄຳອະທິບາຍ";
            this.descriptions.MinimumWidth = 6;
            this.descriptions.Name = "descriptions";
            this.descriptions.ReadOnly = true;
            this.descriptions.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // created_date
            // 
            this.created_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.created_date.DataPropertyName = "created_date";
            this.created_date.HeaderText = "ວັນ​ຂຽນບິນ";
            this.created_date.MinimumWidth = 6;
            this.created_date.Name = "created_date";
            this.created_date.ReadOnly = true;
            this.created_date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.created_date.Width = 132;
            // 
            // detail
            // 
            this.detail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.detail.HeaderText = "";
            this.detail.Image = global::CarServiceManagement.Properties.Resources.billdetail;
            this.detail.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.detail.MinimumWidth = 8;
            this.detail.Name = "detail";
            this.detail.ReadOnly = true;
            this.detail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.detail.Width = 8;
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.edit.HeaderText = "";
            this.edit.Image = global::CarServiceManagement.Properties.Resources.pencil_24;
            this.edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.edit.MinimumWidth = 8;
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.edit.Width = 8;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delete.HeaderText = "";
            this.delete.Image = global::CarServiceManagement.Properties.Resources.delete_24;
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete.MinimumWidth = 8;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.delete.Width = 8;
            // 
            // RepairBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 548);
            this.Controls.Add(this.gunaDtgvRepairBill);
            this.Controls.Add(this.guna2PanelBottom);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "RepairBill";
            this.Text = "ບິນສ້ອມແປງ / ຂາຍອາໄຫຼ່";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2PanelBottom.ResumeLayout(false);
            this.guna2PanelBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDtgvRepairBill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ImageButton btnReload;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTo;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpFrom;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelBottom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbbFilter;
        private Guna.UI2.WinForms.Guna2ImageButton ImageButtonAdd;
        private Guna.UI2.WinForms.Guna2DataGridView gunaDtgvRepairBill;
        private System.Windows.Forms.DataGridViewTextBoxColumn repairbillID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn cust_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn payment;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_date;
        private System.Windows.Forms.DataGridViewImageColumn detail;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}