namespace CarServiceManagement
{
    partial class SpareParts
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
            this.guna2PanelBottom = new Guna.UI2.WinForms.Guna2Panel();
            this.ImageButtonAdd = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtPartName = new Guna.UI2.WinForms.Guna2TextBox();
            this.gunaDtgvParts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.partID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cal_unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.part_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2PanelBottom.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDtgvParts)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PanelBottom
            // 
            this.guna2PanelBottom.Controls.Add(this.ImageButtonAdd);
            this.guna2PanelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2PanelBottom.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(144)))));
            this.guna2PanelBottom.Location = new System.Drawing.Point(0, 392);
            this.guna2PanelBottom.Margin = new System.Windows.Forms.Padding(4);
            this.guna2PanelBottom.Name = "guna2PanelBottom";
            this.guna2PanelBottom.Size = new System.Drawing.Size(800, 58);
            this.guna2PanelBottom.TabIndex = 7;
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
            this.ImageButtonAdd.Location = new System.Drawing.Point(742, 5);
            this.ImageButtonAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ImageButtonAdd.Name = "ImageButtonAdd";
            this.ImageButtonAdd.PressedState.ImageSize = new System.Drawing.Size(0, 0);
            this.ImageButtonAdd.Size = new System.Drawing.Size(49, 47);
            this.ImageButtonAdd.TabIndex = 0;
            this.ImageButtonAdd.Click += new System.EventHandler(this.ImageButtonAdd_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2PictureBox1);
            this.guna2Panel1.Controls.Add(this.txtPartName);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(70)))), ((int)(((byte)(144)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(800, 60);
            this.guna2Panel1.TabIndex = 9;
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
            // txtPartName
            // 
            this.txtPartName.BorderRadius = 2;
            this.txtPartName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPartName.DefaultText = "";
            this.txtPartName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPartName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPartName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPartName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPartName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPartName.Font = new System.Drawing.Font("Phetsarath OT", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPartName.ForeColor = System.Drawing.Color.Black;
            this.txtPartName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPartName.Location = new System.Drawing.Point(88, 10);
            this.txtPartName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPartName.Name = "txtPartName";
            this.txtPartName.PasswordChar = '\0';
            this.txtPartName.PlaceholderText = "";
            this.txtPartName.SelectedText = "";
            this.txtPartName.Size = new System.Drawing.Size(279, 40);
            this.txtPartName.TabIndex = 1;
            this.txtPartName.TextChanged += new System.EventHandler(this.txtPartName_TextChanged);
            // 
            // gunaDtgvParts
            // 
            this.gunaDtgvParts.AllowUserToAddRows = false;
            this.gunaDtgvParts.AllowUserToDeleteRows = false;
            this.gunaDtgvParts.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.gunaDtgvParts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gunaDtgvParts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gunaDtgvParts.BackgroundColor = System.Drawing.Color.White;
            this.gunaDtgvParts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gunaDtgvParts.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gunaDtgvParts.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Noto Sans Lao SemiCondensed", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDtgvParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gunaDtgvParts.ColumnHeadersHeight = 35;
            this.gunaDtgvParts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partID,
            this.name,
            this.stock,
            this.price,
            this.currency,
            this.cal_unit,
            this.descriptions,
            this.part_type,
            this.brand,
            this.type_name,
            this.edit,
            this.delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gunaDtgvParts.DefaultCellStyle = dataGridViewCellStyle3;
            this.gunaDtgvParts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaDtgvParts.EnableHeadersVisualStyles = false;
            this.gunaDtgvParts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDtgvParts.Location = new System.Drawing.Point(0, 60);
            this.gunaDtgvParts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaDtgvParts.Name = "gunaDtgvParts";
            this.gunaDtgvParts.ReadOnly = true;
            this.gunaDtgvParts.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Noto Sans Lao", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gunaDtgvParts.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gunaDtgvParts.RowHeadersVisible = false;
            this.gunaDtgvParts.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Phetsarath OT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            this.gunaDtgvParts.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.gunaDtgvParts.RowTemplate.Height = 33;
            this.gunaDtgvParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gunaDtgvParts.Size = new System.Drawing.Size(800, 332);
            this.gunaDtgvParts.TabIndex = 10;
            this.gunaDtgvParts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDtgvParts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gunaDtgvParts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gunaDtgvParts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gunaDtgvParts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gunaDtgvParts.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gunaDtgvParts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDtgvParts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDtgvParts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gunaDtgvParts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDtgvParts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gunaDtgvParts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gunaDtgvParts.ThemeStyle.HeaderStyle.Height = 35;
            this.gunaDtgvParts.ThemeStyle.ReadOnly = true;
            this.gunaDtgvParts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gunaDtgvParts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gunaDtgvParts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gunaDtgvParts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDtgvParts.ThemeStyle.RowsStyle.Height = 33;
            this.gunaDtgvParts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gunaDtgvParts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gunaDtgvParts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gunaDtgvParts_CellContentClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "";
            this.dataGridViewImageColumn1.Image = global::CarServiceManagement.Properties.Resources.pencil;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
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
            this.dataGridViewImageColumn2.Width = 125;
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
            // partID
            // 
            this.partID.DataPropertyName = "partID";
            this.partID.HeaderText = "partID";
            this.partID.MinimumWidth = 6;
            this.partID.Name = "partID";
            this.partID.ReadOnly = true;
            this.partID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.partID.Visible = false;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "ອາໄຫຼ່";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // stock
            // 
            this.stock.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stock.DataPropertyName = "stock";
            this.stock.HeaderText = "ຈ/ນ";
            this.stock.MinimumWidth = 6;
            this.stock.Name = "stock";
            this.stock.ReadOnly = true;
            this.stock.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.stock.Width = 79;
            // 
            // price
            // 
            this.price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "ລາຄາ";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.ReadOnly = true;
            this.price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.price.Width = 84;
            // 
            // currency
            // 
            this.currency.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.currency.DataPropertyName = "currency";
            this.currency.HeaderText = "ສະກຸນເງິນ";
            this.currency.MinimumWidth = 6;
            this.currency.Name = "currency";
            this.currency.ReadOnly = true;
            this.currency.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.currency.Width = 117;
            // 
            // cal_unit
            // 
            this.cal_unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cal_unit.DataPropertyName = "cal_unit";
            this.cal_unit.HeaderText = "ໜ່ວຍວັດ";
            this.cal_unit.MinimumWidth = 6;
            this.cal_unit.Name = "cal_unit";
            this.cal_unit.ReadOnly = true;
            this.cal_unit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.cal_unit.Width = 113;
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
            // part_type
            // 
            this.part_type.DataPropertyName = "part_type";
            this.part_type.HeaderText = "partTypeID";
            this.part_type.MinimumWidth = 6;
            this.part_type.Name = "part_type";
            this.part_type.ReadOnly = true;
            this.part_type.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.part_type.Visible = false;
            // 
            // brand
            // 
            this.brand.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.brand.DataPropertyName = "brand";
            this.brand.HeaderText = "ຍີ່ຫໍ້";
            this.brand.MinimumWidth = 6;
            this.brand.Name = "brand";
            this.brand.ReadOnly = true;
            this.brand.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.brand.Width = 71;
            // 
            // type_name
            // 
            this.type_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.type_name.DataPropertyName = "type_name";
            this.type_name.HeaderText = "ປະເພດ";
            this.type_name.MinimumWidth = 6;
            this.type_name.Name = "type_name";
            this.type_name.ReadOnly = true;
            this.type_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.type_name.Width = 98;
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
            // SpareParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gunaDtgvParts);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2PanelBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SpareParts";
            this.Text = "ຈັດການຂໍ້ມູນອາໄຫຼ່";
            this.guna2PanelBottom.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaDtgvParts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2PanelBottom;
        private Guna.UI2.WinForms.Guna2ImageButton ImageButtonAdd;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtPartName;
        private Guna.UI2.WinForms.Guna2DataGridView gunaDtgvParts;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn partID;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn currency;
        private System.Windows.Forms.DataGridViewTextBoxColumn cal_unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptions;
        private System.Windows.Forms.DataGridViewTextBoxColumn part_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_name;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.DataGridViewImageColumn delete;
    }
}