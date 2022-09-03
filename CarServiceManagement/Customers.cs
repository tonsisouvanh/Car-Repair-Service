using CarServiceManagement.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarServiceManagement
{
    public partial class Customers : Form
    {
        public Customers()
        {
            InitializeComponent();
            Load_Customers();
        }

        public void Load_Customers()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from Customer where " +
             "concat(name,email,phone,province,district,created_date) LIKE N'%" + txtSearch.Text + "%'");
            gunaDtgvCustomers.DataSource = data;
            gunaDtgvCustomers.Columns["created_date"].DefaultCellStyle.Format = "dd/MM/yyyy";

        }

        private void ImageButtonAdd_Click(object sender, EventArgs e)
        {
            CustomerModule cus = new CustomerModule(this);
            cus.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Load_Customers();
        }

        private void gunaDtgvCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = gunaDtgvCustomers.Columns[e.ColumnIndex].Name;

            if (colName == "delete")
            {
                if (TMessageBox.Show("ຕ້ອງການລົບຂໍ້ມູນ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int customerID = Int32.Parse(gunaDtgvCustomers.Rows[e.RowIndex].Cells["customerID"].FormattedValue.ToString());

                        string query = "DELETE Customer WHERE customerID = " + customerID;
                        int result = DataProvider.Instance.ExecuteNoneQuery(query);

                        if (result != 0)
                        {
                            TMessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            TMessageBox.Show("ບໍ່ສາມາດລົບໄດ້ ຫຼື ລອງລົບຂໍ້ມູນລົດຂອງລູກຄ້າກ່ອນ ແລ້ວພະຍາຍາມໃໝ່", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    catch (Exception ex)
                    {
                        TMessageBox.Show(ex.Message);
                    }
                    Load_Customers();

                }
            }
            else if (colName == "edit")
            {
                CustomerModule module = new CustomerModule(this);

                module.labelID.Text = gunaDtgvCustomers.Rows[e.RowIndex].Cells["customerID"].FormattedValue.ToString();

                module.txtCusName.Text = gunaDtgvCustomers.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
                module.txtEmail.Text = gunaDtgvCustomers.Rows[e.RowIndex].Cells["email"].FormattedValue.ToString();
                module.txtPhone.Text = gunaDtgvCustomers.Rows[e.RowIndex].Cells["phone"].FormattedValue.ToString();
                module.comboBoxProvince.SelectedIndex = module.comboBoxProvince.FindStringExact(gunaDtgvCustomers.Rows[e.RowIndex].Cells["province"].FormattedValue.ToString());
                module.comboBoxDistrict.SelectedIndex = module.comboBoxDistrict.FindStringExact(gunaDtgvCustomers.Rows[e.RowIndex].Cells["district"].FormattedValue.ToString());
                module.txtAddressDetail.Text = gunaDtgvCustomers.Rows[e.RowIndex].Cells["address_detail"].FormattedValue.ToString();


                module.btnSave.Enabled = false;
                module.btnUpdate.Enabled = true;

                module.ShowDialog();
                Load_Customers();

            }
            else if (colName == "addcar")
            {
                int id = Convert.ToInt32(gunaDtgvCustomers.Rows[e.RowIndex].Cells["customerID"].FormattedValue.ToString());
                VehicleDetail v = new VehicleDetail(id);
                v.ShowDialog();
            }
        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Title = "Export Excel";
            savefile.FileName = "Customers.xls";
            savefile.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";


            if (savefile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Excel.exportExcel(savefile.FileName, gunaDtgvCustomers);
                    TMessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception)
                {
                    TMessageBox.Show("ລົ້ມເຫຼວ", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
