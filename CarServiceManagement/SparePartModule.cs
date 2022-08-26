using CarServiceManagement.DAO;
using System;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CarServiceManagement
{
    public partial class SparePartModule : Form
    {
        SpareParts spareParts;
        public SparePartModule(SpareParts sp)
        {
            InitializeComponent();

            spareParts = sp;
            load_PartType();
            btnUpdate.Enabled = false;
            numberStock.Value = 1;


        }

        private bool checkForm()
        {
            string partName = txtPartName.Text.ToString();
            string cal_unit = txtCalUnit.Text.ToString();
            string price = txtPrice.Text.ToString();
            string importPrice = txtImportPrice.Text.ToString();



            return partName != "" && cal_unit != "" && price != "" && importPrice != "";
        }

        private bool isNumber(string inputData)
        {
            if (Regex.IsMatch(inputData, @"^\d+$"))
                return true;
            return false;
        }

        public void Clear()
        {
            txtPartName.Clear();
            txtPrice.Clear();
            txtImportPrice.Clear();
            txtCalUnit.Clear();
            txtPartDesc.Clear();
            //txtCurrency.Clear();
            txtBrand.Clear();

            comboBoxPartType.SelectedIndex = 0;
            //comboBoxPartBrand.SelectedIndex = 0;
            numberStock.Value = 0;

            //btnSave.Enabled = true;
            //btnUpdate.Enabled = false;
        }

        private void load_PartType()
        {
            DataTable dtDept = DataProvider.Instance.ExecuteQuery("Select * from PartType");

            comboBoxPartType.DataSource = dtDept;
            comboBoxPartType.DisplayMember = "name";
            comboBoxPartType.ValueMember = "parttypeID";

            string temp = labelPartTypeName.Text.ToString();
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
                if (MessageBox.Show("ຕ້ອງການບັນທິກຂໍ້ມູນ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (!checkForm())
                    {
                        MessageBox.Show("ກາລຸນາປ້ອນຂໍ້ມູນໃຫ້ຄົບຖ້ວນ!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (!isNumber(txtPrice.Text) || !isNumber(txtImportPrice.Text))
                    {
                        MessageBox.Show("ລາຄາຕ້ອງເປັນໂຕເລກ!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int stock = Convert.ToInt32(Math.Round(numberStock.Value, 0));
                    decimal price = Convert.ToDecimal(txtPrice.Text.ToString());
                    decimal importPrice = Convert.ToDecimal(txtImportPrice.Text.ToString());

                    int typeId = Convert.ToInt32(comboBoxPartType.SelectedValue.ToString());
                    int importbillID = Convert.ToInt32(labelImportbillID.Text.ToString());

                    string query = "exec sp_AddPart @name , @stock , @price , @import_price , @cal_unit , @description , @part_type , @brand , @importbillID";
                    int result = DataProvider.Instance.ExecuteNoneQuery(query, new object[] { txtPartName.Text, stock, price, importPrice, txtCalUnit.Text, txtPartDesc.Text, typeId, txtBrand.Text, importbillID });

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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkForm())
                {
                    MessageBox.Show("ກາລຸນາປ້ອນຂໍ້ມູນໃຫ້ຄົບຖ້ວນ!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //if (!isNumber(txtPrice.Text))
                //{
                //    MessageBox.Show("ລາຄາຕ້ອງເປັນໂຕເລກ!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    return;
                //}

                if (MessageBox.Show("ຕ້ອງການແກ້ໄຂຂໍ້ມູນ", "Update Record!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int stock = Convert.ToInt32(Math.Round(numberStock.Value, 0));
                    decimal price = Convert.ToDecimal(txtPrice.Text.ToString());
                    decimal importPrice = Convert.ToDecimal(txtImportPrice.Text.ToString());

                    int typeId = Convert.ToInt32(comboBoxPartType.SelectedValue.ToString());
                    int partId = Convert.ToInt32(labelID.Text.ToString());
                    string query = "exec sp_UpdatePart @name , @stock , @price , @import_price , @cal_unit , @description , @part_type , @brand , @partId";
                    int result = DataProvider.Instance.ExecuteNoneQuery(query, new object[] { txtPartName.Text, stock, price, importPrice, txtCalUnit.Text, txtPartDesc.Text, typeId, txtBrand.Text, partId });

                    if (result != 0)
                    {
                        MessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("ບໍ່ສາມາດເພີ່ມໄດ້", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Clear();

                    spareParts.Load_SpareParts();

                    this.Dispose();// To close this form after update data
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void labelAddType_Click(object sender, EventArgs e)
        {
            SparePartTypes sp = new SparePartTypes();
            SparePartTypeModule f = new SparePartTypeModule(sp);
            f.ShowDialog();
            load_PartType();
        }
    }
}
