using CarServiceManagement.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarServiceManagement
{
    public partial class SpareParts : Form
    {
        public SpareParts()
        {
            InitializeComponent();
            Load_SpareParts();
        }

        public void Load_SpareParts()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("select p.*,pt.name as type_name " +
                "from PartType pt,Part p where pt.parttypeID = p.part_type " +
                "and concat(p.name, pt.name, p.brand) LIKE '%" + txtPartName.Text + "%'");
            gunaDtgvParts.DataSource = data;
            gunaDtgvParts.Columns["price"].DefaultCellStyle.Format = "N0";
            gunaDtgvParts.Columns["import_price"].DefaultCellStyle.Format = "N0";

        }

        private void ImageButtonAdd_Click(object sender, EventArgs e)
        {
            //SparePartModule sparePartModule = new SparePartModule(this);
            //sparePartModule.ShowDialog();
        }

        private void gunaDtgvParts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //For update and delete brand by cell click from tbBrand
            string colName = gunaDtgvParts.Columns[e.ColumnIndex].Name;

            if (colName == "delete")
            {
                if (MessageBox.Show("ຕ້ອງການລົບຂໍ້ມູນ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int typeId = Int16.Parse(gunaDtgvParts.Rows[e.RowIndex].Cells["partID"].FormattedValue.ToString());

                        string query = "DELETE Part WHERE partID = " + typeId;
                        int result = DataProvider.Instance.ExecuteNoneQuery(query);

                        if (result != 0)
                        {
                            MessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            MessageBox.Show("ບໍ່ສາມາດລົບໄດ້", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    Load_SpareParts();

                }
            }
            else if (colName == "edit")
            {
                SparePartModule spm = new SparePartModule(this);

                spm.labelID.Text = gunaDtgvParts.Rows[e.RowIndex].Cells["partID"].FormattedValue.ToString();
                spm.txtPartName.Text = gunaDtgvParts.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();
                spm.txtPartDesc.Text = gunaDtgvParts.Rows[e.RowIndex].Cells["descriptions"].FormattedValue.ToString();
                spm.txtCalUnit.Text = gunaDtgvParts.Rows[e.RowIndex].Cells["cal_unit"].FormattedValue.ToString();
                spm.txtPrice.Text = gunaDtgvParts.Rows[e.RowIndex].Cells["price"].FormattedValue.ToString();
                spm.txtImportPrice.Text = gunaDtgvParts.Rows[e.RowIndex].Cells["import_price"].FormattedValue.ToString();
                spm.txtCurrency.Text = gunaDtgvParts.Rows[e.RowIndex].Cells["currency"].FormattedValue.ToString();
                spm.txtBrand.Text = gunaDtgvParts.Rows[e.RowIndex].Cells["brand"].FormattedValue.ToString();
                spm.numberStock.Value = Convert.ToDecimal(gunaDtgvParts.Rows[e.RowIndex].Cells["stock"].FormattedValue.ToString());
                spm.comboBoxPartType.SelectedIndex = spm.comboBoxPartType.FindStringExact(gunaDtgvParts.Rows[e.RowIndex].Cells["type_name"].FormattedValue.ToString());

                spm.btnSave.Enabled = false;
                spm.btnUpdate.Enabled = true;

                spm.ShowDialog();
                Load_SpareParts();

            }
        }

        private void txtPartName_TextChanged(object sender, EventArgs e)
        {
            DataTable dtDept = DataProvider.Instance.ExecuteQuery("select p.*,pt.name as type_name from PartType pt,Part p where pt.parttypeID = p.part_type " +
    "and concat(p.name, pt.name, p.brand) LIKE N'%" + txtPartName.Text + "%'");
            gunaDtgvParts.DataSource = dtDept;
            gunaDtgvParts.Columns["price"].DefaultCellStyle.Format = "N0";
        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            //DataTable spareParts = DataProvider.Instance.ExecuteQuery("select p.*,pt.name as type_name from PartType pt,Part p where pt.parttypeID = p.part_type");
            //DataSet dset = new DataSet();
            //dset.Tables.Add(spareParts);

            //try
            //{
            //    SaveFileDialog savefile = new SaveFileDialog();
            //    savefile.FileName = "Data.xls";
            //    savefile.Filter = "Excel Files|*.xls;*.xlsx;*.xlsm";
            //    if (dset.Tables[0].Rows.Count > 0)
            //    {
            //        if (savefile.ShowDialog() == DialogResult.OK)
            //        {
            //            StreamWriter wr = new StreamWriter(savefile.FileName);
            //            for (int i = 0; i < dset.Tables[0].Columns.Count; i++)
            //            {
            //                wr.Write(dset.Tables[0].Columns[i].ToString().ToUpper() + "\t");
            //            }

            //            wr.WriteLine();

            //            for (int i = 0; i < (dset.Tables[0].Rows.Count); i++)
            //            {
            //                for (int j = 0; j < dset.Tables[0].Columns.Count; j++)
            //                {
            //                    if (dset.Tables[0].Rows[i][j] != null)
            //                    {
            //                        wr.Write(Convert.ToString(dset.Tables[0].Rows[i][j]) + "\t");
            //                    }
            //                    else
            //                    {
            //                        wr.Write("\t");
            //                    }
            //                }
            //                //go to next line
            //                wr.WriteLine();
            //            }
            //            //close file
            //            wr.Close();
            //            MessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show(this, "Zero record to export , perform a operation first", "Can't export file", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{

            //}
        }
    }
}
