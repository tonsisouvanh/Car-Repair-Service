using CarServiceManagement.DAO;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CarServiceManagement
{
    public partial class PartImportBillModule : Form
    {
        PartImportBills partImportBills;
        public PartImportBillModule(PartImportBills pib)
        {
            InitializeComponent();
            partImportBills = pib;
            btnUpdate.Enabled = false;

            txtTotal.Enabled = false;
            dtpCreatedDate.Enabled = false;

            cbbStatus.SelectedIndex = 1;
        }

        private bool isNumber(string inputData)
        {
            if (Regex.IsMatch(inputData, @"^\d+$"))
                return true;
            return false;
        }

        private bool checkForm()
        {
            string supplier = txtSupplier.Text.ToString();
            string suppierContact = txtSupplierContact.Text.ToString();

            return supplier != "";
        }

        public void Clear()
        {
            txtSupplier.Clear();
            txtSupplierContact.Clear();
            txtPayment.Clear();
            txtDesc.Clear();
            cbbStatus.SelectedIndex = 1;
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
                    if (!checkForm())
                    {
                        MessageBox.Show("ກາລຸນາປ້ອນຂໍ້ມູນໃຫ້ຄົບຖ້ວນ!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string query = "exec sp_AddPartImportBill @supplier , @supplier_contact , @status , @payment , @descriptions";
                    int result = DataProvider.Instance.ExecuteNoneQuery(query, new object[] { txtSupplier.Text, txtSupplierContact.Text, cbbStatus.SelectedItem.ToString(), txtPayment.Text, txtDesc.Text });

                    if (result != 0)
                    {
                        MessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("ບໍ່ສາມາດເພີ່ມໄດ້", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Clear();

                    partImportBills.Load_PartImportBill();
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
                if (!checkForm())
                {
                    MessageBox.Show("ກາລຸນາປ້ອນຂໍ້ມູນໃຫ້ຄົບຖ້ວນ!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("ຕ້ອງການແກ້ໄຂຂໍ້ມູນ", "Update Record!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    int billID = Convert.ToInt32(labelID.Text.ToString());
                    string query = "exec sp_UpdatePartImportBill @supplier , @supplier_contact , @status , @payment , @created_date , @descriptions , @billID";
                    int result = DataProvider.Instance.ExecuteNoneQuery(query, new object[] { txtSupplier.Text, txtSupplierContact.Text, cbbStatus.SelectedItem.ToString(), txtPayment.Text, dtpCreatedDate.Value.ToString(), txtDesc.Text, billID });

                    if (result != 0)
                    {
                        MessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("ບໍ່ສາມາດເພີ່ມໄດ້", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Clear();

                    partImportBills.Load_PartImportBill();

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

    }
}
