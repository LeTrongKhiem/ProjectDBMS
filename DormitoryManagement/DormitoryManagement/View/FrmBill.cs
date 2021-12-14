using DormitoryManagement.Controller;
using DormitoryManagement.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace DormitoryManagement.View
{
    public partial class FrmBill : Form
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

        public FrmBill(UserDTO user)
        {
            InitializeComponent();
            this.User = user;
        }

        public FrmBill(UserDTO user, string billID)
        {
            InitializeComponent();
            this.User = user;
            LoadBill(billID);
        }

        #region FillDaTa
        /// <summary>
        /// Load thông tin của Bill nhờ vào id của Bill
        /// </summary>
        /// <param name="id"></param>
        private void LoadBill(string id)
        {
            
        }


        public void FillDataServiceUnit() //Load tất cả các Service
        {
            List<ServiceUnitDTO> ListServiceUnit = ServiceUnitDAO.GetListServiceUnit();
            cmbTenDV.DataSource = ListServiceUnit;
            cmbTenDV.DisplayMember = "ServiceName";
            txtPricePerUnit.Text = ListServiceUnit[0].PricePerUnit.ToString();
            txtUnit.Text = ListServiceUnit[0].UnitName.ToString();
        }
        //comment
        public void FillDataSector() //Load tất cả các khu phòng
        {
            List<SectorDTO> ListSector = SectorDAO.GetListSector();
            cmbBuilding.DataSource = ListSector;
            cmbBuilding.DisplayMember = "SectorName";
        }

        public void FillDataRoomBySector(string Sector_Name) // Load danh sách phòng theo Khu
        {
            List<RoomDTO> ListRoom = RoomDAO.GetListRoomBySector(Sector_Name);
            cmbRoom.DataSource = ListRoom;
            cmbRoom.DisplayMember = "RoomId";
        }

        #endregion FillDaTa

        #region Get___By____

        public string GetServiceIDByServiceName(string ServiceName)
        {
            List<ServiceDTO> ListService = ServiceDAO.GetListService();
            for (int i = 0; i < ListService.Count; i++)
            {
                if (ServiceName == ListService[i].ServiceName)
                {
                    return ListService[i].ServiceId.ToString();
                }
            }
            return "";
        }

        public string GetUnitNameByServiceName(string ServiceName)
        {
            UnitDTO Unit = UnitDAO.GetUnitByServiceName(ServiceName);
            return Unit.UnitName;
        }

        #endregion Get___By____

        #region Click

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //check du lieu dau vao co du chua
            if (cmbBuilding.Text == "")
            {
                MessageBox.Show("Sector not null");
            }
            else if (cmbRoom.Text == "")
            {
                MessageBox.Show("Room not null");
            }
            else if (cmbMonth.Text == "")
            {
                MessageBox.Show("Month not null");
            }
            else if (txtYear.Text == "")
            {
                MessageBox.Show("Year not null");
            }
            else if (cmbTenDV.Text.Trim() == "" || numSoLuong.Value <= 0)//Kiểm tra dữ liệu có phù hợp không
            {
                MessageBox.Show("Invalid number", "Data entry error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string Service_ID = GetServiceIDByServiceName(cmbTenDV.Text.ToString());
                int SoLuong = Int32.Parse(numSoLuong.Value.ToString());
                decimal Gia = Decimal.Parse(txtPricePerUnit.Text.ToString());
                string Price = (SoLuong * Gia).ToString();
                decimal total = Decimal.Parse(txtTotal.Text.ToString());
                total += (SoLuong * Gia);
                txtTotal.Text = total.ToString();
                string[] rowValue = new string[] { Service_ID, cmbTenDV.Text, txtUnit.Text, txtPricePerUnit.Text, numSoLuong.Value.ToString(), Price };
                for (int i = 0; i < dgvBillReg.Rows.Count; i++)// Kiểm tra nếu dịch vụ đó đã có sử dụng thì cộng thêm với số lượng cũ
                {
                    if (dgvBillReg.Rows[i].Cells[1].Value == cmbTenDV.Text)
                    {
                        decimal price = Decimal.Parse(dgvBillReg.Rows[i].Cells[5].Value.ToString());
                        decimal Number = Decimal.Parse(dgvBillReg.Rows[i].Cells[4].Value.ToString());
                        Number += numSoLuong.Value;
                        price += Gia * numSoLuong.Value;
                        dgvBillReg.Rows[i].Cells[4].Value = Number.ToString();
                        dgvBillReg.Rows[i].Cells[5].Value = price.ToString();
                        return;
                    }
                }
                dgvBillReg.Rows.Add(rowValue);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvBillReg.CurrentCell.RowIndex;
                decimal Price = Decimal.Parse(dgvBillReg.Rows[index].Cells[5].Value.ToString());
                decimal Total = Decimal.Parse(txtTotal.Text.ToString());
                Total = Total - Price;
                txtTotal.Text = Total.ToString();
                var row = dgvBillReg.Rows[index];
                if (row.IsNewRow == false)
                {
                    string maDV = row.Cells[0].Value.ToString().Trim();
                    dgvBillReg.Rows.Remove(row);
                }
                dgvBillReg.Refresh();
                MessageBox.Show("Deleted successfully!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvBillReg.Rows.Count <= 1)
            {
                MessageBox.Show("Please select at least one service", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            long Employee_ID = User.UserId;
            string Room_Name = cmbRoom.Text;
            string Sector_Name = cmbBuilding.Text;
            string Month = cmbMonth.Text;
            string Year = txtYear.Text;
            string Status = "0";
            string Total = txtTotal.Text;
            DateTime CreatDay = dtCreatedDate.Value;
            if (AddBill(Employee_ID, Room_Name, Sector_Name, CreatDay, Month, Year, Status, Total))
            {
                for (int i = 0; i < dgvBillReg.Rows.Count - 1; i++)
                {
                    string Service_Name = dgvBillReg.Rows[i].Cells[1].Value.ToString();
                    string Quantity = dgvBillReg.Rows[i].Cells[4].Value.ToString();
                    string Unit_Name = dgvBillReg.Rows[i].Cells[2].Value.ToString();
                    string Total_Cost_Per_Service = dgvBillReg.Rows[i].Cells[5].Value.ToString();
                    BillDetailDAO.AddDetailBill(Service_Name, Quantity, Sector_Name, Room_Name, Month, Year, Unit_Name, Total_Cost_Per_Service);
                }
                MessageBox.Show("Add Bill Success");
                dgvBillReg.Rows.Clear();
            }
            else
            {
                dgvBillReg.Rows.Clear();
            }
        }

        private bool AddBill(long Employee_ID, string Room_Name, string Sector_Name, DateTime CreatDay, string Month, string Year, string Status, string Total)
        {
            return BillDAO.AddBill(Employee_ID, Room_Name, Sector_Name, CreatDay, Month, Year, Status, Total);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            dgvPayment.Rows.Clear();
            string SectorName = cmbBuilding.Text;
            string RoomId = cmbRoom.Text;
            string Month = cmbMonth.Text.ToString();
            string Year = txtYear.Text;
            List<BillDetailDTO> ListService = BillDetailDAO.GetViewBillDetail(SectorName, RoomId, Month, Year);
            for (int i = 0; i < ListService.Count; i++)
            {
                BillDetailDTO OneService = ListService[i];
                int Quantity = OneService.NewQuantity - OneService.OldQuantity;
                decimal Total_Cost_Per_Service = OneService.ToTal_Cost_Per_Service;
                decimal Cost_Per_Unit = Total_Cost_Per_Service / Quantity;
                string[] rowvalue = new string[] { OneService.ServiceId.ToString(),
                                                   OneService.ServiceName.ToString(),
                                                   OneService.UnitName.ToString(),
                                                   Cost_Per_Unit.ToString(),
                                                   Quantity.ToString(),
                                                   Total_Cost_Per_Service.ToString()};
                dgvPayment.Rows.Add(rowvalue);
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            decimal Total_Cost_Bill = 0;
            for (int i = 0; i < dgvPayment.Rows.Count - 1; i++)
            {
                decimal temp = Decimal.Parse(dgvPayment.Rows[i].Cells[5].Value.ToString());
                Total_Cost_Bill = Total_Cost_Bill + temp;
            }
            DateTime CreatDay = dtCreatedDate.Value;
            if(AddPayMent(User.UserId.ToString(), CreatDay, Total_Cost_Bill, cmbBuilding.Text.ToString(), cmbRoom.Text.ToString(), cmbMonth.Text.ToString(), txtYear.Text.ToString()))
            {
                MessageBox.Show("Payment Success");
            }    

            //PayMentDAO.AddPayMent(User.UserId.ToString(), CreatDay, Total_Cost_Bill, cmbBuilding.Text.ToString(), cmbRoom.Text.ToString(), cmbMonth.Text.ToString(), txtYear.Text.ToString());
            
            dgvPayment.Rows.Clear();
        }
        bool AddPayMent(string User_ID, DateTime CreatDay, decimal Total_Cost_Bill, string Sector_Name, string Room_ID, string Month, string Year)
        {
            return PayMentDAO.AddPayMent(User_ID, CreatDay, Total_Cost_Bill, Sector_Name, Room_ID, Month, Year);
        }

        #endregion Click

        private void FrmBill_Load(object sender, EventArgs e)
        {
            FillDataServiceUnit();
            FillDataSector();
            txtEmployee.Text = (Convert.ToString(User.FirstName) + " " + Convert.ToString(User.LastName)).Trim();
            DateTime now = DateTime.Now;
            cmbMonth.Text = now.Month.ToString();
            txtYear.Text = now.Year.ToString();
            dgvBillReg.Rows[0].Cells[5].Value = 0;
            txtTotal.Text = "0";
            //cmt
        }

        #region EventChange

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

        private void cmbTenDV_SelectedValueChanged(object sender, EventArgs e)
        {
            string ServiceName = cmbTenDV.Text.ToString();
            List<ServiceUnitDTO> ListServiceUnit = ServiceUnitDAO.GetListServiceUnit();
            for (int i = 0; i < ListServiceUnit.Count; i++)
            {
                ServiceUnitDTO ServiceUnit = ListServiceUnit[i];
                if (ServiceName == ServiceUnit.ServiceName)
                {
                    txtPricePerUnit.Text = ServiceUnit.PricePerUnit.ToString();
                    txtUnit.Text = ServiceUnit.UnitName.ToString();
                }
            }
        }

        #endregion EventChange

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //cmt
        }
    }
}