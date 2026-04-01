namespace CSA406
{
    partial class StudentDashboard
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.grpReport = new System.Windows.Forms.GroupBox();
            this.lblReportStatus = new System.Windows.Forms.Label();
            this.btnUploadReport = new System.Windows.Forms.Button();
            this.grpReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(520, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Student Dashboard";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblWelcome.Location = new System.Drawing.Point(25, 60);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(66, 17);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblStatus.Location = new System.Drawing.Point(25, 90);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(59, 17);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status:";
            // 
            // grpReport
            // 
            this.grpReport.Controls.Add(this.lblReportStatus);
            this.grpReport.Controls.Add(this.btnUploadReport);
            this.grpReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.grpReport.Location = new System.Drawing.Point(25, 125);
            this.grpReport.Name = "grpReport";
            this.grpReport.Size = new System.Drawing.Size(470, 134);
            this.grpReport.TabIndex = 3;
            this.grpReport.TabStop = false;
            this.grpReport.Text = "Work Term Report Submission";
            // 
            // lblReportStatus
            // 
            this.lblReportStatus.AutoSize = true;
            this.lblReportStatus.Location = new System.Drawing.Point(20, 35);
            this.lblReportStatus.Name = "lblReportStatus";
            this.lblReportStatus.Size = new System.Drawing.Size(119, 16);
            this.lblReportStatus.TabIndex = 0;
            this.lblReportStatus.Text = "Report: Checking...";
            // 
            // btnUploadReport
            // 
            this.btnUploadReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnUploadReport.Location = new System.Drawing.Point(20, 70);
            this.btnUploadReport.Name = "btnUploadReport";
            this.btnUploadReport.Size = new System.Drawing.Size(430, 35);
            this.btnUploadReport.TabIndex = 1;
            this.btnUploadReport.Text = "Upload PDF Report";
            this.btnUploadReport.UseVisualStyleBackColor = true;
            this.btnUploadReport.Click += new System.EventHandler(this.btnUploadReport_Click);
            // 
            // StudentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 275);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.grpReport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StudentDashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSA - Student Dashboard";
            this.grpReport.ResumeLayout(false);
            this.grpReport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox grpReport;
        private System.Windows.Forms.Label lblReportStatus;
        private System.Windows.Forms.Button btnUploadReport;
    }
}
