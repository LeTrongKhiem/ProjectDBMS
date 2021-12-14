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
    public partial class FrmRoomTypes : Form
    {
        public FrmRoomTypes()
        {
            InitializeComponent();
        }
        void AutoSizeModeColumn(DataGridView dataGridView)
        {
            if (dataGridView.Columns.Count == 0) { return; }

            for (int i = 0; i < dataGridView.Columns.Count - 1; i++)
            {
                dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dataGridView.Columns[dataGridView.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void FrmRoomTypes_Load(object sender, EventArgs e)
        {
            dgvRoomTypes.DataSource = RoomDAO.GetListRoomView();
            AutoSizeModeColumn(dgvRoomTypes);
        }
    }
}
