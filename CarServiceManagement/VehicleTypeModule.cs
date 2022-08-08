using CarServiceManagement.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceManagement
{
    public partial class VehicleTypeModule : Form
    {
        VehicleTypes vehicleTypes;
        public VehicleTypeModule(VehicleTypes vt)
        {
            InitializeComponent();
            vehicleTypes = vt;
            btnUpdate.Enabled = false;
            txtVehicleTypeName.Focus();
        }

        private bool checkForm()
        {
            string name = txtVehicleTypeName.Text.ToString();

            return name != "";
        }

        public void Clear()
        {
            txtVehicleTypeName.Clear();
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


                    string query = "INSERT INTO VehicleType(type_name) VALUES(N'" + txtVehicleTypeName.Text+"')";
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

                    vehicleTypes.load_VehicleTypes();
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
                    string query = "UPDATE VehicleType SET type_name = N'" + txtVehicleTypeName.Text + "' WHERE typeID = " + Int16.Parse(labelVehicleTypeID.Text.ToString());
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

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
