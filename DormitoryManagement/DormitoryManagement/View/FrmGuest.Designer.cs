namespace DormitoryManagement
{
    partial class FrmGuest
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
            this.label1 = new System.Windows.Forms.Label();
            this.pnQuanTri = new System.Windows.Forms.Panel();
            this.tlpManage = new System.Windows.Forms.TableLayoutPanel();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pnThongTin = new System.Windows.Forms.Panel();
            this.tlpInfo = new System.Windows.Forms.TableLayoutPanel();
            this.lbThongTin = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pnQuanTri.SuspendLayout();
            this.pnBottom.SuspendLayout();
            this.pnThongTin.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.BackColor = System.Drawing.Color.Linen;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Black", 50.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(1482, 250);
            this.lbTitle.TabIndex = 4;
            this.lbTitle.Text = "DORMITORY MANAGEMENT";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1476, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "MANAGEMENT";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnQuanTri
            // 
            this.pnQuanTri.AutoSize = true;
            this.pnQuanTri.BackColor = System.Drawing.Color.Goldenrod;
            this.pnQuanTri.Controls.Add(this.tlpManage);
            this.pnQuanTri.Controls.Add(this.label1);
            this.pnQuanTri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnQuanTri.Location = new System.Drawing.Point(3, 2);
            this.pnQuanTri.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnQuanTri.Name = "pnQuanTri";
            this.pnQuanTri.Size = new System.Drawing.Size(1476, 248);
            this.pnQuanTri.TabIndex = 1;
            // 
            // tlpManage
            // 
            this.tlpManage.ColumnCount = 2;
            this.tlpManage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpManage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpManage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpManage.Location = new System.Drawing.Point(0, 39);
            this.tlpManage.Name = "tlpManage";
            this.tlpManage.RowCount = 1;
            this.tlpManage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpManage.Size = new System.Drawing.Size(1476, 209);
            this.tlpManage.TabIndex = 1;
            // 
            // pnBottom
            // 
            this.pnBottom.BackColor = System.Drawing.Color.Silver;
            this.pnBottom.Controls.Add(this.label3);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBottom.Location = new System.Drawing.Point(4, 508);
            this.pnBottom.Margin = new System.Windows.Forms.Padding(4);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(1474, 41);
            this.pnBottom.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(483, 41);
            this.label3.TabIndex = 1;
            this.label3.Text = "(c) Bản quyền thuộc về FIT";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnThongTin
            // 
            this.pnThongTin.AutoSize = true;
            this.pnThongTin.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnThongTin.Controls.Add(this.tlpInfo);
            this.pnThongTin.Controls.Add(this.lbThongTin);
            this.pnThongTin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnThongTin.Location = new System.Drawing.Point(4, 256);
            this.pnThongTin.Margin = new System.Windows.Forms.Padding(4);
            this.pnThongTin.Name = "pnThongTin";
            this.pnThongTin.Size = new System.Drawing.Size(1474, 244);
            this.pnThongTin.TabIndex = 3;
            // 
            // tlpInfo
            // 
            this.tlpInfo.ColumnCount = 4;
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInfo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpInfo.Location = new System.Drawing.Point(0, 42);
            this.tlpInfo.Name = "tlpInfo";
            this.tlpInfo.RowCount = 1;
            this.tlpInfo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpInfo.Size = new System.Drawing.Size(1474, 202);
            this.tlpInfo.TabIndex = 1;
            // 
            // lbThongTin
            // 
            this.lbThongTin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lbThongTin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbThongTin.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lbThongTin.Location = new System.Drawing.Point(0, 0);
            this.lbThongTin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbThongTin.Name = "lbThongTin";
            this.lbThongTin.Size = new System.Drawing.Size(1474, 42);
            this.lbThongTin.TabIndex = 0;
            this.lbThongTin.Text = "INFORMATION";
            this.lbThongTin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.pnQuanTri, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.pnThongTin, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.pnBottom, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 250);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1482, 553);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // FrmGuest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 803);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.lbTitle);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmGuest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dormitory Management";
            this.pnQuanTri.ResumeLayout(false);
            this.pnBottom.ResumeLayout(false);
            this.pnThongTin.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnQuanTri;
        private System.Windows.Forms.Panel pnBottom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnThongTin;
        private System.Windows.Forms.Label lbThongTin;
        private System.Windows.Forms.TableLayoutPanel tlpManage;
        private System.Windows.Forms.TableLayoutPanel tlpInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

