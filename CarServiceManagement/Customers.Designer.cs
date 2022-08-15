namespace CarServiceManagement
{
    partial class Customers
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
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PanelBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.ImageButtonAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            this.gunaDtgvCustomers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.district = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address_detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.created_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updated_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addcar = new System.Windows.Forms.DataGridViewImageColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.guna2PanelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDtgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.txtSearch);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(800, 60);
            this.guna2Panel1.TabIndex = 10;
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
            this.guna2PictureBox1.Location = new System.Drawing.Point(331, 16);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.txtSearch.Size = new System.Drawing.Size(279, 39);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // guna2PanelBottom
            // 
            this.guna2PanelBottom.Controls.Add(this.ImageButtonAdd);
            this.guna2PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2PanelBottom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.guna2PanelBottom.Location = new System.Drawing.Point(0, 392);
            this.guna2PanelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PanelBottom.Name = "guna2PanelBottom";
            this.guna2PanelBottom.Size = new System.Drawing.Size(800, 58);
            this.guna2PanelBottom.TabIndex = 13;
            // 
            // ImageButtonAdd
            // 
            this.ImageButtonAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ImageButtonAdd.BackColor = System.Drawing.Color.Transparent;
            this.ImageButtonAdd.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.ImageButtonAdd.HoverState.ImageSize = new System.Drawing.Size(38, 38);
            this.ImageButtonAdd.Image = global::CarServiceManagement.Properties.Resources.plus_green;
            this.ImageButtonAdd.ImageOffset = new System.Drawing.Point(0, 0);
            this.ImageButtonAdd.ImageRotate = 0F;
            this.ImageButtonAdd.ImageSize = new System.Drawing.Size(40, 40);
            this.ImageButtonAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ImageButtonAdd.Location = new System.Drawing.Point(741, 5);
            this.ImageButtonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImageButtonAdd.Name = "ImageButtonAdd";
            this.ImageButtonAdd.PressedState.ImageSize = new System.Drawing.Size(0, 0);
            this.ImageButtonAdd.Size = new System.Drawing.Size(49, 47);
            this.ImageButtonAdd.TabIndex = 0;
            this.ImageButtonAdd.Click += new System.EventHandler(this.ImageButtonAdd_Click);
            // 
            // gunaDtgvCustomers
            // 
            this.gunaDtgvCustomers.AllowUserToAddRows = false;
            this.gunaDtgvCustomers.AllowUserToDeleteRows = false;
            this.gunaDtgvCustomers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.gunaDtgvCustomers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDtgvCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDtgvCustomers.BackgroundColor = System.Drawing.Color.White;
            this.gunaDtgvCustomers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDtgvCustomers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDtgvCustomers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Noto Sans Lao SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDtgvCustomers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDtgvCustomers.ColumnHeadersHeight = 35;
            this.gunaDtgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerID,
            this.name,
            this.email,
            this.phone,
            this.province,
            this.district,
            this.address_detail,
            this.created_date,
            this.updated_date,
            this.addcar,
            this.edit,
            this.delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDtgvCustomers.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDtgvCustomers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaDtgvCustomers.EnableHeadersVisualStyles = false;
            this.gunaDtgvCustomers.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDtgvCustomers.Location = new System.Drawing.Point(0, 60);
            this.gunaDtgvCustomers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaDtgvCustomers.Name = "gunaDtgvCustomers";
            this.gunaDtgvCustomers.ReadOnly = true;
            this.gunaDtgvCustomers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Noto Sans Lao", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDtgvCustomers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gunaDtgvCustomers.RowHeadersVisible = false;
            this.gunaDtgvCustomers.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(2);
            this.gunaDtgvCustomers.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gunaDtgvCustomers.RowTemplate.Height = 33;
            this.gunaDtgvCustomers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDtgvCustomers.Size = new System.Drawing.Size(800, 332);
            this.gunaDtgvCustomers.TabIndex = 14;
            this.gunaDtgvCustomers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDtgvCustomers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDtgvCustomers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDtgvCustomers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDtgvCustomers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDtgvCustomers.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDtgvCustomers.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDtgvCustomers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDtgvCustomers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDtgvCustomers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDtgvCustomers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDtgvCustomers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDtgvCustomers.ThemeStyle.HeaderStyle.Height = 35;
            this.gunaDtgvCustomers.ThemeStyle.ReadOnly = true;
            this.gunaDtgvCustomers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDtgvCustomers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDtgvCustomers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDtgvCustomers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDtgvCustomers.ThemeStyle.RowsStyle.Height = 33;
            this.gunaDtgvCustomers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDtgvCustomers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDtgvCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDtgvCustomers_CellContentClick);
            // 
            // customerID
            // 
            this.customerID.DataPropertyName = "customerID";
            this.customerID.HeaderText = "customerID";
            this.customerID.MinimumWidth = 6;
            this.customerID.Name = "customerID";
            this.customerID.ReadOnly = true;
            this.customerID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.customerID.Visible = false;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "ລູກຄ້າ";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name.Width = 90;
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
            // province
            // 
            this.province.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.province.DataPropertyName = "province";
            this.province.HeaderText = "ແຂວງ";
            this.province.MinimumWidth = 6;
            this.province.Name = "province";
            this.province.ReadOnly = true;
            this.province.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.province.Width = 87;
            // 
            // district
            // 
            this.district.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.district.DataPropertyName = "district";
            this.district.HeaderText = "ເມືອງ";
            this.district.MinimumWidth = 6;
            this.district.Name = "district";
            this.district.ReadOnly = true;
            this.district.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.district.Width = 84;
            // 
            // address_detail
            // 
            this.address_detail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address_detail.DataPropertyName = "address_detail";
            this.address_detail.HeaderText = "ທີ່ຢູ່";
            this.address_detail.MinimumWidth = 6;
            this.address_detail.Name = "address_detail";
            this.address_detail.ReadOnly = true;
            this.address_detail.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // created_date
            // 
            this.created_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.created_date.DataPropertyName = "created_date";
            this.created_date.HeaderText = "ວັນ​ເລີ່ມໃຊ້ບໍລິການ";
            this.created_date.MinimumWidth = 6;
            this.created_date.Name = "created_date";
            this.created_date.ReadOnly = true;
            this.created_date.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.created_date.Width = 178;
            // 
            // updated_date
            // 
            this.updated_date.DataPropertyName = "updated_date";
            this.updated_date.HeaderText = "update";
            this.updated_date.MinimumWidth = 6;
            this.updated_date.Name = "updated_date";
            this.updated_date.ReadOnly = true;
            this.updated_date.Visible = false;
            // 
            // addcar
            // 
            this.addcar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.addcar.HeaderText = "";
            this.addcar.Image = global::CarServiceManagement.Properties.Resources.car;
            this.addcar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.addcar.MinimumWidth = 8;
            this.addcar.Name = "addcar";
            this.addcar.ReadOnly = true;
            this.addcar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.addcar.Width = 8;
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
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn3.HeaderText = "";
            this.dataGridViewImageColumn3.Image = global::CarServiceManagement.Properties.Resources.delete_24;
            this.dataGridViewImageColumn3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            this.dataGridViewImageColumn3.ReadOnly = true;
            this.dataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewImageColumn3.Width = 125;
            // 
            // Customers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gunaDtgvCustomers);
            this.Controls.Add(this.guna2PanelBottom);
            this.Controls.Add(this.guna2Panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Customers";
            this.Text = "ຂໍ້ມູນລູກຄ້າ";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.guna2PanelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaDtgvCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private Guna.UI2.WinForms.Guna2Panel guna2PanelBottom;
        private Guna.UI2.WinForms.Guna2ImageButton ImageButtonAdd;
        private Guna.UI2.WinForms.Guna2DataGridView gunaDtgvCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn province;
        private System.Windows.Forms.DataGridViewTextBoxColumn district;
        private System.Windows.Forms.DataGridViewTextBoxColumn address_detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn created_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn updated_date;
        private System.Windows.Forms.DataGridViewImageColumn addcar;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}