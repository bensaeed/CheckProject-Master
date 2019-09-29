namespace IssueCheck
{
    partial class FrmMain
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
            this.components = new System.ComponentModel.Container();
            this.groupBoxMainForm = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tSSl_LblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSLDateSystem = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSLTimeInSystem = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tSSLUserLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReport = new System.Windows.Forms.Button();
            this.btnManage = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.groupBoxMainForm.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxMainForm
            // 
            this.groupBoxMainForm.Controls.Add(this.label4);
            this.groupBoxMainForm.Controls.Add(this.label3);
            this.groupBoxMainForm.Controls.Add(this.label2);
            this.groupBoxMainForm.Controls.Add(this.label1);
            this.groupBoxMainForm.Controls.Add(this.btnExit);
            this.groupBoxMainForm.Controls.Add(this.btnReport);
            this.groupBoxMainForm.Controls.Add(this.btnManage);
            this.groupBoxMainForm.Controls.Add(this.btnNew);
            this.groupBoxMainForm.Location = new System.Drawing.Point(131, 12);
            this.groupBoxMainForm.Name = "groupBoxMainForm";
            this.groupBoxMainForm.Size = new System.Drawing.Size(505, 124);
            this.groupBoxMainForm.TabIndex = 0;
            this.groupBoxMainForm.TabStop = false;
            this.groupBoxMainForm.Enter += new System.EventHandler(this.groupBoxMainForm_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "خروج";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(180, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "گزارشات";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "مدیریت";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(357, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "صدور چک";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tSSl_LblDate,
            this.tSSLDateSystem,
            this.toolStripStatusLabel1,
            this.tSSLTimeInSystem,
            this.toolStripStatusLabel2,
            this.tSSLUserLogin});
            this.statusStrip1.Location = new System.Drawing.Point(0, 374);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(796, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tSSl_LblDate
            // 
            this.tSSl_LblDate.Name = "tSSl_LblDate";
            this.tSSl_LblDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tSSl_LblDate.Size = new System.Drawing.Size(104, 17);
            this.tSSl_LblDate.Text = "تاریخ جاری سیستم : ";
            // 
            // tSSLDateSystem
            // 
            this.tSSLDateSystem.Name = "tSSLDateSystem";
            this.tSSLDateSystem.Size = new System.Drawing.Size(19, 17);
            this.tSSLDateSystem.Text = "....";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(111, 17);
            this.toolStripStatusLabel1.Text = "ساعت جاری سیستم : ";
            // 
            // tSSLTimeInSystem
            // 
            this.tSSLTimeInSystem.Name = "tSSLTimeInSystem";
            this.tSSLTimeInSystem.Size = new System.Drawing.Size(19, 17);
            this.tSSLTimeInSystem.Text = "....";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(103, 17);
            this.toolStripStatusLabel2.Text = "کاربر جاری سیستم : ";
            // 
            // tSSLUserLogin
            // 
            this.tSSLUserLogin.Name = "tSSLUserLogin";
            this.tSSLUserLogin.Size = new System.Drawing.Size(16, 17);
            this.tSSLUserLogin.Text = "...";
            // 
            // timerMain
            // 
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = global::IssueCheck.Properties.Resources.Close_icon1;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Location = new System.Drawing.Point(66, 20);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 86);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReport
            // 
            this.btnReport.BackgroundImage = global::IssueCheck.Properties.Resources._02_File_icon1;
            this.btnReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReport.Location = new System.Drawing.Point(158, 20);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(86, 86);
            this.btnReport.TabIndex = 1;
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // btnManage
            // 
            this.btnManage.BackgroundImage = global::IssueCheck.Properties.Resources.Files_icon1;
            this.btnManage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnManage.Location = new System.Drawing.Point(250, 20);
            this.btnManage.Name = "btnManage";
            this.btnManage.Size = new System.Drawing.Size(86, 86);
            this.btnManage.TabIndex = 1;
            this.btnManage.UseVisualStyleBackColor = true;
            this.btnManage.Click += new System.EventHandler(this.btnManage_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackgroundImage = global::IssueCheck.Properties.Resources.Add_File_icon;
            this.btnNew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNew.Location = new System.Drawing.Point(342, 20);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(86, 86);
            this.btnNew.TabIndex = 0;
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 396);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBoxMainForm);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "صفحه اصلي";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmMain_FormClosed);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBoxMainForm.ResumeLayout(false);
            this.groupBoxMainForm.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMainForm;
        private System.Windows.Forms.Button btnManage;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tSSl_LblDate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.ToolStripStatusLabel tSSLDateSystem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tSSLTimeInSystem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tSSLUserLogin;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}