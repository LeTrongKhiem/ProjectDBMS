using DormitoryManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryManagement.Controller
{
    public static class CommuneDAO
    {
        public static List<CommuneDTO> GetLisCommuneByProvinceAndDistrict(string provinceName, string districtName)
        {
            List<CommuneDTO> communeDTOs = new List<CommuneDTO>();
            string query = string.Format("EXEC dbo.USP_GetListCommuneByProvinceAndDistrict @PROVINCE_NAME = N'{0}', @DISTRICT_NAME = N'{1}'", provinceName,districtName);
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            foreach (DataRow item in dataTable.Rows)
            {
                CommuneDTO communeDTO = new CommuneDTO(item);
                communeDTOs.Add(communeDTO);

            }
            return communeDTOs;
        }
        public static DataTable GetCommuneNameByCommuneID(string Commune_ID)
        {
            string query = string.Format("EXEC dbo.USP_GetCommuneNameByCommuneID @Commune_ID = '{0}'", Commune_ID);
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            return dataTable;
        }
    }
}
