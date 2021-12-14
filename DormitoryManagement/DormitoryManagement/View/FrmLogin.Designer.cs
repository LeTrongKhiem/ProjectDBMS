namespace DormitoryManagement.View
{
    partial class FrmLogin
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
         this.btnLogin = new System.Windows.Forms.Button();
         this.txtUserName = new System.Windows.Forms.TextBox();
         this.btnClose = new System.Windows.Forms.Button();
         this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
         this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
         this.groupBox2 = new System.Windows.Forms.GroupBox();
         this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
         this.txtPassword = new System.Windows.Forms.TextBox();
         this.btnHidePassword = new System.Windows.Forms.Button();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.tableLayoutPanel1.SuspendLayout();
         this.tableLayoutPanel2.SuspendLayout();
         this.groupBox2.SuspendLayout();
         this.tableLayoutPanel3.SuspendLayout();
         this.groupBox1.SuspendLayout();
         this.SuspendLayout();
         // 
         // lbTitle
         // 
         this.lbTitle.BackColor = System.Drawing.Color.Transparent;
         this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
         this.lbTitle.Font = new System.Drawing.Font("Segoe UI Black", 46F, System.Drawing.FontStyle.Bold);
         this.lbTitle.ForeColor = System.Drawing.Color.DarkRed;
         this.lbTitle.Location = new System.Drawing.Point(0, 0);
         this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
         this.lbTitle.Name = "lbTitle";
         this.lbTitle.Size = new System.Drawing.Size(802, 210);
         this.lbTitle.TabIndex = 9;
         this.lbTitle.Text = "DORMITORY MANAGEMENT";
         this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
         // 
         // btnLogin
         // 
         this.btnLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.btnLogin.BackColor = System.Drawing.Color.Transparent;
         this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnLogin.ForeColor = System.Drawing.Color.DarkRed;
         this.btnLogin.Location = new System.Drawing.Point(3, 3);
         this.btnLogin.MinimumSize = new System.Drawing.Size(100, 30);
         this.btnLogin.Name = "btnLogin";
         this.btnLogin.Size = new System.Drawing.Size(191, 36);
         this.btnLogin.TabIndex = 6;
         this.btnLogin.Text = "LOGIN";
         this.btnLogin.UseVisualStyleBackColor = false;
         this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
         // 
         // txtUserName
         // 
         this.txtUserName.BackColor = System.Drawing.SystemColors.Control;
         this.txtUserName.Dock = System.Windows.Forms.DockStyle.Fill;
         this.txtUserName.Font = new System.Drawing.Font("Segoe UI Black", 12F);
         this.txtUserName.Location = new System.Drawing.Point(3, 25);
         this.txtUserName.MinimumSize = new System.Drawing.Size(216, 25);
         this.txtUserName.Name = "txtUserName";
         this.txtUserName.Size = new System.Drawing.Size(389, 35);
         this.txtUserName.TabIndex = 1;
         // 
         // btnClose
         // 
         this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
         this.btnClose.BackColor = System.Drawing.Color.Transparent;
         this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
         this.btnClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.btnClose.ForeColor = System.Drawing.Color.DarkRed;
         this.btnClose.Location = new System.Drawing.Point(200, 3);
         this.btnClose.MinimumSize = new System.Drawing.Size(100, 30);
         this.btnClose.Name = "btnClose";
         this.btnClose.Size = new System.Drawing.Size(192, 36);
         this.btnClose.TabIndex = 7;
         this.btnClose.Text = "EXIT";
         this.btnClose.UseVisualStyleBackColor = false;
         this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
         // 
         // tableLayoutPanel1
         // 
         this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
         this.tableLayoutPanel1.ColumnCount = 3;
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
         this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 3);
         this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 2);
         this.tableLayoutPanel1.Controls.Add(this.groupBox1, 1, 1);
         this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 210);
         this.tableLayoutPanel1.Name = "tableLayoutPanel1";
         this.tableLayoutPanel1.RowCount = 5;
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
         this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23F));
         this.tableLayoutPanel1.Size = new System.Drawing.Size(802, 323);
         this.tableLayoutPanel1.TabIndex = 2;
         // 
         // tableLayoutPanel2
         // 
         this.tableLayoutPanel2.ColumnCount = 2;
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel2.Controls.Add(this.btnLogin, 0, 0);
         this.tableLayoutPanel2.Controls.Add(this.btnClose, 1, 0);
         this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel2.Location = new System.Drawing.Point(203, 202);
         this.tableLayoutPanel2.Name = "tableLayoutPanel2";
         this.tableLayoutPanel2.RowCount = 1;
         this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
         this.tableLayoutPanel2.Size = new System.Drawing.Size(395, 42);
         this.tableLayoutPanel2.TabIndex = 5;
         // 
         // groupBox2
         // 
         this.groupBox2.Controls.Add(this.tableLayoutPanel3);
         this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
         this.groupBox2.Location = new System.Drawing.Point(203, 128);
         this.groupBox2.Name = "groupBox2";
         this.groupBox2.Size = new System.Drawing.Size(395, 68);
         this.groupBox2.TabIndex = 2;
         this.groupBox2.TabStop = false;
         this.groupBox2.Text = "Password";
         // 
         // tableLayoutPanel3
         // 
         this.tableLayoutPanel3.ColumnCount = 2;
         this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85F));
         this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
         this.tableLayoutPanel3.Controls.Add(this.txtPassword, 0, 0);
         this.tableLayoutPanel3.Controls.Add(this.btnHidePassword, 1, 0);
         this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
         this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 25);
         this.tableLayoutPanel3.Name = "tableLayoutPanel3";
         this.tableLayoutPanel3.RowCount = 1;
         this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
         this.tableLayoutPanel3.Size = new System.Drawing.Size(389, 40);
         this.tableLayoutPanel3.TabIndex = 2;
         // 
         // txtPassword
         // 
         this.txtPassword.BackColor = System.Drawing.SystemColors.Control;
         this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
         this.txtPassword.Font = new System.Drawing.Font("Segoe UI Black", 12F);
         this.txtPassword.Location = new System.Drawing.Point(3, 3);
         this.txtPassword.MinimumSize = new System.Drawing.Size(216, 25);
         this.txtPassword.Name = "txtPassword";
         this.txtPassword.Size = new System.Drawing.Size(324, 35);
         this.txtPassword.TabIndex = 3;
         this.txtPassword.UseSystemPasswordChar = true;
         // 
         // btnHidePassword
         // 
         this.btnHidePassword.BackColor = System.Drawing.Color.Transparent;
         this.btnHidePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.btnHidePassword.Dock = System.Windows.Forms.DockStyle.Fill;
         this.btnHidePassword.Location = new System.Drawing.Point(333, 3);
         this.btnHidePassword.Name = "btnHidePassword";
         this.btnHidePassword.Size = new System.Drawing.Size(53, 34);
         this.btnHidePassword.TabIndex = 4;
         this.btnHidePassword.UseVisualStyleBackColor = false;
         this.btnHidePassword.Click += new System.EventHandler(this.btnHidePassword_Click);
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.txtUserName);
         this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
         this.groupBox1.Location = new System.Drawing.Point(203, 54);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(395, 68);
         this.groupBox1.TabIndex = 1;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Username";
         // 
         // FrmLogin
         // 
         this.AcceptButton = this.btnLogin;
         this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.BackColor = System.Drawing.SystemColors.Control;
         this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
         this.ClientSize = new System.Drawing.Size(802, 533);
         this.Controls.Add(this.tableLayoutPanel1);
         this.Controls.Add(this.lbTitle);
         this.DoubleBuffered = true;
         this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
         this.MaximizeBox = false;
         this.Name = "FrmLogin";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Login";
         this.tableLayoutPanel1.ResumeLayout(false);
         this.tableLayoutPanel2.ResumeLayout(false);
         this.groupBox2.ResumeLayout(false);
         this.tableLayoutPanel3.ResumeLayout(false);
         this.tableLayoutPanel3.PerformLayout();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnHidePassword;
    }
}