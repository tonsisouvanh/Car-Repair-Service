using System;
using System.Windows.Forms;

namespace CarServiceManagement
{
    public partial class BillMain : Form
    {
        System.Windows.Forms.Timer t = null;
        public BillMain()
        {
            InitializeComponent();
            StartTimer();
        }
        private void StartTimer()
        {
            t = new System.Windows.Forms.Timer();
            t.Interval = 1000;
            t.Tick += new EventHandler(t_Tick);
            t.Enabled = true;
        }

        void t_Tick(object sender, EventArgs e)
        {
            this.labelTimer.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt");
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
            MainMenu f = new MainMenu();
            f.ShowDialog();
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
