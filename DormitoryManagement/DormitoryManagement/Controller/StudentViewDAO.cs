using DormitoryManagement.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryManagement.Controller
{
    public class StudentViewDAO
    {
        public static DataTable GetListStudentView()
        {
            string query = string.Format("EXEC dbo.USP_GetListStudentGeneral");
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            return dataTable;
        }
        public static DataTable GetListStudentViewALive()
        {
            string query = string.Format("EXEC dbo.USP_GetListStudentGeneralALive");
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            return dataTable;
        }
        public static DataTable GetListStudentViewGoingOut()
        {
            string query = string.Format("EXEC dbo.USP_GetListStudentGeneralGoingOut");
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            return dataTable;
        }
        public static DataTable SearchStudentViewByUserId(string userId)
        {
            string query = string.Format("EXEC dbo.USP_GetListStudentGeneralByUserId @USER_ID = '{0}'", userId);
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            return dataTable;
        }
        public static DataTable SearchStudentViewByStudentId(string studentId)
        {
            string query = string.Format("EXEC dbo.USP_GetListStudentGeneralByStudentId @STUDENT_ID = '{0}'", studentId);
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            return dataTable;

        }
        public static DataTable SearchStudentViewByFullName(string fullName)
        {
            string query = string.Format("EXEC dbo.USP_GetListStudentGeneralByFullName @FULL_NAME = N'{0}'", fullName);
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            return dataTable;

        }
        public static DataTable SearchStudentViewByGender(string gender)
        {
            string query = string.Format("EXEC dbo.USP_GetListStudentGeneralByGender @GENDER = N'{0}'", gender);
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            return dataTable;

        }
        public static DataTable SearchStudentViewBySsn(string ssn)
        {
            string query = string.Format("EXEC dbo.USP_GetListStudentGeneralBySsn @SSN = '{0}'", ssn);
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            return dataTable;

        }
        public static DataTable SearchStudentViewByCollege(string college)
        {
            string query = string.Format("EXEC dbo.USP_GetListStudentGeneralByCollegeName @COLLEGE_NAME = N'{0}'", college);
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            return dataTable;
        }
        public static DataTable GetStudentInfo(string SSN)
        {
            string query = string.Format("EXEC dbo.USP_GetStudentInfo @SSN = '{0}'", SSN);
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            return dataTable;
        }
    }
}
