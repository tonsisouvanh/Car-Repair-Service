using CarServiceManagement.DAO;
using System;
using System.Windows.Forms;

namespace CarServiceManagement
{
    public partial class VehicleBrandModule : Form
    {
        VehicleBrands vehicleBrands;
        public VehicleBrandModule(VehicleBrands vb)
        {
            InitializeComponent();
            vehicleBrands = vb;
            btnUpdate.Enabled = false;
            txtVehicleBrandName.Focus();
        }

        private bool checkForm()
        {
            string name = txtVehicleBrandName.Text.ToString();

            return name != "";
        }

        public void Clear()
        {
            txtVehicleBrandName.Clear();
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


                    string query = "INSERT INTO VehicleBrand(brand_name) VALUES(N'" + txtVehicleBrandName.Text + "')";
                    int result = DataProvider.Instance.ExecuteNoneQuery(query);

                    if (result != 0)
                    {
                        MessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("ບໍ່ສາມາດເພີ່ມໄດ້", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Clear();

                    vehicleBrands.load_VehicleBrands();
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
                    string query = "UPDATE VehicleBrand SET brand_name = N'" + txtVehicleBrandName.Text + "' WHERE brandID = " + Int16.Parse(labelVehicleBrandID.Text.ToString());
                    int result = DataProvider.Instance.ExecuteNoneQuery(query);

                    if (result != 0)
                    {
                        MessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("ບໍ່ສາມາດແກ້ໄຂໄດ້", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Clear();
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
