using DormitoryManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryManagement.Controller
{
    public class ProvinceDAO
    {
        public static List<ProvinceDTO> GetListProvince()
        {
            List<ProvinceDTO> provinceDTOs = new List<ProvinceDTO>();
            string query = string.Format("EXEC dbo.USP_GetListProvince");
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                ProvinceDTO provinceDTO = new ProvinceDTO(item);
                provinceDTOs.Add(provinceDTO);

            }
            return provinceDTOs;
        }
        public static DataTable GetProvinceNameByProvinceID(string Province_ID)
        {
            string query = string.Format("EXEC dbo.USP_GetProvinceNameByProvinceID @Province_ID = '{0}'", Province_ID);
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            return dataTable;
        }
    }
}
