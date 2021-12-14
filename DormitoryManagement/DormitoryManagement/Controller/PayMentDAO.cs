using System;

namespace DormitoryManagement.Controller
{
   public static class PayMentDAO
   {
      public static bool AddPayMent(string Employee_ID, DateTime Paying_Date, Decimal Amount, string Sector_Name, string Room_ID, string Month, string Year)
      {
         string PAYINGDAY = Convert.ToDateTime(Paying_Date).ToString("yyyyMMdd");
         string query = string.Format("EXEC dbo.USP_INSERT_PAYMENT @Employee_ID = {0}," +
                                                                  "@Paying_Date = '{1}', " +
                                                                  "@Amount = {2}," +
                                                                  "@Sector_Name = '{3}'," +
                                                                  "@Room_ID = N'{4}', " +
                                                                  "@Month = {5}," +
                                                                  "@Year = {6}", Employee_ID, PAYINGDAY, Amount, Sector_Name, Room_ID, Month, Year);
         int result = DataProvider.ExcuteNonQuery(query);
         return result > 0;
      }
   }
}