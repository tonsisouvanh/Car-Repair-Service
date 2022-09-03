using System;
using System.Windows.Forms;

namespace CarServiceManagement
{
    public partial class FormConnection : Form
    {
        public FormConnection()
        {
            InitializeComponent();
        }

        private void FormConnection_Load(object sender, EventArgs e)
        {
            cbbServer.Items.Add(".");
            cbbServer.Items.Add("(local)");
            cbbServer.Items.Add(@".\SQLEXPRESS");
            cbbServer.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            cbbServer.SelectedIndex = 3;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True", cbbServer.Text, tbDatabase.Text);

            try
            {
                SqlHelper helper = new SqlHelper(connectionString);
                if (helper.IsConnection)
                    TMessageBox.Show("Text connection succeeded.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                TMessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string connectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True", cbbServer.Text, tbDatabase.Text);

            try
            {
                SqlHelper helper = new SqlHelper(connectionString);
                if (helper.IsConnection)
                {
                    AppSetting setting = new AppSetting();
                    setting.SaveConnectionString("CarServiceManagement.configuration", connectionString);
                    TMessageBox.Show("Your connection string has been saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                TMessageBox.Show(ex.Message);
            }
        }
    }
}
