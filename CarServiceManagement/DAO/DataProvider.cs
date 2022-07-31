using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarServiceManagement.DAO
{
    internal class DataProvider
    {
        private static DataProvider instance;


        public static DataProvider Instance
        {
            get
            {
                if (instance == null)
                    instance = new DataProvider();
                return DataProvider.instance;
            }
            private set
            {
                DataProvider.instance = value;
            }
        }
        private DataProvider() { }
        //private string connectionSTR = ConfigurationManager.ConnectionStrings["CarServiceManagement.configuration"].ConnectionString.ToString();
        private string connectionSTR = @"Data Source=DESKTOP-0HN7NPR\SQLEXPRESS;Initial Catalog=GarageServiceDB;Integrated Security=True";


        public SqlCommand AddParameters(string query, SqlCommand command, object[] parameters)
        {
            if (parameters != null)
            {
                string[] paramsList = query.Split(' ');
                int index = 0;
                foreach (string param in paramsList)
                    if (param.Contains('@'))
                        command.Parameters.AddWithValue(param, parameters[index++]);
            }
            return command;
        }


        public DataTable ExecuteQuery(string query, object[] parameters = null)
        {

            DataTable data = new DataTable();
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command = AddParameters(query, command, parameters);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(data);
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.ToString());
                MessageBox.Show("Fail to connect to database!");
            }

            return data;
        }


        public int ExecuteNoneQuery(string query, object[] parameters = null)
        {

            int data = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {

                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command = AddParameters(query, command, parameters);
                    data = command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return data;
        }


        public object ExecuteScalar(string query, object[] parameters = null)
        {

            object data = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionSTR))
                {

                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command = AddParameters(query, command, parameters);
                    data = command.ExecuteScalar();
                    connection.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            return data;
        }
    }
}
