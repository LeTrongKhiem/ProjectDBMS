using System;
using System.Data;

namespace DormitoryManagement.Model
{
	public class SectorDTO
	{
		public string SectorId { get; set; }
		public string SectorName { get; set; }
		public SectorDTO(DataRow dr)
		{
			this.SectorId = Convert.ToString(dr["SECTOR_ID"]).Trim();
			this.SectorName = Convert.ToString(dr["SECTOR_NAME"]).Trim();
		}
	}
}