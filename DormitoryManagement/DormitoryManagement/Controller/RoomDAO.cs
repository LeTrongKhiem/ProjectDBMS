using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DormitoryManagement.Model;

namespace DormitoryManagement.Controller
{
    public static class RoomDAO
    {
        public static List<RoomDTO> GetListRoom()
        {
            string query = string.Format("EXEC dbo.USP_GetListRoom");
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            List<RoomDTO> ListRoom = new List<RoomDTO>();
            foreach (DataRow item in dataTable.Rows)
            {
                RoomDTO Room = new RoomDTO(item);
                ListRoom.Add(Room);
            }
            return ListRoom;
        }
        public static List<RoomDTO> GetListRoomBySector(string Sector_ID)
        {
            string query = string.Format("EXEC dbo.USP_GetListRoomBySectorID @Sector_ID = {0}", Sector_ID);
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            List<RoomDTO> ListRoom = new List<RoomDTO>();
            foreach (DataRow item in dataTable.Rows)
            {
                RoomDTO Room = new RoomDTO(item);
                ListRoom.Add(Room);
            }
            return ListRoom;
        }
        public static DataTable GetListRoomRegistration() 
        {
            string query = string.Format("EXEC dbo.USP_GetListRoomRegistration");
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            return dataTable;
        }
        public static DataTable GetListRoomRegistrationByStudentId(string studentId)
        {
            string query = string.Format("EXEC dbo.USP_GetListRoomRegistrationByStudentId @STUDENT_ID = '{0}'",studentId);
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            return dataTable;
        }
        public static DataTable GetListRoomRegistrationByStudentName(string studentName)
        {
            string query = string.Format("EXEC dbo.USP_GetListRoomRegistrationByStudentName @STUDENT_NAME = N'{0}'", studentName);
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            return dataTable;
        }
        public static DataTable GetListRoomRegistrationByBuldingAndRoom(string bulding, string room)
        {
            string query = string.Format("EXEC dbo.USP_GetListRoomRegistrationBySectorAndRoom @SECTOR_NAME = N'{0}', @ROOM_ID = N'{1}'", bulding,room);
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            return dataTable;
        }
        public static DataTable GetListRoomView()
        {
            string query = string.Format("EXEC dbo.USP_GetListRoomView");
            DataTable dataTable = DataProvider.ExcuteQuery(query);
            return dataTable;
        }
    }
}
