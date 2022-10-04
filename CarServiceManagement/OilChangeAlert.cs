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
            DataTable data = DataProvider.Instance.ExecuteQuery("select oilchange_date, start_kms, end_kms from Vehicle where customerID = " + custID);

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];

                dtpStart.Text = row["oilchange_date"].ToString().Split(' ')[0];
                txtStartKms.Text = row["start_kms"].ToString();
                txtEndKms.Text = row["end_kms"].ToString();


            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (TMessageBox.Show("ຕ້ອງການບັນທິກຂໍ້ມູນ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    DateTime currDate = dtpStart.Value;

                    //string query = "Update Vehicle set oilchange_date = '" + currDate + "', required_oilchange_date = '" + nextChange + "' " +
                    //    "where CustomerID = " + custID;
                    string query = "Update Vehicle set oilchange_date = '" + currDate + "', start_kms = " + Convert.ToInt32(txtStartKms.Text) + ",end_kms = " + Convert.ToInt32(txtEndKms.Text) +
                        " where CustomerID = " + custID;
                    int result = DataProvider.Instance.ExecuteNoneQuery(query);

                    if (result != 0)
                    {
                        TMessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                    else
                    {
                        TMessageBox.Show("ບໍ່ສາມາດເພີ່ມໄດ້", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            catch (Exception ex)
            {
                TMessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
