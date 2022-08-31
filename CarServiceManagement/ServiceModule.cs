using CarServiceManagement.DAO;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CarServiceManagement
{
    public partial class ServiceModule : Form
    {
        public ServiceModule()
        {
            InitializeComponent();
        }

        private bool checkForm()
        {
            string service = txtService.Text.ToString();
            string servicePrice = txtServicePrice.Text.ToString();

            return service != "" && servicePrice != "";
        }

        private bool isNumber(string inputData)
        {
            if (Regex.IsMatch(inputData, @"^\d+$"))
                return true;
            return false;
        }

        public void Clear()
        {
            txtService.Clear();
            txtServicePrice.Clear();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkForm())
                {
                    MessageBox.Show("ກາລຸນາປ້ອນຂໍ້ມູນໃຫ້ຄົບຖ້ວນ!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (!isNumber(txtServicePrice.Text))
                {
                    MessageBox.Show("ລາຄາຕ້ອງເປັນໂຕເລກ!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (MessageBox.Show("ຕ້ອງການບັນທິກຂໍ້ມູນ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int repairbillID = Convert.ToInt32(labelID.Text.ToString());
                    decimal servicePrice = Convert.ToDecimal(txtServicePrice.Text.ToString());
                    string query = "exec sp_addService @repairbillID , @service , @service_price";
                    int result = DataProvider.Instance.ExecuteNoneQuery(query, new object[] { repairbillID, txtService.Text, servicePrice });

                    if (result != 0)
                    {
                        MessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
                    }
                    else
                    {
                        MessageBox.Show("ບໍ່ສາມາດເພີ່ມໄດ້", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Clear();
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
