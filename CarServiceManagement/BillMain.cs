using System;
using System.Windows.Forms;

namespace CarServiceManagement
{
    public partial class BillMain : Form
    {
        public BillMain()
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

        private void ImageButtonMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void ImageButtonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //MainMenu f = new MainMenu();
            //f.ShowDialog();
        }

        private void sidebar_importedPartsBill_Click(object sender, EventArgs e)
        {
            openChildForm(new PartImportBills());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            openChildForm(new RepairBill());
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
