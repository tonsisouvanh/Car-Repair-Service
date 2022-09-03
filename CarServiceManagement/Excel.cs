using System;
using System.Windows.Forms;

namespace CarServiceManagement
{
    internal class Excel
    {
        public static void exportExcel(string path, DataGridView dtgv)
        {
            Microsoft.Office.Interop.Excel.Application application = new Microsoft.Office.Interop.Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dtgv.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = dtgv.Columns[i].HeaderText;
            }
            for (int i = 0; i < dtgv.Rows.Count; i++)
            {
                for (int j = 0; j < dtgv.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = dtgv.Rows[i].Cells[j].Value;
                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }
    }
}
