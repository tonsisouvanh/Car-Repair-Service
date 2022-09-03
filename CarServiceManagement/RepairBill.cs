using CarServiceManagement.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarServiceManagement
{
    public partial class RepairBill : Form
    {
        public RepairBill()
        {
            InitializeComponent();
            Load_RepairBill();
        }

        public void Load_RepairBill()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select b.repairbillID,b.customerID,c.name as cust_name,c.phone,c.email,b.status,b.payment,b.total,b.descriptions,b.created_date " +
           "from RepairBill b inner join Customer c on b.customerID = c.customerID where " +
           "concat(b.status,b.payment,c.name,c.phone,c.email) LIKE N'%" + txtSearch.Text + "%'");

            gunaDtgvRepairBill.DataSource = data;
            gunaDtgvRepairBill.Columns["total"].DefaultCellStyle.Format = "N0";
            gunaDtgvRepairBill.Columns["created_date"].DefaultCellStyle.Format = "dd/MM/yyyy";

        }

        private void ImageButtonAdd_Click(object sender, EventArgs e)
        {
            RepairBillModule f = new RepairBillModule(this);
            f.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Load_RepairBill();
        }
        public void LoadBillHist()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select b.repairbillID,b.customerID,c.name as cust_name,c.phone,c.email,b.status,b.payment,b.total,b.descriptions,b.created_date " +
           "from RepairBill b inner join Customer c on b.customerID = c.customerID WHERE cast(b.created_date AS date) BETWEEN '" + dtpFrom.Value.ToString() + "' AND '" + dtpTo.Value.ToString() + "'");
            gunaDtgvRepairBill.DataSource = data;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadBillHist();
        }

        private void cbbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query;
            if (cbbFilter.Text == "low - high")
            {
                query = "select b.repairbillID,b.customerID,c.name as cust_name,c.phone,c.email,b.status,b.payment,b.total,b.descriptions,b.created_date " +
           "from RepairBill b inner join Customer c on b.customerID = c.customerID WHERE cast(b.created_date AS date) BETWEEN '" + dtpFrom.Value.ToString() + "' AND '" + dtpTo.Value.ToString() + "' order by b.total asc";
            }
            else if (cbbFilter.Text == "high - low")
            {
                query = "select b.repairbillID,b.customerID,c.name as cust_name,c.phone,c.email,b.status,b.payment,b.total,b.descriptions,b.created_date " +
           "from RepairBill b inner join Customer c on b.customerID = c.customerID WHERE cast(b.created_date AS date) BETWEEN '" + dtpFrom.Value.ToString() + "' AND '" + dtpTo.Value.ToString() + "' order by b.total desc";
            }
            else if (cbbFilter.Text == "status")
            {
                query = "select b.repairbillID,b.customerID,c.name as cust_name,c.phone,c.email,b.status,b.payment,b.total,b.descriptions,b.created_date " +
           "from RepairBill b inner join Customer c on b.customerID = c.customerID WHERE cast(b.created_date AS date) BETWEEN '" + dtpFrom.Value.ToString() + "' AND '" + dtpTo.Value.ToString() + "' order by b.status";
            }
            else
            {
                query = "select b.repairbillID,b.customerID,c.name as cust_name,c.phone,c.email,b.status,b.payment,b.total,b.descriptions,b.created_date " +
           "from RepairBill b inner join Customer c on b.customerID = c.customerID where " +
           "concat(b.status,b.payment,c.name,c.phone,c.email) LIKE N'%" + txtSearch.Text + "%'";
            }

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            gunaDtgvRepairBill.DataSource = data;
        }

        private void gunaDtgvRepairBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = gunaDtgvRepairBill.Columns[e.ColumnIndex].Name;

            if (colName == "delete")
            {
                if (TMessageBox.Show("ຕ້ອງການລົບຂໍ້ມູນ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int repairbillID = Int32.Parse(gunaDtgvRepairBill.Rows[e.RowIndex].Cells["repairbillID"].FormattedValue.ToString());

                        string query = "DELETE RepairBill WHERE repairbillID = " + repairbillID;
                        int result = DataProvider.Instance.ExecuteNoneQuery(query);

                        if (result != 0)
                        {
                            TMessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            TMessageBox.Show("ບໍ່ສາມາດລົບໄດ້ ຫຼື ລອງລົບຂໍ້ມູນລາຍລະອຽດບິນກ່ອນ ແລ້ວພະຍາຍາມໃໝ່", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    catch (Exception ex)
                    {
                        TMessageBox.Show(ex.Message);
                    }
                    Load_RepairBill();

                }
            }
            else if (colName == "edit")
            {

                RepairBillModule module = new RepairBillModule(this);

                module.labelID.Text = gunaDtgvRepairBill.Rows[e.RowIndex].Cells["repairbillID"].FormattedValue.ToString();
                module.labelCustID.Text = gunaDtgvRepairBill.Rows[e.RowIndex].Cells["customerID"].FormattedValue.ToString();

                module.cbbStatus.SelectedItem = module.cbbStatus.FindStringExact(gunaDtgvRepairBill.Rows[e.RowIndex].Cells["status"].FormattedValue.ToString());
                module.txtPayment.Text = gunaDtgvRepairBill.Rows[e.RowIndex].Cells["payment"].FormattedValue.ToString();
                module.txtDesc.Text = gunaDtgvRepairBill.Rows[e.RowIndex].Cells["descriptions"].FormattedValue.ToString();
                module.txtTotal.Text = gunaDtgvRepairBill.Rows[e.RowIndex].Cells["total"].FormattedValue.ToString();
                module.dtpCreatedDate.Value = Convert.ToDateTime(gunaDtgvRepairBill.Rows[e.RowIndex].Cells["created_date"].Value.ToString());


                module.btnSave.Enabled = false;
                module.btnUpdate.Enabled = true;
                module.formInputPanel.Enabled = true;
                module.txtCustInfo.Text = gunaDtgvRepairBill.Rows[e.RowIndex].Cells["phone"].FormattedValue.ToString();
                module.txtCustInfo.Enabled = false;
                module.labelAddNewCust.Enabled = false;


                module.ShowDialog();
                Load_RepairBill();

            }
            else if (colName == "detail")
            {
                int id = Convert.ToInt32(gunaDtgvRepairBill.Rows[e.RowIndex].Cells["repairbillID"].FormattedValue.ToString());
                RepairBillDetail f = new RepairBillDetail(this, id);

                f.labelBillNumber.Text = gunaDtgvRepairBill.Rows[e.RowIndex].Cells["repairbillID"].FormattedValue.ToString();
                f.labelBillStatus.Text = gunaDtgvRepairBill.Rows[e.RowIndex].Cells["status"].FormattedValue.ToString();
                f.labelTotal.Text = gunaDtgvRepairBill.Rows[e.RowIndex].Cells["total"].FormattedValue.ToString();
                f.labelCreatedDate.Text = gunaDtgvRepairBill.Rows[e.RowIndex].Cells["created_date"].FormattedValue.ToString();
                f.labelDesc.Text = gunaDtgvRepairBill.Rows[e.RowIndex].Cells["descriptions"].FormattedValue.ToString();
                f.labelCustID.Text = gunaDtgvRepairBill.Rows[e.RowIndex].Cells["customerID"].FormattedValue.ToString();
                f.labelPayment.Text = gunaDtgvRepairBill.Rows[e.RowIndex].Cells["payment"].FormattedValue.ToString();
                f.ShowDialog();
            }
        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Title = "Export Excel";
            savefile.FileName = "repairbill.xls";
            savefile.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";


            if (savefile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Excel.exportExcel(savefile.FileName, gunaDtgvRepairBill);
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
