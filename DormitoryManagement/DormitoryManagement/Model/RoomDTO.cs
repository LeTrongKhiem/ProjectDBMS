using System;
using System.Data;

namespace DormitoryManagement.Model
{
	public class RoomDTO
	{
		public string RoomId { get; set; }
		public string SectorId { get; set; }
		public int RoomTypeId { get; set; }
		public RoomDTO(DataRow dr)
		{
			this.RoomId = Convert.ToString(dr["ROOM_ID"]).Trim();
			this.SectorId = Convert.ToString(dr["SECTOR_ID"]).Trim();
			this.RoomTypeId = Convert.ToInt32(dr["ROOM_TYPE_ID"]);
		}
	}
}