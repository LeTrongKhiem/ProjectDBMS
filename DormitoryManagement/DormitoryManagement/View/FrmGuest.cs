using DormitoryManagement.View;
using System.Windows.Forms;

namespace DormitoryManagement
{
    public partial class FrmGuest : Form
    {
        #region Fields
        private Item ctrlLogin;
        private Item ctrlExit;
        private Item ctrlBuildings;
        private Item ctrlRoomType;
        private Item ctrlServices;
        private Item ctrlGuide;
        #endregion

        #region Properties
        public Item CtrlLogin { get => ctrlLogin; set => ctrlLogin = value; }
        public Item CtrlExit { get => ctrlExit; set => ctrlExit = value; }
        protected Item CtrlBuildings { get => ctrlBuildings; set => ctrlBuildings = value; }
        protected Item CtrlRoomType { get => ctrlRoomType; set => ctrlRoomType = value; }
        protected Item CtrlServices { get => ctrlServices; set => ctrlServices = value; }
        protected Item CtrlGuide { get => ctrlGuide; set => ctrlGuide = value; }
        #endregion

        public FrmGuest()
        {
            InitializeComponent();
            Init();
        }

        #region Init

        protected void Init()
        {
            #region Management
            //Đăng nhập
            CtrlLogin = Dashboard.InitLogin(this);
            tlpManage.Controls.Add(ctrlLogin);
            //Thoát
            CtrlExit = Dashboard.InitExit();
            tlpManage.Controls.Add(ctrlExit);
            #endregion

            #region Info
            //DS Khu phòng
            CtrlBuildings = Dashboard.InitListBuildings();
            tlpInfo.Controls.Add(ctrlBuildings);
            //Loại phòng
            CtrlRoomType = Dashboard.InitListRoomType();
            tlpInfo.Controls.Add(ctrlRoomType);
            //DS dịch vụ
            CtrlServices = Dashboard.InitListServices();
            tlpInfo.Controls.Add(ctrlServices);
            //Hướng dẫn
            CtrlGuide = Dashboard.InitGuide();
            tlpInfo.Controls.Add(ctrlGuide);
            #endregion
        }
        #endregion
    }
}
