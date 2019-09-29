namespace IssueCheck
{
    partial class FrmManageChecks
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rBtnAll = new System.Windows.Forms.RadioButton();
            this.rBtnCancel = new System.Windows.Forms.RadioButton();
            this.rBtnIssue = new System.Windows.Forms.RadioButton();
            this.txtDateTo = new System.Windows.Forms.TextBox();
            this.txtDateFrom = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPay_To = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValueTo = new System.Windows.Forms.TextBox();
            this.txtValueFrom = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CmbDuration = new System.Windows.Forms.ComboBox();
            this.dGChecks = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnActiveCheck = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnCancelCheck = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGChecks)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rBtnAll);
            this.groupBox1.Controls.Add(this.rBtnCancel);
            this.groupBox1.Controls.Add(this.rBtnIssue);
            this.groupBox1.Controls.Add(this.txtDateTo);
            this.groupBox1.Controls.Add(this.txtDateFrom);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtPay_To);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtValueTo);
            this.groupBox1.Controls.Add(this.txtValueFrom);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(888, 111);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو ";
            // 
            // rBtnAll
            // 
            this.rBtnAll.AutoSize = true;
            this.rBtnAll.Location = new System.Drawing.Point(419, 74);
            this.rBtnAll.Name = "rBtnAll";
            this.rBtnAll.Size = new System.Drawing.Size(46, 17);
            this.rBtnAll.TabIndex = 54;
            this.rBtnAll.Text = "همه";
            this.rBtnAll.UseVisualStyleBackColor = true;
            this.rBtnAll.CheckedChanged += new System.EventHandler(this.rBtnAll_CheckedChanged);
            // 
            // rBtnCancel
            // 
            this.rBtnCancel.AutoSize = true;
            this.rBtnCancel.Location = new System.Drawing.Point(471, 74);
            this.rBtnCancel.Name = "rBtnCancel";
            this.rBtnCancel.Size = new System.Drawing.Size(116, 17);
            this.rBtnCancel.TabIndex = 54;
            this.rBtnCancel.Text = "چک های باطل شده";
            this.rBtnCancel.UseVisualStyleBackColor = true;
            this.rBtnCancel.CheckedChanged += new System.EventHandler(this.rBtnCancel_CheckedChanged);
            // 
            // rBtnIssue
            // 
            this.rBtnIssue.AutoSize = true;
            this.rBtnIssue.Checked = true;
            this.rBtnIssue.Location = new System.Drawing.Point(593, 74);
            this.rBtnIssue.Name = "rBtnIssue";
            this.rBtnIssue.Size = new System.Drawing.Size(116, 17);
            this.rBtnIssue.TabIndex = 54;
            this.rBtnIssue.TabStop = true;
            this.rBtnIssue.Text = "چک های صادر شده";
            this.rBtnIssue.UseVisualStyleBackColor = true;
            this.rBtnIssue.CheckedChanged += new System.EventHandler(this.rBtnIssue_CheckedChanged);
            // 
            // txtDateTo
            // 
            this.txtDateTo.Location = new System.Drawing.Point(609, 41);
            this.txtDateTo.Name = "txtDateTo";
            this.txtDateTo.Size = new System.Drawing.Size(100, 21);
            this.txtDateTo.TabIndex = 53;
            this.txtDateTo.TextChanged += new System.EventHandler(this.txtDateTo_TextChanged);
            // 
            // txtDateFrom
            // 
            this.txtDateFrom.Location = new System.Drawing.Point(609, 16);
            this.txtDateFrom.Name = "txtDateFrom";
            this.txtDateFrom.Size = new System.Drawing.Size(100, 21);
            this.txtDateFrom.TabIndex = 53;
            this.txtDateFrom.TextChanged += new System.EventHandler(this.txtDateFrom_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "جستجو";
            // 
            // txtPay_To
            // 
            this.txtPay_To.Location = new System.Drawing.Point(226, 41);
            this.txtPay_To.Name = "txtPay_To";
            this.txtPay_To.Size = new System.Drawing.Size(293, 21);
            this.txtPay_To.TabIndex = 49;
            this.txtPay_To.TextChanged += new System.EventHandler(this.txtPay_To_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(715, 75);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(46, 14);
            this.label2.TabIndex = 35;
            this.label2.Text = "شامل :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label8.Location = new System.Drawing.Point(519, 44);
            this.label8.Name = "label8";
            this.label8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 48;
            this.label8.Text = "در وجه :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(347, 19);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(47, 14);
            this.label3.TabIndex = 47;
            this.label3.Text = "تا مبلغ :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label7.Location = new System.Drawing.Point(519, 19);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(47, 14);
            this.label7.TabIndex = 47;
            this.label7.Text = "از مبلغ :";
            // 
            // txtValueTo
            // 
            this.txtValueTo.Location = new System.Drawing.Point(226, 14);
            this.txtValueTo.Name = "txtValueTo";
            this.txtValueTo.Size = new System.Drawing.Size(121, 21);
            this.txtValueTo.TabIndex = 46;
            this.txtValueTo.TextChanged += new System.EventHandler(this.txtValueTo_TextChanged);
            // 
            // txtValueFrom
            // 
            this.txtValueFrom.Location = new System.Drawing.Point(398, 16);
            this.txtValueFrom.Name = "txtValueFrom";
            this.txtValueFrom.Size = new System.Drawing.Size(121, 21);
            this.txtValueFrom.TabIndex = 46;
            this.txtValueFrom.TextChanged += new System.EventHandler(this.txtValueFrom_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(715, 48);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(48, 14);
            this.label4.TabIndex = 35;
            this.label4.Text = "تا تاریخ :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(715, 20);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(48, 14);
            this.label1.TabIndex = 35;
            this.label1.Text = "از تاریخ :";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CmbDuration);
            this.groupBox2.Controls.Add(this.dGChecks);
            this.groupBox2.Location = new System.Drawing.Point(12, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(888, 360);
            this.groupBox2.TabIndex = 46;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "لیست چک های صادر شده ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // CmbDuration
            // 
            this.CmbDuration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbDuration.FormattingEnabled = true;
            this.CmbDuration.Location = new System.Drawing.Point(6, 10);
            this.CmbDuration.Name = "CmbDuration";
            this.CmbDuration.Size = new System.Drawing.Size(156, 21);
            this.CmbDuration.TabIndex = 1;
            this.CmbDuration.SelectedIndexChanged += new System.EventHandler(this.CmbDuration_SelectedIndexChanged);
            // 
            // dGChecks
            // 
            this.dGChecks.AllowUserToAddRows = false;
            this.dGChecks.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dGChecks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGChecks.Location = new System.Drawing.Point(6, 32);
            this.dGChecks.MultiSelect = false;
            this.dGChecks.Name = "dGChecks";
            this.dGChecks.ReadOnly = true;
            this.dGChecks.RowHeadersWidth = 10;
            this.dGChecks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dGChecks.Size = new System.Drawing.Size(876, 322);
            this.dGChecks.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.btnPrintReport);
            this.groupBox3.Controls.Add(this.btnView);
            this.groupBox3.Controls.Add(this.btnActiveCheck);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Controls.Add(this.btnCancelCheck);
            this.groupBox3.Controls.Add(this.btnEdit);
            this.groupBox3.Controls.Add(this.btnPrint);
            this.groupBox3.Controls.Add(this.btnNew);
            this.groupBox3.Location = new System.Drawing.Point(12, 479);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(888, 97);
            this.groupBox3.TabIndex = 47;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "عملیات چک";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(794, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 56;
            this.label15.Text = "چاپ گزارش";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "صفحه اصلي";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(235, 74);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 13);
            this.label13.TabIndex = 52;
            this.label13.Text = "ابطال به جاری";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(191, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(31, 13);
            this.label10.TabIndex = 52;
            this.label10.Text = "ابطال";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(423, 75);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 13);
            this.label14.TabIndex = 52;
            this.label14.Text = "مشاهده";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(493, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 52;
            this.label6.Text = "ویرایش";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(740, 75);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 52;
            this.label12.Text = "چاب چك";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(551, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "صدور چک";
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.BackgroundImage = global::IssueCheck.Properties.Resources.Printer_icon1;
            this.btnPrintReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintReport.Location = new System.Drawing.Point(794, 15);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(59, 59);
            this.btnPrintReport.TabIndex = 55;
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // btnView
            // 
            this.btnView.BackgroundImage = global::IssueCheck.Properties.Resources._02_File_icon3;
            this.btnView.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnView.Location = new System.Drawing.Point(419, 15);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(59, 57);
            this.btnView.TabIndex = 54;
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnActiveCheck
            // 
            this.btnActiveCheck.BackgroundImage = global::IssueCheck.Properties.Resources.File_Refresh_icon1;
            this.btnActiveCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActiveCheck.Location = new System.Drawing.Point(243, 15);
            this.btnActiveCheck.Name = "btnActiveCheck";
            this.btnActiveCheck.Size = new System.Drawing.Size(59, 57);
            this.btnActiveCheck.TabIndex = 53;
            this.btnActiveCheck.UseVisualStyleBackColor = true;
            this.btnActiveCheck.Click += new System.EventHandler(this.btnActiveCheck_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::IssueCheck.Properties.Resources.home_icon1;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(16, 15);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(59, 59);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnCancelCheck
            // 
            this.btnCancelCheck.BackgroundImage = global::IssueCheck.Properties.Resources.File_Block_icon1;
            this.btnCancelCheck.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelCheck.Location = new System.Drawing.Point(178, 15);
            this.btnCancelCheck.Name = "btnCancelCheck";
            this.btnCancelCheck.Size = new System.Drawing.Size(59, 57);
            this.btnCancelCheck.TabIndex = 0;
            this.btnCancelCheck.UseVisualStyleBackColor = true;
            this.btnCancelCheck.Click += new System.EventHandler(this.btnCancelCheck_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = global::IssueCheck.Properties.Resources.Files_Edit_File_icon1;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Location = new System.Drawing.Point(484, 15);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(59, 59);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackgroundImage = global::IssueCheck.Properties.Resources.Billing_icon1;
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrint.Location = new System.Drawing.Point(729, 15);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(59, 59);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackgroundImage = global::IssueCheck.Properties.Resources.Add_File_icon2;
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNew.Location = new System.Drawing.Point(551, 15);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(59, 59);
            this.btnNew.TabIndex = 0;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::IssueCheck.Properties.Resources.File_Search_icon1;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Location = new System.Drawing.Point(37, 18);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(65, 65);
            this.btnSearch.TabIndex = 50;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // FrmManageChecks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 577);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "FrmManageChecks";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مديريت چك ها";
            this.Load += new System.EventHandler(this.FrmManageChecks_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dGChecks)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dGChecks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValueFrom;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPay_To;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDateTo;
        private System.Windows.Forms.TextBox txtDateFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rBtnAll;
        private System.Windows.Forms.RadioButton rBtnCancel;
        private System.Windows.Forms.RadioButton rBtnIssue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtValueTo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnCancelCheck;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnActiveCheck;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.ComboBox CmbDuration;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnPrintReport;
    }
}