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
            //btnUpdate.Enabled = false;
            //btnSave.Enabled = true;
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
                if (MessageBox.Show("ຕ້ອງການບັນທິກຂໍ້ມູນ?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (!checkForm())
                    {
                        MessageBox.Show("ກາລຸນາປ້ອນຂໍ້ມູນ!", "Warning Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string query = "INSERT INTO PartType (name) VALUES(N'" + txtPartTypeName.Text + "')";
                    int result = DataProvider.Instance.ExecuteNoneQuery(query);

                    if (result != 0)
                    {
                        MessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("ບໍ່ສາມາດເພີ່ມໄດ້", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Clear();

                    sparePartTypes.Load_SparePartTypes();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                if (MessageBox.Show("ຕ້ອງການແກ້ໄຂຂໍ້ມູນ", "Update Record!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string query = "UPDATE PartType SET name = N'" + txtPartTypeName.Text + "' WHERE parttypeID = " + Int16.Parse(labelID.Text.ToString());
                    int result = DataProvider.Instance.ExecuteNoneQuery(query);

                    if (result != 0)
                    {
                        MessageBox.Show("ສຳເລັດ", "Info Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {
                        MessageBox.Show("ບໍ່ສາມາດແກ້ໄຂໄດ້", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    Clear();
                    this.Dispose();// To close this form after update data
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
