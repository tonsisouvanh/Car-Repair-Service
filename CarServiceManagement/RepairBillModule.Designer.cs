﻿namespace CarServiceManagement
{
    partial class RepairBillModule
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
            this.dtpCreatedDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustInfo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelAddNewCust = new System.Windows.Forms.Label();
            this.formInputPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.labelCustID = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtKmageCheck = new System.Windows.Forms.TextBox();
            this.btnKmageCheck = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.formInputPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpCreatedDate
            // 
            this.dtpCreatedDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpCreatedDate.Checked = true;
            this.dtpCreatedDate.CustomFormat = "dd/MM/yyyy";
            this.dtpCreatedDate.Enabled = false;
            this.dtpCreatedDate.FillColor = System.Drawing.Color.SteelBlue;
            this.dtpCreatedDate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCreatedDate.ForeColor = System.Drawing.Color.White;
            this.dtpCreatedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCreatedDate.Location = new System.Drawing.Point(677, 173);
            this.dtpCreatedDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpCreatedDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpCreatedDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpCreatedDate.Name = "dtpCreatedDate";
            this.dtpCreatedDate.Size = new System.Drawing.Size(303, 38);
            this.dtpCreatedDate.TabIndex = 128;
            this.dtpCreatedDate.Value = new System.DateTime(2022, 8, 8, 13, 37, 7, 480);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Defago Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(440, 173);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 33);
            this.label7.TabIndex = 140;
            this.label7.Text = "ກີບ";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Defago Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(180, 173);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(251, 40);
            this.txtTotal.TabIndex = 127;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Defago Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 173);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 33);
            this.label6.TabIndex = 139;
            this.label6.Text = "ລວມເງິນ";
            // 
            // cbbStatus
            // 
            this.cbbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbbStatus.DropDownHeight = 200;
            this.cbbStatus.Font = new System.Drawing.Font("Defago Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.IntegralHeight = false;
            this.cbbStatus.Items.AddRange(new object[] {
            "ຊຳລະແລ້ວ",
            "ຍັງບໍ່ຊຳລະ"});
            this.cbbStatus.Location = new System.Drawing.Point(180, 18);
            this.cbbStatus.Margin = new System.Windows.Forms.Padding(4);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(299, 41);
            this.cbbStatus.TabIndex = 124;
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Defago Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(556, 173);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 33);
            this.label9.TabIndex = 141;
            this.label9.Text = "ວັນຂຽນບິນ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Dosis", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(765, 585);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(125, 43);
            this.btnUpdate.TabIndex = 132;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Defago Noto Sans", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(4, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "ປ້ອນ / ແກ້ໄຂຂໍ່ມູນບິນສ້ອມແປງ";
            // 
            // txtDesc
            // 
            this.txtDesc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDesc.Font = new System.Drawing.Font("Defago Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(180, 74);
            this.txtDesc.Margin = new System.Windows.Forms.Padding(4);
            this.txtDesc.Multiline = true;
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(799, 79);
            this.txtDesc.TabIndex = 126;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Defago Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 74);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 33);
            this.label8.TabIndex = 137;
            this.label8.Text = "ຄຳອະທິບາຍ";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Defago Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(556, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 33);
            this.label4.TabIndex = 136;
            this.label4.Text = "ຊຳລະດ້ວຍ";
            // 
            // txtPayment
            // 
            this.txtPayment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPayment.Font = new System.Drawing.Font("Defago Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayment.Location = new System.Drawing.Point(693, 18);
            this.txtPayment.Margin = new System.Windows.Forms.Padding(4);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(285, 40);
            this.txtPayment.TabIndex = 125;
            // 
            // labelID
            // 
            this.labelID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(48, 609);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(38, 16);
            this.labelID.TabIndex = 135;
            this.labelID.Text = "BillID";
            this.labelID.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Defago Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 33);
            this.label3.TabIndex = 134;
            this.label3.Text = "ສະຖານະໃບບິນ";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Dosis", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(632, 585);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(125, 43);
            this.btnSave.TabIndex = 130;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Dosis", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(897, 585);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(125, 43);
            this.btnCancel.TabIndex = 133;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(70)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.picClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 62);
            this.panel1.TabIndex = 129;
            // 
            // picClose
            // 
            this.picClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picClose.BackColor = System.Drawing.Color.Transparent;
            this.picClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.picClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picClose.HoverState.ImageSize = new System.Drawing.Size(27, 27);
            this.picClose.Image = global::CarServiceManagement.Properties.Resources.close_32;
            this.picClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.picClose.ImageRotate = 0F;
            this.picClose.ImageSize = new System.Drawing.Size(23, 23);
            this.picClose.Location = new System.Drawing.Point(1017, 7);
            this.picClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picClose.Name = "picClose";
            this.picClose.PressedState.ImageSize = new System.Drawing.Size(27, 27);
            this.picClose.Size = new System.Drawing.Size(37, 46);
            this.picClose.TabIndex = 13;
            this.picClose.Click += new System.EventHandler(this.picClose_Click);
            // 
            // txtCustName
            // 
            this.txtCustName.BackColor = System.Drawing.SystemColors.Control;
            this.txtCustName.Enabled = false;
            this.txtCustName.Font = new System.Drawing.Font("Defago Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustName.Location = new System.Drawing.Point(733, 177);
            this.txtCustName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(285, 40);
            this.txtCustName.TabIndex = 146;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Defago Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(584, 177);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 33);
            this.label10.TabIndex = 145;
            this.label10.Text = "ຊື່ລູກຄ້າ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Defago Noto Sans", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 36);
            this.label2.TabIndex = 144;
            this.label2.Text = "ໃສ່ເບີໂທ ຫຼື ອີເມວ ລູກຄ້າເພື່ອຂຽນບິນ";
            // 
            // txtCustInfo
            // 
            this.txtCustInfo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCustInfo.Font = new System.Drawing.Font("Defago Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustInfo.Location = new System.Drawing.Point(219, 177);
            this.txtCustInfo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustInfo.Name = "txtCustInfo";
            this.txtCustInfo.Size = new System.Drawing.Size(299, 40);
            this.txtCustInfo.TabIndex = 142;
            this.txtCustInfo.TextChanged += new System.EventHandler(this.txtCustInfo_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Defago Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 177);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 33);
            this.label5.TabIndex = 143;
            this.label5.Text = "ເບີໂທ";
            // 
            // labelAddNewCust
            // 
            this.labelAddNewCust.AutoSize = true;
            this.labelAddNewCust.BackColor = System.Drawing.Color.Transparent;
            this.labelAddNewCust.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelAddNewCust.Font = new System.Drawing.Font("Defago Noto Sans", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddNewCust.ForeColor = System.Drawing.Color.DodgerBlue;
            this.labelAddNewCust.Location = new System.Drawing.Point(871, 98);
            this.labelAddNewCust.Name = "labelAddNewCust";
            this.labelAddNewCust.Size = new System.Drawing.Size(151, 33);
            this.labelAddNewCust.TabIndex = 147;
            this.labelAddNewCust.Text = "ເພີ່ມຂໍ້ມູນລູກຄ້າໃໝ່";
            this.labelAddNewCust.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelAddNewCust.Click += new System.EventHandler(this.labelAddNewCust_Click);
            // 
            // formInputPanel
            // 
            this.formInputPanel.Controls.Add(this.btnKmageCheck);
            this.formInputPanel.Controls.Add(this.txtKmageCheck);
            this.formInputPanel.Controls.Add(this.label11);
            this.formInputPanel.Controls.Add(this.cbbStatus);
            this.formInputPanel.Controls.Add(this.label3);
            this.formInputPanel.Controls.Add(this.txtPayment);
            this.formInputPanel.Controls.Add(this.label4);
            this.formInputPanel.Controls.Add(this.label8);
            this.formInputPanel.Controls.Add(this.txtDesc);
            this.formInputPanel.Controls.Add(this.label9);
            this.formInputPanel.Controls.Add(this.dtpCreatedDate);
            this.formInputPanel.Controls.Add(this.label6);
            this.formInputPanel.Controls.Add(this.label7);
            this.formInputPanel.Controls.Add(this.txtTotal);
            this.formInputPanel.Enabled = false;
            this.formInputPanel.Location = new System.Drawing.Point(40, 222);
            this.formInputPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.formInputPanel.Name = "formInputPanel";
            this.formInputPanel.Size = new System.Drawing.Size(1000, 342);
            this.formInputPanel.TabIndex = 148;
            // 
            // labelCustID
            // 
            this.labelCustID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelCustID.AutoSize = true;
            this.labelCustID.Location = new System.Drawing.Point(101, 609);
            this.labelCustID.Name = "labelCustID";
            this.labelCustID.Size = new System.Drawing.Size(76, 16);
            this.labelCustID.TabIndex = 149;
            this.labelCustID.Text = "labelCustID";
            this.labelCustID.Visible = false;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Defago Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 241);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(227, 33);
            this.label11.TabIndex = 142;
            this.label11.Text = "ພິມເລກໄລຍະທາງລົດເພື່ອກວດ";
            // 
            // txtKmageCheck
            // 
            this.txtKmageCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKmageCheck.Font = new System.Drawing.Font("Defago Noto Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKmageCheck.Location = new System.Drawing.Point(11, 278);
            this.txtKmageCheck.Margin = new System.Windows.Forms.Padding(4);
            this.txtKmageCheck.Name = "txtKmageCheck";
            this.txtKmageCheck.Size = new System.Drawing.Size(251, 40);
            this.txtKmageCheck.TabIndex = 143;
            // 
            // btnKmageCheck
            // 
            this.btnKmageCheck.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnKmageCheck.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnKmageCheck.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnKmageCheck.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnKmageCheck.FillColor = System.Drawing.Color.Transparent;
            this.btnKmageCheck.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKmageCheck.ForeColor = System.Drawing.Color.White;
            this.btnKmageCheck.Image = global::CarServiceManagement.Properties.Resources.search;
            this.btnKmageCheck.ImageSize = new System.Drawing.Size(30, 30);
            this.btnKmageCheck.Location = new System.Drawing.Point(270, 278);
            this.btnKmageCheck.Name = "btnKmageCheck";
            this.btnKmageCheck.Size = new System.Drawing.Size(50, 40);
            this.btnKmageCheck.TabIndex = 144;
            this.btnKmageCheck.Click += new System.EventHandler(this.btnKmageCheck_Click);
            // 
            // RepairBillModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 652);
            this.Controls.Add(this.labelCustID);
            this.Controls.Add(this.formInputPanel);
            this.Controls.Add(this.labelAddNewCust);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustInfo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RepairBillModule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RepairBillModule";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.formInputPanel.ResumeLayout(false);
            this.formInputPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public Guna.UI2.WinForms.Guna2DateTimePicker dtpCreatedDate;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cbbStatus;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtPayment;
        public System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtCustInfo;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label labelAddNewCust;
        public System.Windows.Forms.Label labelCustID;
        public Guna.UI2.WinForms.Guna2Panel formInputPanel;
        private Guna.UI2.WinForms.Guna2ImageButton picClose;
        public System.Windows.Forms.TextBox txtKmageCheck;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2Button btnKmageCheck;
    }
}