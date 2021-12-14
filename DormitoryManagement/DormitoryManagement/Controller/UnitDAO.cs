using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DormitoryManagement.Model;

namespace DormitoryManagement.Controller
{
    public static class UnitDAO
    {
        public static UnitDTO GetUnitByServiceName(string ServiceName)
        {
            string query = string.Format("EXEC dbo.GetUnitByServiceName @Service_name = N'{0}'", ServiceName);
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                return new UnitDTO(item);
            }
            return null;
        }
    }
}
