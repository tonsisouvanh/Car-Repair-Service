using System;
using System.Windows.Forms;

namespace CarServiceManagement
{
    public partial class Qty : Form
    {
        public bool isCancel = false;
        public Qty()
        {
            InitializeComponent();
            numericQty.Value = 1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            numericQty.Value = 0;
            isCancel = true;
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
