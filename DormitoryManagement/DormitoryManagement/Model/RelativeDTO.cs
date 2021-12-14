using System;
using System.Data;

namespace DormitoryManagement.Model
{
	public class RelativeDTO
	{
		public long UserId { get; set; }
		public long RelativeUserId { get; set; }
		public string Relationship { get; set; }
		public RelativeDTO(DataRow dr)
		{
			this.UserId = Convert.ToInt64(dr["USER_ID"]);
			this.RelativeUserId = Convert.ToInt64(dr["RELATIVE_USER_ID"]);
			this.Relationship = Convert.ToString(dr["RELATIONSHIP"]).Trim();
		}
	}
}