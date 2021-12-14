using DormitoryManagement.Model;
using System.Drawing;
using System.Windows.Forms;

namespace DormitoryManagement.View
{
    public static class Dashboard
    {
        #region Fields
        private static UserDTO user;
        private static StudentDTO student;
        private static AdminDTO admin;
        private static EmployeeDTO employee;
        #endregion

        #region Properties
        public static UserDTO User { get => user; set => user = value; }
        public static StudentDTO Student { get => student; set => student = value; }
        public static AdminDTO Admin { get => admin; set => admin = value; }
        public static EmployeeDTO Employee { get => employee; set => employee = value; }
        #endregion

        #region Init

        #region General
        public static Item InitLogin(Form frm)
        {
            Item ctrlLogin = new Item(Login, frm);
            ctrlLogin.picItem.BackgroundImage = Properties.Resources.Logout;
            ctrlLogin.btnTitle.Text = "LOGIN";
            return ctrlLogin;
        }

        public static Item InitLogout(Form frm)
        {
            Item ctrlLogout = new Item(Dashboard.Logout, frm);
            ctrlLogout.picItem.BackgroundImage = Properties.Resources.Logout;
            ctrlLogout.btnTitle.Text = "LOGOUT";
            return ctrlLogout;
        }

        public static Item InitChangePassword(UserDTO user)
        {
            User = user;
            Item ctrlChangePassword = new Item(Dashboard.ChangePassword);
            ctrlChangePassword.picItem.BackgroundImage = Properties.Resources.ForgotPassword;
            ctrlChangePassword.btnTitle.Text = "CHANGE";
            return ctrlChangePassword;
        }

        public static Item InitChangePassword(object account)
        {
            Item ctrlChangePassword = new Item(Dashboard.ChangePassword);
            ctrlChangePassword.picItem.BackgroundImage = Properties.Resources.ForgotPassword;
            ctrlChangePassword.btnTitle.Text = "CHANGE";
            return ctrlChangePassword;
        }

        public static Item InitExit()
        {
            Item ctrlExit = new Item(Dashboard.Exit);
            ctrlExit.picItem.BackgroundImage = Properties.Resources.Cancel;
            ctrlExit.btnTitle.Text = "EXIT";
            return ctrlExit;
        }
        #endregion

        #region Add

        public static Item InitRoom(UserDTO user)
        {
            User = user;
            Item ctrlRoom = new Item(Dashboard.Room);
            ctrlRoom.picItem.BackgroundImage = Properties.Resources.BunkBed;
            ctrlRoom.btnTitle.Text = "ROOM";
            return ctrlRoom;
        }

        public static Item InitBill(UserDTO user)
        {
            User = user;
            Item ctrlBill = new Item(Dashboard.Bill);
            ctrlBill.picItem.BackgroundImage = Properties.Resources.Form;
            ctrlBill.btnTitle.Text = "BILL";
            return ctrlBill;
        }

        public static Item InitAddStudent()
        {
            Item ctrlAddStudent = new Item(Dashboard.StudentInfo);
            ctrlAddStudent.picItem.BackgroundImage = Properties.Resources.Student;
            ctrlAddStudent.btnTitle.Text = "STUDENT";
            return ctrlAddStudent;
        }

        public static Item InitEmployeeInfo(AdminDTO admin, UserDTO user)
        {
            Admin = admin;
            User = user;
            Item ctrlEmployee = new Item(Dashboard.EmployeeInfo);
            ctrlEmployee.picItem.BackgroundImage = Properties.Resources.Employee;
            ctrlEmployee.btnTitle.Text = "ABOUT";
            return ctrlEmployee;
        }
        public static Item InitEmployeeInfo(EmployeeDTO employee, UserDTO user)
        {
            Employee = employee;
            User = user;
            Item ctrlEmployee = new Item(Dashboard.EmployeeInfo);
            ctrlEmployee.picItem.BackgroundImage = Properties.Resources.Employee;
            ctrlEmployee.btnTitle.Text = "ABOUT";
            return ctrlEmployee;
        }
        public static Item InitAddEmployee()
        {
            Item ctrlAddEmployee = new Item(Dashboard.AddEmployee);
            ctrlAddEmployee.picItem.BackgroundImage = Properties.Resources.Employee;
            ctrlAddEmployee.btnTitle.Text = "EMPLOYEE";
            return ctrlAddEmployee;
        }

        public static Item InitRoomRegistration()
        {
            Item ctrlRoomRegistration = new Item(Dashboard.RoomRegistration);
            ctrlRoomRegistration.picItem.BackgroundImage = Properties.Resources.Room;
            ctrlRoomRegistration.btnTitle.Text = "ROOM";
            return ctrlRoomRegistration;
        }

        #endregion

        #region Information

        #region Persional Information
        public static Item InitStudentInfo(StudentDTO student, UserDTO user)
        {
            Student = student;
            User = user;
            Item ctrlStudentInfo = new Item(Dashboard.StudentInfo);
            ctrlStudentInfo.ImageItem = Properties.Resources.Student;
            ctrlStudentInfo.Title = "INFORMATION";
            return ctrlStudentInfo;
        }
        #endregion

        public static Item InitListEmployees()
        {
            Item ctrlListEmployees = new Item(Dashboard.ListEmployees);
            ctrlListEmployees.ImageItem = Properties.Resources.Collaboration;
            ctrlListEmployees.Title = "EMPLOYEES";
            return ctrlListEmployees;
        }

        public static Item InitListStudents(UserDTO user)
        {
            User = user;
            Item ctrlListStudents = new Item(Dashboard.ListStudents);
            ctrlListStudents.ImageItem = Properties.Resources.Student;
            ctrlListStudents.Title = "STUDENTS";
            return ctrlListStudents;
        }

        public static Item InitSearch()
        {
            Item ctrlSearch = new Item(Dashboard.Search);
            ctrlSearch.ImageItem = Properties.Resources.Search;
            ctrlSearch.Title = "SEARCH";
            return ctrlSearch;
        }

        public static Item InitReport()
        {
            Item ctrlReport = new Item(Dashboard.Report);
            ctrlReport.ImageItem = Properties.Resources.Report;
            ctrlReport.Title = "REPORT";
            return ctrlReport;
        }

        public static Item InitListBuildings()
        {
            Item ctrlBuildings = new Item(Dashboard.ListBuildings);
            ctrlBuildings.ImageItem = Properties.Resources.Building;
            ctrlBuildings.Title = "BUILDINGS";
            return ctrlBuildings;
        }

        public static Item InitListRoomType()
        {
            Item ctrlRoomType = new Item(Dashboard.ListRoomTypes);
            ctrlRoomType.ImageItem = Properties.Resources.BunkBed;
            ctrlRoomType.Title = "ROOM TYPES";
            return ctrlRoomType;
        }

        public static Item InitListServices()
        {
            Item ctrlServices = new Item(Dashboard.ListServices);
            ctrlServices.ImageItem = Properties.Resources.Water;
            ctrlServices.Title = "SERVICES";
            return ctrlServices;
        }

        public static Item InitGuide()
        {
            Item ctrlGuide = new Item(Dashboard.Guide);
            ctrlGuide.ImageItem = Properties.Resources.Info;
            ctrlGuide.Title = "GUIDE";
            return ctrlGuide;
        }
        #endregion

        #endregion
        
        #region Delegate method

        #region General
        public static void Login(object frm)
        {
            FrmLogin frmLogin = new FrmLogin();
            ((Form)frm).Hide();
            frmLogin.ShowDialog();
            if (frm is Form f && f.IsDisposed != true) { f.Show(); }
        }

        public static void Logout(object frm)
        {
            DialogResult re = MessageBox.Show("Bạn muốn đăng xuất khỏi phần mềm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                ((Form)frm).Dispose();
                DatabaseConnection.SetDefault();
            }
        }

        public static void ChangePassword()
        {
            FrmChangePassword changePassword = new FrmChangePassword(User);
            changePassword.ShowDialog();
        }

        public static void ChangePassword(object account)
        {
            FrmChangePassword changePassword = new FrmChangePassword(User);
            changePassword.ShowDialog();
        }

        public static void Exit()
        {
            DialogResult re = MessageBox.Show("Bạn muốn thoát khỏi phần mềm?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        #endregion

        #region Add
        public static void Bill()
        {
            FrmBill frmBill = new FrmBill(User);
            frmBill.tlpBottom.ColumnCount = 2;
            frmBill.btnDelete.Visible = false;
            frmBill.ShowDialog();
        }

        public static void RoomRegInfo()
        {
            FrmRoomRegistration frmRoomRegInfo = new FrmRoomRegistration(User);
            frmRoomRegInfo.ShowDialog();
        }

        public static void RoomRegistration()
        {
            FrmRoomRegistration frmRoomRegistration = new FrmRoomRegistration(User);
            frmRoomRegistration.btnDelete.Visible = false;
            frmRoomRegistration.btnPrint.Enabled = false;
            frmRoomRegistration.tlpBottom.ColumnCount = 2;
            frmRoomRegistration.ShowDialog();
        }

        public static void AddEmployee()
        {
            FrmEmployeeInfo frmAddEmployee = new FrmEmployeeInfo(Employee, User);
            frmAddEmployee.btnDelete.Visible = false;
            frmAddEmployee.btnEdit.Visible = false;
            frmAddEmployee.btnSave.Visible = true;
            frmAddEmployee.IsOnlyViewInfo = false;
            frmAddEmployee.tlpBottom.ColumnCount = 1;
            frmAddEmployee.ShowDialog();
        }

        public static void EmployeeInfo()
        {
            FrmEmployeeInfo frmEmployeeInfo = new FrmEmployeeInfo(Employee,User);
            frmEmployeeInfo.btnDelete.Visible = false;
            frmEmployeeInfo.btnSave.Enabled = false;
            frmEmployeeInfo.IsOnlyViewInfo = true;
            frmEmployeeInfo.tlpBottom.ColumnCount = 2;
            frmEmployeeInfo.ShowDialog();
        }
        #endregion

        #region Information

        #region Persional Information
        public static void StudentInfo()
        {
            FrmStudentInfo frmStudentInfo = new FrmStudentInfo(Student, User);
            frmStudentInfo.ShowDialog();
        }
        #endregion

        public static void Room()
        {
            FrmRoom frmRoom = new FrmRoom();
            frmRoom.ShowDialog();
        }

        public static void ListEmployees()
        {
            FrmListEmployees frmListEmployees = new FrmListEmployees();
            frmListEmployees.ShowDialog();
        }
        public static void ListStudents()
        {
            FrmListStudents frmListStudents = new FrmListStudents(User);
            frmListStudents.ShowDialog();
        }

        public static void ListServices()
        {
            FrmServices frmServices = new FrmServices(User);
            
            if (User == null)
            {
                frmServices.dgvServices.Enabled = false;
                frmServices.btnAdd.Visible = false;
            }    
            frmServices.ShowDialog();
        }

        public static void ListBuildings()
        {
            FrmBuildings frmBuildings = new FrmBuildings();
            frmBuildings.ShowDialog();
        }

        public static void ListRoomTypes()
        {
            FrmRoomTypes frmRoomTypes = new FrmRoomTypes();
            frmRoomTypes.ShowDialog();
        }

        public static void Guide()
        {
            FrmGuide frmGuide = new FrmGuide();
            frmGuide.ShowDialog();
        }

        public static void Search()
        {
            FrmSearch search = new FrmSearch();
            search.ShowDialog();
        }

        public static void Report()
        {
            FrmReport report = new FrmReport();
            report.ShowDialog();
        }
        #endregion

        #endregion
    }
}
