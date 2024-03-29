﻿using CarServiceManagement.DAO;
using System;
using System.Data;
using System.Windows.Forms;

namespace CarServiceManagement
{
    public partial class Login : Form
    {
        public string _pass = "";
        public bool _isactivate;
        public Login()
        {
            InitializeComponent();
            txtUsername.Focus();
        }

        private void picClose_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("ຕ້ອງການອອກຈາກລະບົບ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
            var result = TMessageBox.Show("ຕ້ອງການອອກຈາກລະບົບ?",
               "Question",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }



        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string _username = "", _name = "";
            if (txtUsername.Text == "" || txtPass.Text == "")
            {
                //MessageBox.Show("ຂໍ້ມູນບໍ່ຄົບຖ້ວນ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                var result = TMessageBox.Show("ຂໍ້ມູນບໍ່ຄົບຖ້ວນ",
               "Warning",
               MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    DataTable data = DataProvider.Instance.ExecuteQuery("select * from Account where username = '" + txtUsername.Text + "' and password = '" + txtPass.Text + "'");

                    if (data.Rows.Count > 0)
                    {
                        DataRow row = data.Rows[0];
                        _username = row["username"].ToString();
                        _name = row["name"].ToString();
                        this.Hide();
                        MainMenu f = new MainMenu();
                        f.labelName.Text = _name;
                        f.ShowDialog();
                    }
                    else
                    {
                        //MessageBox.Show("ຊື່,ເບີໂທ ຫຼື ລະຫັດບໍ່ຖີກຕ້ອງ!", "ACCESS DENIED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        TMessageBox.Show("ຊື່,ເບີໂທ ຫຼື ລະຫັດບໍ່ຖີກຕ້ອງ!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    TMessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = TMessageBox.Show("ຕ້ອງການອອກຈາກລະບົບ?",
               "Question",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                btnLogin.PerformClick();
            }
        }

        private void picMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void labelConnectionSetting_Click(object sender, EventArgs e)
        {
            FormConnection f = new FormConnection();
            f.ShowDialog();
        }
    }
}
