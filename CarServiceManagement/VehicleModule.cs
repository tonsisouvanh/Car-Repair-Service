﻿using CarServiceManagement.DAO;
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
    public partial class VehicleModule : Form
    {
        Vehicles vehicles;
        public VehicleModule(Vehicles v)
        {
            InitializeComponent();
            vehicles = v;
            load_Type();
            load_Brand();
            btnUpdate.Enabled = false;
            formInputPanel.Enabled = false;
            txtCustInfo.Focus();
        }

        private bool checkForm()
        {
            string name = txtVehicleName.Text.ToString();
            string plate_number = txtPlateNumber.Text.ToString();

            return name != "" && plate_number != "";
        }

        public void Clear()
        {
            txtVehicleName.Clear();
            txtColor.Clear();
            txtPlateNumber.Clear();
            txtPlateNumber.Clear();
            txtDescriptions.Clear();

            comboBoxType.SelectedIndex = 0;
            comboBoxBrand.SelectedIndex = 0;

            //btnSave.Enabled = true;
            //btnUpdate.Enabled = false;
        }

        private void load_Type()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from VehicleType");

            comboBoxType.DataSource = data;
            comboBoxType.DisplayMember = "type_name";
            comboBoxType.ValueMember = "typeID";

        }

        private void load_Brand()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from VehicleBrand");

            comboBoxBrand.DataSource = data;
            comboBoxBrand.DisplayMember = "brand_name";
            comboBoxBrand.ValueMember = "brandID";

        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtCustInfo_TextChanged(object sender, EventArgs e)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select TOP(1) customerID, name from customer where phone = '"+txtCustInfo.Text+"'");
            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];

                txtCustName.Text = row["name"].ToString();
                labelCustID.Text = row["customerID"].ToString();
                formInputPanel.Enabled = true;

            }
            else
            {
                txtCustName.Clear();
                formInputPanel.Enabled = false;
            }

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

                    //if (!isNumber(txtPhone.Text.ToString()))
                    //{
                    //    MessageBox.Show("ເບີໂທບໍ່ຖືກຕ້ອງ", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //    return;
                    //}

                    int typeID = Convert.ToInt32(comboBoxType.SelectedValue.ToString());
                    int brandID = Convert.ToInt32(comboBoxBrand.SelectedValue.ToString());
                    int customerID = Convert.ToInt32(labelCustID.Text.ToString());

                    string query = "exec sp_AddVehicle @name , @color , @typeID , @brandID , @plate_number , @descriptions , @customerID";
                    int result = DataProvider.Instance.ExecuteNoneQuery(query, new object[] { txtVehicleName.Text, txtColor.Text, 
                        typeID, brandID, txtPlateNumber.Text, txtDescriptions.Text, customerID });

                    if (result != 0)
                    {
                        MessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("ບໍ່ສາມາດເພີ່ມໄດ້", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Clear();

                    vehicles.Load_Vehicles();
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
                    if (!checkForm())
                    {
                        MessageBox.Show("ກາລຸນາປ້ອນຂໍ້ມູນໃຫ້ຄົບຖ້ວນ!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    int vehicleID = Convert.ToInt32(labelID.Text.ToString());
                    int customerID = Convert.ToInt32(labelCustID.Text.ToString());
                    int typeID = Convert.ToInt32(comboBoxType.SelectedValue.ToString());
                    int brandID = Convert.ToInt32(comboBoxBrand.SelectedValue.ToString());

                    string query = "exec sp_UpdateVehicle @name , @color , @typeID , @brandID , @plate_number , @descriptions , @vehicleID , @customerID";
                    int result = DataProvider.Instance.ExecuteNoneQuery(query, new object[] { txtVehicleName.Text, txtColor.Text,
                        typeID, brandID, txtPlateNumber.Text, txtDescriptions.Text,vehicleID, customerID });

                    if (result != 0)
                    {
                        MessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("ບໍ່ສາມາດເພີ່ມໄດ້", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Clear();

                    vehicles.Load_Vehicles();

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
