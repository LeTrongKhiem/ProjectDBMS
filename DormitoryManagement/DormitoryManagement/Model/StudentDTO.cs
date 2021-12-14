using System;
using System.Data;

namespace DormitoryManagement.Model
{
	public class StudentDTO
	{
		public long UserId { get; set; }
		public string StudentId { get; set; }
		public int CollegeId { get; set; }
		public string Faculty { get; set; }
		public string Majors { get; set; }
		public string InsuranceId { get; set; }
		public StudentDTO(DataRow dr)
		{
			this.UserId = Convert.ToInt64(dr["USER_ID"]);
			this.StudentId = Convert.ToString(dr["STUDENT_ID"]).Trim();
			this.CollegeId = Convert.ToInt32(dr["COLLEGE_ID"]);
			this.Faculty = Convert.ToString(dr["FACULTY"]).Trim();
			this.Majors = Convert.ToString(dr["MAJORS"]).Trim();
			this.InsuranceId = Convert.ToString(dr["INSURANCE_ID"]).Trim();
		}
	}
}