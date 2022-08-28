using System;
using System.Windows.Forms;

namespace CarServiceManagement
{
    public partial class RepairbillReport : Form
    {
        public RepairbillReport()
        {
            InitializeComponent();
        }

        private void RepairbillReport_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }
    }
}
