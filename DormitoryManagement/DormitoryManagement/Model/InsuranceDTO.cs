using System;
using System.Data;

namespace DormitoryManagement.Model
{
	public class InsuranceDTO
	{
		public string InsuranceId { get; set; }
		public string BasePractice { get; set; }
		public DateTime RegistrationDate { get; set; }
		public int Duration { get; set; }
		public InsuranceDTO(DataRow dr)
		{
			this.InsuranceId = Convert.ToString(dr["INSURANCE_ID"]).Trim();
			this.BasePractice = Convert.ToString(dr["BASE_PRACTICE"]).Trim();
			this.RegistrationDate = Convert.ToDateTime(dr["REGISTRATION_DATE"]);
			this.Duration = Convert.ToInt32(dr["DURATION"]);
		}
	}
}