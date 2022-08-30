using System;
using System.Windows.Forms;

namespace CarServiceManagement
{
    public partial class CustomerMain : Form
    {
        public CustomerMain()
        {
            InitializeComponent();
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

        private void sidebar_customers_Click(object sender, EventArgs e)
        {
            openChildForm(new Customers());
        }

        private void sidebar_vehicles_Click(object sender, EventArgs e)
        {
            openChildForm(new Vehicles());

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            openChildForm(new VehicleTypes());

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            openChildForm(new VehicleBrands());

        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
    }
}
