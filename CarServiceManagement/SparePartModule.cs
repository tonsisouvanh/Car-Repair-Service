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
    public partial class SparePartModule : Form
    {
        public SparePartModule(SpareParts spareParts)
        {
            InitializeComponent();

            //load_PartBrand();
            load_PartType();
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
        }
        private void load_PartBrand()
        {


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

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
