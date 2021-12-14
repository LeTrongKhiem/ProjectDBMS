using System;
using System.Data;

namespace DormitoryManagement.Model
{
	public class PaymentDTO
	{
		public long PaymentId { get; set; }
		public long BillId { get; set; }
		public long EmployeeId { get; set; }
		public DateTime PayingDate { get; set; }
		public string Amount { get; set; }
		public PaymentDTO(DataRow dr)
		{
			this.PaymentId = Convert.ToInt64(dr["PAYMENT_ID"]);
			this.BillId = Convert.ToInt64(dr["BILL_ID"]);
			this.EmployeeId = Convert.ToInt64(dr["EMPLOYEE_ID"]);
			this.PayingDate = Convert.ToDateTime(dr["PAYING_DATE"]);
			this.Amount = Convert.ToString(dr["AMOUNT"]).Trim();
		}
	}
}