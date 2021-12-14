using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace DormitoryManagement
{
   public static class DataProvider
   {
      public static bool TestConnection()
      {
         bool result = false;
         SqlConnection connection = null;

         try
         {
            connection = DatabaseConnection.GetConnection();
            result = true;
         }
         catch (System.Exception e)
         {
            MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
         finally
         {
            if (connection != null)
            {
               connection.Close();
               connection.Dispose();
            }
         }

         return result;
      }

      public static DataTable ExcuteQuery(string query, object[] parameter = null)
      {
         DataTable data = new DataTable();
         SqlConnection connection = null;

         try
         {
            connection = DatabaseConnection.GetConnection();

            SqlCommand command = new SqlCommand(query, connection);
            SetParameters(query, command, parameter);

            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(data);
         }
         catch (System.Exception e)
         {
            MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
         finally
         {
            if (connection != null)
            {
               connection.Close();
               connection.Dispose();
            }
         }

         return data;
      }

      public static int ExcuteNonQuery(string query, object[] parameter = null)
      {
         int data = 0;
         SqlConnection connection = null;

         try
         {
            connection = DatabaseConnection.GetConnection();

            SqlCommand command = new SqlCommand(query, connection);
            SetParameters(query, command, parameter);
            data = command.ExecuteNonQuery();

            connection.Close();

         }
         catch (System.Exception e)
         {
            MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
         finally
         {
            if (connection != null)
            {
               connection.Close();
               connection.Dispose();
            }
         }

         return data;
      }

      public static object ExcuteScalar(string query, object[] parameter = null)
      {
         object data = 0;
         SqlConnection connection = null;

         try
         {
            connection = DatabaseConnection.GetConnection();
            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);
            SetParameters(query, command, parameter);
            data = command.ExecuteScalar();
         }
         catch (System.Exception e)
         {
            MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
         finally
         {
            if (connection != null)
            {
               connection.Close();
               connection.Dispose();
            }
         }

         return data;
      }

      private static void SetParameters(string query, SqlCommand command, object[] parameter = null)
      {
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
      }
   }
}