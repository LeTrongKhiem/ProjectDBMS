using System;
using System.Data;

namespace DormitoryManagement.Model
{
	public class DistrictDTO
	{
		public string DistrictId { get; set; }
		public string DistrictName { get; set; }
		public string DistrictType { get; set; }
		public string ProvinceId { get; set; }
		public DistrictDTO(DataRow dr)
		{
			this.DistrictId = Convert.ToString(dr["DISTRICT_ID"]).Trim();
			this.DistrictName = Convert.ToString(dr["DISTRICT_NAME"]).Trim();
			this.DistrictType = Convert.ToString(dr["DISTRICT_TYPE"]).Trim();
			this.ProvinceId = Convert.ToString(dr["PROVINCE_ID"]).Trim();
		}
	}
}