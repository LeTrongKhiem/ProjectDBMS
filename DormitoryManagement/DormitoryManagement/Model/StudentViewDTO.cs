using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryManagement.Model
{
	public class StudentViewDTO
	{
		public long UserId { get; set; }
		public string StudentId { get; set; }
		public string FullName { get; set; }
		public string Gender { get; set; }
		public DateTime Dob { get; set; }
		public string Ssn { get; set; }
		public string PhoneNumber { get; set; }
		public string Email { get; set; }
		public string College { get; set; }

		public StudentViewDTO(DataRow dr)
		{
			this.UserId = Convert.ToInt64(dr["Id"]);
			this.StudentId = Convert.ToString(dr["Student Id"]).Trim();
			this.FullName = Convert.ToString(dr["Full name"]).Trim();
			this.Gender = Convert.ToString(dr["Gender"]).Trim();
			this.Dob = Convert.ToDateTime(dr["Date of birth"]);
			this.Ssn = Convert.ToString(dr["SSN"]).Trim();
			this.PhoneNumber = Convert.ToString(dr["Phone number"]).Trim();
			this.Email = Convert.ToString(dr["Email"]).Trim();
			this.College = Convert.ToString(dr["College"]).Trim();
		}
	}
}

