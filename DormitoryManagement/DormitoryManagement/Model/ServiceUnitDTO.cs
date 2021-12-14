using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DormitoryManagement.Model
{
    public class ServiceUnitDTO
    {
        public int ServiceId { get; set; }
        public string ServiceName { get; set; }
        public decimal PricePerUnit { get; set; }
        public string UnitName { get; set; }
        public bool Status { get; set; }
        public ServiceUnitDTO(DataRow dr)
        {
            this.ServiceId = Convert.ToInt32(dr["SERVICE_ID"]);
            this.ServiceName = Convert.ToString(dr["SERVICE_NAME"]);
            this.PricePerUnit = Convert.ToDecimal(dr["PRICE_PER_UNIT"]);
            this.UnitName = Convert.ToString(dr["UNIT_NAME"]);
            this.Status = Convert.ToBoolean(dr["STATUS"]);
        }
    }
}
