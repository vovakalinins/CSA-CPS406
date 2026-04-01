namespace CSA406
{
    partial class Form1
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
            this.CDfinalAcceptBtn = new System.Windows.Forms.Button();
            this.CDacceptBtn = new System.Windows.Forms.Button();
            this.CDrejectBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CDlistview = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CDselectedApplicant = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CDfinalAcceptBtn
            // 
            this.CDfinalAcceptBtn.Enabled = false;
            this.CDfinalAcceptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.CDfinalAcceptBtn.ForeColor = System.Drawing.Color.DarkBlue;
            this.CDfinalAcceptBtn.Location = new System.Drawing.Point(510, 365);
            this.CDfinalAcceptBtn.Name = "CDfinalAcceptBtn";
            this.CDfinalAcceptBtn.Size = new System.Drawing.Size(245, 41);
            this.CDfinalAcceptBtn.TabIndex = 5;
            this.CDfinalAcceptBtn.Text = "Final Acceptance";
            this.CDfinalAcceptBtn.UseVisualStyleBackColor = true;
            this.CDfinalAcceptBtn.Click += new System.EventHandler(this.CDfinalAcceptBtn_Click);
            // 
            // CDacceptBtn
            // 
            this.CDacceptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDacceptBtn.ForeColor = System.Drawing.Color.Green;
            this.CDacceptBtn.Location = new System.Drawing.Point(268, 365);
            this.CDacceptBtn.Name = "CDacceptBtn";
            this.CDacceptBtn.Size = new System.Drawing.Size(216, 41);
            this.CDacceptBtn.TabIndex = 4;
            this.CDacceptBtn.Text = "Accept";
            this.CDacceptBtn.UseVisualStyleBackColor = true;
            this.CDacceptBtn.Click += new System.EventHandler(this.CDacceptBtn_Click);
            // 
            // CDrejectBtn
            // 
            this.CDrejectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDrejectBtn.ForeColor = System.Drawing.Color.Maroon;
            this.CDrejectBtn.Location = new System.Drawing.Point(19, 365);
            this.CDrejectBtn.Name = "CDrejectBtn";
            this.CDrejectBtn.Size = new System.Drawing.Size(216, 41);
            this.CDrejectBtn.TabIndex = 3;
            this.CDrejectBtn.Text = "Reject";
            this.CDrejectBtn.UseVisualStyleBackColor = true;
            this.CDrejectBtn.Click += new System.EventHandler(this.CDrejectBtn_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label5.Location = new System.Drawing.Point(0, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(784, 30);
            this.label5.TabIndex = 0;
            this.label5.Text = "Coordinator Dashboard";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CDlistview
            // 
            this.CDlistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.CDlistview.FullRowSelect = true;
            this.CDlistview.GridLines = true;
            this.CDlistview.HideSelection = false;
            this.CDlistview.Location = new System.Drawing.Point(19, 50);
            this.CDlistview.Name = "CDlistview";
            this.CDlistview.Size = new System.Drawing.Size(736, 268);
            this.CDlistview.TabIndex = 1;
            this.CDlistview.UseCompatibleStateImageBehavior = false;
            this.CDlistview.View = System.Windows.Forms.View.Details;
            this.CDlistview.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.CDlistview_ItemSelectionChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 0;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Student ID";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email";
            this.columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Provisional Status";
            this.columnHeader5.Width = 125;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Final Status";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Report Uploaded";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Eval Received";
            this.columnHeader8.Width = 90;
            // 
            // CDselectedApplicant
            // 
            this.CDselectedApplicant.Location = new System.Drawing.Point(19, 328);
            this.CDselectedApplicant.Name = "CDselectedApplicant";
            this.CDselectedApplicant.Size = new System.Drawing.Size(736, 23);
            this.CDselectedApplicant.TabIndex = 2;
            this.CDselectedApplicant.Text = "Selected Applicant: name, studentid, email";
            this.CDselectedApplicant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CDselectedApplicant.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 421);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CDlistview);
            this.Controls.Add(this.CDselectedApplicant);
            this.Controls.Add(this.CDrejectBtn);
            this.Controls.Add(this.CDacceptBtn);
            this.Controls.Add(this.CDfinalAcceptBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSA (Co-op Support Application) - Coordinator";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView CDlistview;
        private System.Windows.Forms.Button CDfinalAcceptBtn;
        private System.Windows.Forms.Button CDacceptBtn;
        private System.Windows.Forms.Button CDrejectBtn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label CDselectedApplicant;
    }
}
