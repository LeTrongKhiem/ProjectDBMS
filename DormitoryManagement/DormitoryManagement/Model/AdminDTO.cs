using System;
using System.Data;

namespace DormitoryManagement.Model
{
	public class AdminDTO
	{
		public long UserId { get; set; }
		public AdminDTO(DataRow dr)
		{
			this.UserId = Convert.ToInt64(dr["USER_ID"]);
		}
	}
}