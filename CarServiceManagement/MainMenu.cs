﻿using System;
using System.Windows.Forms;

namespace CarServiceManagement
{
    public partial class MainMenu : Form
    {
        System.Windows.Forms.Timer t = null;
        public MainMenu()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            StartTimer();
        }

        private void StartTimer()
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;
        }

        void t_Tick(object sender, EventArgs e)
        {
            this.labelTimer.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
        }

        private void ImageButtonMaximize_Click(object sender, EventArgs e)
        {
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            SparePartMain sppm = new SparePartMain();
            sppm.ShowDialog();
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            CustomerMain customer = new CustomerMain();
            customer.ShowDialog();
        }

        private void guna2TileButton3_Click(object sender, EventArgs e)
        {
            BillMain bill = new BillMain();
            bill.ShowDialog();

        }

        private void guna2ImageButton1_Click_1(object sender, EventArgs e)
        {
            if (TMessageBox.Show("ລົງຊື່ອອກຈາກລະບົບ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                Login f = new Login();
                f.Show();
            }

        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ImageButtonClose_Click(object sender, EventArgs e)
        {
            if (TMessageBox.Show("ລົງຊື່ອອກຈາກລະບົບ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Dispose();
                Login f = new Login();
                f.Show();
            }
        }

        private void guna2TileButton4_Click(object sender, EventArgs e)
        {
            SaleReport f = new SaleReport();
            f.ShowDialog();
        }
    }
}
