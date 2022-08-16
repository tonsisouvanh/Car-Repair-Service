using CarServiceManagement.DAO;
using System;
using System.Data;
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
            load_SpareParts();

        }

        private void reloadTotal(int billID)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select top(1) sum(subtotal) as total from PartImportBillDetail " +
                "where importbillID = " + billID +
                "group by importbillID");

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
        public void load_ImportBillDetail()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select pibd.importbilldetailID, pibd.partID, pibd.importbillID, p.name, p.price, pibd.quantity,p.cal_unit, pibd.subtotal " +
                "from PartImportBillDetail pibd inner join Part p on pibd.partID = p.partID where pibd.importbillID = " + passedID);
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

        private void PartImportBillDetail_Load(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(labelBillNumber.Text.ToString());
        }

        private void gunaDtgvPartImportBillDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = gunaDtgvPartImportBillDetail.Columns[e.ColumnIndex].Name;
            int qty = Convert.ToInt32(gunaDtgvPartImportBillDetail.Rows[e.RowIndex].Cells["quantity"].FormattedValue.ToString());
            int id = Convert.ToInt32(gunaDtgvPartImportBillDetail.Rows[e.RowIndex].Cells["importbilldetailID"].FormattedValue.ToString());
            int billid = Convert.ToInt32(gunaDtgvPartImportBillDetail.Rows[e.RowIndex].Cells["importbillID"].FormattedValue.ToString());
            int partid = Convert.ToInt32(gunaDtgvPartImportBillDetail.Rows[e.RowIndex].Cells["partID"].FormattedValue.ToString());
            decimal subtotal = Convert.ToDecimal(gunaDtgvPartImportBillDetail.Rows[e.RowIndex].Cells["subtotal"].FormattedValue.ToString());

            if (colName == "delete")
            {
                if (MessageBox.Show("ຕ້ອງການລົບຂໍ້ມູນ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {


                        string query = "exec sp_DeletePartImportBillDetail @importbilldetailID , @partID , @importBillID , @quantity , @subtotal";

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
                    load_ImportBillDetail();
                    load_SpareParts();

                    partImportBills.Load_PartImportBill();
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
                int qty = Convert.ToInt32(Math.Round(f.numericQty.Value, 0));
                int billid = Convert.ToInt32(labelBillNumber.Text.ToString());
                int partid = Convert.ToInt32(gunaDtgvParts.Rows[e.RowIndex].Cells["partIDs"].FormattedValue.ToString());
                if (qty > 0)
                {
                    try
                    {


                        string query = "exec sp_AddPartImportBillDetail @partID , @importBillID , @quantity";
                        int result = DataProvider.Instance.ExecuteNoneQuery(query, new object[] { partid, billid, qty });


                        if (result != 0)
                        {
                            MessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("ບໍ່ສາມາດເພີ່ມໄດ້", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        load_ImportBillDetail();
                        load_SpareParts();

                        partImportBills.Load_PartImportBill();

                        reloadTotal(billid);



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            //else if(colName == "delete")
            //{
            //    if (MessageBox.Show("ຕ້ອງການລົບຂໍ້ມູນ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        try
            //        {
            //            int id = Convert.ToInt32(gunaDtgvPartImportBillDetail.Rows[e.RowIndex].Cells["importbilldetailID"].FormattedValue.ToString());
            //            int billid = Convert.ToInt32(gunaDtgvPartImportBillDetail.Rows[e.RowIndex].Cells["importbillID"].FormattedValue.ToString());
            //            int partid = Convert.ToInt32(gunaDtgvPartImportBillDetail.Rows[e.RowIndex].Cells["partID"].FormattedValue.ToString());
            //            int qty = Convert.ToInt32(gunaDtgvPartImportBillDetail.Rows[e.RowIndex].Cells["quantity"].FormattedValue.ToString());
            //            decimal subtotal = Convert.ToInt32(gunaDtgvPartImportBillDetail.Rows[e.RowIndex].Cells["subtotal"].FormattedValue.ToString());


            //            string query = "exec sp_AddPartImportBillDetail @importbilldetailID ,@partID , @importBillID , @quantity , @subtotal";

            //            int result = DataProvider.Instance.ExecuteNoneQuery(query, new object[] {id, partid, billid, qty, subtotal });

            //            if (result != 0)
            //            {
            //                MessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //            }
            //            else
            //            {
            //                MessageBox.Show("ບໍ່ສາມາດລົບໄດ້ ຫຼື ລອງລົບຂໍ້ມູນລົດຂອງລູກຄ້າກ່ອນ ແລ້ວພະຍາຍາມໃໝ່", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }

            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show(ex.Message);
            //        }
            //        load_ImportBillDetail();

            //    }
            //}
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //DataTable data = DataProvider.Instance.ExecuteQuery("select p.partID as partIDs,p.name,p.price as part_price,p.cal_unit " +
            //    "from Part p where p.name like N'%" + txtSearch.Text + "%'");
            //gunaDtgvParts.DataSource = data;
            //gunaDtgvParts.Columns["part_price"].DefaultCellStyle.Format = "N0";
            load_SpareParts();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            PartImportBillReport f = new PartImportBillReport(this);
            f.ShowDialog();
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
