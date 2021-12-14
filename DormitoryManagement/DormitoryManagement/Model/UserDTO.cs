using System;
using System.Data;

namespace DormitoryManagement.Model
{
	public class UserDTO
	{
		public long UserId { get; set; }
		public string LastName { get; set; }
		public string FirstName { get; set; }
		public DateTime Dob { get; set; }
		public string Gender { get; set; }
		public string Ssn { get; set; }
		public long AddressId { get; set; }
		public string PhoneNumber1 { get; set; }
		public string PhoneNumber2 { get; set; }
		public string Email { get; set; }
		public string ImagePath { get; set; }
		public string Username { get; set; }
		public string Password { get; set; }
		public string UserType { get; set; }
		public bool Status { get; set; }
		public UserDTO(DataRow dr)
		{
			this.UserId = Convert.ToInt64(dr["USER_ID"]);
			this.LastName = Convert.ToString(dr["LAST_NAME"]).Trim();
			this.FirstName = Convert.ToString(dr["FIRST_NAME"]).Trim();
			this.Dob = Convert.ToDateTime(dr["DOB"]);
			this.Gender = Convert.ToString(dr["GENDER"]).Trim();
			this.Ssn = Convert.ToString(dr["SSN"]).Trim();
			this.AddressId = Convert.ToInt64(dr["ADDRESS_ID"]);
			this.PhoneNumber1 = Convert.ToString(dr["PHONE_NUMBER_1"]).Trim();
			this.PhoneNumber2 = Convert.ToString(dr["PHONE_NUMBER_2"]).Trim();
			this.Email = Convert.ToString(dr["EMAIL"]).Trim();
			this.ImagePath = Convert.ToString(dr["IMAGE_PATH"]).Trim();
			this.Username = Convert.ToString(dr["USERNAME"]).Trim();
			this.Password = Convert.ToString(dr["PASSWORD"]).Trim();
			this.UserType = Convert.ToString(dr["USER_TYPE"]).Trim();
			this.Status = Convert.ToBoolean(dr["STATUS"]);
		}
	}
}