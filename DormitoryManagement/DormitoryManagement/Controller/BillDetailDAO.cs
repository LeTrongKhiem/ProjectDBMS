using DormitoryManagement.Model;
using System.Collections.Generic;
using System.Data;

namespace DormitoryManagement.Controller
{
   public static class BillDetailDAO
   {
      public static bool AddDetailBill(string Service_Name, string Quantity, string Sector_Name, string Room_ID, string Month, string Year, string Unit_Name, string Total_Cost_Per_Service)
      {
         string query = string.Format("EXEC dbo.USP_INSERT_SERVICE_BILL_DETAIL @Service_Name = N'{0}', " +
                                                                              "@Quantity = {1}," +
                                                                              "@Sector_Name = N'{2}'," +
                                                                              "@Room_ID = N'{3}', " +
                                                                              "@Month = {4}," +
                                                                              "@Year = {5}," +
                                                                              "@Unit_Name = {6}," +
                                                                              "@Total_Cost = {7}", Service_Name, Quantity, Sector_Name, Room_ID, Month, Year, Unit_Name, Total_Cost_Per_Service);
         int result = DataProvider.ExcuteNonQuery(query);
         return result > 0;
      }

      public static List<BillDetailDTO> GetViewBillDetail(string Sector_Name, string Room_ID, string Month, string Year)
      {
         string query = string.Format("SELECT * FROM dbo.UFN_ReturnForViewBillDetail(N'{0}', '{1}', {2}, {3})", Sector_Name, Room_ID, Month, Year);
         DataTable dataTable = DataProvider.ExcuteQuery(query);
         List<BillDetailDTO> ListService = new List<BillDetailDTO>();
         foreach (DataRow item in dataTable.Rows)
         {
            BillDetailDTO temp = new BillDetailDTO(item);
            ListService.Add(temp);
         }
         return ListService;
      }
   }
}