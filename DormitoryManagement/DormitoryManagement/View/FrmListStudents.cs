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
   public partial class FrmListStudents : Form
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
      public FrmListStudents(UserDTO user)
      {
         this.User = user;
         InitializeComponent();
      }
      public void LoadListStudentAvailable()
      {
         dgvStudents.DataSource = StudentViewDAO.GetListStudentViewALive();
         txtQuantity.Text = (dgvStudents.RowCount - 1).ToString();
      }
      public void AutoSizeModeColumn(DataGridView dataGridView)
      {
         for (int i = 0; i < dataGridView.Columns.Count - 1; i++)
         {
            dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
         }
         if (dataGridView.Columns.Count > 0)
         {
            dataGridView.Columns[dataGridView.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
         }
      }

      private void dgvStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {
         int index = dgvStudents.CurrentCell.RowIndex;
         FrmStudentInfo frmStudentInfo = new FrmStudentInfo(null, User);
         frmStudentInfo.SSN = Convert.ToString(dgvStudents.Rows[index].Cells[4].Value);
         //MessageBox.Show(Convert.ToString(dgvStudents.Rows[index].Cells[4].Value));
         frmStudentInfo.ShowDialog();
         FrmListStudents_Load(this, new EventArgs());
      }

      private void FrmListStudents_Load(object sender, EventArgs e)
      {
         LoadListStudentAvailable();
         AutoSizeModeColumn(dgvStudents);
      }
   }
}
