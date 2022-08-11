using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceManagement
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit Application?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void ImageButtonMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
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
    }
}
