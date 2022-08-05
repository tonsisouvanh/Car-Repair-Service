using CarServiceManagement.DAO;
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
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            Load_Customers();
        }

        public void Load_Customers()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Customer");
            gunaDtgvCustomers.DataSource = data;
            //gunaDtgvCustomers.Columns["price"].DefaultCellStyle.Format = "N0";
        }

        private void ImageButtonAdd_Click(object sender, EventArgs e)
        {
            CustomerModule cus = new CustomerModule();
            cus.ShowDialog();
        }
    }
}
