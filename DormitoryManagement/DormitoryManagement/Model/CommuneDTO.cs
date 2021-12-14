using System;
using System.Data;

namespace DormitoryManagement.Model
{
	public class CommuneDTO
	{
		public string CommuneId { get; set; }
		public string CommuneName { get; set; }
		public string CommuneType { get; set; }
		public string Priority { get; set; }
		public string DistrictId { get; set; }
		public CommuneDTO(DataRow dr)
		{
			this.CommuneId = Convert.ToString(dr["COMMUNE_ID"]).Trim();
			this.CommuneName = Convert.ToString(dr["COMMUNE_NAME"]).Trim();
			this.CommuneType = Convert.ToString(dr["COMMUNE_TYPE"]).Trim();
			this.Priority = Convert.ToString(dr["PRIORITY"]).Trim();
			this.DistrictId = Convert.ToString(dr["DISTRICT_ID"]).Trim();
		}
	}
}