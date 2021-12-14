namespace DormitoryManagement.View
{
    partial class FrmStudentInfo
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
            this.btnChoose = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnSV = new System.Windows.Forms.Panel();
            this.pnContainer = new System.Windows.Forms.Panel();
            this.tlpBottom = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.groupUniversity = new System.Windows.Forms.GroupBox();
            this.txtMajor = new System.Windows.Forms.TextBox();
            this.txtFaculty = new System.Windows.Forms.TextBox();
            this.lbMajor = new System.Windows.Forms.Label();
            this.lbFaculty = new System.Windows.Forms.Label();
            this.cbbUniversity = new System.Windows.Forms.ComboBox();
            this.lbUniversity = new System.Windows.Forms.Label();
            this.groupAddress = new System.Windows.Forms.GroupBox();
            this.cbbPriority = new System.Windows.Forms.ComboBox();
            this.lbPriority = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lbAddress = new System.Windows.Forms.Label();
            this.cbbCommune = new System.Windows.Forms.ComboBox();
            this.cbbDistrict = new System.Windows.Forms.ComboBox();
            this.cbbProvince = new System.Windows.Forms.ComboBox();
            this.lbProvince = new System.Windows.Forms.Label();
            this.lbCommune = new System.Windows.Forms.Label();
            this.lbDistrict = new System.Windows.Forms.Label();
            this.groupContact = new System.Windows.Forms.GroupBox();
            this.txtPhone2 = new System.Windows.Forms.TextBox();
            this.lbPhone2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone1 = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbPhone1 = new System.Windows.Forms.Label();
            this.groupAvatar = new System.Windows.Forms.GroupBox();
            this.picAvt = new System.Windows.Forms.PictureBox();
            this.groupPersionalInfo = new System.Windows.Forms.GroupBox();
            this.txtHealthInsurance = new System.Windows.Forms.TextBox();
            this.lbInsuranceID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lbSSN = new System.Windows.Forms.Label();
            this.ckbFemale = new System.Windows.Forms.CheckBox();
            this.lbGender = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbDoB = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lbStudentID = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.pnTop = new System.Windows.Forms.Panel();
            this.pnSV.SuspendLayout();
            this.pnContainer.SuspendLayout();
            this.tlpBottom.SuspendLayout();
            this.groupUniversity.SuspendLayout();
            this.groupAddress.SuspendLayout();
            this.groupContact.SuspendLayout();
            this.groupAvatar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).BeginInit();
            this.groupPersionalInfo.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChoose
            // 
            this.btnChoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChoose.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnChoose.Location = new System.Drawing.Point(81, 312);
            this.btnChoose.Margin = new System.Windows.Forms.Padding(4);
            this.btnChoose.Name = "btnChoose";
            this.btnChoose.Size = new System.Drawing.Size(100, 37);
            this.btnChoose.TabIndex = 21;
            this.btnChoose.Text = "CHOOSE";
            this.btnChoose.UseVisualStyleBackColor = true;
            this.btnChoose.Click += new System.EventHandler(this.btnChoose_Click);
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
            this.lbTitle.Size = new System.Drawing.Size(1498, 62);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "STUDENT INFORMATION";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.pnSV.Size = new System.Drawing.Size(1498, 471);
            this.pnSV.TabIndex = 32;
            // 
            // pnContainer
            // 
            this.pnContainer.Controls.Add(this.tlpBottom);
            this.pnContainer.Controls.Add(this.groupUniversity);
            this.pnContainer.Controls.Add(this.groupAddress);
            this.pnContainer.Controls.Add(this.groupContact);
            this.pnContainer.Controls.Add(this.groupAvatar);
            this.pnContainer.Controls.Add(this.groupPersionalInfo);
            this.pnContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnContainer.Location = new System.Drawing.Point(0, 0);
            this.pnContainer.Margin = new System.Windows.Forms.Padding(4);
            this.pnContainer.Name = "pnContainer";
            this.pnContainer.Size = new System.Drawing.Size(1498, 471);
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
            this.tlpBottom.Location = new System.Drawing.Point(0, 427);
            this.tlpBottom.Name = "tlpBottom";
            this.tlpBottom.RowCount = 1;
            this.tlpBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBottom.Size = new System.Drawing.Size(1498, 44);
            this.tlpBottom.TabIndex = 74;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Crimson;
            this.btnDelete.Location = new System.Drawing.Point(1001, 2);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(494, 40);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSave.Location = new System.Drawing.Point(502, 2);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(493, 40);
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
            this.btnEdit.Size = new System.Drawing.Size(493, 40);
            this.btnEdit.TabIndex = 29;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click_1);
            // 
            // groupUniversity
            // 
            this.groupUniversity.Controls.Add(this.txtMajor);
            this.groupUniversity.Controls.Add(this.txtFaculty);
            this.groupUniversity.Controls.Add(this.lbMajor);
            this.groupUniversity.Controls.Add(this.lbFaculty);
            this.groupUniversity.Controls.Add(this.cbbUniversity);
            this.groupUniversity.Controls.Add(this.lbUniversity);
            this.groupUniversity.Location = new System.Drawing.Point(811, 233);
            this.groupUniversity.Name = "groupUniversity";
            this.groupUniversity.Size = new System.Drawing.Size(349, 170);
            this.groupUniversity.TabIndex = 73;
            this.groupUniversity.TabStop = false;
            this.groupUniversity.Text = "University";
            // 
            // txtMajor
            // 
            this.txtMajor.Location = new System.Drawing.Point(106, 124);
            this.txtMajor.Name = "txtMajor";
            this.txtMajor.Size = new System.Drawing.Size(212, 27);
            this.txtMajor.TabIndex = 86;
            // 
            // txtFaculty
            // 
            this.txtFaculty.Location = new System.Drawing.Point(106, 76);
            this.txtFaculty.Name = "txtFaculty";
            this.txtFaculty.Size = new System.Drawing.Size(212, 27);
            this.txtFaculty.TabIndex = 74;
            // 
            // lbMajor
            // 
            this.lbMajor.AutoSize = true;
            this.lbMajor.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMajor.Location = new System.Drawing.Point(15, 127);
            this.lbMajor.Name = "lbMajor";
            this.lbMajor.Size = new System.Drawing.Size(50, 20);
            this.lbMajor.TabIndex = 85;
            this.lbMajor.Text = "Major";
            // 
            // lbFaculty
            // 
            this.lbFaculty.AutoSize = true;
            this.lbFaculty.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFaculty.Location = new System.Drawing.Point(15, 79);
            this.lbFaculty.Name = "lbFaculty";
            this.lbFaculty.Size = new System.Drawing.Size(59, 20);
            this.lbFaculty.TabIndex = 83;
            this.lbFaculty.Text = "Faculty";
            // 
            // cbbUniversity
            // 
            this.cbbUniversity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbUniversity.FormattingEnabled = true;
            this.cbbUniversity.Location = new System.Drawing.Point(105, 28);
            this.cbbUniversity.Name = "cbbUniversity";
            this.cbbUniversity.Size = new System.Drawing.Size(212, 28);
            this.cbbUniversity.TabIndex = 15;
            // 
            // lbUniversity
            // 
            this.lbUniversity.AutoSize = true;
            this.lbUniversity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUniversity.Location = new System.Drawing.Point(16, 34);
            this.lbUniversity.Name = "lbUniversity";
            this.lbUniversity.Size = new System.Drawing.Size(80, 20);
            this.lbUniversity.TabIndex = 73;
            this.lbUniversity.Text = "University";
            // 
            // groupAddress
            // 
            this.groupAddress.Controls.Add(this.cbbPriority);
            this.groupAddress.Controls.Add(this.lbPriority);
            this.groupAddress.Controls.Add(this.txtAddress);
            this.groupAddress.Controls.Add(this.lbAddress);
            this.groupAddress.Controls.Add(this.cbbCommune);
            this.groupAddress.Controls.Add(this.cbbDistrict);
            this.groupAddress.Controls.Add(this.cbbProvince);
            this.groupAddress.Controls.Add(this.lbProvince);
            this.groupAddress.Controls.Add(this.lbCommune);
            this.groupAddress.Controls.Add(this.lbDistrict);
            this.groupAddress.Location = new System.Drawing.Point(430, 28);
            this.groupAddress.Name = "groupAddress";
            this.groupAddress.Size = new System.Drawing.Size(345, 375);
            this.groupAddress.TabIndex = 66;
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
            this.cbbPriority.Items.AddRange(new object[] {
            "1",
            "2",
            "2NT",
            "3"});
            this.cbbPriority.Location = new System.Drawing.Point(106, 231);
            this.cbbPriority.Margin = new System.Windows.Forms.Padding(4);
            this.cbbPriority.Name = "cbbPriority";
            this.cbbPriority.Size = new System.Drawing.Size(212, 28);
            this.cbbPriority.TabIndex = 88;
            // 
            // lbPriority
            // 
            this.lbPriority.AutoSize = true;
            this.lbPriority.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPriority.Location = new System.Drawing.Point(18, 234);
            this.lbPriority.Name = "lbPriority";
            this.lbPriority.Size = new System.Drawing.Size(61, 20);
            this.lbPriority.TabIndex = 89;
            this.lbPriority.Text = "Priority";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Control;
            this.txtAddress.Location = new System.Drawing.Point(106, 183);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(212, 27);
            this.txtAddress.TabIndex = 70;
            // 
            // lbAddress
            // 
            this.lbAddress.AutoSize = true;
            this.lbAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddress.Location = new System.Drawing.Point(18, 183);
            this.lbAddress.Name = "lbAddress";
            this.lbAddress.Size = new System.Drawing.Size(66, 20);
            this.lbAddress.TabIndex = 69;
            this.lbAddress.Text = "Address";
            // 
            // cbbCommune
            // 
            this.cbbCommune.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCommune.FormattingEnabled = true;
            this.cbbCommune.Location = new System.Drawing.Point(106, 134);
            this.cbbCommune.Margin = new System.Windows.Forms.Padding(4);
            this.cbbCommune.Name = "cbbCommune";
            this.cbbCommune.Size = new System.Drawing.Size(212, 28);
            this.cbbCommune.TabIndex = 14;
            // 
            // cbbDistrict
            // 
            this.cbbDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbDistrict.FormattingEnabled = true;
            this.cbbDistrict.Location = new System.Drawing.Point(106, 83);
            this.cbbDistrict.Margin = new System.Windows.Forms.Padding(4);
            this.cbbDistrict.Name = "cbbDistrict";
            this.cbbDistrict.Size = new System.Drawing.Size(212, 28);
            this.cbbDistrict.TabIndex = 13;
            this.cbbDistrict.SelectedIndexChanged += new System.EventHandler(this.cmbDistrict_SelectedIndexChanged);
            // 
            // cbbProvince
            // 
            this.cbbProvince.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbProvince.FormattingEnabled = true;
            this.cbbProvince.Location = new System.Drawing.Point(106, 32);
            this.cbbProvince.Name = "cbbProvince";
            this.cbbProvince.Size = new System.Drawing.Size(212, 28);
            this.cbbProvince.TabIndex = 12;
            this.cbbProvince.SelectedIndexChanged += new System.EventHandler(this.cmbProvice_SelectedIndexChanged);
            // 
            // lbProvince
            // 
            this.lbProvince.AutoSize = true;
            this.lbProvince.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProvince.Location = new System.Drawing.Point(18, 32);
            this.lbProvince.Name = "lbProvince";
            this.lbProvince.Size = new System.Drawing.Size(69, 20);
            this.lbProvince.TabIndex = 68;
            this.lbProvince.Text = "Province";
            // 
            // lbCommune
            // 
            this.lbCommune.AutoSize = true;
            this.lbCommune.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCommune.Location = new System.Drawing.Point(18, 134);
            this.lbCommune.Name = "lbCommune";
            this.lbCommune.Size = new System.Drawing.Size(81, 20);
            this.lbCommune.TabIndex = 67;
            this.lbCommune.Text = "Commune";
            // 
            // lbDistrict
            // 
            this.lbDistrict.AutoSize = true;
            this.lbDistrict.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDistrict.Location = new System.Drawing.Point(18, 83);
            this.lbDistrict.Name = "lbDistrict";
            this.lbDistrict.Size = new System.Drawing.Size(60, 20);
            this.lbDistrict.TabIndex = 64;
            this.lbDistrict.Text = "District";
            // 
            // groupContact
            // 
            this.groupContact.Controls.Add(this.txtPhone2);
            this.groupContact.Controls.Add(this.lbPhone2);
            this.groupContact.Controls.Add(this.txtEmail);
            this.groupContact.Controls.Add(this.txtPhone1);
            this.groupContact.Controls.Add(this.lbEmail);
            this.groupContact.Controls.Add(this.lbPhone1);
            this.groupContact.Location = new System.Drawing.Point(815, 28);
            this.groupContact.Name = "groupContact";
            this.groupContact.Size = new System.Drawing.Size(345, 183);
            this.groupContact.TabIndex = 65;
            this.groupContact.TabStop = false;
            this.groupContact.Text = "Contact";
            // 
            // txtPhone2
            // 
            this.txtPhone2.BackColor = System.Drawing.SystemColors.Control;
            this.txtPhone2.Location = new System.Drawing.Point(106, 83);
            this.txtPhone2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone2.Name = "txtPhone2";
            this.txtPhone2.Size = new System.Drawing.Size(212, 27);
            this.txtPhone2.TabIndex = 10;
            // 
            // lbPhone2
            // 
            this.lbPhone2.AutoSize = true;
            this.lbPhone2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone2.Location = new System.Drawing.Point(20, 83);
            this.lbPhone2.Name = "lbPhone2";
            this.lbPhone2.Size = new System.Drawing.Size(66, 20);
            this.lbPhone2.TabIndex = 69;
            this.lbPhone2.Text = "Phone 2";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Control;
            this.txtEmail.Location = new System.Drawing.Point(106, 134);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(212, 27);
            this.txtEmail.TabIndex = 11;
            // 
            // txtPhone1
            // 
            this.txtPhone1.BackColor = System.Drawing.SystemColors.Control;
            this.txtPhone1.Location = new System.Drawing.Point(106, 32);
            this.txtPhone1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPhone1.Name = "txtPhone1";
            this.txtPhone1.Size = new System.Drawing.Size(212, 27);
            this.txtPhone1.TabIndex = 9;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(20, 134);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(47, 20);
            this.lbEmail.TabIndex = 67;
            this.lbEmail.Text = "Email";
            // 
            // lbPhone1
            // 
            this.lbPhone1.AutoSize = true;
            this.lbPhone1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhone1.Location = new System.Drawing.Point(20, 32);
            this.lbPhone1.Name = "lbPhone1";
            this.lbPhone1.Size = new System.Drawing.Size(66, 20);
            this.lbPhone1.TabIndex = 65;
            this.lbPhone1.Text = "Phone 1";
            // 
            // groupAvatar
            // 
            this.groupAvatar.Controls.Add(this.picAvt);
            this.groupAvatar.Controls.Add(this.btnChoose);
            this.groupAvatar.Location = new System.Drawing.Point(1198, 28);
            this.groupAvatar.Name = "groupAvatar";
            this.groupAvatar.Size = new System.Drawing.Size(265, 375);
            this.groupAvatar.TabIndex = 62;
            this.groupAvatar.TabStop = false;
            this.groupAvatar.Text = "Avatar";
            // 
            // picAvt
            // 
            this.picAvt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picAvt.Location = new System.Drawing.Point(41, 43);
            this.picAvt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picAvt.Name = "picAvt";
            this.picAvt.Size = new System.Drawing.Size(180, 240);
            this.picAvt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAvt.TabIndex = 52;
            this.picAvt.TabStop = false;
            // 
            // groupPersionalInfo
            // 
            this.groupPersionalInfo.Controls.Add(this.txtHealthInsurance);
            this.groupPersionalInfo.Controls.Add(this.lbInsuranceID);
            this.groupPersionalInfo.Controls.Add(this.txtID);
            this.groupPersionalInfo.Controls.Add(this.lbSSN);
            this.groupPersionalInfo.Controls.Add(this.ckbFemale);
            this.groupPersionalInfo.Controls.Add(this.lbGender);
            this.groupPersionalInfo.Controls.Add(this.dateTimePicker1);
            this.groupPersionalInfo.Controls.Add(this.lbDoB);
            this.groupPersionalInfo.Controls.Add(this.txtStudentID);
            this.groupPersionalInfo.Controls.Add(this.lbStudentID);
            this.groupPersionalInfo.Controls.Add(this.lbLastName);
            this.groupPersionalInfo.Controls.Add(this.txtLastName);
            this.groupPersionalInfo.Controls.Add(this.lbFirstName);
            this.groupPersionalInfo.Controls.Add(this.txtFirstName);
            this.groupPersionalInfo.Location = new System.Drawing.Point(32, 28);
            this.groupPersionalInfo.Name = "groupPersionalInfo";
            this.groupPersionalInfo.Size = new System.Drawing.Size(360, 375);
            this.groupPersionalInfo.TabIndex = 61;
            this.groupPersionalInfo.TabStop = false;
            this.groupPersionalInfo.Text = "Persional Info";
            // 
            // txtHealthInsurance
            // 
            this.txtHealthInsurance.BackColor = System.Drawing.SystemColors.Control;
            this.txtHealthInsurance.Location = new System.Drawing.Point(123, 326);
            this.txtHealthInsurance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHealthInsurance.Name = "txtHealthInsurance";
            this.txtHealthInsurance.Size = new System.Drawing.Size(212, 27);
            this.txtHealthInsurance.TabIndex = 7;
            // 
            // lbInsuranceID
            // 
            this.lbInsuranceID.AutoSize = true;
            this.lbInsuranceID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInsuranceID.Location = new System.Drawing.Point(20, 329);
            this.lbInsuranceID.Name = "lbInsuranceID";
            this.lbInsuranceID.Size = new System.Drawing.Size(97, 20);
            this.lbInsuranceID.TabIndex = 85;
            this.lbInsuranceID.Text = "Insurance ID";
            this.lbInsuranceID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.SystemColors.Control;
            this.txtID.Location = new System.Drawing.Point(123, 274);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(212, 27);
            this.txtID.TabIndex = 6;
            // 
            // lbSSN
            // 
            this.lbSSN.AutoSize = true;
            this.lbSSN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSSN.Location = new System.Drawing.Point(20, 277);
            this.lbSSN.Name = "lbSSN";
            this.lbSSN.Size = new System.Drawing.Size(37, 20);
            this.lbSSN.TabIndex = 83;
            this.lbSSN.Text = "SSN";
            // 
            // ckbFemale
            // 
            this.ckbFemale.AutoSize = true;
            this.ckbFemale.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbFemale.Location = new System.Drawing.Point(123, 228);
            this.ckbFemale.Margin = new System.Windows.Forms.Padding(4);
            this.ckbFemale.Name = "ckbFemale";
            this.ckbFemale.Size = new System.Drawing.Size(89, 27);
            this.ckbFemale.TabIndex = 5;
            this.ckbFemale.Text = "Female";
            this.ckbFemale.UseVisualStyleBackColor = true;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGender.Location = new System.Drawing.Point(20, 231);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(60, 20);
            this.lbGender.TabIndex = 79;
            this.lbGender.Text = "Gender";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(123, 183);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(212, 27);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // lbDoB
            // 
            this.lbDoB.AutoSize = true;
            this.lbDoB.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDoB.Location = new System.Drawing.Point(20, 183);
            this.lbDoB.Name = "lbDoB";
            this.lbDoB.Size = new System.Drawing.Size(39, 20);
            this.lbDoB.TabIndex = 77;
            this.lbDoB.Text = "DoB";
            // 
            // txtStudentID
            // 
            this.txtStudentID.BackColor = System.Drawing.SystemColors.Control;
            this.txtStudentID.Location = new System.Drawing.Point(123, 32);
            this.txtStudentID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(212, 27);
            this.txtStudentID.TabIndex = 1;
            // 
            // lbStudentID
            // 
            this.lbStudentID.AutoSize = true;
            this.lbStudentID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentID.Location = new System.Drawing.Point(20, 32);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(84, 20);
            this.lbStudentID.TabIndex = 75;
            this.lbStudentID.Text = "Student ID";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastName.Location = new System.Drawing.Point(20, 134);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(81, 20);
            this.lbLastName.TabIndex = 73;
            this.lbLastName.Text = "Last name";
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.Control;
            this.txtLastName.Location = new System.Drawing.Point(123, 134);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(212, 27);
            this.txtLastName.TabIndex = 3;
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFirstName.Location = new System.Drawing.Point(20, 83);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(83, 20);
            this.lbFirstName.TabIndex = 71;
            this.lbFirstName.Text = "First name";
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.Control;
            this.txtFirstName.Location = new System.Drawing.Point(123, 83);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(212, 27);
            this.txtFirstName.TabIndex = 2;
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.lbTitle);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnTop.MinimumSize = new System.Drawing.Size(959, 62);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1498, 62);
            this.pnTop.TabIndex = 34;
            // 
            // FrmStudentInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1498, 533);
            this.Controls.Add(this.pnSV);
            this.Controls.Add(this.pnTop);
            this.MaximizeBox = false;
            this.Name = "FrmStudentInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student";
            this.Load += new System.EventHandler(this.FrmStudentInfo_Load);
            this.pnSV.ResumeLayout(false);
            this.pnContainer.ResumeLayout(false);
            this.tlpBottom.ResumeLayout(false);
            this.groupUniversity.ResumeLayout(false);
            this.groupUniversity.PerformLayout();
            this.groupAddress.ResumeLayout(false);
            this.groupAddress.PerformLayout();
            this.groupContact.ResumeLayout(false);
            this.groupContact.PerformLayout();
            this.groupAvatar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvt)).EndInit();
            this.groupPersionalInfo.ResumeLayout(false);
            this.groupPersionalInfo.PerformLayout();
            this.pnTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnChoose;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel pnSV;
        private System.Windows.Forms.Panel pnContainer;
        private System.Windows.Forms.PictureBox picAvt;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.GroupBox groupPersionalInfo;
        private System.Windows.Forms.GroupBox groupAvatar;
        private System.Windows.Forms.GroupBox groupAddress;
        private System.Windows.Forms.Label lbProvince;
        private System.Windows.Forms.Label lbCommune;
        private System.Windows.Forms.Label lbDistrict;
        private System.Windows.Forms.GroupBox groupContact;
        private System.Windows.Forms.TextBox txtPhone2;
        private System.Windows.Forms.Label lbPhone2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone1;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbPhone1;
        private System.Windows.Forms.TextBox txtHealthInsurance;
        private System.Windows.Forms.Label lbInsuranceID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lbSSN;
        private System.Windows.Forms.CheckBox ckbFemale;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbDoB;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lbStudentID;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.GroupBox groupUniversity;
        private System.Windows.Forms.Label lbMajor;
        private System.Windows.Forms.Label lbFaculty;
        private System.Windows.Forms.ComboBox cbbUniversity;
        private System.Windows.Forms.Label lbUniversity;
        private System.Windows.Forms.ComboBox cbbCommune;
        private System.Windows.Forms.ComboBox cbbDistrict;
        private System.Windows.Forms.ComboBox cbbProvince;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lbAddress;
        private System.Windows.Forms.TextBox txtMajor;
        private System.Windows.Forms.TextBox txtFaculty;
        private System.Windows.Forms.ComboBox cbbPriority;
        private System.Windows.Forms.Label lbPriority;
        private System.Windows.Forms.TableLayoutPanel tlpBottom;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEdit;
    }
}