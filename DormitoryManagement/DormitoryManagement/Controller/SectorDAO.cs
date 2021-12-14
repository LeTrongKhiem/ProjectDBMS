using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DormitoryManagement.Model;

namespace DormitoryManagement.Controller
{
    public static class SectorDAO
    {
        public static List<SectorDTO> GetListSector()
        {
            string query = string.Format("EXEC dbo.USP_GetListSector");
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            List<SectorDTO> ListSector = new List<SectorDTO>();
            foreach (DataRow item in dataTable.Rows)
            {
                SectorDTO Sector = new SectorDTO(item);
                ListSector.Add(Sector);
            }
            return ListSector;
        }
    }
}
