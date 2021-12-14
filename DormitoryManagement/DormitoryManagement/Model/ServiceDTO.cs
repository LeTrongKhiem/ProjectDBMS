using System;
using System.Data;

namespace DormitoryManagement.Model
{
	public class ServiceDTO
	{
		public int ServiceId { get; set; }
		public string ServiceName { get; set; }
		public int UnitId { get; set; }
		public string PricePerUnit { get; set; }
		public bool Status { get; set; }
		public ServiceDTO(DataRow dr)
		{
			this.ServiceId = Convert.ToInt32(dr["SERVICE_ID"]);
			this.ServiceName = Convert.ToString(dr["SERVICE_NAME"]).Trim();
			this.UnitId = Convert.ToInt32(dr["UNIT_ID"]);
			this.PricePerUnit = Convert.ToString(dr["PRICE_PER_UNIT"]).Trim();
			this.Status = Convert.ToBoolean(dr["STATUS"]);
		}
	}
}