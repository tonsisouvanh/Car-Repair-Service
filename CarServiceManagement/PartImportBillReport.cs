using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarServiceManagement.DAO;
using Microsoft.Reporting.WinForms;

namespace CarServiceManagement
{
    public partial class PartImportBillReport : Form
    {
        PartImportBillDetail partImportBillDetail;
        public PartImportBillReport(PartImportBillDetail pidt)
        {
            InitializeComponent();
            partImportBillDetail = pidt;
            LoadPartImportBill();

        }

        private string priceStringFormat(string strPrice)
        {
            decimal total = Convert.ToDecimal(strPrice);
            return total.ToString("N0");
        }

        private void PartImportBillReport_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        public void LoadPartImportBill()
        {
            ReportDataSource reportDataSource;
            try
            {
                this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptPartImportBill.rdlc";
                this.reportViewer1.LocalReport.DataSources.Clear();
                int id = Convert.ToInt32(partImportBillDetail.labelBillNumber.Text.ToString());
                DataSet1 ds = new DataSet1();
                DataTable data = DataProvider.Instance.ExecuteQuery("select p.partID,p.name,p.price,p.cal_unit,p.stock as qty_in_stcok,bdt.quantity as qty_imported,bdt.subtotal " +
                    "from PartImportBillDetail bdt inner join Part p on bdt.partID = p.partID where importbillID = " + id) ;



                ReportParameter pPartImportBillID = new ReportParameter("pPartImportBillID", partImportBillDetail.labelBillNumber.Text);
                ReportParameter pDate = new ReportParameter("pDate", partImportBillDetail.dtpCreatedDate.Text);
                ReportParameter pTotal = new ReportParameter("pTotal", partImportBillDetail.labelTotal.Text);
                ReportParameter pStatus = new ReportParameter("pStatus", partImportBillDetail.labelBillStatus.Text);
                ReportParameter pSupplier = new ReportParameter("pSupplier", partImportBillDetail.labelSupplier.Text);
                ReportParameter pPayment = new ReportParameter("pPayment", partImportBillDetail.labelPayment.Text);

                reportViewer1.LocalReport.SetParameters(pPartImportBillID);
                reportViewer1.LocalReport.SetParameters(pDate);
                reportViewer1.LocalReport.SetParameters(pTotal);
                reportViewer1.LocalReport.SetParameters(pStatus);
                reportViewer1.LocalReport.SetParameters(pSupplier);
                reportViewer1.LocalReport.SetParameters(pPayment);


                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", data));

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 
    }
}
