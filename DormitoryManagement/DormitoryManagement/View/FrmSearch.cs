using DormitoryManagement.Controller;
using DormitoryManagement.Model;
using DormitoryManagement.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DormitoryManagement.View
{
    public partial class FrmSearch : Form
    {
        #region Var
        int indexSelected;
        string indexSectorIdSelected="";
        string indexRoomIdSelected="";
        string SectorNameSelected="";
        int indexSelectedRoomRegistration = 0;
        #endregion
        public FrmSearch()
        {
            InitializeComponent();
        }
        #region Events
        private void FrmSearch_Load(object sender, EventArgs e)
        {
            GetFullListStudent();
            txtInputStudent.Enabled = false;
            AutoSizeModeColumn(dgvStudent);
            //
            GetListRoomRegistration();
            AutoSizeModeColumn(dgvRoomReg);
            GetListSector();
            txtInputRoomReg.Enabled = false;
            //
            GetListBillView();
            AutoSizeModeColumn(dgvBill);
        }
        /// <summary>
        /// ---------------------------STUDENTS
        /// </summary>
        /// <param ></param>
        /// <param></param>
        private void cbbCategoryStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedItem == null)
                return;
            indexSelected = comboBox.SelectedIndex;
            switch (indexSelected)
            {
                case 0:
                    {
                        GetFullListStudent();
                        txtInputStudent.Enabled = false;
                        txtInputStudent.Text = "";
                        break;
                    }
                case 1:
                    {
                        GetFullListStudentALive();
                        txtInputStudent.Enabled = false;
                        txtInputStudent.Text = "";
                        break;
                    }
                case 2:
                    {
                        GetFullListStudentGoingOut();
                        txtInputStudent.Enabled = false;
                        txtInputStudent.Text = "";
                        break;
                    }
                default:
                    {
                        GetFullListStudent();
                        txtInputStudent.Enabled = true;
                        txtInputStudent.Text = "";
                        break;
                    }
            }
        }
        private void txtInputStudent_TextChanged(object sender, EventArgs e)
        {
            string inputText = "";
            inputText = txtInputStudent.Text.Trim().ToString();
            if (indexSelected == 3)
            {
                if (txtInputStudent.Text == "")
                {
                    GetFullListStudent();
                }
                else if (txtInputStudent.Text == "HHH")
                {
                    txtInputStudent.Text = "";
                }
                else if (FormatData.IsNumber(inputText) == true && inputText.Length < 10)
                {
                    GetFullListStudentByUserId(inputText);
                }
                else if (txtInputStudent.Text != "")
                {
                    txtInputStudent.Text = "HHH";
                }
            }
            else if (indexSelected == 4)
            {
                if (txtInputStudent.Text == "")
                {
                    GetFullListStudent();
                }
                else if (inputText.Length < 16)
                {
                    GetFullListStudentByStudentId(inputText);
                }
            }
            else if (indexSelected == 5)
            {
                if (txtInputStudent.Text == "")
                {
                    GetFullListStudent();
                }
                else if (inputText.Length < 101)
                {
                    GetFullListStudentByFullName(inputText);
                }
            }
            else if (indexSelected == 6)
            {
                if (txtInputStudent.Text == "")
                {
                    GetFullListStudent();
                }
                else if (inputText.Length < 11)
                {
                    GetFullListStudentByGender(inputText);
                }
            }
            else if (indexSelected == 7)
            {
                if (txtInputStudent.Text == "")
                {
                    GetFullListStudent();
                }
                else if (inputText.Length < 13)
                {
                    GetFullListStudentBySsn(inputText);
                }
            }
            else if (indexSelected == 8)
            {
                if (txtInputStudent.Text == "")
                {
                    GetFullListStudent();
                }
                else if (inputText.Length < 150)
                {
                    GetFullListStudentByCollege(inputText);
                }
            }
        }
        /// <summary>
        /// ---------------------------ROOM_REGISTRATION
        /// </summary>
        /// <param ></param>
        /// <param></param>

        private void cbbCategoryRoomReg_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedItem == null)
                return;
            indexSelectedRoomRegistration = comboBox.SelectedIndex;
            switch (indexSelectedRoomRegistration)
            {
                case 0:
                    {
                        GetListRoomRegistration();
                        txtInputRoomReg.Enabled = false;
                        txtInputRoomReg.Text = "";
                        break;
                    }
                case 1:
                    {
                        GetListRoomRegistration();
                        txtInputRoomReg.Enabled = true;
                        txtInputRoomReg.Text = "";
                        break;
                    }
                case 2:
                    {
                        GetListRoomRegistration();
                        txtInputRoomReg.Enabled = true;
                        txtInputRoomReg.Text = "";
                        break;
                    }
                default:
                    {
                        GetListRoomRegistration();
                        txtInputRoomReg.Text = "";
                        break;
                    }
            }
        }

        private void txtInputRoomReg_TextChanged(object sender, EventArgs e)
        {
            string inputText = "";
            inputText = txtInputRoomReg.Text.Trim().ToString();

            if (indexSelectedRoomRegistration == 0)
            {
                if (txtInputRoomReg.Text == "")
                {
                    GetListRoomRegistration();
                }
            }
            else if (indexSelectedRoomRegistration == 1)
            {
                if (txtInputRoomReg.Text == "")
                {
                    GetListRoomRegistration();
                }
                else if (inputText.Length < 16)
                {
                    GetListRoomRegistrationByStudentId(inputText);
                }
            }
            else if (indexSelectedRoomRegistration == 2)
            {
                if (txtInputRoomReg.Text == "")
                {
                    GetListRoomRegistration();
                }
                else if (inputText.Length < 101)
                {
                    GetListRoomRegistrationByStudentName(inputText);
                }
            }
        }

        private void cbbBuilding_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedItem == null)
                return;
            SectorDTO sectorDTO = (SectorDTO)comboBox.SelectedValue;
            indexSectorIdSelected = sectorDTO.SectorId;
            SectorNameSelected = sectorDTO.SectorName;
            GetListRoomBySectorId(indexSectorIdSelected);
            GetListRoomRegistrationByBuildingAndRoom(SectorNameSelected, indexRoomIdSelected);
        }

        private void cbbRoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedItem == null)
                return;
            RoomDTO roomDTO = (RoomDTO)comboBox.SelectedValue;
            indexRoomIdSelected = roomDTO.RoomId;
            GetListRoomRegistrationByBuildingAndRoom(SectorNameSelected, indexRoomIdSelected);
        }


        /// <summary>
        /// ---------------------------BILL
        /// </summary>
        /// <param ></param>
        /// <param></param>
        /// 
        private void cbbBuiding_Bill_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedItem == null)
                return;
            SectorDTO sectorDTO = (SectorDTO)comboBox.SelectedValue;
            indexSectorIdSelected = sectorDTO.SectorId;
            SectorNameSelected = sectorDTO.SectorName;
            GetListRoomBySectorId(indexSectorIdSelected);
            GetListBillViewByBuildingAndRoom(SectorNameSelected, indexRoomIdSelected);
        }
        private void cbbRoom_Bill_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = sender as ComboBox;
            if (comboBox.SelectedItem == null)
                return;
            RoomDTO roomDTO = (RoomDTO)comboBox.SelectedValue;
            indexRoomIdSelected = roomDTO.RoomId;
            GetListBillViewByBuildingAndRoom(SectorNameSelected, indexRoomIdSelected);
        }
        private void ckbPaid_CheckedChanged(object sender, EventArgs e)
        {
            GetListBillView();
            int Temp = dgvBill.Rows.Count -1;
            if (ckbPaid.Checked)
            {
                for (int i = 0; i < Temp - 1; i++)
                {
                    if (dgvBill.Rows[i].Cells[9].Value != null && (bool)dgvBill.Rows[i].Cells[9].Value != true)
                    {
                        dgvBill.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }
            else
            {
                for (int i = 0; i < Temp - 1; i++)
                {
                    if (dgvBill.Rows[i].Cells[9].Value != null && (bool)dgvBill.Rows[i].Cells[9].Value == true )
                    {
                        dgvBill.Rows.RemoveAt(i);
                        i--;
                    }
                }
            }    
        }
        private void btnSearch_Bill_Click(object sender, EventArgs e)
        {
            DateTime from = dtpFromDate.Value;
            DateTime to = dtpToDate.Value;
            int monthFrom = from.Month;
            int yearFrom = from.Year;
            int monthTo = to.Month;
            int yearTo = to.Year;
            GetListBillViewByDate(monthFrom, yearFrom, monthTo, yearTo);
        }
        #endregion

        #region Methods
        void AutoSizeModeColumn(DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.Columns.Count - 1; i++)
            {
                dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dataGridView.Columns[dataGridView.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        void GetFullListStudent()
        {
            DataTable dataTable = StudentViewDAO.GetListStudentView();
            dgvStudent.DataSource = dataTable;
        }
        void GetFullListStudentALive()
        {
            DataTable dataTable = StudentViewDAO.GetListStudentViewALive();
            dgvStudent.DataSource = dataTable;
        }
        void GetFullListStudentGoingOut()
        {
            DataTable dataTable = StudentViewDAO.GetListStudentViewGoingOut();
            dgvStudent.DataSource = dataTable;
        }
        void GetFullListStudentByUserId(string userId)
        {
            DataTable dataTable = StudentViewDAO.SearchStudentViewByUserId(userId);
            dgvStudent.DataSource = dataTable;
        }
        void GetFullListStudentByStudentId(string studentId)
        {
            DataTable dataTable = StudentViewDAO.SearchStudentViewByStudentId(studentId);
            dgvStudent.DataSource = dataTable;
        }
        void GetFullListStudentByFullName(string fullName)
        {
            DataTable dataTable = StudentViewDAO.SearchStudentViewByFullName(fullName);
            dgvStudent.DataSource = dataTable;
        }
        void GetFullListStudentByGender(string gender)
        {
            DataTable dataTable = StudentViewDAO.SearchStudentViewByGender(gender);
            dgvStudent.DataSource = dataTable;
        }
        void GetFullListStudentBySsn(string ssn)
        {
            DataTable dataTable = StudentViewDAO.SearchStudentViewBySsn(ssn);
            dgvStudent.DataSource = dataTable;
        }
        void GetFullListStudentByCollege(string college)
        {
            DataTable dataTable = StudentViewDAO.SearchStudentViewByCollege(college);
            dgvStudent.DataSource = dataTable;
        }
        /// <summary>
        /// ---------------------------ROOM_REGISTRATION
        /// </summary>
        /// <param ></param>
        /// <param></param>
        void GetListRoomRegistration()
        {
            DataTable dataTable = RoomDAO.GetListRoomRegistration();
            dgvRoomReg.DataSource = dataTable;
        }
        void GetListSector()
        {
            List<SectorDTO> sectorDTOs = SectorDAO.GetListSector();
            cbbBuilding.DataSource = sectorDTOs;
            cbbBuilding.DisplayMember = "SectorName";
            cbbBuiding_Bill.DataSource = sectorDTOs;
            cbbBuiding_Bill.DisplayMember = "SectorName";
        }
        void GetListRoomBySectorId(string SectorId)
        {
            List<RoomDTO> roomDTOs = RoomDAO.GetListRoomBySector(SectorId);
            cbbRoom.DataSource = roomDTOs;
            cbbRoom.DisplayMember = "RoomId";
            cbbRoom_Bill.DataSource = roomDTOs;
            cbbRoom_Bill.DisplayMember = "RoomId";
        }
        void GetListRoomRegistrationByStudentId(string studentId)
        {
            DataTable dataTable = RoomDAO.GetListRoomRegistrationByStudentId(studentId);
            dgvRoomReg.DataSource = dataTable;
        }
        void GetListRoomRegistrationByStudentName(string studentName)
        {
            DataTable dataTable = RoomDAO.GetListRoomRegistrationByStudentName(studentName);
            dgvRoomReg.DataSource = dataTable;
        }
        void GetListRoomRegistrationByBuildingAndRoom(string building, string room)
        {
            DataTable dataTable = RoomDAO.GetListRoomRegistrationByBuldingAndRoom(building,room);
            dgvRoomReg.DataSource = dataTable;
        }

        /// <summary>
        /// ---------------------------BILL
        /// </summary>
        /// <param ></param>
        /// <param></param>
        void GetListBillView()
        {
            DataTable dataTable = BillDAO.GetListBillView();
            dgvBill.DataSource = dataTable;
        }
        void GetListBillViewByBuildingAndRoom(string building, string room)
        {
            DataTable dataTable = BillDAO.GetListBillViewByBuldingAndRoom(building, room);
            dgvBill.DataSource = dataTable;
        }
        void GetListBillViewByDate(int monthFrom, int yearFrom, int monthTo, int yearTo)
        {

            DataTable dataTable = BillDAO.GetListBillViewByDate(monthFrom, yearFrom, monthTo, yearTo);
            dgvBill.DataSource = dataTable;
        }



        #endregion

        private void dgvRoomReg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index = dgvRoomReg.CurrentCell.RowIndex;
                //string id = Convert.ToString(selectedRow.Cells["Id"].Value);
                string Student_ID = Convert.ToString(dgvRoomReg.Rows[index].Cells[3].Value);
                /*string building = Convert.ToString(selectedRow.Cells["Building"].Value);
                string room = Convert.ToString(selectedRow.Cells["Room"].Value);
                DateTime startDate = Convert.ToDateTime(selectedRow.Cells["Start date"].Value);
                string duration = Convert.ToString(selectedRow.Cells["Duration"].Value);
                string empID = Convert.ToString(selectedRow.Cells["Employee Id"].Value);
                string createdDate = Convert.ToString(selectedRow.Cells["Created Date"].Value);
                string semester = Convert.ToString(selectedRow.Cells["Semester"].Value);
                string academicYear = Convert.ToString(selectedRow.Cells["Academic year"].Value);*/

                FrmRoomRegistration frmRoomRegInfo = new FrmRoomRegistration(Dashboard.User, Student_ID);
                frmRoomRegInfo.ShowDialog();
                GetListRoomRegistration();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
