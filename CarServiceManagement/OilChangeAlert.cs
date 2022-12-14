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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("ຕ້ອງການບັນທິກຂໍ້ມູນ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DateTime currDate = dtpStart.Value;
                    DateTime nextChange = dtpEnd.Value;

                    string query = "Update Vehicle set oilchange_date = '" + currDate + "', required_oilchange_date = '" + nextChange + "' " +
                        "where CustomerID = " + custID;
                    int result = DataProvider.Instance.ExecuteNoneQuery(query);

                    if (result != 0)
                    {
                        MessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("ບໍ່ສາມາດເພີ່ມໄດ້", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
