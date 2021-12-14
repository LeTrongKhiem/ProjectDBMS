using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryManagement.Controller
{
    public static class DataProvider
    {
        private static string connectionString = @"Data Source=DESKTOP-VJSMPL6;Initial Catalog=DormitoryManagement;Integrated Security=True";
        //private static string connectionString = @"Data Source=Hiae\HOHUYHOANG;Initial Catalog=DormitoryManagement;Integrated Security=True";
        //private string connectionString = @"Data Source=(local);Initial Catalog=DormitoryManagement;Integrated Security=True";
        //private static string connectionString = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;

        public static DataTable ExcuteQuery(string query, object[] parameter = null)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] ListPara = query.Split(' ');// cắt chuỗi theo khoảng trắng
                    int i = 0;
                    foreach (string item in ListPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                 adapter.Fill(data);

                connection.Close();
            }
            return data;
        }
        public static int ExcuteNonQuery(string query, object[] parameter = null)
        {
            int data = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] ListPara = query.Split(' ');// cắt chuỗi theo khoảng trắng
                    int i = 0;
                    foreach (string item in ListPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteNonQuery();

                connection.Close();
            }
            return data;
        }
        public static object ExcuteScalar(string query, object[] parameter = null)
        {
            object data = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] ListPara = query.Split(' ');// cắt chuỗi theo khoảng trắng
                    int i = 0;
                    foreach (string item in ListPara)
                    {
                        if (item.Contains('@'))
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);
                            i++;
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }
            return data;
        }
    }
}
