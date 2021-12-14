using DormitoryManagement.Controller;
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
    public partial class FrmBuildings : Form
    {
        public FrmBuildings()
        {
            InitializeComponent();
        }

        private void FrmBuildings_Load(object sender, EventArgs e)
        {
            dgvBuildings.DataSource = SectorDAO.GetListSector();
        }
    }
}
