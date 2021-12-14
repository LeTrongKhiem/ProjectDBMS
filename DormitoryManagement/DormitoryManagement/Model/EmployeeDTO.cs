using System;
using System.Data;

namespace DormitoryManagement.Model
{
	public class EmployeeDTO
	{
		public long UserId { get; set; }
		public long ManagerId { get; set; }
		public DateTime StartDate { get; set; }
		public string Salary { get; set; }
		public EmployeeDTO(DataRow dr)
		{
			this.UserId = Convert.ToInt64(dr["USER_ID"]);
			//this.ManagerId = Convert.ToInt64(dr["MANAGER_ID"]);
			this.StartDate = Convert.ToDateTime(dr["START_DATE"]);
			this.Salary = Convert.ToString(dr["SALARY"]).Trim();
		}
	}
}