using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.Remoting.Messaging;
using System.Windows.Forms;
using DormitoryManagement.View;

namespace DormitoryManagement
{
    public enum ItemType
    {
        Building,
        Employee,
        Service,
        Bill,
        RoomType,
        Unknown
    }
    public delegate void ClickEvent();
    public delegate void ClickItem(object o);

    public partial class Item : UserControl
    {
        #region Fields
        private ClickEvent clickEvent = null; //delegate
        private ClickItem clickItem = null; //delegate
        private object metadata;
        private ItemType type = ItemType.Unknown;
        private string strKey = "";
        #endregion

        #region Properties
        [Category("Customize"), Description("Change title for item.")]
        public string Title { get => this.btnTitle.Text; set => this.btnTitle.Text = value; }

        [Category("Customize"), Description("Change background image for item.")]
        public Image ImageItem { get => this.picItem.BackgroundImage; set => this.picItem.BackgroundImage = value; }

        public string StrKey { get => strKey; set => strKey = value; }
        public ItemType Type { get => type; set => type = value; }
        public object Metadata { get => metadata; set => metadata = value; }
        public ClickEvent ClickEvent { get => clickEvent; set => clickEvent = value; }
        public ClickItem ClickItem { get => clickItem; set => clickItem = value; }
        #endregion

        #region Constructors
        public Item()
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Top;
        }

        public Item(ClickItem click, object o)
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Top;
            this.ClickItem = click;
            this.metadata = o;
        }

        public Item(ClickEvent click)
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Top;
            this.ClickEvent = click;
        }

        public Item(ItemType type)
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Top;
            this.Type = type;
            this.ClickEvent = EventClick;
        }

        public Item(ItemType type, string key)
        {
            InitializeComponent();
            this.Anchor = AnchorStyles.Top;
            this.Type = type;
            this.ClickEvent = ShowInfo;
            StrKey = key;
        }
        #endregion

        private void ShowInfo()
        {
            switch (this.Type)
            {
                //case ItemType.KhuPhong:
                //    break;
                //case ItemType.RoomType:
                //    FrmLoaiPhong loaiPhong = new FrmLoaiPhong(this.strKey);
                //    loaiPhong.ShowDialog();
                //    break;
                //case ItemType.NhanVien:
                //    FrmNhanVien nhanVien = new FrmNhanVien(this.strKey);
                //    nhanVien.ShowDialog();
                //    break;
                //case ItemType.Service:
                //    FrmDichVu dichVu = new FrmDichVu(this.strKey);
                //    dichVu.ShowDialog();
                //    break;
            }
        }

        private void EventClick()
        {
            //FrmTongQuan tongQuan = new FrmTongQuan(this.type);
            //tongQuan.ShowDialog();
        }

        private void btnTitle_Click(object sender, EventArgs e)
        {
            if (ClickEvent != null)
                this.ClickEvent();
            if (clickItem != null)
                this.ClickItem(metadata);
        }

        private void btnTitle_Enter(object sender, EventArgs e)
        {
            btnTitle.BackColor = Color.Coral;
        }

        private void btnTitle_Leave(object sender, EventArgs e)
        {
            btnTitle.BackColor = Color.Transparent;
        }
    }
}
