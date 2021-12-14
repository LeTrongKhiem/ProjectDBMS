namespace DormitoryManagement.View
{
    partial class FrmChangePassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitle = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupOldPassword = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.txtOldPassword = new System.Windows.Forms.TextBox();
            this.btnOldPassword = new System.Windows.Forms.Button();
            this.groupUsername = new System.Windows.Forms.GroupBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnChange = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupNewPassword = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.btnNewPassword = new System.Windows.Forms.Button();
            this.groupConfirmPassword = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.txtConfirm = new System.Windows.Forms.TextBox();
            this.btnConfirmPassword = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupOldPassword.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.groupUsername.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.groupNewPassword.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupConfirmPassword.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.Goldenrod;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Black", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(802, 55);
            this.lbTitle.TabIndex = 22;
            this.lbTitle.Text = "CHANGE PASSWORD";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.groupOldPassword, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupUsername, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.groupNewPassword, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.groupConfirmPassword, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 55);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.67505F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.09434F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.93291F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.93291F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.90147F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(802, 478);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // groupOldPassword
            // 
            this.groupOldPassword.BackColor = System.Drawing.Color.Transparent;
            this.groupOldPassword.Controls.Add(this.tableLayoutPanel3);
            this.groupOldPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupOldPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupOldPassword.Location = new System.Drawing.Point(203, 137);
            this.groupOldPassword.Name = "groupOldPassword";
            this.groupOldPassword.Size = new System.Drawing.Size(395, 66);
            this.groupOldPassword.TabIndex = 0;
            this.groupOldPassword.TabStop = false;
            this.groupOldPassword.Text = "Old password";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.txtOldPassword, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnOldPassword, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(389, 37);
            this.tableLayoutPanel3.TabIndex = 24;
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtOldPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtOldPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtOldPassword.Location = new System.Drawing.Point(3, 3);
            this.txtOldPassword.MinimumSize = new System.Drawing.Size(216, 25);
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.Size = new System.Drawing.Size(344, 34);
            this.txtOldPassword.TabIndex = 17;
            this.txtOldPassword.UseSystemPasswordChar = true;
            // 
            // btnOldPassword
            // 
            this.btnOldPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnOldPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOldPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOldPassword.Location = new System.Drawing.Point(353, 3);
            this.btnOldPassword.Name = "btnOldPassword";
            this.btnOldPassword.Size = new System.Drawing.Size(33, 31);
            this.btnOldPassword.TabIndex = 20;
            this.btnOldPassword.UseVisualStyleBackColor = false;
            this.btnOldPassword.Click += new System.EventHandler(this.btnOldPassword_Click);
            // 
            // groupUsername
            // 
            this.groupUsername.BackColor = System.Drawing.Color.Transparent;
            this.groupUsername.Controls.Add(this.txtUserName);
            this.groupUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupUsername.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupUsername.Location = new System.Drawing.Point(203, 67);
            this.groupUsername.Name = "groupUsername";
            this.groupUsername.Size = new System.Drawing.Size(395, 64);
            this.groupUsername.TabIndex = 0;
            this.groupUsername.TabStop = false;
            this.groupUsername.Text = "Username";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.Control;
            this.txtUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUserName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtUserName.Location = new System.Drawing.Point(3, 26);
            this.txtUserName.MinimumSize = new System.Drawing.Size(216, 25);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(389, 34);
            this.txtUserName.TabIndex = 16;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnChange, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(203, 361);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(395, 46);
            this.tableLayoutPanel4.TabIndex = 24;
            // 
            // btnChange
            // 
            this.btnChange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnChange.BackColor = System.Drawing.Color.Transparent;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnChange.Location = new System.Drawing.Point(3, 3);
            this.btnChange.MinimumSize = new System.Drawing.Size(100, 30);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(191, 40);
            this.btnChange.TabIndex = 18;
            this.btnChange.Text = "CHANGE";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.DarkRed;
            this.btnCancel.Location = new System.Drawing.Point(200, 3);
            this.btnCancel.MinimumSize = new System.Drawing.Size(100, 30);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(192, 40);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // groupNewPassword
            // 
            this.groupNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.groupNewPassword.Controls.Add(this.tableLayoutPanel2);
            this.groupNewPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupNewPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupNewPassword.Location = new System.Drawing.Point(203, 209);
            this.groupNewPassword.Name = "groupNewPassword";
            this.groupNewPassword.Size = new System.Drawing.Size(395, 70);
            this.groupNewPassword.TabIndex = 26;
            this.groupNewPassword.TabStop = false;
            this.groupNewPassword.Text = "New password";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.txtNewPassword, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnNewPassword, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(389, 41);
            this.tableLayoutPanel2.TabIndex = 23;
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.SystemColors.Control;
            this.txtNewPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewPassword.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtNewPassword.Location = new System.Drawing.Point(3, 3);
            this.txtNewPassword.MinimumSize = new System.Drawing.Size(216, 25);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(344, 34);
            this.txtNewPassword.TabIndex = 17;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // btnNewPassword
            // 
            this.btnNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnNewPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNewPassword.Location = new System.Drawing.Point(353, 3);
            this.btnNewPassword.Name = "btnNewPassword";
            this.btnNewPassword.Size = new System.Drawing.Size(33, 35);
            this.btnNewPassword.TabIndex = 20;
            this.btnNewPassword.UseVisualStyleBackColor = false;
            this.btnNewPassword.Click += new System.EventHandler(this.btnNewPassword_Click);
            // 
            // groupConfirmPassword
            // 
            this.groupConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.groupConfirmPassword.Controls.Add(this.tableLayoutPanel5);
            this.groupConfirmPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupConfirmPassword.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupConfirmPassword.Location = new System.Drawing.Point(203, 285);
            this.groupConfirmPassword.Name = "groupConfirmPassword";
            this.groupConfirmPassword.Size = new System.Drawing.Size(395, 70);
            this.groupConfirmPassword.TabIndex = 27;
            this.groupConfirmPassword.TabStop = false;
            this.groupConfirmPassword.Text = "Confirm password";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel5.Controls.Add(this.txtConfirm, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btnConfirmPassword, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(389, 41);
            this.tableLayoutPanel5.TabIndex = 24;
            // 
            // txtConfirm
            // 
            this.txtConfirm.BackColor = System.Drawing.SystemColors.Control;
            this.txtConfirm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConfirm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtConfirm.Location = new System.Drawing.Point(3, 3);
            this.txtConfirm.MinimumSize = new System.Drawing.Size(216, 25);
            this.txtConfirm.Name = "txtConfirm";
            this.txtConfirm.Size = new System.Drawing.Size(344, 34);
            this.txtConfirm.TabIndex = 17;
            this.txtConfirm.UseSystemPasswordChar = true;
            // 
            // btnConfirmPassword
            // 
            this.btnConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirmPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConfirmPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnConfirmPassword.Location = new System.Drawing.Point(353, 3);
            this.btnConfirmPassword.Name = "btnConfirmPassword";
            this.btnConfirmPassword.Size = new System.Drawing.Size(33, 35);
            this.btnConfirmPassword.TabIndex = 20;
            this.btnConfirmPassword.UseVisualStyleBackColor = false;
            this.btnConfirmPassword.Click += new System.EventHandler(this.btnConfirmPassword_Click);
            // 
            // FrmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 533);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbTitle);
            this.Name = "FrmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.FrmChangePassword_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupOldPassword.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.groupUsername.ResumeLayout(false);
            this.groupUsername.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.groupNewPassword.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupConfirmPassword.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupOldPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtOldPassword;
        private System.Windows.Forms.Button btnOldPassword;
        private System.Windows.Forms.GroupBox groupUsername;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.GroupBox groupNewPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtNewPassword;
        private System.Windows.Forms.Button btnNewPassword;
        private System.Windows.Forms.GroupBox groupConfirmPassword;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox txtConfirm;
        private System.Windows.Forms.Button btnConfirmPassword;
    }
}