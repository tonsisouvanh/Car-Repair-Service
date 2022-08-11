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
    public partial class PartImportBillDetail : Form
    {
        PartImportBills partImportBills;
        int passedID = 0;
        public PartImportBillDetail(PartImportBills p, int tempid)
        {
            InitializeComponent();
            partImportBills = p;
            passedID = tempid;
            load_ImportBillDetail();

        }

        public void load_ImportBillDetail()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select pibd.importbilldetailID, pibd.partID, pibd.importbillID, p.name, p.price, pibd.quantity,p.cal_unit, pibd.subtotal " +
                "from PartImportBillDetail pibd inner join Part p on pibd.partID = p.partID where pibd.importbillID = "+ passedID);
            gunaDtgvPartImportBillDetail.DataSource = data;
            gunaDtgvPartImportBillDetail.Columns["price"].DefaultCellStyle.Format = "N0";
            gunaDtgvPartImportBillDetail.Columns["subtotal"].DefaultCellStyle.Format = "N0";


        }

        private void ImageButtonMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void ImageButtonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ImageButtonAdd_Click(object sender, EventArgs e)
        {
            //this.Hide();
            PartImportBillDetailModule f = new PartImportBillDetailModule(this, partImportBills);
            f.labelBillDetailID.Text = labelBillNumber.Text;
            f.ShowDialog();
        }

        private void PartImportBillDetail_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(labelBillNumber.Text.ToString());
        }

        private void gunaDtgvPartImportBillDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = gunaDtgvPartImportBillDetail.Columns[e.ColumnIndex].Name;

            if (colName == "delete")
            {
                if (MessageBox.Show("ຕ້ອງການລົບຂໍ້ມູນ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int customerID = Int32.Parse(gunaDtgvPartImportBillDetail.Rows[e.RowIndex].Cells["customerID"].FormattedValue.ToString());

                        string query = "DELETE Customer WHERE customerID = " + customerID;
                        int result = DataProvider.Instance.ExecuteNoneQuery(query);

                        if (result != 0)
                        {
                            MessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("ບໍ່ສາມາດລົບໄດ້ ຫຼື ລອງລົບຂໍ້ມູນລົດຂອງລູກຄ້າກ່ອນ ແລ້ວພະຍາຍາມໃໝ່", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    load_ImportBillDetail();

                }
            }
            else if (colName == "edit")
            {
                //CustomerModule module = new CustomerModule(this);

                //module.labelID.Text = gunaDtgvCustomers.Rows[e.RowIndex].Cells["customerID"].FormattedValue.ToString();

                //module.txtCusName.Text = gunaDtgvCustomers.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
                //module.txtEmail.Text = gunaDtgvCustomers.Rows[e.RowIndex].Cells["email"].FormattedValue.ToString();
                //module.txtPhone.Text = gunaDtgvCustomers.Rows[e.RowIndex].Cells["phone"].FormattedValue.ToString();
                //module.comboBoxProvince.SelectedIndex = module.comboBoxProvince.FindStringExact(gunaDtgvCustomers.Rows[e.RowIndex].Cells["province"].FormattedValue.ToString());
                //module.comboBoxDistrict.SelectedIndex = module.comboBoxDistrict.FindStringExact(gunaDtgvCustomers.Rows[e.RowIndex].Cells["district"].FormattedValue.ToString());
                //module.txtAddressDetail.Text = gunaDtgvCustomers.Rows[e.RowIndex].Cells["address_detail"].FormattedValue.ToString();


                //module.btnSave.Enabled = false;
                //module.btnUpdate.Enabled = true;

                //module.ShowDialog();
                //Load_Customers();
            }
        }
    }
}
