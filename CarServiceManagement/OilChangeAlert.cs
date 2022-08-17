using CarServiceManagement.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarServiceManagement
{
    public partial class OilChangeAlert : Form
    {
        int custID = 0;
        public OilChangeAlert(int passedId)
        {
            InitializeComponent();
            custID = passedId;
            loadInfo();
        }
        public void loadInfo()
        {
            //DataTable data = DataProvider.Instance.ExecuteQuery("select cast(oilchange_date as date) as oilchange_date,cast(required_oilchange_date as date) as required_oilchange_date from Vehicle where customerID = " + custID);
            DataTable data = DataProvider.Instance.ExecuteQuery("select oilchange_date, required_oilchange_date from Vehicle where customerID = " + custID);

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];

                dtpStart.Text = row["oilchange_date"].ToString().Split(' ')[0];
                dtpEnd.Text = row["required_oilchange_date"].ToString().Split(' ')[0];

            }
        }
        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
