using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DormitoryManagement.Model;

namespace DormitoryManagement.Controller
{
    public static class ServiceDAO
    {
        public static List<ServiceDTO> GetListService()
        {
            string query = string.Format("EXEC dbo.USP_GetListService");
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            List<ServiceDTO> listService = new List<ServiceDTO>();
            foreach (DataRow item in dataTable.Rows)
            {
                ServiceDTO temp = new ServiceDTO(item);
                listService.Add(temp);
            }
            return listService;
        }

        public static DataTable GetServicesInfo()
        {
            string query = string.Format("EXEC dbo.USP_GetServicesInfo");
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            return dataTable;
        }
        public static bool AddService(string Service_Name, string Price_Per_Unit, string Unit_Name)
        {
            string query = string.Format("EXEC dbo.USP_InsertService @Service_Name = N'{0}'," +
                                                                    "@Price_Per_Unit = {1}," +
                                                                    "@Unit_Name = N'{2}'", Service_Name, Price_Per_Unit, Unit_Name);
            int result = DataProvider.ExcuteNonQuery(query);
            return result > 0;
        }
        public static bool UpdateService(string Service_Name, decimal Price)
        {
            string query = string.Format("EXEC dbo.USP_UpdateService @Service_Name = N'{0}'," +
                                                                    "@Price = {1}", Service_Name, Price);
            int result = DataProvider.ExcuteNonQuery(query);
            return result > 0;
        }
        public static bool DeleteService(string Service_Name)
        {
            string query = string.Format("EXEC dbo.USP_UnableService @Service_Name = N'{0}'", Service_Name);
            int result = DataProvider.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
