using DormitoryManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryManagement.Controller
{
    public static class EmployeeDAO
    {
        public static EmployeeDTO GetEmployeeById(long id)
        {
            string query = string.Format("EXEC dbo.USP_GetEmployeeById @USER_ID = {0}", id);
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                return new EmployeeDTO(item);

            }
            return null;
        }

        public static DataTable GetEmployees()
        {
            string query = string.Format("EXEC dbo.USP_GetListEmployeeView");
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            return dataTable;
        }
        public static DataTable GetEmployeesByUserId(long userId)
        {
            string query = string.Format("EXEC dbo.USP_GetEmployeeView @USER_ID = {0}",userId);
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            return dataTable;
        }
        public static bool UpdateSalary(long userId, string salary)
        {
            string query = string.Format("EXEC dbo.USP_UpdateSalary @USER_ID = {0}, @SALARY = {1} ", userId, salary);
            DataTable result = DataProvider.ExcuteQuery(query);
            return result.Rows.Count > 0;
        }
    }
}
