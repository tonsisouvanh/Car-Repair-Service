using CarServiceManagement.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarServiceManagement
{
    public partial class RepairBillDetail : Form
    {
        RepairBill repairBill;
        int passedID = 0;

        public RepairBillDetail(RepairBill rpb, int tempid)
        {
            InitializeComponent();

            repairBill = rpb;
            passedID = tempid;

            load_RepairBillDetail();
            load_SpareParts();
            load_Services();

        }

        private void reloadTotal(int billID)
        {
            //DataTable data = DataProvider.Instance.ExecuteQuery("select top(1) sum(subtotal) as total from RepairBillDetail " +
            //    "where repairbillID = " + billID +
            //    "group by repairbillID");
            DataTable data = DataProvider.Instance.ExecuteQuery("select top(1) total from RepairBill " +
               "where repairbillID = " + billID);

            if (data.Rows.Count > 0)
            {
                DataRow row = data.Rows[0];

                decimal total = Convert.ToDecimal(row["total"].ToString());
                this.labelTotal.Text = total.ToString("N0");
            }
        }

        public void load_SpareParts()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select p.partID as partIDs,p.name,p.price as part_price,p.cal_unit,p.stock from Part p " +
                "where p.name like N'%" + txtSearch.Text + "%'");
            gunaDtgvParts.DataSource = data;
            gunaDtgvParts.Columns["part_price"].DefaultCellStyle.Format = "N0";

        }
        public void load_Services()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select serviceID,service,service_price from Services where repairbillID = " + passedID);
            dtgvServices.DataSource = data;
            dtgvServices.Columns["service_price"].DefaultCellStyle.Format = "N0";

        }
        public void load_RepairBillDetail()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select pibd.repairbilldetailID, pibd.partID, pibd.repairbillID, p.name, pibd.part_price as price, pibd.quantity,p.cal_unit, pibd.subtotal " +
                "from RepairBillDetail pibd inner join Part p on pibd.partID = p.partID where pibd.repairbillID = " + passedID);
            gunaDtgvRepairBillDetail.DataSource = data;
            gunaDtgvRepairBillDetail.Columns["price"].DefaultCellStyle.Format = "N0";
            gunaDtgvRepairBillDetail.Columns["subtotal"].DefaultCellStyle.Format = "N0";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            load_SpareParts();
        }

        private void ImageButtonMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }

        private void ImageButtonClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void gunaDtgvRepairBillDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = gunaDtgvRepairBillDetail.Columns[e.ColumnIndex].Name;
            int qty = Convert.ToInt32(gunaDtgvRepairBillDetail.Rows[e.RowIndex].Cells["quantity"].FormattedValue.ToString());
            int id = Convert.ToInt32(gunaDtgvRepairBillDetail.Rows[e.RowIndex].Cells["repairbilldetailID"].FormattedValue.ToString());
            int billid = Convert.ToInt32(gunaDtgvRepairBillDetail.Rows[e.RowIndex].Cells["repairbillID"].FormattedValue.ToString());
            int partid = Convert.ToInt32(gunaDtgvRepairBillDetail.Rows[e.RowIndex].Cells["partID"].FormattedValue.ToString());
            decimal subtotal = Convert.ToDecimal(gunaDtgvRepairBillDetail.Rows[e.RowIndex].Cells["subtotal"].FormattedValue.ToString());

            if (colName == "delete")
            {
                if (MessageBox.Show("ຕ້ອງການລົບຂໍ້ມູນ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {


                        string query = "exec sp_DeleteRepairBillDetail @repairbilldetailID , @partID , @repairbillID , @quantity , @subtotal";

                        int result = DataProvider.Instance.ExecuteNoneQuery(query, new object[] { id, partid, billid, qty, subtotal });

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
                    load_RepairBillDetail();
                    load_SpareParts();
                    repairBill.Load_RepairBill();
                    reloadTotal(billid);

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

        private void gunaDtgvParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = gunaDtgvParts.Columns[e.ColumnIndex].Name;

            if (colName == "add")
            {
                Qty f = new Qty();
                f.ShowDialog();
                int stockQty = Convert.ToInt32(gunaDtgvParts.Rows[e.RowIndex].Cells["stock"].FormattedValue.ToString());
                int qty = Convert.ToInt32(Math.Round(f.numericQty.Value, 0));
                int billid = Convert.ToInt32(labelBillNumber.Text.ToString());
                int partid = Convert.ToInt32(gunaDtgvParts.Rows[e.RowIndex].Cells["partIDs"].FormattedValue.ToString());
                decimal partPrice = Convert.ToDecimal(gunaDtgvParts.Rows[e.RowIndex].Cells["part_price"].FormattedValue.ToString());

                if (qty > 0 && qty <= stockQty)
                {
                    try
                    {
                        string query = "exec sp_AddRepairBillDetail @partID , @importBillID , @quantity , @part_price";
                        int result = DataProvider.Instance.ExecuteNoneQuery(query, new object[] { partid, billid, qty, partPrice });


                        if (result != 0)
                        {
                            MessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("ບໍ່ສາມາດເພີ່ມໄດ້", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        load_RepairBillDetail();
                        load_SpareParts();

                        repairBill.Load_RepairBill();

                        reloadTotal(billid);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("ຈຳນວນເຄື່ອງໃນສາງບໍ່ພຽງພໍ", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            ServiceModule f = new ServiceModule();
            f.labelID.Text = labelBillNumber.Text;
            f.ShowDialog();

            load_RepairBillDetail();
            load_Services();
            repairBill.Load_RepairBill();
            reloadTotal(passedID);
        }

        private void dtgvServices_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dtgvServices.Columns[e.ColumnIndex].Name;

            if (colName == "updateservice")
            {
                //int stockQty = Convert.ToInt32(gunaDtgvParts.Rows[e.RowIndex].Cells["stock"].FormattedValue.ToString());
                //int qty = Convert.ToInt32(Math.Round(f.numericQty.Value, 0));
                //int billid = Convert.ToInt32(labelBillNumber.Text.ToString());
                //int partid = Convert.ToInt32(gunaDtgvParts.Rows[e.RowIndex].Cells["partIDs"].FormattedValue.ToString());
                //decimal partPrice = Convert.ToDecimal(gunaDtgvParts.Rows[e.RowIndex].Cells["part_price"].FormattedValue.ToString());

                //try
                //{
                //    string query = "exec sp_AddRepairBillDetail @partID , @importBillID , @quantity , @part_price";
                //    int result = DataProvider.Instance.ExecuteNoneQuery(query, new object[] { partid, billid, qty, partPrice });


                //    if (result != 0)
                //    {
                //        MessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    }
                //    else
                //    {
                //        MessageBox.Show("ບໍ່ສາມາດເພີ່ມໄດ້", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }

                //    load_RepairBillDetail();
                //    load_SpareParts();

                //    repairBill.Load_RepairBill();

                //    reloadTotal(billid);

                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
            }
            else if (colName == "deleteservice")
            {
                if (MessageBox.Show("ຕ້ອງການລົບຂໍ້ມູນ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int serviceID = Int32.Parse(dtgvServices.Rows[e.RowIndex].Cells["serviceID"].FormattedValue.ToString());
                        decimal servicePrice = Convert.ToDecimal(dtgvServices.Rows[e.RowIndex].Cells["service_price"].FormattedValue.ToString());

                        string query = "exec sp_deleteService @serviceID , @repairbillID , @service_price";
                        int result = DataProvider.Instance.ExecuteNoneQuery(query, new object[] { serviceID, passedID, servicePrice });

                        if (result != 0)
                        {
                            MessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("ບໍ່ສາມາດລົບໄດ້ ຫຼື ລອງລົບຂໍ້ມູນລາຍລະອຽດບິນກ່ອນ ແລ້ວພະຍາຍາມໃໝ່", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    load_Services();
                    reloadTotal(passedID);
                    repairBill.Load_RepairBill();
                }
            }
        }

        private void btnPricnt_Click(object sender, EventArgs e)
        {

        }
    }
}
