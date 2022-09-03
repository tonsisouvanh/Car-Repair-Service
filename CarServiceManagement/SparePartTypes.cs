using CarServiceManagement.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarServiceManagement
{
    public partial class SparePartTypes : Form
    {
        public SparePartTypes()
        {
            InitializeComponent();
            Load_SparePartTypes();
        }
        public void Load_SparePartTypes()
        {
            DataTable dtTable = DataProvider.Instance.ExecuteQuery("select * from PartType");
            DtgvPartTypes.DataSource = dtTable;
        }

        private void guna2ImageButtonAdd_Click(object sender, EventArgs e)
        {
            SparePartTypeModule sparePartTypeModule = new SparePartTypeModule(this);
            sparePartTypeModule.ShowDialog();
        }

        private void DtgvPartTypes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = DtgvPartTypes.Columns[e.ColumnIndex].Name;

            if (colName == "delete")
            {
                if (TMessageBox.Show("ຕ້ອງການລົບຂໍ້ມູນ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int typeId = Int16.Parse(DtgvPartTypes.Rows[e.RowIndex].Cells["parttypeID"].FormattedValue.ToString());

                        string query = "DELETE PartType WHERE parttypeID = " + typeId;
                        int result = DataProvider.Instance.ExecuteNoneQuery(query);

                        if (result != 0)
                        {
                            TMessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                        else
                        {
                            TMessageBox.Show("ບໍ່ສາມາດລົບໄດ້", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    catch (Exception ex)
                    {
                        TMessageBox.Show(ex.Message);
                    }
                    Load_SparePartTypes();

                }
            }
            else if (colName == "edit")
            {
                SparePartTypeModule sptm = new SparePartTypeModule(this);
                sptm.labelID.Text = DtgvPartTypes.Rows[e.RowIndex].Cells["parttypeID"].FormattedValue.ToString();
                sptm.txtPartTypeName.Text = DtgvPartTypes.Rows[e.RowIndex].Cells["name"].FormattedValue.ToString();

                sptm.btnSave.Enabled = false;
                sptm.btnUpdate.Enabled = true;

                sptm.ShowDialog();
                Load_SparePartTypes();

            }

        }
    }
}
