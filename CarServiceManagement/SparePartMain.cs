﻿using System;
using System.Windows.Forms;

namespace CarServiceManagement
{
    public partial class SparePartMain : Form
    {
        public SparePartMain()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;

        }

        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            lblTitle.Text = childForm.Text;
            PanelMain.Controls.Add(childForm);
            PanelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ImageButtonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ImageButtonMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void sidebar_SpareParts_Click(object sender, EventArgs e)
        {
            openChildForm(new SpareParts());
        }

        private void sidebar_SparePartType_Click(object sender, EventArgs e)
        {
            openChildForm(new SparePartTypes());

        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
