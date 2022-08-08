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
    public partial class VehicleTypes : Form
    {
        public VehicleTypes()
        {
            InitializeComponent();
            load_VehicleTypes();
        }

        private void guna2ImageButtonAdd_Click(object sender, EventArgs e)
        {
            VehicleTypeModule vm = new VehicleTypeModule(this);
            vm.ShowDialog();
        }

        public void load_VehicleTypes()
        {
            DataTable dtTable = DataProvider.Instance.ExecuteQuery("select * from VehicleType");
            DtgvVehicleTypes.DataSource = dtTable;
        }

        private void DtgvVehicleTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //For update and delete brand by cell click from tbBrand
            string colName = DtgvVehicleTypes.Columns[e.ColumnIndex].Name;

            if (colName == "delete")
            {
                if (MessageBox.Show("ຕ້ອງການລົບຂໍ້ມູນ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int typeId = Int16.Parse(DtgvVehicleTypes.Rows[e.RowIndex].Cells["typeID"].FormattedValue.ToString());

                        string query = "DELETE VehicleType WHERE typeID = " + typeId;
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
                    load_VehicleTypes();

                }
            }
            else if (colName == "edit")
            {
                VehicleTypeModule vtm = new VehicleTypeModule(this);
                vtm.labelVehicleTypeID.Text = DtgvVehicleTypes.Rows[e.RowIndex].Cells["typeID"].FormattedValue.ToString();
                vtm.txtVehicleTypeName.Text = DtgvVehicleTypes.Rows[e.RowIndex].Cells["type_name"].FormattedValue.ToString();

                vtm.btnSave.Enabled = false;
                vtm.btnUpdate.Enabled = true;

                vtm.ShowDialog();
                load_VehicleTypes();

            }

        }
    }
}
