using CarServiceManagement.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarServiceManagement
{
    public partial class VehicleDetail : Form
    {
        int custID = 0;
        public VehicleDetail(int id)
        {
            InitializeComponent();
            custID = id;
            load_vehicle();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void load_vehicle()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select top(1) v.*,vt.type_name,vb.brand_name from Vehicle v " +
                "inner join VehicleType vt on v.typeID = vt.typeID " +
                "inner join VehicleBrand vb on v.brandID = vb.brandID " +
                "where customerID = " + custID);

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];


                this.labelName.Text = row["name"].ToString();
                this.labelColor.Text = row["color"].ToString();
                this.labelType.Text = row["type_name"].ToString();
                this.labelBrand.Text = row["brand_name"].ToString();
                this.labelPlateNO.Text = row["plate_number"].ToString();
                this.dtpStart.Text = row["oilchange_date"].ToString();
                this.dtpEnd.Text = row["required_oilchange_date"].ToString();
                this.txtDescriptions.Text = row["descriptions"].ToString();


            }
        }
    }
}
