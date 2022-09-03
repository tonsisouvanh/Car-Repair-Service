using CarServiceManagement.DAO;
using System;
using System.Windows.Forms;

namespace CarServiceManagement
{
    public partial class SparePartTypeModule : Form
    {
        SparePartTypes sparePartTypes;
        public SparePartTypeModule(SparePartTypes spt)
        {
            InitializeComponent();
            sparePartTypes = spt;

            btnUpdate.Enabled = false;
        }

        public void Clear()
        {
            txtPartTypeName.Clear();
            txtPartTypeName.Focus();
        }

        private bool checkForm()
        {
            string partTypeName = txtPartTypeName.Text.ToString();

            return partTypeName != "";
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (TMessageBox.Show("ຕ້ອງການບັນທິກຂໍ້ມູນ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (!checkForm())
                    {
                        TMessageBox.Show("ກາລຸນາປ້ອນຂໍ້ມູນ!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string query = "INSERT INTO PartType (name) VALUES(N'" + txtPartTypeName.Text + "')";
                    int result = DataProvider.Instance.ExecuteNoneQuery(query);

                    if (result != 0)
                    {
                        TMessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        TMessageBox.Show("ບໍ່ສາມາດເພີ່ມໄດ້", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Clear();

                    sparePartTypes.Load_SparePartTypes();
                }

            }
            catch (Exception ex)
            {

                TMessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                if (TMessageBox.Show("ຕ້ອງການແກ້ໄຂຂໍ້ມູນ", "Update Record!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string query = "UPDATE PartType SET name = N'" + txtPartTypeName.Text + "' WHERE parttypeID = " + Int16.Parse(labelID.Text.ToString());
                    int result = DataProvider.Instance.ExecuteNoneQuery(query);

                    if (result != 0)
                    {
                        TMessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        TMessageBox.Show("ບໍ່ສາມາດແກ້ໄຂໄດ້", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Clear();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                TMessageBox.Show(ex.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
