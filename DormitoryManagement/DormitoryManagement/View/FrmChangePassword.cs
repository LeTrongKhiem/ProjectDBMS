using DormitoryManagement.Controller;
using DormitoryManagement.Model;
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
    public partial class FrmChangePassword : Form
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
        public FrmChangePassword(UserDTO user)
        {
            InitializeComponent();
            this.User = user;
        }
        #region Events
        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            txtUserName.Text = User.Username;
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string oldPass = txtOldPassword.Text;
            string newPass = txtNewPassword.Text;
            string confirmPass = txtConfirm.Text;
            if (Login(username.Trim(), oldPass.Trim()))
            {
                if (newPass.Trim().Equals(oldPass.Trim())) {
                    MessageBox.Show("Old password middle new password!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (newPass.Trim().Equals(confirmPass.Trim()))
                    {
                        if (ChangePass(User.UserId, oldPass, newPass))
                        {
                            txtOldPassword.Text = "";
                            txtNewPassword.Text = "";
                            txtConfirm.Text = "";
                            MessageBox.Show("Successfully changed!", "Notification", MessageBoxButtons.OK);
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Error!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The new password doesn't match!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Old password is incorrect!", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnOldPassword_Click(object sender, EventArgs e)
        {
            if (this.txtOldPassword.UseSystemPasswordChar == true)
            {
                this.txtOldPassword.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtOldPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnNewPassword_Click(object sender, EventArgs e)
        {
            if (this.txtNewPassword.UseSystemPasswordChar == true)
            {
                this.txtNewPassword.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtNewPassword.UseSystemPasswordChar = true;
            }
        }

        private void btnConfirmPassword_Click(object sender, EventArgs e)
        {
            if (this.txtConfirm.UseSystemPasswordChar == true)
            {
                this.txtConfirm.UseSystemPasswordChar = false;
            }
            else
            {
                this.txtConfirm.UseSystemPasswordChar = true;
            }
        }
        #endregion
        #region Methods
        bool Login(string username, string password)
        {
            return UserDAO.Login(username, password);
        }
        bool ChangePass(long userId, string oldpass, string newpass)
        {
            return UserDAO.ChangePassword(userId, oldpass, newpass);
        }
        #endregion

    }
}
