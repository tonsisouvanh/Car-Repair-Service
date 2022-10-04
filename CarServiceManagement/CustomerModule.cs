using CarServiceManagement.DAO;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CarServiceManagement
{
    public partial class CustomerModule : Form
    {
        Customers customers;
        public CustomerModule(Customers cust)
        {
            InitializeComponent();
            load_Province();
            load_District();
            customers = cust;
            btnUpdate.Enabled = false;
            comboBoxProvince.SelectedIndex = 14;
            txtPhone.Text = "020";

        }

        private bool isNumber(string inputData)
        {
            if (Regex.IsMatch(inputData, @"^\d+$"))
                return true;
            return false;
        }

        private bool checkForm()
        {
            string cusName = txtCusName.Text.ToString();
            string phone = txtPhone.Text.ToString();

            return cusName != "" && phone != "";
        }

        public void Clear()
        {
            txtCusName.Clear();
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddressDetail.Clear();
            comboBoxProvince.SelectedIndex = 0;
            comboBoxDistrict.SelectedIndex = 0;
        }

        private void load_Province()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Provinces");

            comboBoxProvince.DataSource = data;
            comboBoxProvince.DisplayMember = "name";
            comboBoxProvince.ValueMember = "name";
        }

        private void load_District()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("Select * from Districts");

            comboBoxDistrict.DataSource = data;
            comboBoxDistrict.DisplayMember = "name";
            comboBoxDistrict.ValueMember = "name";
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (TMessageBox.Show("ຕ້ອງການບັນທິກຂໍ້ມູນ?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (!checkForm())
                    {
                        TMessageBox.Show("ກາລຸນາປ້ອນຂໍ້ມູນໃຫ້ຄົບຖ້ວນ!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    if (!isNumber(txtPhone.Text.ToString()))
                    {
                        TMessageBox.Show("ເບີໂທບໍ່ຖືກຕ້ອງ", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string query = "exec sp_AddCustomer @name , @email , @phone , @province , @district , @address_detail";
                    int result = DataProvider.Instance.ExecuteNoneQuery(query, new object[] { txtCusName.Text, txtEmail.Text, txtPhone.Text, comboBoxProvince.SelectedValue.ToString(), comboBoxDistrict.Text.ToString(), txtAddressDetail.Text });

                    if (result != 0)
                    {
                        TMessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (TMessageBox.Show("ຕ້ອງການເພີ່ມຂໍ້ມູນລົດ ຫຼືບໍ່?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            VehicleModule f = new VehicleModule(new Vehicles());
                            f.txtCustInfo.Text = txtPhone.Text;
                            f.ShowDialog();
                        }
                    }
                    else
                    {
                        TMessageBox.Show("ບໍ່ສາມາດເພີ່ມໄດ້", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    customers.Load_Customers();
                }

            }
            catch (Exception ex)
            {

                TMessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkForm())
                {
                    TMessageBox.Show("ກາລຸນາປ້ອນຂໍ້ມູນໃຫ້ຄົບຖ້ວນ!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (TMessageBox.Show("ຕ້ອງການແກ້ໄຂຂໍ້ມູນ", "Update Record!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    if (!isNumber(txtPhone.Text.ToString()))
                    {
                        TMessageBox.Show("ເບີໂທບໍ່ຖືກຕ້ອງ", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    int customerID = Convert.ToInt32(labelID.Text.ToString());
                    string query = "exec sp_UpdateCustomer @name , @email , @phone , @province , @district , @address_detail , @customerID";
                    int result = DataProvider.Instance.ExecuteNoneQuery(query, new object[] { txtCusName.Text, txtEmail.Text, txtPhone.Text, comboBoxProvince.SelectedValue.ToString(), comboBoxDistrict.SelectedValue.ToString(), txtAddressDetail.Text, customerID });

                    if (result != 0)
                    {
                        TMessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        TMessageBox.Show("ບໍ່ສາມາດເພີ່ມໄດ້", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Clear();

                    customers.Load_Customers();

                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                TMessageBox.Show(ex.Message);
            }
        }

    }
}
