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
    public partial class VehicleBrands : Form
    {
        public VehicleBrands()
        {
            InitializeComponent();
            load_VehicleBrands();
        }

        private void guna2ImageButtonAdd_Click(object sender, EventArgs e)
        {
            VehicleBrandModule vb = new VehicleBrandModule(this);
            vb.ShowDialog();
        }
        public void load_VehicleBrands()
        {
            DataTable dtTable = DataProvider.Instance.ExecuteQuery("select * from VehicleBrand");
            DtgvVehicleBrands.DataSource = dtTable;
        }

        private void DtgvVehicleBrands_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //For update and delete brand by cell click from tbBrand
            string colName = DtgvVehicleBrands.Columns[e.ColumnIndex].Name;

            if (colName == "delete")
            {
                if (MessageBox.Show("ຕ້ອງການລົບຂໍ້ມູນ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int brandID = Int16.Parse(DtgvVehicleBrands.Rows[e.RowIndex].Cells["brandID"].FormattedValue.ToString());

                        string query = "DELETE VehicleBrand WHERE brandID = " + brandID;
                        int result = DataProvider.Instance.ExecuteNoneQuery(query);

                        if (result != 0)
                        {
                            MessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("ບໍ່ສາມາດລົບໄດ້", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    load_VehicleBrands();

                }
            }
            else if (colName == "edit")
            {
                VehicleBrandModule vtm = new VehicleBrandModule(this);
                vtm.labelVehicleBrandID.Text = DtgvVehicleBrands.Rows[e.RowIndex].Cells["brandID"].FormattedValue.ToString();
                vtm.txtVehicleBrandName.Text = DtgvVehicleBrands.Rows[e.RowIndex].Cells["brand_name"].FormattedValue.ToString();

                vtm.btnSave.Enabled = false;
                vtm.btnUpdate.Enabled = true;

                vtm.ShowDialog();
                load_VehicleBrands();

            }
        }
    }
}
