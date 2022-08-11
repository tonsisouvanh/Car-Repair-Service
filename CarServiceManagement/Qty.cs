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
    public partial class Qty : Form
    {
        //int billID = 0;
        //int partID = 0;
        //PartImportBillDetail partImportBillDetail;
        //PartImportBills partImportBills;
        //public Qty(PartImportBillDetail pimbd,PartImportBills pib,int pBillID, int pPartID)
        public Qty()
        {
            InitializeComponent();
            numericQty.Value = 1;
            //billID = pBillID;
            //partID = pPartID;
            //partImportBillDetail = pimbd;
            //partImportBills = pib;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            numericQty.Value = 0;
            this.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    //if (MessageBox.Show("ຕ້ອງການບັນທິກຂໍ້ມູນ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    //{
                   
            //        int qty = Convert.ToInt32(Math.Round(numericQty.Value, 0));
                    

            //        string query = "exec sp_AddPartImportBillDetail @partID , @importBillID , @quantity";
            //        int result = DataProvider.Instance.ExecuteNoneQuery(query, new object[] { partID, billID, qty});

            //        if (result != 0)
            //        {
            //            MessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        }
            //        else
            //        {
            //            MessageBox.Show("ບໍ່ສາມາດເພີ່ມໄດ້", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }

            //    partImportBillDetail.load_ImportBillDetail();
            //    partImportBills.Load_PartImportBill();
            //    this.Dispose();
            //    //}

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show(ex.Message);
            //}
            this.Dispose();
        }
    }
}
