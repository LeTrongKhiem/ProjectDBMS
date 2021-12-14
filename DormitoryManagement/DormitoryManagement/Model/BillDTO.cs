using System;
using System.Data;

namespace DormitoryManagement.Model
{
	public class BillDTO
	{
		public long BillId { get; set; }
		public long EmployeeId { get; set; }
		public string RoomId { get; set; }
		public DateTime CreateTime { get; set; }
		public string Total { get; set; }
		public BillDTO(DataRow dr)
		{
			this.BillId = Convert.ToInt64(dr["BILL_ID"]);
			this.EmployeeId = Convert.ToInt64(dr["EMPLOYEE_ID"]);
			this.RoomId = Convert.ToString(dr["ROOM_ID"]).Trim();
			this.CreateTime = Convert.ToDateTime(dr["CREATE_TIME"]);
			this.Total = Convert.ToString(dr["TOTAL"]).Trim();
		}
	}
}