using CarServiceManagement.DAO;
using Microsoft.Reporting.WinForms;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarServiceManagement
{
    public partial class RepairbillReport : Form
    {
        RepairBillDetail repairBillDetail;
        public RepairbillReport(RepairBillDetail rbdt)
        {
            InitializeComponent();
            repairBillDetail = rbdt;
            LoadRepairBill();
        }

        private string sumPart()
        {
            string result;

            decimal sum = 0;
            for (int i = 0; i < repairBillDetail.gunaDtgvRepairBillDetail.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(repairBillDetail.gunaDtgvRepairBillDetail.Rows[i].Cells["subtotal"].Value);
            }
            result = sum.ToString("N0");
            return result;
        }


        private string sumService()
        {
            string result;

            decimal sum = 0;
            for (int i = 0; i < repairBillDetail.dtgvServices.Rows.Count; ++i)
            {
                sum += Convert.ToDecimal(repairBillDetail.dtgvServices.Rows[i].Cells["service_price"].Value);
            }
            result = sum.ToString("N0");
            return result;
        }

        private void RepairbillReport_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
        }

        public void LoadRepairBill()
        {
            try
            {
                //this.reportViewer1.LocalReport.ReportPath = Application.StartupPath + @"\Reports\rptRepairBill.rdlc";
                this.reportViewer1.LocalReport.ReportPath = @"C:\Users\tonsi\OneDrive\Desktop\C#_Project\CarServiceManagement\CarServiceManagement\rptRepairBill.rdlc";


                this.reportViewer1.LocalReport.DataSources.Clear();

                int id = Convert.ToInt32(repairBillDetail.labelBillNumber.Text.ToString());
                DataTable data = DataProvider.Instance.ExecuteQuery("select p.partID,p.code,p.name,p.price as part_price,p.cal_unit,rbdt.quantity,rbdt.subtotal " +
                    "from RepairBillDetail rbdt inner join Part p on rbdt.partID = p.partID where repairbillID = " + id);

                DataTable serviceData = DataProvider.Instance.ExecuteQuery("select * from Services where repairbillID = " + id);

                string sumpart = sumPart();
                string sumservice = sumService();

                ReportParameter pRepairBillID = new ReportParameter("pRepairbillID", repairBillDetail.labelBillNumber.Text);
                ReportParameter pCreatedDate = new ReportParameter("pCreatedDate", repairBillDetail.labelCreatedDate.Text);
                ReportParameter pTotal = new ReportParameter("pTotal", repairBillDetail.labelTotal.Text);
                ReportParameter pStatus = new ReportParameter("pStatus", repairBillDetail.labelBillStatus.Text);
                ReportParameter pPayment = new ReportParameter("pPayment", repairBillDetail.labelPayment.Text);
                ReportParameter pDescription = new ReportParameter("pDescription", repairBillDetail.labelDesc.Text);

                ReportParameter pTotalPart = new ReportParameter("pTotalPart", sumpart);
                ReportParameter pTotalService = new ReportParameter("pTotalService", sumservice);

                reportViewer1.LocalReport.SetParameters(pRepairBillID);
                reportViewer1.LocalReport.SetParameters(pCreatedDate);
                reportViewer1.LocalReport.SetParameters(pTotal);
                reportViewer1.LocalReport.SetParameters(pStatus);
                reportViewer1.LocalReport.SetParameters(pPayment);
                reportViewer1.LocalReport.SetParameters(pDescription);
                reportViewer1.LocalReport.SetParameters(pTotalPart);
                reportViewer1.LocalReport.SetParameters(pTotalService);




                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", data));
                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", serviceData));


            }
            catch (Exception ex)
            {
                TMessageBox.Show(ex.Message);
            }
        }
    }
}
