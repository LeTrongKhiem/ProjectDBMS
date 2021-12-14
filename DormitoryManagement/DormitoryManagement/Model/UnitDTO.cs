using System;
using System.Data;

namespace DormitoryManagement.Model
{
	public class UnitDTO
	{
		public int UnitId { get; set; }
		public string UnitName { get; set; }
		public UnitDTO(DataRow dr)
		{
			this.UnitId = Convert.ToInt32(dr["UNIT_ID"]);
			this.UnitName = Convert.ToString(dr["UNIT_NAME"]).Trim();
		}
	}
}