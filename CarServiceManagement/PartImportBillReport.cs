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
            LoadPartImportBill();
            partImportBillDetail = pidt;


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

                DataSet1 ds = new DataSet1();
                DataTable data = DataProvider.Instance.ExecuteQuery("select p.partID,p.name,p.price,p.cal_unit,p.stock as qty_in_stcok,bdt.quantity as qty_imported,bdt.subtotal " +
                    "from PartImportBillDetail bdt inner join Part p on bdt.partID = p.partID");
                ds.CreateDataReader(data);

                ReportParameter pPartImportBillID = new ReportParameter("pPartImportBillID", "20108");
                ReportParameter pDate = new ReportParameter("pDate", "2020-12-12");
                ReportParameter pTotal = new ReportParameter("pTotal", "0203909");
                ReportParameter pStatus = new ReportParameter("pStatus", "Owe");
                ReportParameter pSupplier = new ReportParameter("pSupplier", "Jame Som Paeng");
                ReportParameter pPayment = new ReportParameter("pPayment", "Credit");

                reportViewer1.LocalReport.SetParameters(pPartImportBillID);
                reportViewer1.LocalReport.SetParameters(pDate);
                reportViewer1.LocalReport.SetParameters(pTotal);
                reportViewer1.LocalReport.SetParameters(pStatus);
                reportViewer1.LocalReport.SetParameters(pSupplier);
                reportViewer1.LocalReport.SetParameters(pPayment);

                reportDataSource = new ReportDataSource("DataSet1", ds.Tables["DtPartImportBill"]);
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                //reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
                //reportViewer1.ZoomMode = ZoomMode.Percent;
                //reportViewer1.ZoomPercent = 30;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 
    }
}
