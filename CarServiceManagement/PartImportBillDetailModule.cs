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
    public partial class PartImportBillDetailModule : Form
    {
        PartImportBillDetail partImportBillDetail;
        PartImportBills partImportBills;

        public PartImportBillDetailModule(PartImportBillDetail pibd, PartImportBills pib)
        {
            InitializeComponent();
            partImportBillDetail = pibd;
            partImportBills = pib;
            load_SpareParts();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //partImportBillDetail.Show();
        }

        public void load_SpareParts()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select p.*,pt.name as type_name from PartType pt,Part p where pt.parttypeID = p.part_type ");
            gunaDtgvParts.DataSource = data;
            gunaDtgvParts.Columns["price"].DefaultCellStyle.Format = "N0";
        }

        private void gunaDtgvParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = gunaDtgvParts.Columns[e.ColumnIndex].Name;

            if (colName == "add")
            {
                Qty f = new Qty();
                f.ShowDialog();
                int qty = Convert.ToInt32(Math.Round(f.numericQty.Value, 0));
                if(qty > 0)
                {
                    try
                    {
                        int billid = Convert.ToInt32(labelBillDetailID.Text.ToString());
                        int partid = Convert.ToInt32(gunaDtgvParts.Rows[e.RowIndex].Cells["partID"].FormattedValue.ToString());

                        string query = "exec sp_AddPartImportBillDetail @partID , @importBillID , @quantity";
                        int result = DataProvider.Instance.ExecuteNoneQuery(query, new object[] { partID, billid, qty });

                        if (result != 0)
                        {
                            MessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("ບໍ່ສາມາດເພີ່ມໄດ້", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        partImportBillDetail.load_ImportBillDetail();
                        partImportBills.Load_PartImportBill();
                        this.Dispose();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }

            }
            //else if (colName == "edit")
            //{
            //    CustomerModule module = new CustomerModule(this);

            //    module.labelID.Text = gunaDtgvCustomers.Rows[e.RowIndex].Cells["customerID"].FormattedValue.ToString();

            //    module.txtCusName.Text = gunaDtgvCustomers.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
            //    module.txtEmail.Text = gunaDtgvCustomers.Rows[e.RowIndex].Cells["email"].FormattedValue.ToString();
            //    module.txtPhone.Text = gunaDtgvCustomers.Rows[e.RowIndex].Cells["phone"].FormattedValue.ToString();
            //    module.comboBoxProvince.SelectedIndex = module.comboBoxProvince.FindStringExact(gunaDtgvCustomers.Rows[e.RowIndex].Cells["province"].FormattedValue.ToString());
            //    module.comboBoxDistrict.SelectedIndex = module.comboBoxDistrict.FindStringExact(gunaDtgvCustomers.Rows[e.RowIndex].Cells["district"].FormattedValue.ToString());
            //    module.txtAddressDetail.Text = gunaDtgvCustomers.Rows[e.RowIndex].Cells["address_detail"].FormattedValue.ToString();


            //    module.btnSave.Enabled = false;
            //    module.btnUpdate.Enabled = true;

            //    module.ShowDialog();
            //    Load_Customers();

            //}
         
        }
    }
}
