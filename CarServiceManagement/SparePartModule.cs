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
    public partial class SparePartModule : Form
    {
        SpareParts spareParts;
        public SparePartModule(SpareParts sp)
        {
            InitializeComponent();

            spareParts = sp;
            load_PartType();
            btnUpdate.Enabled = false;

            
        }

        private bool checkForm()
        {
            string partName = txtPartName.Text.ToString();
            string desc = txtPartDesc.Text.ToString();
            string cal_unit = txtCalUnit.Text.ToString();
            string price = txtPrice.Text.ToString();
            string currency = txtCurrency.Text.ToString();


            return partName != "" && desc != "" && cal_unit != "" && price != "" && currency != "";
        }

        public void Clear()
        {
            txtPartName.Clear();
            txtPrice.Clear();
            txtCalUnit.Clear();
            txtPartDesc.Clear();
            txtCurrency.Clear();
            txtBrand.Clear();

            comboBoxPartType.SelectedIndex = 0;
            //comboBoxPartBrand.SelectedIndex = 0;
            numberStock.Value = 1;

            btnSave.Enabled = true;
            btnUpdate.Enabled = false;
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

                    int stock = Convert.ToInt32(Math.Round(numberStock.Value, 0));
                    decimal price = Convert.ToDecimal(txtPrice.Text.ToString());
                    int typeId = Convert.ToInt32(comboBoxPartType.SelectedValue.ToString());
                    string query = "exec sp_AddPart @name , @stock , @price , @currency , @cal_unit , @description , @part_type , @brand";
                    int result = DataProvider.Instance.ExecuteNoneQuery(query, new object[] {txtPartName.Text, stock, price,txtCurrency.Text, txtCalUnit.Text, txtPartDesc.Text,typeId,txtBrand.Text});

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
                    int stock = Convert.ToInt32(Math.Round(numberStock.Value, 0));
                    decimal price = Convert.ToDecimal(txtPrice.Text.ToString());
                    int typeId = Convert.ToInt32(comboBoxPartType.SelectedValue.ToString());
                    int partId = Convert.ToInt32(labelID.Text.ToString());
                    string query = "exec sp_UpdatePart @name , @stock , @price , @currency , @cal_unit , @description , @part_type , @brand , @partId";
                    int result = DataProvider.Instance.ExecuteNoneQuery(query, new object[] { txtPartName.Text, stock, price, txtCurrency.Text, txtCalUnit.Text, txtPartDesc.Text, typeId, txtBrand.Text, partId });

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

    }
}
