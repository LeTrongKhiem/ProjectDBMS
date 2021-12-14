using System;
using System.Data;

namespace DormitoryManagement.Model
{
	public class ProvinceDTO
	{
		public string ProvinceId { get; set; }
		public string ProvinceName { get; set; }
		public string ProvinceType { get; set; }
		public ProvinceDTO(DataRow dr)
		{
			this.ProvinceId = Convert.ToString(dr["PROVINCE_ID"]).Trim();
			this.ProvinceName = Convert.ToString(dr["PROVINCE_NAME"]).Trim();
			this.ProvinceType = Convert.ToString(dr["PROVINCE_TYPE"]).Trim();
		}
	}
}