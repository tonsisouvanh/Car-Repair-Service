using CarServiceManagement.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarServiceManagement
{
    public partial class Vehicles : Form
    {
        public Vehicles()
        {
            InitializeComponent();
            Load_Vehicles();
        }

        public void Load_Vehicles()
        {
            //DataTable data = DataProvider.Instance.ExecuteQuery("select v.*, vt.type_name, vb.brand_name, c.name as custname, c.phone " +
            //    "from Vehicle v inner join Customer c on v.customerID = c.customerID " +
            //    "inner join VehicleType vt on v.typeID = vt.typeID " +
            //    "inner join VehicleBrand vb on v.brandID = vb.brandID");
            //gunaDtgvVehicles.DataSource = data;
            DataTable data = DataProvider.Instance.ExecuteQuery("select distinct v.vehicleID,v.name,v.color,v.typeID,v.brandID,v.plate_number,v.descriptions,v.customerID,vt.type_name,vb.brand_name, c.name as custname, c.phone,v.oilchange_date,v.required_oilchange_date " +
                "from Vehicle v inner join Customer c on v.customerID = c.customerID " +
                "inner join VehicleType vt on v.typeID = vt.typeID " +
                "inner join VehicleBrand vb on v.brandID = vb.brandID " +
                "where concat(v.name, v.color, v.plate_number, vt.type_name, vb.brand_name, c.name, c.phone) LIKE N'%" + txtSearch.Text + "%'");
            gunaDtgvVehicles.DataSource = data;
        }

        private void ImageButtonAdd_Click(object sender, EventArgs e)
        {
            VehicleModule v = new VehicleModule(this);
            v.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Load_Vehicles();
        }

        private void gunaDtgvVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //For update and delete brand by cell click from tbBrand
            string colName = gunaDtgvVehicles.Columns[e.ColumnIndex].Name;

            if (colName == "delete")
            {
                if (MessageBox.Show("ຕ້ອງການລົບຂໍ້ມູນ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int vehicleID = Int32.Parse(gunaDtgvVehicles.Rows[e.RowIndex].Cells["vehicleID"].FormattedValue.ToString());

                        string query = "DELETE Vehicle WHERE vehicleID = " + vehicleID;
                        int result = DataProvider.Instance.ExecuteNoneQuery(query);

                        if (result != 0)
                        {
                            MessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("ບໍ່ສາມາດລົບໄດ້ ຫຼື ລອງລົບຂໍ້ມູນລົດກ່ອນຂອງລູກຄ້າກ່ອນ ແລ້ວພະຍາຍາມໃໝ່", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    Load_Vehicles();

                }
            }
            else if (colName == "edit")
            {
                VehicleModule module = new VehicleModule(this);

                module.labelID.Text = gunaDtgvVehicles.Rows[e.RowIndex].Cells["vehicleID"].FormattedValue.ToString();
                module.labelCustID.Text = gunaDtgvVehicles.Rows[e.RowIndex].Cells["customerID"].FormattedValue.ToString();

                module.txtVehicleName.Text = gunaDtgvVehicles.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
                module.txtColor.Text = gunaDtgvVehicles.Rows[e.RowIndex].Cells["color"].FormattedValue.ToString();
                module.comboBoxType.SelectedIndex = module.comboBoxType.FindStringExact(gunaDtgvVehicles.Rows[e.RowIndex].Cells["type_name"].FormattedValue.ToString());
                module.comboBoxBrand.SelectedIndex = module.comboBoxBrand.FindStringExact(gunaDtgvVehicles.Rows[e.RowIndex].Cells["brand_name"].FormattedValue.ToString());
                module.txtPlateNumber.Text = gunaDtgvVehicles.Rows[e.RowIndex].Cells["plate_number"].FormattedValue.ToString();
                module.txtDescriptions.Text = gunaDtgvVehicles.Rows[e.RowIndex].Cells["descriptions"].FormattedValue.ToString();


                module.btnSave.Enabled = false;
                module.btnUpdate.Enabled = true;
                module.formInputPanel.Enabled = true;
                module.txtCustInfo.Text = gunaDtgvVehicles.Rows[e.RowIndex].Cells["phone"].FormattedValue.ToString();
                module.txtCustInfo.Enabled = false;

                module.ShowDialog();
                Load_Vehicles();

            }
        }

        private void guna2TileButton2_Click(object sender, EventArgs e)
        {
            Load_Vehicles();
        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select distinct v.vehicleID,v.name,v.color,v.typeID,v.brandID,v.plate_number,v.descriptions,v.customerID,vt.type_name,vb.brand_name, c.name as custname, c.phone,v.oilchange_date,v.required_oilchange_date " +
                "from Vehicle v inner join Customer c on v.customerID = c.customerID " +
                "inner join VehicleType vt on v.typeID = vt.typeID " +
                "inner join VehicleBrand vb on v.brandID = vb.brandID " +
                "where concat(v.name, v.color, v.plate_number, vt.type_name, vb.brand_name, c.name, c.phone) LIKE N'%" + txtSearch.Text + "%' and cast(getdate() as date) >= v.oilchange_date and cast(getdate() as date) = v.required_oilchange_date");
            gunaDtgvVehicles.DataSource = data;
        }
    }
}
