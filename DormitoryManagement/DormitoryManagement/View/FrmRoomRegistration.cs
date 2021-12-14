using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DormitoryManagement.Controller;
using DormitoryManagement.Model;

namespace DormitoryManagement.View
{
    public partial class FrmRoomRegistration : Form
    {
        private UserDTO user;
        public UserDTO User
        {
            get => user;
            set
            {
                this.user = value;
            }
        }
        public FrmRoomRegistration(UserDTO user)
        {
            InitializeComponent();
            this.User = user;
            lbMaNV.Text = Convert.ToString(User.UserId);
        }

        public FrmRoomRegistration(UserDTO user, string Student_ID)
        {
            InitializeComponent();
            this.User = user;
            btnOK.Enabled = false;
            btnPrint.Enabled = false;
            btnDelete.Enabled = true;
            //tlpBottom.ColumnCount = 2;
            panel1.Enabled = false;

            //Load RoomReg Info using roomRegID
            LoadRoomRegInfo(Student_ID);
        }

        /// <summary>
        /// Load thông tin chi tiết của RoomReg dựa vào ID
        /// </summary>
        private void LoadRoomRegInfo(string Student_ID)
        {
            DataTable dt = RoomRegistrationDAO.LoadRoomRegistration(Student_ID);
            txtSSN.Text = dt.Rows[0][1].ToString();
            //cmbBuilding.Text = dt.Rows[0][]
            cmbRoom.Text = dt.Rows[0][2].ToString();
            cmbSemester.Text = dt.Rows[0][6].ToString();
            txtAcademicYear.Text = dt.Rows[0][7].ToString();
            cbbDuration.Text = dt.Rows[0][8].ToString();
            lbMaNV.Text = dt.Rows[0][3].ToString();
            DateTime daytime = Convert.ToDateTime(dt.Rows[0][5]);
            dtpStartDate.Value = daytime;
        }

        public void FillDataSector() //Load tất cả các khu phòng
        {
            List<SectorDTO> ListSector = SectorDAO.GetListSector();
            cmbBuilding.DataSource = ListSector;
            cmbBuilding.DisplayMember = "SectorName";
        }
        public void FillDataRoom() // Load tất cả các phòng
        {
            List<RoomDTO> ListRoom = RoomDAO.GetListRoom();
            cmbRoom.DataSource = ListRoom;
            cmbRoom.DisplayMember = "RoomId";
        }
        public void FillDataRoomBySector(string Sector_Name) // Load danh sách phòng theo Khu
        {
            List<RoomDTO> ListRoom = RoomDAO.GetListRoomBySector(Sector_Name);
            cmbRoom.DataSource = ListRoom;
            cmbRoom.DisplayMember = "RoomId";
        }

        private void cmbBuilding_SelectedValueChanged(object sender, EventArgs e)
        {
            string SectorName = cmbBuilding.Text.ToString();
            List<SectorDTO> ListSector = SectorDAO.GetListSector();
            for (int i = 0; i < ListSector.Count; i++)
            {
                SectorDTO Sector = ListSector[i];
                if (SectorName == Sector.SectorName)
                {
                    FillDataRoomBySector(Sector.SectorId);
                }
            }
        }

        private void FrmRoomRegistration_Load(object sender, EventArgs e)
        {

            FillDataSector();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtSSN.Text == "")
            {
                MessageBox.Show("You have not entered your identity card");
            }
            else if (cmbSemester.Text == "")
            {
                MessageBox.Show("You have not chosen a semester");
            }
            else if (txtAcademicYear.Text == "")
            {
                MessageBox.Show("You have not entered the academic year");
            }
            else if (cbbDuration.Text == "")
            {
                MessageBox.Show("You have not chosen duration");
            }
            else
            {
                long Employee_ID = User.UserId;
                string Ssn = Convert.ToString(txtSSN.Text);
                string Sector_Name = Convert.ToString(cmbBuilding.Text);
                string Room_ID = Convert.ToString(cmbRoom.Text);
                DateTime Start_Day = dtpStartDate.Value;
                int Semester = Convert.ToInt32(cmbSemester.Text);
                int Academic_Year = Convert.ToInt32(txtAcademicYear.Text);
                string Duaration = Convert.ToString(cbbDuration.Text);
                string Status = "1";
                if (AddRoomRegistration(Employee_ID, Ssn, Sector_Name, Room_ID, Start_Day, Semester, Academic_Year, Duaration, Status))
                {
                    MessageBox.Show("Registration Success");
                    btnPrint.Enabled = true;
                }
            }
        }
        bool AddRoomRegistration(long Employee_ID, string Ssn, string Sector_Name, string Room_ID, DateTime Start_Day, int Semester, int Academic_Year, string Duaration, string Status)
        {
            return RoomRegistrationDAO.AddRoomRegistration(Employee_ID, Ssn, Sector_Name, Room_ID, Start_Day, Semester, Academic_Year, Duaration, Status);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Do you want to delete this room registration? ", "Notify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                //ServiceDAO.DeleteService(txtServiceName.Text);
                //this.Dispose();
                //FrmServices a = new FrmServices();
                //a.ShowDialog();
                RoomRegistrationDAO.DeleteRoomRegistration(txtSSN.Text);
                MessageBox.Show("Deleted Successfully!");
                this.Dispose();
            }
        }
    }
}
