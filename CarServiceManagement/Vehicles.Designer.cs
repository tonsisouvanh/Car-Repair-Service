namespace CarServiceManagement
{
    partial class Vehicles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PanelBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2TileButton1 = new Guna.UI2.WinForms.Guna2TileButton();
            this.ImageButtonAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            this.gunaDtgvVehicles = new Guna.UI2.WinForms.Guna2DataGridView();
            this.vehicleID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brandID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plate_number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.custname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oilchange_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.required_oilchange_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2TileButton2 = new Guna.UI2.WinForms.Guna2TileButton();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2PanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDtgvVehicles)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.guna2TileButton2);
            this.guna2Panel1.Controls.Add(this.guna2TileButton1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.txtSearch);
            this.guna2Panel1.CustomBorderColor = System.Drawing.Color.White;
            this.guna2Panel1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(800, 60);
            this.guna2Panel1.TabIndex = 13;
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
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.White;
            this.guna2PictureBox1.Image = global::CarServiceManagement.Properties.Resources.search;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(330, 16);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(29, 28);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 2;
            this.guna2PictureBox1.TabStop = false;
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
            this.txtSearch.Location = new System.Drawing.Point(88, 10);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(279, 40);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // guna2PanelBottom
            // 
            this.guna2PanelBottom.Controls.Add(this.ImageButtonAdd);
            this.guna2PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2PanelBottom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.guna2PanelBottom.Location = new System.Drawing.Point(0, 392);
            this.guna2PanelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PanelBottom.Name = "guna2PanelBottom";
            this.guna2PanelBottom.Size = new System.Drawing.Size(800, 58);
            this.guna2PanelBottom.TabIndex = 15;
            // 
            // guna2TileButton1
            // 
            this.guna2TileButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TileButton1.Animated = true;
            this.guna2TileButton1.AutoRoundedCorners = true;
            this.guna2TileButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2TileButton1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TileButton1.BorderRadius = 19;
            this.guna2TileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TileButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton1.FillColor = System.Drawing.Color.Teal;
            this.guna2TileButton1.Font = new System.Drawing.Font("Noto Sans Lao", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TileButton1.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton1.Location = new System.Drawing.Point(525, 10);
            this.guna2TileButton1.Name = "guna2TileButton1";
            this.guna2TileButton1.Size = new System.Drawing.Size(263, 41);
            this.guna2TileButton1.TabIndex = 1;
            this.guna2TileButton1.Text = "ລົດຕ້ອງການປ່ຽນນ້ຳມັນເຄື່ອງ";
            this.guna2TileButton1.UseTransparentBackground = true;
            this.guna2TileButton1.Click += new System.EventHandler(this.guna2TileButton1_Click);
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
            this.ImageButtonAdd.Location = new System.Drawing.Point(742, 5);
            this.ImageButtonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImageButtonAdd.Name = "ImageButtonAdd";
            this.ImageButtonAdd.PressedState.ImageSize = new System.Drawing.Size(0, 0);
            this.ImageButtonAdd.Size = new System.Drawing.Size(49, 47);
            this.ImageButtonAdd.TabIndex = 0;
            this.ImageButtonAdd.Click += new System.EventHandler(this.ImageButtonAdd_Click);
            // 
            // gunaDtgvVehicles
            // 
            this.gunaDtgvVehicles.AllowUserToAddRows = false;
            this.gunaDtgvVehicles.AllowUserToDeleteRows = false;
            this.gunaDtgvVehicles.AllowUserToResizeRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            this.gunaDtgvVehicles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.gunaDtgvVehicles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDtgvVehicles.BackgroundColor = System.Drawing.Color.White;
            this.gunaDtgvVehicles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDtgvVehicles.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDtgvVehicles.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Noto Sans Lao SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDtgvVehicles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.gunaDtgvVehicles.ColumnHeadersHeight = 35;
            this.gunaDtgvVehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleID,
            this.name,
            this.color,
            this.typeID,
            this.brandID,
            this.plate_number,
            this.descriptions,
            this.customerID,
            this.type_name,
            this.brand_name,
            this.custname,
            this.phone,
            this.oilchange_date,
            this.required_oilchange_date,
            this.edit,
            this.delete});
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDtgvVehicles.DefaultCellStyle = dataGridViewCellStyle13;
            this.gunaDtgvVehicles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaDtgvVehicles.EnableHeadersVisualStyles = false;
            this.gunaDtgvVehicles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDtgvVehicles.Location = new System.Drawing.Point(0, 60);
            this.gunaDtgvVehicles.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaDtgvVehicles.Name = "gunaDtgvVehicles";
            this.gunaDtgvVehicles.ReadOnly = true;
            this.gunaDtgvVehicles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Noto Sans Lao", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDtgvVehicles.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.gunaDtgvVehicles.RowHeadersVisible = false;
            this.gunaDtgvVehicles.RowHeadersWidth = 51;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            this.gunaDtgvVehicles.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.gunaDtgvVehicles.RowTemplate.Height = 33;
            this.gunaDtgvVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDtgvVehicles.Size = new System.Drawing.Size(800, 390);
            this.gunaDtgvVehicles.TabIndex = 14;
            this.gunaDtgvVehicles.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDtgvVehicles.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDtgvVehicles.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDtgvVehicles.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDtgvVehicles.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDtgvVehicles.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDtgvVehicles.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDtgvVehicles.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDtgvVehicles.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDtgvVehicles.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDtgvVehicles.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDtgvVehicles.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDtgvVehicles.ThemeStyle.HeaderStyle.Height = 35;
            this.gunaDtgvVehicles.ThemeStyle.ReadOnly = true;
            this.gunaDtgvVehicles.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDtgvVehicles.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDtgvVehicles.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDtgvVehicles.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDtgvVehicles.ThemeStyle.RowsStyle.Height = 33;
            this.gunaDtgvVehicles.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDtgvVehicles.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDtgvVehicles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDtgvVehicles_CellContentClick);
            // 
            // vehicleID
            // 
            this.vehicleID.DataPropertyName = "vehicleID";
            this.vehicleID.HeaderText = "vehicleID";
            this.vehicleID.MinimumWidth = 6;
            this.vehicleID.Name = "vehicleID";
            this.vehicleID.ReadOnly = true;
            this.vehicleID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.vehicleID.Visible = false;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "ລົດ";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // color
            // 
            this.color.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.color.DataPropertyName = "color";
            this.color.HeaderText = "ສີລົດ";
            this.color.MinimumWidth = 6;
            this.color.Name = "color";
            this.color.ReadOnly = true;
            this.color.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.color.Width = 83;
            // 
            // typeID
            // 
            this.typeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.typeID.DataPropertyName = "typeID";
            this.typeID.HeaderText = "typeID";
            this.typeID.MinimumWidth = 6;
            this.typeID.Name = "typeID";
            this.typeID.ReadOnly = true;
            this.typeID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.typeID.Visible = false;
            this.typeID.Width = 124;
            // 
            // brandID
            // 
            this.brandID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.brandID.DataPropertyName = "brandID";
            this.brandID.HeaderText = "brandID";
            this.brandID.MinimumWidth = 6;
            this.brandID.Name = "brandID";
            this.brandID.ReadOnly = true;
            this.brandID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.brandID.Visible = false;
            this.brandID.Width = 141;
            // 
            // plate_number
            // 
            this.plate_number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.plate_number.DataPropertyName = "plate_number";
            this.plate_number.HeaderText = "ເລກລົດ";
            this.plate_number.MinimumWidth = 6;
            this.plate_number.Name = "plate_number";
            this.plate_number.ReadOnly = true;
            this.plate_number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.plate_number.Width = 102;
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
            // customerID
            // 
            this.customerID.DataPropertyName = "customerID";
            this.customerID.HeaderText = "customerID";
            this.customerID.MinimumWidth = 6;
            this.customerID.Name = "customerID";
            this.customerID.ReadOnly = true;
            this.customerID.Visible = false;
            // 
            // type_name
            // 
            this.type_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.type_name.DataPropertyName = "type_name";
            this.type_name.HeaderText = "ປະເພດ";
            this.type_name.MinimumWidth = 6;
            this.type_name.Name = "type_name";
            this.type_name.ReadOnly = true;
            this.type_name.Width = 98;
            // 
            // brand_name
            // 
            this.brand_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.brand_name.DataPropertyName = "brand_name";
            this.brand_name.HeaderText = "ຍີ່ຫໍ້";
            this.brand_name.MinimumWidth = 6;
            this.brand_name.Name = "brand_name";
            this.brand_name.ReadOnly = true;
            this.brand_name.Width = 71;
            // 
            // custname
            // 
            this.custname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.custname.DataPropertyName = "custname";
            this.custname.HeaderText = "ລູກຄ້າ";
            this.custname.MinimumWidth = 6;
            this.custname.Name = "custname";
            this.custname.ReadOnly = true;
            this.custname.Width = 90;
            // 
            // phone
            // 
            this.phone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "ເບີໂທ";
            this.phone.MinimumWidth = 6;
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 84;
            // 
            // oilchange_date
            // 
            this.oilchange_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.oilchange_date.DataPropertyName = "oilchange_date";
            this.oilchange_date.HeaderText = "ວັນປ່ຽນນ້ຳມັນເຄຶ່ອງ";
            this.oilchange_date.MinimumWidth = 6;
            this.oilchange_date.Name = "oilchange_date";
            this.oilchange_date.ReadOnly = true;
            this.oilchange_date.Width = 193;
            // 
            // required_oilchange_date
            // 
            this.required_oilchange_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.required_oilchange_date.DataPropertyName = "required_oilchange_date";
            this.required_oilchange_date.HeaderText = "ວັນກຳນົດປ່ຽນໃໝ່";
            this.required_oilchange_date.MinimumWidth = 6;
            this.required_oilchange_date.Name = "required_oilchange_date";
            this.required_oilchange_date.ReadOnly = true;
            this.required_oilchange_date.Width = 179;
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.edit.HeaderText = "";
            this.edit.Image = global::CarServiceManagement.Properties.Resources.pencil_24;
            this.edit.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.edit.MinimumWidth = 6;
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.edit.Width = 6;
            // 
            // delete
            // 
            this.delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.delete.HeaderText = "";
            this.delete.Image = global::CarServiceManagement.Properties.Resources.delete_24;
            this.delete.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.delete.MinimumWidth = 6;
            this.delete.Name = "delete";
            this.delete.ReadOnly = true;
            this.delete.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.delete.Width = 6;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::CarServiceManagement.Properties.Resources.pencil_24;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn1.Width = 125;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "";
            this.dataGridViewImageColumn2.Image = global::CarServiceManagement.Properties.Resources.delete_24;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn2.Width = 125;
            // 
            // guna2TileButton2
            // 
            this.guna2TileButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TileButton2.Animated = true;
            this.guna2TileButton2.AutoRoundedCorners = true;
            this.guna2TileButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2TileButton2.BorderColor = System.Drawing.Color.Transparent;
            this.guna2TileButton2.BorderRadius = 19;
            this.guna2TileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2TileButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2TileButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2TileButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2TileButton2.FillColor = System.Drawing.Color.Teal;
            this.guna2TileButton2.Font = new System.Drawing.Font("Noto Sans Lao", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TileButton2.ForeColor = System.Drawing.Color.White;
            this.guna2TileButton2.Location = new System.Drawing.Point(397, 10);
            this.guna2TileButton2.Name = "guna2TileButton2";
            this.guna2TileButton2.Size = new System.Drawing.Size(102, 41);
            this.guna2TileButton2.TabIndex = 4;
            this.guna2TileButton2.Text = "ທັງໝົດ";
            this.guna2TileButton2.UseTransparentBackground = true;
            this.guna2TileButton2.Click += new System.EventHandler(this.guna2TileButton2_Click);
            // 
            // Vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.guna2PanelBottom);
            this.Controls.Add(this.gunaDtgvVehicles);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Vehicles";
            this.Text = "ຂໍ້ມູນລົດ";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2PanelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDtgvVehicles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ImageButton ImageButtonAdd;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelBottom;
        private Guna.UI2.WinForms.Guna2DataGridView gunaDtgvVehicles;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn brandID;
        private System.Windows.Forms.DataGridViewTextBoxColumn plate_number;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn custname;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn oilchange_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn required_oilchange_date;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton1;
        private Guna.UI2.WinForms.Guna2TileButton guna2TileButton2;
    }
}