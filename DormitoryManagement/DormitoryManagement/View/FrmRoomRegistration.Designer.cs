namespace DormitoryManagement.View
{
    partial class FrmRoomRegistration
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
            this.lbNgayGioDK = new System.Windows.Forms.Label();
            this.lbNgay = new System.Windows.Forms.Label();
            this.lbEmployeeID = new System.Windows.Forms.Label();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lbDuration = new System.Windows.Forms.Label();
            this.blStartDate = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbbDuration = new System.Windows.Forms.ComboBox();
            this.cmbBuilding = new System.Windows.Forms.ComboBox();
            this.cmbRoom = new System.Windows.Forms.ComboBox();
            this.cmbSemester = new System.Windows.Forms.ComboBox();
            this.lbBuilding = new System.Windows.Forms.Label();
            this.txtAcademicYear = new System.Windows.Forms.TextBox();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.lbAcademicYear = new System.Windows.Forms.Label();
            this.lbSemester = new System.Windows.Forms.Label();
            this.lbRoom = new System.Windows.Forms.Label();
            this.lbStudentID = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.lbPhieuDangKy = new System.Windows.Forms.Label();
            this.lbMaNV = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tlpBottom = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.tlpBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbNgayGioDK
            // 
            this.lbNgayGioDK.AutoSize = true;
            this.lbNgayGioDK.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNgayGioDK.Location = new System.Drawing.Point(483, 98);
            this.lbNgayGioDK.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgayGioDK.Name = "lbNgayGioDK";
            this.lbNgayGioDK.Size = new System.Drawing.Size(32, 17);
            this.lbNgayGioDK.TabIndex = 43;
            this.lbNgayGioDK.Text = "      ";
            // 
            // lbNgay
            // 
            this.lbNgay.AutoSize = true;
            this.lbNgay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbNgay.Location = new System.Drawing.Point(371, 98);
            this.lbNgay.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNgay.Name = "lbNgay";
            this.lbNgay.Size = new System.Drawing.Size(94, 17);
            this.lbNgay.TabIndex = 41;
            this.lbNgay.Text = "Created date:";
            // 
            // lbEmployeeID
            // 
            this.lbEmployeeID.AutoSize = true;
            this.lbEmployeeID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbEmployeeID.Location = new System.Drawing.Point(38, 98);
            this.lbEmployeeID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEmployeeID.Name = "lbEmployeeID";
            this.lbEmployeeID.Size = new System.Drawing.Size(91, 17);
            this.lbEmployeeID.TabIndex = 40;
            this.lbEmployeeID.Text = "Employee ID:";
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.CustomFormat = "yyyy-MM-dd";
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStartDate.Location = new System.Drawing.Point(44, 186);
            this.dtpStartDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(217, 24);
            this.dtpStartDate.TabIndex = 35;
            // 
            // lbDuration
            // 
            this.lbDuration.AutoSize = true;
            this.lbDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDuration.Location = new System.Drawing.Point(327, 161);
            this.lbDuration.Name = "lbDuration";
            this.lbDuration.Size = new System.Drawing.Size(81, 20);
            this.lbDuration.TabIndex = 33;
            this.lbDuration.Text = "Duration";
            // 
            // blStartDate
            // 
            this.blStartDate.AutoSize = true;
            this.blStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blStartDate.Location = new System.Drawing.Point(39, 159);
            this.blStartDate.Name = "blStartDate";
            this.blStartDate.Size = new System.Drawing.Size(92, 20);
            this.blStartDate.TabIndex = 31;
            this.blStartDate.Text = "Start date";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cbbDuration);
            this.panel1.Controls.Add(this.dtpStartDate);
            this.panel1.Controls.Add(this.lbDuration);
            this.panel1.Controls.Add(this.blStartDate);
            this.panel1.Controls.Add(this.cmbBuilding);
            this.panel1.Controls.Add(this.cmbRoom);
            this.panel1.Controls.Add(this.cmbSemester);
            this.panel1.Controls.Add(this.lbBuilding);
            this.panel1.Controls.Add(this.txtAcademicYear);
            this.panel1.Controls.Add(this.txtSSN);
            this.panel1.Controls.Add(this.lbAcademicYear);
            this.panel1.Controls.Add(this.lbSemester);
            this.panel1.Controls.Add(this.lbRoom);
            this.panel1.Controls.Add(this.lbStudentID);
            this.panel1.Location = new System.Drawing.Point(42, 118);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(595, 239);
            this.panel1.TabIndex = 39;
            // 
            // cbbDuration
            // 
            this.cbbDuration.FormattingEnabled = true;
            this.cbbDuration.Location = new System.Drawing.Point(327, 186);
            this.cbbDuration.Name = "cbbDuration";
            this.cbbDuration.Size = new System.Drawing.Size(217, 24);
            this.cbbDuration.TabIndex = 36;
            // 
            // cmbBuilding
            // 
            this.cmbBuilding.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.cmbBuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuilding.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBuilding.FormattingEnabled = true;
            this.cmbBuilding.Location = new System.Drawing.Point(43, 117);
            this.cmbBuilding.Margin = new System.Windows.Forms.Padding(4);
            this.cmbBuilding.Name = "cmbBuilding";
            this.cmbBuilding.Size = new System.Drawing.Size(96, 28);
            this.cmbBuilding.TabIndex = 30;
            this.cmbBuilding.SelectedValueChanged += new System.EventHandler(this.cmbBuilding_SelectedValueChanged);
            // 
            // cmbRoom
            // 
            this.cmbRoom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.cmbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRoom.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRoom.FormattingEnabled = true;
            this.cmbRoom.Location = new System.Drawing.Point(151, 117);
            this.cmbRoom.Margin = new System.Windows.Forms.Padding(4);
            this.cmbRoom.Name = "cmbRoom";
            this.cmbRoom.Size = new System.Drawing.Size(108, 28);
            this.cmbRoom.TabIndex = 29;
            // 
            // cmbSemester
            // 
            this.cmbSemester.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.cmbSemester.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSemester.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSemester.FormattingEnabled = true;
            this.cmbSemester.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbSemester.Location = new System.Drawing.Point(327, 50);
            this.cmbSemester.Margin = new System.Windows.Forms.Padding(4);
            this.cmbSemester.Name = "cmbSemester";
            this.cmbSemester.Size = new System.Drawing.Size(217, 28);
            this.cmbSemester.TabIndex = 28;
            // 
            // lbBuilding
            // 
            this.lbBuilding.AutoSize = true;
            this.lbBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBuilding.Location = new System.Drawing.Point(40, 94);
            this.lbBuilding.Name = "lbBuilding";
            this.lbBuilding.Size = new System.Drawing.Size(77, 20);
            this.lbBuilding.TabIndex = 22;
            this.lbBuilding.Text = "Building";
            // 
            // txtAcademicYear
            // 
            this.txtAcademicYear.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtAcademicYear.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtAcademicYear.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAcademicYear.Location = new System.Drawing.Point(327, 117);
            this.txtAcademicYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAcademicYear.Name = "txtAcademicYear";
            this.txtAcademicYear.Size = new System.Drawing.Size(217, 27);
            this.txtAcademicYear.TabIndex = 15;
            this.txtAcademicYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSSN
            // 
            this.txtSSN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSSN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.txtSSN.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSSN.Location = new System.Drawing.Point(44, 50);
            this.txtSSN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSSN.Name = "txtSSN";
            this.txtSSN.Size = new System.Drawing.Size(217, 27);
            this.txtSSN.TabIndex = 14;
            this.txtSSN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbAcademicYear
            // 
            this.lbAcademicYear.AutoSize = true;
            this.lbAcademicYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAcademicYear.Location = new System.Drawing.Point(327, 92);
            this.lbAcademicYear.Name = "lbAcademicYear";
            this.lbAcademicYear.Size = new System.Drawing.Size(133, 20);
            this.lbAcademicYear.TabIndex = 5;
            this.lbAcademicYear.Text = "Academic year";
            // 
            // lbSemester
            // 
            this.lbSemester.AutoSize = true;
            this.lbSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSemester.Location = new System.Drawing.Point(327, 27);
            this.lbSemester.Name = "lbSemester";
            this.lbSemester.Size = new System.Drawing.Size(89, 20);
            this.lbSemester.TabIndex = 4;
            this.lbSemester.Text = "Semester";
            // 
            // lbRoom
            // 
            this.lbRoom.AutoSize = true;
            this.lbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRoom.Location = new System.Drawing.Point(147, 94);
            this.lbRoom.Name = "lbRoom";
            this.lbRoom.Size = new System.Drawing.Size(57, 20);
            this.lbRoom.TabIndex = 3;
            this.lbRoom.Text = "Room";
            // 
            // lbStudentID
            // 
            this.lbStudentID.AutoSize = true;
            this.lbStudentID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStudentID.Location = new System.Drawing.Point(40, 25);
            this.lbStudentID.Name = "lbStudentID";
            this.lbStudentID.Size = new System.Drawing.Size(46, 20);
            this.lbStudentID.TabIndex = 0;
            this.lbStudentID.Text = "SSN";
            // 
            // btnOK
            // 
            this.btnOK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.DodgerBlue;
            this.btnOK.Location = new System.Drawing.Point(3, 2);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(192, 36);
            this.btnOK.TabIndex = 37;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrint.Enabled = false;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(202, 4);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(190, 32);
            this.btnPrint.TabIndex = 38;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // lbPhieuDangKy
            // 
            this.lbPhieuDangKy.BackColor = System.Drawing.Color.Goldenrod;
            this.lbPhieuDangKy.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbPhieuDangKy.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPhieuDangKy.ForeColor = System.Drawing.Color.DarkRed;
            this.lbPhieuDangKy.Location = new System.Drawing.Point(0, 0);
            this.lbPhieuDangKy.Name = "lbPhieuDangKy";
            this.lbPhieuDangKy.Size = new System.Drawing.Size(679, 66);
            this.lbPhieuDangKy.TabIndex = 36;
            this.lbPhieuDangKy.Text = "ROOM REGISTRATION";
            this.lbPhieuDangKy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMaNV
            // 
            this.lbMaNV.AutoSize = true;
            this.lbMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaNV.Location = new System.Drawing.Point(146, 98);
            this.lbMaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaNV.Name = "lbMaNV";
            this.lbMaNV.Size = new System.Drawing.Size(32, 17);
            this.lbMaNV.TabIndex = 42;
            this.lbMaNV.Text = "      ";
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.Crimson;
            this.btnDelete.Location = new System.Drawing.Point(400, 4);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(192, 32);
            this.btnDelete.TabIndex = 44;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tlpBottom
            // 
            this.tlpBottom.ColumnCount = 3;
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBottom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBottom.Controls.Add(this.btnOK, 0, 0);
            this.tlpBottom.Controls.Add(this.btnDelete, 2, 0);
            this.tlpBottom.Controls.Add(this.btnPrint, 1, 0);
            this.tlpBottom.Location = new System.Drawing.Point(41, 389);
            this.tlpBottom.Name = "tlpBottom";
            this.tlpBottom.RowCount = 1;
            this.tlpBottom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBottom.Size = new System.Drawing.Size(596, 40);
            this.tlpBottom.TabIndex = 44;
            // 
            // FrmRoomRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 441);
            this.Controls.Add(this.tlpBottom);
            this.Controls.Add(this.lbNgayGioDK);
            this.Controls.Add(this.lbNgay);
            this.Controls.Add(this.lbEmployeeID);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbPhieuDangKy);
            this.Controls.Add(this.lbMaNV);
            this.MaximizeBox = false;
            this.Name = "FrmRoomRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Room Registration";
            this.Load += new System.EventHandler(this.FrmRoomRegistration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tlpBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNgayGioDK;
        private System.Windows.Forms.Label lbNgay;
        private System.Windows.Forms.Label lbEmployeeID;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lbDuration;
        private System.Windows.Forms.Label blStartDate;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbBuilding;
        private System.Windows.Forms.ComboBox cmbRoom;
        private System.Windows.Forms.ComboBox cmbSemester;
        private System.Windows.Forms.Label lbBuilding;
        private System.Windows.Forms.TextBox txtAcademicYear;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.Label lbAcademicYear;
        private System.Windows.Forms.Label lbSemester;
        private System.Windows.Forms.Label lbRoom;
        private System.Windows.Forms.Label lbStudentID;
        private System.Windows.Forms.Label lbPhieuDangKy;
        private System.Windows.Forms.Label lbMaNV;
        private System.Windows.Forms.ComboBox cbbDuration;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnOK;
        public System.Windows.Forms.Button btnPrint;
        public System.Windows.Forms.TableLayoutPanel tlpBottom;
    }
}