using CarServiceManagement.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarServiceManagement
{
    public partial class RepairBillModule : Form
    {
        RepairBill repairBill;
        public RepairBillModule(RepairBill rb)
        {
            InitializeComponent();
            btnUpdate.Enabled = false;
            txtCustInfo.Focus();
            repairBill = rb;
            cbbStatus.SelectedIndex = 0;
            txtCustInfo.Text = "020";
        }

        public void Clear()
        {
            txtCustInfo.Clear();
            txtPayment.Clear();
            txtDesc.Clear();
            txtTotal.Clear();

            cbbStatus.SelectedIndex = -1;

        }


        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("ຕ້ອງການບັນທິກຂໍ້ມູນ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int customerID = Convert.ToInt32(labelCustID.Text.ToString());
                    string query = "exec sp_AddRepairBill @customerID , @status , @payment , @descriptions";
                    int result = DataProvider.Instance.ExecuteNoneQuery(query, new object[] { customerID, cbbStatus.SelectedItem.ToString(), txtPayment.Text, txtDesc.Text });

                    if (result != 0)
                    {
                        MessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("ບໍ່ສາມາດເພີ່ມໄດ້", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Clear();

                    repairBill.Load_RepairBill();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("ຕ້ອງການແກ້ໄຂຂໍ້ມູນ", "Update Record!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    int billID = Convert.ToInt32(labelID.Text.ToString());
                    string query = "exec sp_UpdateRepairBill @status , @payment , @created_date , @descriptions , @repairbillID";
                    int result = DataProvider.Instance.ExecuteNoneQuery(query, new object[] { cbbStatus.SelectedItem.ToString(), txtPayment.Text, dtpCreatedDate.Value.ToString(), txtDesc.Text, billID });

                    if (result != 0)
                    {
                        MessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("ບໍ່ສາມາດເພີ່ມໄດ້", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Clear();

                    repairBill.Load_RepairBill();

                    this.Dispose();// To close this form after update data
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void labelAddNewCust_Click(object sender, EventArgs e)
        {
            CustomerModule f = new CustomerModule(new Customers());
            f.ShowDialog();
        }

        private void txtCustInfo_TextChanged(object sender, EventArgs e)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select customerID, name from customer where phone = '" + txtCustInfo.Text + "'");
            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];

                txtCustName.Text = row["name"].ToString();
                labelCustID.Text = row["customerID"].ToString();
                formInputPanel.Enabled = true;
            }
            else
            {
                txtCustName.Text = "ບໍ່ພົບຂໍ້ມູນລູກຄ້າ";
                formInputPanel.Enabled = false;
            }
        }
    }
}
