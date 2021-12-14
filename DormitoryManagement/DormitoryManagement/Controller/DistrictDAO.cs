using DormitoryManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryManagement.Controller
{
    public static class DistrictDAO
    {
        public static List<DistrictDTO> GetListDistrictByProvinceName(string provinceName)
        {
            List<DistrictDTO> districtDTOs = new List<DistrictDTO>();
            string query = string.Format("EXEC dbo.USP_GetListDistrictByProvinceName @PROVINCE_NAME = N'{0}'", provinceName);
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                DistrictDTO districtDTO = new DistrictDTO(item);
                districtDTOs.Add(districtDTO);

            }
            return districtDTOs;
        }
        public static DataTable GetDistrictNameByDistricID(string District_ID)
        {
            string query = string.Format("EXEC dbo.USP_GetDistrictNameByDistrictID @District_ID = '{0}'", District_ID);
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            return dataTable;
        }
    }
}
