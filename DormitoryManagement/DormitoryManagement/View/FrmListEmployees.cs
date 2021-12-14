using DormitoryManagement.Controller;
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
    public partial class FrmListEmployees : Form
    {
        BindingSource BindingSourceEmployee= new BindingSource();
        public FrmListEmployees()
        {
            InitializeComponent();
        }

        private void FrmListEmployees_Load(object sender, EventArgs e)
        {
            LoadEmployee();
            AddEmployeeBinding();
            AutoSizeModeColumn(dgvEmployees);

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            long userId =long.Parse(txtUserId.Text);
            string Salary = txtSalary.Text;
            if ((txtSalary.Text == "") || FormatData.IsNumber(txtSalary.Text) == false)
            {
                MessageBox.Show("Not Is Salary", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                UpdateSalary(userId,Salary);
                MessageBox.Show("Edited successfully!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            LoadEmployee();
        }
        void AutoSizeModeColumn(DataGridView dataGridView)
        {
            for (int i = 0; i < dataGridView.Columns.Count -1; i++)
            {
                dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dataGridView.Columns[dataGridView.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }
        void LoadEmployee()
        {
            BindingSourceEmployee.DataSource = EmployeeDAO.GetEmployees();
            dgvEmployees.DataSource = BindingSourceEmployee;
            txtQuantity.Text = (dgvEmployees.Rows.Count - 1).ToString();
        }
        void AddEmployeeBinding()
        {
            txtUserId.DataBindings.Add(new Binding("Text", dgvEmployees.DataSource, "USER_ID", true, DataSourceUpdateMode.Never));
            txtSalary.DataBindings.Add(new Binding("Text", dgvEmployees.DataSource, "SALARY", true, DataSourceUpdateMode.Never));
        }
        void UpdateSalary(long userId, string salary)
        {
            EmployeeDAO.UpdateSalary(userId,salary);
        }

        
    }
}
