using System;
using System.Data;

namespace DormitoryManagement.Model
{
	public class AddressDTO
	{
		public long AddressId { get; set; }
		public string Street { get; set; }
		public string CommnuneId { get; set; }
		public string DistrictId { get; set; }
		public string ProvinceId { get; set; }
		public AddressDTO(DataRow dr)
		{
			this.AddressId = Convert.ToInt64(dr["ADDRESS_ID"]);
			this.Street = Convert.ToString(dr["STREET"]).Trim();
			this.CommnuneId = Convert.ToString(dr["COMMNUNE_ID"]).Trim();
			this.DistrictId = Convert.ToString(dr["DISTRICT_ID"]).Trim();
			this.ProvinceId = Convert.ToString(dr["PROVINCE_ID"]).Trim();
		}
	}
}