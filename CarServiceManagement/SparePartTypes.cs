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
            //For update and delete brand by cell click from tbBrand
            string colName = DtgvPartTypes.Columns[e.ColumnIndex].Name;

            if (colName == "delete")
            {
                if (MessageBox.Show("ຕ້ອງການລົບຂໍ້ມູນ?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        int typeId = Int16.Parse(DtgvPartTypes.Rows[e.RowIndex].Cells["parttypeID"].FormattedValue.ToString());

                        string query = "DELETE PartType WHERE parttypeID = " + typeId;
                        int result = DataProvider.Instance.ExecuteNoneQuery(query);

                        if(result != 0)
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
            }

            Load_SparePartTypes();
        }
    }
}
