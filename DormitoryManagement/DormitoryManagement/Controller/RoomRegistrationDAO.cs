using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DormitoryManagement.Model;
using System.Data;

namespace DormitoryManagement.Controller
{
    public static class RoomRegistrationDAO
    {
        public static bool AddRoomRegistration(long Employee_ID, string Ssn, string Sector_Name, string Room_ID, DateTime Start_Day, int Semester, int Academic_Year, string Duaration, string Status)
        {
            string START_DAY = Convert.ToDateTime(Start_Day).ToString("yyyyMMdd");
            string query = string.Format("EXEC dbo.USP_INSERT_ROOMREGISTRATION @EMPLOYEE_ID = {0}," +
                                                                              "@SSN = '{1}'," +
                                                                              "@SECTOR_NAME = N'{2}', " +
                                                                              "@ROOM_ID = N'{3}'," +
                                                                              "@START_DAY = '{4}'," +
                                                                              " @SEMESTER = {5}," +
                                                                              "@ACADEMIC_YEAR ={6}," +
                                                                              "@DURATION = N'{7}', " +
                                                                              "@STATUS = {8}", Employee_ID, Ssn, Sector_Name, Room_ID,START_DAY, Semester, Academic_Year, Duaration, Status);
            int result = DataProvider.ExcuteNonQuery(query);
            return result > 0;
        }
        public static DataTable LoadRoomRegistration(string Student_ID)
        {
            string query = string.Format("EXEC dbo.USP_LoadRoomRegistrationByStudentID @Student_ID = '{0}'", Student_ID);
            DataTable dt = DataProvider.ExcuteQuery(query);
            return dt;
        }
        public static bool DeleteRoomRegistration(string SSN)
        {
            string query = string.Format("EXEC dbo.USP_UpdateRoomRegistration @Ssn = '{0}'", SSN);
            int result = DataProvider.ExcuteNonQuery(query);
            return result > 0;
        }
    }
}
