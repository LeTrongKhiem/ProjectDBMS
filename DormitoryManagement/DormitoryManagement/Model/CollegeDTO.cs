using System;
using System.Data;

namespace DormitoryManagement.Model
{
	public class CollegeDTO
	{
		public int CollegeId { get; set; }
		public string CollegeCode { get; set; }
		public string CollegeName { get; set; }
		public CollegeDTO(DataRow dr)
		{
			this.CollegeId = Convert.ToInt32(dr["COLLEGE_ID"]);
			this.CollegeCode = Convert.ToString(dr["COLLEGE_CODE"]).Trim();
			this.CollegeName = Convert.ToString(dr["COLLEGE_NAME"]).Trim();
		}
	}
}