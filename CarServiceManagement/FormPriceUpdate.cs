using CarServiceManagement.DAO;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CarServiceManagement
{
    public partial class FormPriceUpdate : Form
    {
        PartImportBillDetail partImportBillDetail;
        public FormPriceUpdate(PartImportBillDetail p)
        {
            InitializeComponent();
            partImportBillDetail = p;

        }

        private bool isNumber(string inputData)
        {
            if (Regex.IsMatch(inputData, @"^\d+$"))
                return true;
            return false;
        }

        private bool checkForm()
        {
            string importprice = txtImportPrice.Text.ToString();
            string price = txtSellPrice.Text.ToString();

            return importprice != "" && price != "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
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
                if (!isNumber(txtImportPrice.Text) || !isNumber(txtSellPrice.Text))
                {
                    TMessageBox.Show("ກາລຸນາປ້ອນຂໍ້ມູນເປັນໂຕເລກ!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (TMessageBox.Show("ຕ້ອງການແກ້ໄຂຂໍ້ມູນ", "Update Record!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int partID = Convert.ToInt32(labelID.Text.ToString());
                    decimal importPrice = Convert.ToDecimal(txtImportPrice.Text.ToString());
                    decimal sellPrice = Convert.ToDecimal(txtSellPrice.Text.ToString());
                    string query = "update Part set import_price = " + importPrice + ", price = " + sellPrice + " where partID = " + partID;

                    int result = DataProvider.Instance.ExecuteNoneQuery(query);

                    if (result != 0)
                    {
                        TMessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        TMessageBox.Show("ບໍ່ສາມາດເພີ່ມໄດ້", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                    partImportBillDetail.load_SpareParts();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                TMessageBox.Show(ex.Message);
            }
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();

        }
    }
}
