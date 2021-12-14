using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DormitoryManagement.Model;

namespace DormitoryManagement.Controller
{
    public static class ServiceUnitDAO
    {
        public static List<ServiceUnitDTO> GetListServiceUnit()
        {
            string query = string.Format("EXEC dbo.USP_GetListServiceUnit");
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            List<ServiceUnitDTO> listServiceUnit = new List<ServiceUnitDTO>();
            foreach (DataRow item in dataTable.Rows)
            {
                ServiceUnitDTO temp = new ServiceUnitDTO(item);
                listServiceUnit.Add(temp);
            }
            return listServiceUnit;
        }
    }
}
