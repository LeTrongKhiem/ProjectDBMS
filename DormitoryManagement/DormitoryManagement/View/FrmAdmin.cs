using DormitoryManagement.Model;
using System.Windows.Forms;

namespace DormitoryManagement.View
{
    public partial class FrmAdmin : Form
    {
        #region Fields
        private Item ctrlLogout;
        private Item ctrlChangePassword;
        private Item ctrlExit;
        private Item ctrlAdminInfo;
        private Item ctrlBuildings;
        private Item ctrlRoomType;
        private Item ctrlServices;
        private Item ctrlSearch;
        private Item ctrlGuide;
        private Item ctrlListStudents;
        private Item ctrlListEmployees;
        private Item ctrlRoom;
        private Item ctrlBill;
        private Item ctrlAddStudent;
        private Item ctrlAddEmployee;
        private Item ctrlRoomRegistration;
        private Item ctrlReport;
        private AdminDTO loginAdmin;
        private UserDTO loginUser;
        #endregion

        #region Properties
        public Item CtrlLogout { get => ctrlLogout; set => ctrlLogout = value; }
        public Item CtrlExit { get => ctrlExit; set => ctrlExit = value; }
        protected Item CtrlBuildings { get => ctrlBuildings; set => ctrlBuildings = value; }
        protected Item CtrlRoomType { get => ctrlRoomType; set => ctrlRoomType = value; }
        protected Item CtrlServices { get => ctrlServices; set => ctrlServices = value; }
        protected Item CtrlGuide { get => ctrlGuide; set => ctrlGuide = value; }
        public Item CtrlListStudents { get => ctrlListStudents; set => ctrlListStudents = value; }
        public Item CtrlRoom { get => ctrlRoom; set => ctrlRoom = value; }
        public Item CtrlBill { get => ctrlBill; set => ctrlBill = value; }
        public Item CtrlListEmployees { get => ctrlListEmployees; set => ctrlListEmployees = value; }
        public Item CtrlAddStudent { get => ctrlAddStudent; set => ctrlAddStudent = value; }
        public Item CtrlReport { get => ctrlReport; set => ctrlReport = value; }
        public Item CtrlAddEmployee { get => ctrlAddEmployee; set => ctrlAddEmployee = value; }
        public Item CtrlRoomRegistration { get => ctrlRoomRegistration; set => ctrlRoomRegistration = value; }
        public Item CtrlChangePassword { get => ctrlChangePassword; set => ctrlChangePassword = value; }
        public AdminDTO LoginAdmin
        {
            get => loginAdmin;
            set
            {
                this.loginAdmin = value;
            }
        }
        public UserDTO LoginUser
        {
            get => loginUser;
            set
            {
                this.loginUser = value;
            }
        }

        public Item CtrlSearch { get => ctrlSearch; set => ctrlSearch = value; }
        public Item CtrlAdminInfo { get => ctrlAdminInfo; set => ctrlAdminInfo = value; }
        #endregion

        public FrmAdmin(AdminDTO admin, UserDTO user)
        {
            this.InitializeComponent();
            this.LoginAdmin = admin;
            this.LoginUser = user;
            Init();
        }
        
        #region Events

        #endregion

        #region Methods
        protected void Init()
        {
            #region Management
            //Logout
            CtrlLogout = Dashboard.InitLogout(this);
            tlpManage.Controls.Add(CtrlLogout);
            //Change password
            CtrlChangePassword = Dashboard.InitChangePassword(LoginUser);
            tlpManage.Controls.Add(CtrlChangePassword);
            //Exit
            CtrlExit = Dashboard.InitExit();
            tlpManage.Controls.Add(CtrlExit);
            //About Employee
            CtrlAdminInfo = Dashboard.InitEmployeeInfo(LoginAdmin,LoginUser);
            tlpManage.Controls.Add(CtrlAdminInfo);
            #endregion

            #region Information
            //List Employees
            CtrlListEmployees = Dashboard.InitListEmployees();
            tlpInfo.Controls.Add(CtrlListEmployees);
            //List Students
            CtrlListStudents = Dashboard.InitListStudents(LoginUser);
            tlpInfo.Controls.Add(CtrlListStudents);
            //Report
            CtrlReport = Dashboard.InitReport();
            tlpInfo.Controls.Add(CtrlReport);
            //List Buildings
            CtrlBuildings = Dashboard.InitListBuildings();
            tlpInfo.Controls.Add(CtrlBuildings);
            //List RoomType
            CtrlRoomType = Dashboard.InitListRoomType();
            tlpInfo.Controls.Add(CtrlRoomType);
            //List Services
            CtrlServices = Dashboard.InitListServices();
            tlpInfo.Controls.Add(CtrlServices);
            //Search
            CtrlSearch = Dashboard.InitSearch();
            tlpInfo.Controls.Add(CtrlSearch);
            //Guide
            CtrlGuide = Dashboard.InitGuide();
            tlpInfo.Controls.Add(CtrlGuide);
            #endregion

            #region Add
            //Room Registration
            CtrlRoomRegistration = Dashboard.InitRoomRegistration();
            tlpAdd.Controls.Add(CtrlRoomRegistration);
            //Bill
            CtrlBill = Dashboard.InitBill(LoginUser);
            tlpAdd.Controls.Add(CtrlBill);
            //Add Student
            CtrlAddStudent = Dashboard.InitAddStudent();
            tlpAdd.Controls.Add(CtrlAddStudent);
            //Add Employee
            CtrlAddEmployee = Dashboard.InitAddEmployee();
            tlpAdd.Controls.Add(CtrlAddEmployee);
            #endregion
        }
        #endregion

    }
}
