namespace DormitoryManagement.View
{
    partial class FrmEmployeeInfo
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
            this.pnTop = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone1 = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPhone1 = new System.Windows.Forms.Label();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.tlpBottom = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupAvatar = new System.Windows.Forms.GroupBox();
            this.lbProfilePhoto = new System.Windows.Forms.Label();
            this.btnChoose = new System.Windows.Forms.Button();
            this.picAvt = new System.Windows.Forms.PictureBox();
            this.groupAddress = new System.Windows.Forms.GroupBox();
            this.cbbPriority = new System.Windows.Forms.ComboBox();
            this.lbPriority = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbCommune = new System.Windows.Forms.ComboBox();
            this.lbCommune = new System.Windows.Forms.Label();
            this.cbbDistrict = new System.Windows.Forms.ComboBox();
            this.lbDistrict = new System.Windows.Forms.Label();
            this.cbbProvince = new System.Windows.Forms.ComboBox();
            this.lbProvince = new System.Windows.Forms.Label();
            this.groupContact = new System.Windows.Forms.GroupBox();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.lbPhone2 = new System.Windows.Forms.Label();
            this.groupGeneral = new System.Windows.Forms.GroupBox();
            this.cbbUserType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lbStartDate = new System.Windows.Forms.Label();
            this.txtSalary = new System.Windows.Forms.TextBox();
            this.lbSalary = new System.Windows.Forms.Label();
            this.groupInfo = new System.Windows.Forms.GroupBox();
            this.dtpDoB = new System.Windows.Forms.DateTimePicker();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbDoB = new System.Windows.Forms.Label();
            this.ckbFemale = new System.Windows.Forms.CheckBox();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.lbSSN = new System.Windows.Forms.Label();
            this.pnSV = new System.Windows.Forms.Panel();
            this.pnTop.SuspendLayout();
            this.pnContainer.SuspendLayout();
            this.tlpBottom.SuspendLayout();
            this.groupAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).BeginInit();
            this.groupAddress.SuspendLayout();
            this.groupContact.SuspendLayout();
            this.groupGeneral.SuspendLayout();
            this.groupInfo.SuspendLayout();
            this.pnSV.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.lbTitle);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnTop.MinimumSize = new System.Drawing.Size(959, 62);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1167, 62);
            this.pnTop.TabIndex = 36;
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.Goldenrod;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.MinimumSize = new System.Drawing.Size(965, 62);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(1167, 62);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "EMPLOYEE INFORMATION";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(26, 181);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(60, 20);
            this.lbGender.TabIndex = 42;
            this.lbGender.Text = "Gender";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Control;
            this.txtFirstName.Location = new System.Drawing.Point(113, 36);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(212, 27);
            this.txtFirstName.TabIndex = 39;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmail.Location = new System.Drawing.Point(133, 131);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(212, 27);
            this.txtEmail.TabIndex = 18;
            // 
            // txtPhone1
            // 
            this.txtPhone1.BackColor = System.Drawing.SystemColors.Control;
            this.txtPhone1.Location = new System.Drawing.Point(133, 37);
            this.txtPhone1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Size = new System.Drawing.Size(212, 27);
            this.txtPhone1.TabIndex = 16;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(14, 135);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(47, 20);
            this.lbEmail.TabIndex = 17;
            this.lbEmail.Text = "Email";
            // 
            // lbPhone1
            // 
            this.lbPhone1.AutoSize = true;
            this.lbPhone1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone1.Location = new System.Drawing.Point(14, 40);
            this.lbPhone1.Name = "lbPhone1";
            this.lbPhone1.Size = new System.Drawing.Size(66, 20);
            this.lbPhone1.TabIndex = 15;
            this.lbPhone1.Text = "Phone 1";
            // 
            // pnContainer
            // 
            this.pnContainer.Controls.Add(this.tlpBottom);
            this.pnContainer.Controls.Add(this.groupAvatar);
            this.pnContainer.Controls.Add(this.groupAddress);
            this.pnContainer.Controls.Add(this.groupContact);
            this.pnContainer.Controls.Add(this.groupGeneral);
            this.pnContainer.Controls.Add(this.groupInfo);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 0);
            this.pnContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(1167, 560);
            this.pnContainer.TabIndex = 30;
            // 
            // tlpBottom
            // 
            this.tlpBottom.ColumnCount = 3;
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBottom.Controls.Add(this.btnDelete, 0, 0);
            this.tlpBottom.Controls.Add(this.btnSave, 0, 0);
            this.tlpBottom.Controls.Add(this.btnEdit, 0, 0);
            this.tlpBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tlpBottom.Location = new System.Drawing.Point(0, 516);
            this.tlpBottom.Name = "tlpBottom";
            this.tlpBottom.RowCount = 1;
            this.tlpBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBottom.Size = new System.Drawing.Size(1167, 44);
            this.tlpBottom.TabIndex = 73;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Crimson;
            this.btnDelete.Location = new System.Drawing.Point(781, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(383, 40);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSave.Location = new System.Drawing.Point(392, 2);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(383, 40);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Blue;
            this.btnEdit.Location = new System.Drawing.Point(3, 2);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(383, 40);
            this.btnEdit.TabIndex = 29;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // groupAvatar
            // 
            this.groupAvatar.Controls.Add(this.lbProfilePhoto);
            this.groupAvatar.Controls.Add(this.btnChoose);
            this.groupAvatar.Controls.Add(this.picAvt);
            this.groupAvatar.Location = new System.Drawing.Point(864, 28);
            this.groupAvatar.Name = "groupAvatar";
            this.groupAvatar.Size = new System.Drawing.Size(265, 467);
            this.groupAvatar.TabIndex = 72;
            this.groupAvatar.TabStop = false;
            this.groupAvatar.Text = "Avatar";
            // 
            // lbProfilePhoto
            // 
            this.lbProfilePhoto.AutoSize = true;
            this.lbProfilePhoto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProfilePhoto.Location = new System.Drawing.Point(82, 83);
            this.lbProfilePhoto.Name = "lbProfilePhoto";
            this.lbProfilePhoto.Size = new System.Drawing.Size(101, 20);
            this.lbProfilePhoto.TabIndex = 55;
            this.lbProfilePhoto.Text = "Profile photo";
            // 
            // btnChoose
            // 
            this.btnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoose.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnChoose.Location = new System.Drawing.Point(86, 401);
            this.btnChoose.Margin = new System.Windows.Forms.Padding(4);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(100, 37);
            this.btnChoose.TabIndex = 53;
            this.btnChoose.Text = "CHOOSE";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
            // 
            // picAvt
            // 
            this.picAvt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvt.Location = new System.Drawing.Point(43, 139);
            this.picAvt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picAvt.Name = "picAvt";
            this.picAvt.Size = new System.Drawing.Size(180, 240);
            this.picAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAvt.TabIndex = 54;
            this.picAvt.TabStop = false;
            // 
            // groupAddress
            // 
            this.groupAddress.Controls.Add(this.cbbPriority);
            this.groupAddress.Controls.Add(this.lbPriority);
            this.groupAddress.Controls.Add(this.txtStreet);
            this.groupAddress.Controls.Add(this.label4);
            this.groupAddress.Controls.Add(this.cbbCommune);
            this.groupAddress.Controls.Add(this.lbCommune);
            this.groupAddress.Controls.Add(this.cbbDistrict);
            this.groupAddress.Controls.Add(this.lbDistrict);
            this.groupAddress.Controls.Add(this.cbbProvince);
            this.groupAddress.Controls.Add(this.lbProvince);
            this.groupAddress.Location = new System.Drawing.Point(449, 222);
            this.groupAddress.Name = "groupAddress";
            this.groupAddress.Size = new System.Drawing.Size(375, 273);
            this.groupAddress.TabIndex = 70;
            this.groupAddress.TabStop = false;
            this.groupAddress.Text = "Address";
            // 
            // cbbPriority
            // 
            this.cbbPriority.BackColor = System.Drawing.SystemColors.Window;
            this.cbbPriority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbPriority.Enabled = false;
            this.cbbPriority.FormattingEnabled = true;
            this.cbbPriority.ItemHeight = 20;
            this.cbbPriority.Location = new System.Drawing.Point(110, 224);
            this.cbbPriority.Margin = new System.Windows.Forms.Padding(4);
            this.cbbPriority.Name = "cbbPriority";
            this.cbbPriority.Size = new System.Drawing.Size(212, 28);
            this.cbbPriority.TabIndex = 90;
            // 
            // lbPriority
            // 
            this.lbPriority.AutoSize = true;
            this.lbPriority.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriority.Location = new System.Drawing.Point(22, 227);
            this.lbPriority.Name = "lbPriority";
            this.lbPriority.Size = new System.Drawing.Size(61, 20);
            this.lbPriority.TabIndex = 91;
            this.lbPriority.Text = "Priority";
            // 
            // txtStreet
            // 
            this.txtStreet.BackColor = System.Drawing.SystemColors.Control;
            this.txtStreet.Location = new System.Drawing.Point(110, 182);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(212, 27);
            this.txtStreet.TabIndex = 79;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 20);
            this.label4.TabIndex = 78;
            this.label4.Text = "Street";
            // 
            // cbbCommune
            // 
            this.cbbCommune.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCommune.FormattingEnabled = true;
            this.cbbCommune.Location = new System.Drawing.Point(110, 134);
            this.cbbCommune.Name = "cbbCommune";
            this.cbbCommune.Size = new System.Drawing.Size(212, 28);
            this.cbbCommune.TabIndex = 77;
            // 
            // lbCommune
            // 
            this.lbCommune.AutoSize = true;
            this.lbCommune.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCommune.Location = new System.Drawing.Point(22, 134);
            this.lbCommune.Name = "lbCommune";
            this.lbCommune.Size = new System.Drawing.Size(81, 20);
            this.lbCommune.TabIndex = 76;
            this.lbCommune.Text = "Commune";
            // 
            // cbbDistrict
            // 
            this.cbbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDistrict.FormattingEnabled = true;
            this.cbbDistrict.Location = new System.Drawing.Point(110, 87);
            this.cbbDistrict.Name = "cbbDistrict";
            this.cbbDistrict.Size = new System.Drawing.Size(212, 28);
            this.cbbDistrict.TabIndex = 75;
            this.cbbDistrict.SelectedIndexChanged += new System.EventHandler(this.cbbDistrict_SelectedIndexChanged);
            // 
            // lbDistrict
            // 
            this.lbDistrict.AutoSize = true;
            this.lbDistrict.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDistrict.Location = new System.Drawing.Point(22, 87);
            this.lbDistrict.Name = "lbDistrict";
            this.lbDistrict.Size = new System.Drawing.Size(60, 20);
            this.lbDistrict.TabIndex = 74;
            this.lbDistrict.Text = "District";
            // 
            // cbbProvince
            // 
            this.cbbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProvince.FormattingEnabled = true;
            this.cbbProvince.Location = new System.Drawing.Point(110, 40);
            this.cbbProvince.Name = "cbbProvince";
            this.cbbProvince.Size = new System.Drawing.Size(212, 28);
            this.cbbProvince.TabIndex = 73;
            this.cbbProvince.SelectedIndexChanged += new System.EventHandler(this.cbbProvince_SelectedIndexChanged);
            // 
            // lbProvince
            // 
            this.lbProvince.AutoSize = true;
            this.lbProvince.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProvince.Location = new System.Drawing.Point(22, 40);
            this.lbProvince.Name = "lbProvince";
            this.lbProvince.Size = new System.Drawing.Size(69, 20);
            this.lbProvince.TabIndex = 72;
            this.lbProvince.Text = "Province";
            // 
            // groupContact
            // 
            this.groupContact.Controls.Add(this.txtEmail);
            this.groupContact.Controls.Add(this.lbPhone1);
            this.groupContact.Controls.Add(this.lbEmail);
            this.groupContact.Controls.Add(this.txtPhone2);
            this.groupContact.Controls.Add(this.txtPhone1);
            this.groupContact.Controls.Add(this.lbPhone2);
            this.groupContact.Location = new System.Drawing.Point(449, 28);
            this.groupContact.Name = "groupContact";
            this.groupContact.Size = new System.Drawing.Size(375, 178);
            this.groupContact.TabIndex = 69;
            this.groupContact.TabStop = false;
            this.groupContact.Text = "Contact";
            // 
            // txtPhone2
            // 
            this.txtPhone2.BackColor = System.Drawing.SystemColors.Control;
            this.txtPhone2.Location = new System.Drawing.Point(133, 81);
            this.txtPhone2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(212, 27);
            this.txtPhone2.TabIndex = 64;
            // 
            // lbPhone2
            // 
            this.lbPhone2.AutoSize = true;
            this.lbPhone2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone2.Location = new System.Drawing.Point(14, 84);
            this.lbPhone2.Name = "lbPhone2";
            this.lbPhone2.Size = new System.Drawing.Size(66, 20);
            this.lbPhone2.TabIndex = 63;
            this.lbPhone2.Text = "Phone 2";
            // 
            // groupGeneral
            // 
            this.groupGeneral.Controls.Add(this.cbbUserType);
            this.groupGeneral.Controls.Add(this.label1);
            this.groupGeneral.Controls.Add(this.dtpStartDate);
            this.groupGeneral.Controls.Add(this.lbStartDate);
            this.groupGeneral.Controls.Add(this.txtSalary);
            this.groupGeneral.Controls.Add(this.lbSalary);
            this.groupGeneral.Location = new System.Drawing.Point(33, 28);
            this.groupGeneral.Name = "groupGeneral";
            this.groupGeneral.Size = new System.Drawing.Size(375, 178);
            this.groupGeneral.TabIndex = 68;
            this.groupGeneral.TabStop = false;
            this.groupGeneral.Text = "General";
            // 
            // cbbUserType
            // 
            this.cbbUserType.FormattingEnabled = true;
            this.cbbUserType.Items.AddRange(new object[] {
            "EMPLOYEE"});
            this.cbbUserType.Location = new System.Drawing.Point(133, 125);
            this.cbbUserType.Name = "cbbUserType";
            this.cbbUserType.Size = new System.Drawing.Size(212, 28);
            this.cbbUserType.TabIndex = 74;
            this.cbbUserType.Text = "EMPLOYEE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 73;
            this.label1.Text = "User type";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(133, 81);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(212, 27);
            this.dtpStartDate.TabIndex = 71;
            // 
            // lbStartDate
            // 
            this.lbStartDate.AutoSize = true;
            this.lbStartDate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStartDate.Location = new System.Drawing.Point(26, 86);
            this.lbStartDate.Name = "lbStartDate";
            this.lbStartDate.Size = new System.Drawing.Size(78, 20);
            this.lbStartDate.TabIndex = 67;
            this.lbStartDate.Text = "Start date";
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.SystemColors.Control;
            this.txtSalary.Location = new System.Drawing.Point(133, 33);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Size = new System.Drawing.Size(212, 27);
            this.txtSalary.TabIndex = 66;
            // 
            // lbSalary
            // 
            this.lbSalary.AutoSize = true;
            this.lbSalary.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSalary.Location = new System.Drawing.Point(26, 36);
            this.lbSalary.Name = "lbSalary";
            this.lbSalary.Size = new System.Drawing.Size(52, 20);
            this.lbSalary.TabIndex = 65;
            this.lbSalary.Text = "Salary";
            // 
            // groupInfo
            // 
            this.groupInfo.Controls.Add(this.dtpDoB);
            this.groupInfo.Controls.Add(this.txtLastName);
            this.groupInfo.Controls.Add(this.lbLastName);
            this.groupInfo.Controls.Add(this.txtFirstName);
            this.groupInfo.Controls.Add(this.lbFirstName);
            this.groupInfo.Controls.Add(this.lbDoB);
            this.groupInfo.Controls.Add(this.ckbFemale);
            this.groupInfo.Controls.Add(this.txtSSN);
            this.groupInfo.Controls.Add(this.lbSSN);
            this.groupInfo.Controls.Add(this.lbGender);
            this.groupInfo.Location = new System.Drawing.Point(32, 222);
            this.groupInfo.Name = "groupInfo";
            this.groupInfo.Size = new System.Drawing.Size(375, 273);
            this.groupInfo.TabIndex = 67;
            this.groupInfo.TabStop = false;
            this.groupInfo.Text = "Persional Info";
            // 
            // dtpDoB
            // 
            this.dtpDoB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDoB.Location = new System.Drawing.Point(113, 134);
            this.dtpDoB.Name = "dtpDoB";
            this.dtpDoB.Size = new System.Drawing.Size(212, 27);
            this.dtpDoB.TabIndex = 63;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.Control;
            this.txtLastName.Location = new System.Drawing.Point(113, 85);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(212, 27);
            this.txtLastName.TabIndex = 62;
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastName.Location = new System.Drawing.Point(26, 88);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(81, 20);
            this.lbLastName.TabIndex = 61;
            this.lbLastName.Text = "Last name";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstName.Location = new System.Drawing.Point(26, 39);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(83, 20);
            this.lbFirstName.TabIndex = 37;
            this.lbFirstName.Text = "First name";
            // 
            // lbDoB
            // 
            this.lbDoB.AutoSize = true;
            this.lbDoB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoB.Location = new System.Drawing.Point(26, 137);
            this.lbDoB.Name = "lbDoB";
            this.lbDoB.Size = new System.Drawing.Size(39, 20);
            this.lbDoB.TabIndex = 40;
            this.lbDoB.Text = "DoB";
            // 
            // ckbFemale
            // 
            this.ckbFemale.AutoSize = true;
            this.ckbFemale.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbFemale.Location = new System.Drawing.Point(113, 178);
            this.ckbFemale.Margin = new System.Windows.Forms.Padding(4);
            this.ckbFemale.Name = "ckbFemale";
            this.ckbFemale.Size = new System.Drawing.Size(89, 27);
            this.ckbFemale.TabIndex = 60;
            this.ckbFemale.Text = "Female";
            this.ckbFemale.UseVisualStyleBackColor = true;
            // 
            // txtSSN
            // 
            this.txtSSN.BackColor = System.Drawing.SystemColors.Control;
            this.txtSSN.Location = new System.Drawing.Point(113, 222);
            this.txtSSN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(212, 27);
            this.txtSSN.TabIndex = 14;
            // 
            // lbSSN
            // 
            this.lbSSN.AutoSize = true;
            this.lbSSN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSSN.Location = new System.Drawing.Point(26, 224);
            this.lbSSN.Name = "lbSSN";
            this.lbSSN.Size = new System.Drawing.Size(37, 20);
            this.lbSSN.TabIndex = 13;
            this.lbSSN.Text = "SSN";
            // 
            // pnSV
            // 
            this.pnSV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnSV.Controls.Add(this.pnContainer);
            this.pnSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnSV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnSV.Location = new System.Drawing.Point(0, 62);
            this.pnSV.Margin = new System.Windows.Forms.Padding(4);
            this.pnSV.Name = "pnSV";
            this.pnSV.Size = new System.Drawing.Size(1167, 560);
            this.pnSV.TabIndex = 35;
            // 
            // FrmEmployeeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1167, 622);
            this.Controls.Add(this.pnSV);
            this.Controls.Add(this.pnTop);
            this.Name = "FrmEmployeeInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.FrmEmployeeInfo_Load);
            this.pnTop.ResumeLayout(false);
            this.pnContainer.ResumeLayout(false);
            this.tlpBottom.ResumeLayout(false);
            this.groupAvatar.ResumeLayout(false);
            this.groupAvatar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).EndInit();
            this.groupAddress.ResumeLayout(false);
            this.groupAddress.PerformLayout();
            this.groupContact.ResumeLayout(false);
            this.groupContact.PerformLayout();
            this.groupGeneral.ResumeLayout(false);
            this.groupGeneral.PerformLayout();
            this.groupInfo.ResumeLayout(false);
            this.groupInfo.PerformLayout();
            this.pnSV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone1;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPhone1;
        private System.Windows.Forms.CheckBox ckbFemale;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.Label lbSSN;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbDoB;
        private System.Windows.Forms.Panel pnSV;
        private System.Windows.Forms.TextBox txtSalary;
        private System.Windows.Forms.Label lbSalary;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.Label lbPhone2;
        private System.Windows.Forms.GroupBox groupGeneral;
        private System.Windows.Forms.Label lbStartDate;
        private System.Windows.Forms.GroupBox groupInfo;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.GroupBox groupAvatar;
        private System.Windows.Forms.Label lbProfilePhoto;
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.PictureBox picAvt;
        private System.Windows.Forms.GroupBox groupAddress;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbCommune;
        private System.Windows.Forms.Label lbCommune;
        private System.Windows.Forms.ComboBox cbbDistrict;
        private System.Windows.Forms.Label lbDistrict;
        private System.Windows.Forms.ComboBox cbbProvince;
        private System.Windows.Forms.Label lbProvince;
        private System.Windows.Forms.GroupBox groupContact;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.DateTimePicker dtpDoB;
        private System.Windows.Forms.ComboBox cbbPriority;
        private System.Windows.Forms.Label lbPriority;
        private System.Windows.Forms.ComboBox cbbUserType;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Panel pnContainer;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.TableLayoutPanel tlpBottom;
    }
}