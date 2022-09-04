using CarServiceManagement.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarServiceManagement
{
    public partial class PartImportBills : Form
    {
        public PartImportBills()
        {
            InitializeComponent();
            Load_PartImportBill();
        }
        private void calTotalBill()
        {
            decimal sum = 0;
            for (int i = 0; i < gunaDtgvPartImportBill.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(gunaDtgvPartImportBill.Rows[i].Cells["total"].FormattedValue.ToString());
            }
            labelTotalImportbill.Text = sum.ToString("N0");
        }

        public void Load_PartImportBill()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select * from PartImportBill where " +
           "concat(supplier,status,payment) LIKE N'%" + txtSearch.Text + "%'");
            gunaDtgvPartImportBill.DataSource = data;
            gunaDtgvPartImportBill.Columns["total"].DefaultCellStyle.Format = "N0";
            gunaDtgvPartImportBill.Columns["created_date"].DefaultCellStyle.Format = "dd/MM/yyyy";

            calTotalBill();
        }

        private void ImageButtonAdd_Click(object sender, EventArgs e)
        {
            PartImportBillModule f = new PartImportBillModule(this);
            f.ShowDialog();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            Load_PartImportBill();
        }

        public void LoadBillHist()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("SELECT * FROM PartImportBill WHERE cast(created_date AS date) BETWEEN '" + dtpFrom.Value.ToString() + "' AND '" + dtpTo.Value.ToString() + "'");
            gunaDtgvPartImportBill.DataSource = data;
            calTotalBill();

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
                query = "select * from PartImportBill WHERE cast(created_date AS date) BETWEEN '" + dtpFrom.Value.ToString() + "' AND '" + dtpTo.Value.ToString() + "' order by total asc";
            }
            else if (cbbFilter.Text == "high - low")
            {
                query = "select * from PartImportBill WHERE cast(created_date AS date) BETWEEN '" + dtpFrom.Value.ToString() + "' AND '" + dtpTo.Value.ToString() + "' order by total desc";
            }
            else if (cbbFilter.Text == "status")
            {
                query = "select * from PartImportBill WHERE cast(created_date AS date) BETWEEN '" + dtpFrom.Value.ToString() + "' AND '" + dtpTo.Value.ToString() + "' order by status";
            }
            else
            {
                query = "select * from PartImportBill";
            }

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            gunaDtgvPartImportBill.DataSource = data;
            calTotalBill();

        }

        private void gunaDtgvPartImportBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = gunaDtgvPartImportBill.Columns[e.ColumnIndex].Name;

            if (colName == "delete")
            {
                if (TMessageBox.Show("ຕ້ອງການລົບຂໍ້ມູນ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int importbillID = Int32.Parse(gunaDtgvPartImportBill.Rows[e.RowIndex].Cells["importbillID"].FormattedValue.ToString());

                        string query = "DELETE PartImportBill WHERE importbillID = " + importbillID;
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
                    Load_PartImportBill();

                }
            }
            else if (colName == "edit")
            {
                PartImportBillModule module = new PartImportBillModule(this);

                module.labelID.Text = gunaDtgvPartImportBill.Rows[e.RowIndex].Cells["importbillID"].FormattedValue.ToString();

                module.txtSupplier.Text = gunaDtgvPartImportBill.Rows[e.RowIndex].Cells["supplier"].FormattedValue.ToString();
                module.txtSupplierContact.Text = gunaDtgvPartImportBill.Rows[e.RowIndex].Cells["supplier_contact"].FormattedValue.ToString();
                module.cbbStatus.SelectedItem = module.cbbStatus.FindStringExact(gunaDtgvPartImportBill.Rows[e.RowIndex].Cells["status"].FormattedValue.ToString());
                module.txtPayment.Text = gunaDtgvPartImportBill.Rows[e.RowIndex].Cells["payment"].FormattedValue.ToString();
                module.txtDesc.Text = gunaDtgvPartImportBill.Rows[e.RowIndex].Cells["descriptions"].FormattedValue.ToString();
                module.txtTotal.Text = gunaDtgvPartImportBill.Rows[e.RowIndex].Cells["total"].FormattedValue.ToString();
                module.dtpCreatedDate.Value = Convert.ToDateTime(gunaDtgvPartImportBill.Rows[e.RowIndex].Cells["created_date"].Value.ToString());



                module.btnSave.Enabled = false;
                module.btnUpdate.Enabled = true;
                module.dtpCreatedDate.Enabled = true;

                module.ShowDialog();

            }
            else if (colName == "detail")
            {

                int id = Convert.ToInt32(gunaDtgvPartImportBill.Rows[e.RowIndex].Cells["importbillID"].FormattedValue.ToString());
                PartImportBillDetail f = new PartImportBillDetail(this, id);
                f.labelBillNumber.Text = gunaDtgvPartImportBill.Rows[e.RowIndex].Cells["importbillID"].FormattedValue.ToString();
                f.labelBillStatus.Text = gunaDtgvPartImportBill.Rows[e.RowIndex].Cells["status"].FormattedValue.ToString();
                f.labelTotal.Text = gunaDtgvPartImportBill.Rows[e.RowIndex].Cells["total"].FormattedValue.ToString();
                f.dtpCreatedDate.Value = Convert.ToDateTime(gunaDtgvPartImportBill.Rows[e.RowIndex].Cells["created_date"].Value.ToString());
                f.labelSupplier.Text = gunaDtgvPartImportBill.Rows[e.RowIndex].Cells["supplier"].FormattedValue.ToString();
                f.labelPayment.Text = gunaDtgvPartImportBill.Rows[e.RowIndex].Cells["payment"].FormattedValue.ToString();
                f.labelDesc.Text = gunaDtgvPartImportBill.Rows[e.RowIndex].Cells["descriptions"].FormattedValue.ToString();
                f.ShowDialog();

            }
        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Title = "Export Excel";
            savefile.FileName = "ImportBill.xls";
            savefile.Filter = "Excel (*.xlsx)|*.xlsx|Excel 2003 (*.xls)|*.xls";

            if (savefile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Excel.exportExcel(savefile.FileName, gunaDtgvPartImportBill);
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
