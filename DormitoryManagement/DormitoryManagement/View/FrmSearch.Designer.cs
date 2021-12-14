namespace DormitoryManagement.View
{
    partial class FrmSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbTitle = new System.Windows.Forms.Label();
            this.tabSearch = new System.Windows.Forms.TabControl();
            this.tabStudent = new System.Windows.Forms.TabPage();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.cbbCategoryStudent = new System.Windows.Forms.ComboBox();
            this.lbCategory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtInputStudent = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvRoomReg = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.cbbCategoryRoomReg = new System.Windows.Forms.ComboBox();
            this.btnSearchRoomReg = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbRoom = new System.Windows.Forms.ComboBox();
            this.cbbBuilding = new System.Windows.Forms.ComboBox();
            this.txtInputRoomReg = new System.Windows.Forms.TextBox();
            this.tabBill = new System.Windows.Forms.TabPage();
            this.dgvBill = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch_Bill = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbRoom_Bill = new System.Windows.Forms.ComboBox();
            this.cbbBuiding_Bill = new System.Windows.Forms.ComboBox();
            this.ckbPaid = new System.Windows.Forms.CheckBox();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.tabSearch.SuspendLayout();
            this.tabStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomReg)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabBill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.Goldenrod;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Black", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(1112, 62);
            this.lbTitle.TabIndex = 12;
            this.lbTitle.Text = "SEARCH";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabSearch
            // 
            this.tabSearch.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabSearch.Controls.Add(this.tabStudent);
            this.tabSearch.Controls.Add(this.tabPage2);
            this.tabSearch.Controls.Add(this.tabBill);
            this.tabSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabSearch.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabSearch.Location = new System.Drawing.Point(0, 62);
            this.tabSearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.SelectedIndex = 0;
            this.tabSearch.ShowToolTips = true;
            this.tabSearch.Size = new System.Drawing.Size(1112, 590);
            this.tabSearch.TabIndex = 14;
            // 
            // tabStudent
            // 
            this.tabStudent.Controls.Add(this.dgvStudent);
            this.tabStudent.Controls.Add(this.tableLayoutPanel1);
            this.tabStudent.Location = new System.Drawing.Point(4, 31);
            this.tabStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabStudent.Name = "tabStudent";
            this.tabStudent.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabStudent.Size = new System.Drawing.Size(1104, 555);
            this.tabStudent.TabIndex = 0;
            this.tabStudent.Text = "STUDENT";
            this.tabStudent.UseVisualStyleBackColor = true;
            // 
            // dgvStudent
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudent.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvStudent.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvStudent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStudent.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvStudent.Location = new System.Drawing.Point(2, 67);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.dgvStudent.Name = "dgvStudent";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStudent.RowHeadersVisible = false;
            this.dgvStudent.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStudent.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvStudent.Size = new System.Drawing.Size(1100, 486);
            this.dgvStudent.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.40054F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 0.613079F));
            this.tableLayoutPanel1.Controls.Add(this.cbbCategoryStudent, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbCategory, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtInputStudent, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1100, 65);
            this.tableLayoutPanel1.TabIndex = 12;
            // 
            // cbbCategoryStudent
            // 
            this.cbbCategoryStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbCategoryStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cbbCategoryStudent.FormattingEnabled = true;
            this.cbbCategoryStudent.Items.AddRange(new object[] {
            "FULL",
            "ALIVE",
            "GOING OUT",
            "USER_ID",
            "STUDENT_ID",
            "FULLNAME",
            "GENDER",
            "SSN",
            "COLLEGE"});
            this.cbbCategoryStudent.Location = new System.Drawing.Point(3, 35);
            this.cbbCategoryStudent.Name = "cbbCategoryStudent";
            this.cbbCategoryStudent.Size = new System.Drawing.Size(158, 24);
            this.cbbCategoryStudent.TabIndex = 11;
            this.cbbCategoryStudent.Text = "FULL";
            this.cbbCategoryStudent.SelectedIndexChanged += new System.EventHandler(this.cbbCategoryStudent_SelectedIndexChanged);
            // 
            // lbCategory
            // 
            this.lbCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lbCategory.Location = new System.Drawing.Point(3, 0);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(158, 32);
            this.lbCategory.TabIndex = 10;
            this.lbCategory.Text = "Category:";
            this.lbCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(167, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(922, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "What to search:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtInputStudent
            // 
            this.txtInputStudent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInputStudent.Font = new System.Drawing.Font("Segoe UI Black", 12F);
            this.txtInputStudent.Location = new System.Drawing.Point(166, 34);
            this.txtInputStudent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInputStudent.Name = "txtInputStudent";
            this.txtInputStudent.Size = new System.Drawing.Size(924, 29);
            this.txtInputStudent.TabIndex = 14;
            this.txtInputStudent.TextChanged += new System.EventHandler(this.txtInputStudent_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvRoomReg);
            this.tabPage2.Controls.Add(this.tableLayoutPanel3);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(1104, 556);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "ROOM REGISTRATION";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvRoomReg
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoomReg.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRoomReg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRoomReg.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvRoomReg.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvRoomReg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoomReg.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvRoomReg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoomReg.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvRoomReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRoomReg.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvRoomReg.Location = new System.Drawing.Point(2, 67);
            this.dgvRoomReg.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.dgvRoomReg.Name = "dgvRoomReg";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoomReg.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvRoomReg.RowHeadersVisible = false;
            this.dgvRoomReg.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRoomReg.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvRoomReg.Size = new System.Drawing.Size(1100, 487);
            this.dgvRoomReg.TabIndex = 15;
            this.dgvRoomReg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRoomReg_CellContentClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 5;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel3.Controls.Add(this.label7, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbbCategoryRoomReg, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnSearchRoomReg, 4, 1);
            this.tableLayoutPanel3.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.label6, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.cbbRoom, 3, 1);
            this.tableLayoutPanel3.Controls.Add(this.cbbBuilding, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtInputRoomReg, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1100, 65);
            this.tableLayoutPanel3.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label7.Location = new System.Drawing.Point(278, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 32);
            this.label7.TabIndex = 18;
            this.label7.Text = "What to search:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbCategoryRoomReg
            // 
            this.cbbCategoryRoomReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbCategoryRoomReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cbbCategoryRoomReg.FormattingEnabled = true;
            this.cbbCategoryRoomReg.Items.AddRange(new object[] {
            "FULL",
            "STUDENT_ID",
            "STUDENT_FULLNAME"});
            this.cbbCategoryRoomReg.Location = new System.Drawing.Point(3, 35);
            this.cbbCategoryRoomReg.Name = "cbbCategoryRoomReg";
            this.cbbCategoryRoomReg.Size = new System.Drawing.Size(269, 24);
            this.cbbCategoryRoomReg.TabIndex = 15;
            this.cbbCategoryRoomReg.Text = "FULL";
            this.cbbCategoryRoomReg.SelectedIndexChanged += new System.EventHandler(this.cbbCategoryRoomReg_SelectedIndexChanged);
            // 
            // btnSearchRoomReg
            // 
            this.btnSearchRoomReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearchRoomReg.Enabled = false;
            this.btnSearchRoomReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchRoomReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRoomReg.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSearchRoomReg.Location = new System.Drawing.Point(992, 34);
            this.btnSearchRoomReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchRoomReg.Name = "btnSearchRoomReg";
            this.btnSearchRoomReg.Size = new System.Drawing.Size(106, 29);
            this.btnSearchRoomReg.TabIndex = 13;
            this.btnSearchRoomReg.Text = "SEARCH";
            this.btnSearchRoomReg.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Category:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label5.Location = new System.Drawing.Point(553, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(214, 32);
            this.label5.TabIndex = 8;
            this.label5.Text = "Building:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(772, 0);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 32);
            this.label6.TabIndex = 16;
            this.label6.Text = "Room:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbRoom
            // 
            this.cbbRoom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbRoom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cbbRoom.FormattingEnabled = true;
            this.cbbRoom.Location = new System.Drawing.Point(773, 35);
            this.cbbRoom.Name = "cbbRoom";
            this.cbbRoom.Size = new System.Drawing.Size(214, 24);
            this.cbbRoom.TabIndex = 11;
            this.cbbRoom.SelectedIndexChanged += new System.EventHandler(this.cbbRoom_SelectedIndexChanged);
            // 
            // cbbBuilding
            // 
            this.cbbBuilding.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbBuilding.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBuilding.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cbbBuilding.FormattingEnabled = true;
            this.cbbBuilding.Location = new System.Drawing.Point(553, 35);
            this.cbbBuilding.Name = "cbbBuilding";
            this.cbbBuilding.Size = new System.Drawing.Size(214, 24);
            this.cbbBuilding.TabIndex = 14;
            this.cbbBuilding.SelectedIndexChanged += new System.EventHandler(this.cbbBuilding_SelectedIndexChanged);
            // 
            // txtInputRoomReg
            // 
            this.txtInputRoomReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInputRoomReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.txtInputRoomReg.Location = new System.Drawing.Point(277, 34);
            this.txtInputRoomReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtInputRoomReg.Name = "txtInputRoomReg";
            this.txtInputRoomReg.Size = new System.Drawing.Size(271, 23);
            this.txtInputRoomReg.TabIndex = 19;
            this.txtInputRoomReg.TextChanged += new System.EventHandler(this.txtInputRoomReg_TextChanged);
            // 
            // tabBill
            // 
            this.tabBill.Controls.Add(this.dgvBill);
            this.tabBill.Controls.Add(this.tableLayoutPanel2);
            this.tabBill.Location = new System.Drawing.Point(4, 31);
            this.tabBill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabBill.Name = "tabBill";
            this.tabBill.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabBill.Size = new System.Drawing.Size(1104, 556);
            this.tabBill.TabIndex = 2;
            this.tabBill.Text = "BILL";
            this.tabBill.UseVisualStyleBackColor = true;
            // 
            // dgvBill
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvBill.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBill.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvBill.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvBill.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvBill.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.InactiveCaption;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.Goldenrod;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgvBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBill.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvBill.Location = new System.Drawing.Point(2, 67);
            this.dgvBill.Margin = new System.Windows.Forms.Padding(10, 10, 10, 10);
            this.dgvBill.Name = "dgvBill";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvBill.RowHeadersVisible = false;
            this.dgvBill.RowHeadersWidth = 51;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBill.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dgvBill.Size = new System.Drawing.Size(1100, 487);
            this.dgvBill.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 6;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Controls.Add(this.label10, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnSearch_Bill, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label8, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label9, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.cbbRoom_Bill, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbbBuiding_Bill, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.ckbPaid, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtpFromDate, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.dtpToDate, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1100, 65);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(882, 0);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 32);
            this.label10.TabIndex = 17;
            this.label10.Text = "Status:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(223, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 32);
            this.label2.TabIndex = 18;
            this.label2.Text = "To:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSearch_Bill
            // 
            this.btnSearch_Bill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSearch_Bill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch_Bill.ForeColor = System.Drawing.Color.DarkRed;
            this.btnSearch_Bill.Location = new System.Drawing.Point(992, 34);
            this.btnSearch_Bill.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearch_Bill.Name = "btnSearch_Bill";
            this.btnSearch_Bill.Size = new System.Drawing.Size(106, 29);
            this.btnSearch_Bill.TabIndex = 13;
            this.btnSearch_Bill.Text = "SEARCH";
            this.btnSearch_Bill.UseVisualStyleBackColor = true;
            this.btnSearch_Bill.Click += new System.EventHandler(this.btnSearch_Bill_Click);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 32);
            this.label3.TabIndex = 10;
            this.label3.Text = "From:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label8.Location = new System.Drawing.Point(443, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(214, 32);
            this.label8.TabIndex = 8;
            this.label8.Text = "Building:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(662, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 32);
            this.label9.TabIndex = 16;
            this.label9.Text = "Room:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbbRoom_Bill
            // 
            this.cbbRoom_Bill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbRoom_Bill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbRoom_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cbbRoom_Bill.FormattingEnabled = true;
            this.cbbRoom_Bill.Location = new System.Drawing.Point(663, 35);
            this.cbbRoom_Bill.Name = "cbbRoom_Bill";
            this.cbbRoom_Bill.Size = new System.Drawing.Size(214, 24);
            this.cbbRoom_Bill.TabIndex = 11;
            this.cbbRoom_Bill.SelectedIndexChanged += new System.EventHandler(this.cbbRoom_Bill_SelectedIndexChanged);
            // 
            // cbbBuiding_Bill
            // 
            this.cbbBuiding_Bill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbbBuiding_Bill.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBuiding_Bill.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.cbbBuiding_Bill.FormattingEnabled = true;
            this.cbbBuiding_Bill.Location = new System.Drawing.Point(443, 35);
            this.cbbBuiding_Bill.Name = "cbbBuiding_Bill";
            this.cbbBuiding_Bill.Size = new System.Drawing.Size(214, 24);
            this.cbbBuiding_Bill.TabIndex = 14;
            this.cbbBuiding_Bill.SelectedIndexChanged += new System.EventHandler(this.cbbBuiding_Bill_SelectedIndexChanged);
            // 
            // ckbPaid
            // 
            this.ckbPaid.AutoSize = true;
            this.ckbPaid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ckbPaid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ckbPaid.Location = new System.Drawing.Point(882, 34);
            this.ckbPaid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ckbPaid.Name = "ckbPaid";
            this.ckbPaid.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.ckbPaid.Size = new System.Drawing.Size(106, 29);
            this.ckbPaid.TabIndex = 20;
            this.ckbPaid.Text = "Paid";
            this.ckbPaid.UseVisualStyleBackColor = true;
            this.ckbPaid.CheckedChanged += new System.EventHandler(this.ckbPaid_CheckedChanged);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "M/yyyy";
            this.dtpFromDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFromDate.Location = new System.Drawing.Point(2, 34);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(216, 26);
            this.dtpFromDate.TabIndex = 21;
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "M/yyyy";
            this.dtpToDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.dtpToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToDate.Location = new System.Drawing.Point(222, 34);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(216, 26);
            this.dtpToDate.TabIndex = 22;
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 652);
            this.Controls.Add(this.tabSearch);
            this.Controls.Add(this.lbTitle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search";
            this.Load += new System.EventHandler(this.FrmSearch_Load);
            this.tabSearch.ResumeLayout(false);
            this.tabStudent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRoomReg)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabBill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBill)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TabControl tabSearch;
        private System.Windows.Forms.TabPage tabStudent;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabBill;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox cbbCategoryStudent;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInputStudent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.ComboBox cbbRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSearchRoomReg;
        private System.Windows.Forms.ComboBox cbbCategoryRoomReg;
        private System.Windows.Forms.ComboBox cbbBuilding;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridView dgvRoomReg;
        private System.Windows.Forms.DataGridView dgvBill;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInputRoomReg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch_Bill;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbbRoom_Bill;
        private System.Windows.Forms.ComboBox cbbBuiding_Bill;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox ckbPaid;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
    }
}