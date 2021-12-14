using System;
using System.Data;

namespace DormitoryManagement.Model
{
	public class BillDetailDTO
	{
		public long BillDetailId { get; set; }
		public long BillId { get; set; }
		public int ServiceId { get; set; }
		public int OldQuantity { get; set; }
		public int NewQuantity { get; set; }
		public string UnitName { get; set; }
		public decimal ToTal_Cost_Per_Service { get; set; }
		public string ServiceName { get; set; }
		public BillDetailDTO(DataRow dr)
		{
			this.BillDetailId = Convert.ToInt64(dr["BILL_DETAIL_ID"]);
			this.BillId = Convert.ToInt64(dr["BILL_ID"]);
			this.ServiceId = Convert.ToInt32(dr["SERVICE_ID"]);
			this.OldQuantity = Convert.ToInt32(dr["OLD_QUANTITY"]);
			this.NewQuantity = Convert.ToInt32(dr["NEW_QUANTITY"]);
			this.UnitName = Convert.ToString(dr["UNIT_NAME"]);
			this.ToTal_Cost_Per_Service = Convert.ToDecimal(dr["TOTAL_COST"]);
			this.ServiceName = Convert.ToString(dr["ServiceName"]);
		}
	}
}