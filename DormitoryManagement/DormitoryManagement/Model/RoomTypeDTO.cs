using System;
using System.Data;

namespace DormitoryManagement.Model
{
	public class RoomTypeDTO
	{
		public int RoomTypeId { get; set; }
		public string RoomTypeName { get; set; }
		public string Price { get; set; }
		public string Area { get; set; }
		public int Capacity { get; set; }
		public RoomTypeDTO(DataRow dr)
		{
			this.RoomTypeId = Convert.ToInt32(dr["ROOM_TYPE_ID"]);
			this.RoomTypeName = Convert.ToString(dr["ROOM_TYPE_NAME"]).Trim();
			this.Price = Convert.ToString(dr["PRICE"]).Trim();
			this.Area = Convert.ToString(dr["AREA"]).Trim();
			this.Capacity = Convert.ToInt32(dr["CAPACITY"]);
		}
	}
}