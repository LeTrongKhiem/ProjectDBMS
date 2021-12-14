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
    public partial class FrmServiceInfo : Form
    {
        public int Service_ID = 0;
        public FrmServiceInfo()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(Service_ID > 0)
            {
                ServiceDAO.UpdateService(txtServiceName.Text, Convert.ToDecimal(txtPricePerUnit.Text));
                MessageBox.Show("Update Success");
                this.Dispose();
            }
            else
            {
                ServiceDAO.AddService(txtServiceName.Text,txtPricePerUnit.Text , txtUnit.Text);
                MessageBox.Show("Add Success");
                this.Dispose();
            }    
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Do you want to delete this service ? ","Notify", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr == DialogResult.Yes)
            {
                ServiceDAO.DeleteService(txtServiceName.Text);
                this.Dispose();
                //FrmServices a = new FrmServices();
                //a.ShowDialog();
            } 
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            txtPricePerUnit.Enabled = true;
            btnOK.Enabled = true;
        }

        private void FrmServiceInfo_Load(object sender, EventArgs e)
        {
            if(Service_ID > 0)
            {
                List<ServiceUnitDTO> ListServiceUnit = ServiceUnitDAO.GetListServiceUnit();
                for (int i = 0; i < ListServiceUnit.Count; i++)
                {
                    ServiceUnitDTO ServiceUnit = ListServiceUnit[i];
                    if (Service_ID == ServiceUnit.ServiceId)
                    {
                        txtServiceName.Text = ServiceUnit.ServiceName;
                        txtUnit.Text = ServiceUnit.UnitName;
                        txtPricePerUnit.Text = ServiceUnit.PricePerUnit.ToString();
                    }
                }
                txtServiceName.Enabled = false;
                txtUnit.Enabled = false;
                txtPricePerUnit.Enabled = false;
                btnOK.Enabled = false;
            }
        }
    }
}
