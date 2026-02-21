namespace CSA406
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.SAFsubmitButton = new System.Windows.Forms.Button();
            this.SAFemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SAFstuId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SAFname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.CDacceptBtn = new System.Windows.Forms.Button();
            this.CDrejectBtn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CDlistview = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CDselectedApplicant = new System.Windows.Forms.Label();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(521, 408);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.SAFsubmitButton);
            this.tabPage1.Controls.Add(this.SAFemail);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.SAFstuId);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.SAFname);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(513, 382);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Student Application Form";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label4.Location = new System.Drawing.Point(128, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Student Application Form";
            // 
            // SAFsubmitButton
            // 
            this.SAFsubmitButton.Location = new System.Drawing.Point(102, 237);
            this.SAFsubmitButton.Name = "SAFsubmitButton";
            this.SAFsubmitButton.Size = new System.Drawing.Size(311, 23);
            this.SAFsubmitButton.TabIndex = 6;
            this.SAFsubmitButton.Text = "Submit";
            this.SAFsubmitButton.UseVisualStyleBackColor = true;
            this.SAFsubmitButton.Click += new System.EventHandler(this.SAFsubmitButton_Click);
            // 
            // SAFemail
            // 
            this.SAFemail.Location = new System.Drawing.Point(181, 184);
            this.SAFemail.Name = "SAFemail";
            this.SAFemail.Size = new System.Drawing.Size(232, 20);
            this.SAFemail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(99, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email Address:";
            // 
            // SAFstuId
            // 
            this.SAFstuId.Location = new System.Drawing.Point(181, 153);
            this.SAFstuId.MaxLength = 9;
            this.SAFstuId.Name = "SAFstuId";
            this.SAFstuId.Size = new System.Drawing.Size(232, 20);
            this.SAFstuId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student ID:";
            // 
            // SAFname
            // 
            this.SAFname.Location = new System.Drawing.Point(181, 122);
            this.SAFname.Name = "SAFname";
            this.SAFname.Size = new System.Drawing.Size(232, 20);
            this.SAFname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(134, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.CDselectedApplicant);
            this.tabPage2.Controls.Add(this.CDacceptBtn);
            this.tabPage2.Controls.Add(this.CDrejectBtn);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.CDlistview);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(513, 382);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Coordinator Dashboard";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // CDacceptBtn
            // 
            this.CDacceptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDacceptBtn.ForeColor = System.Drawing.Color.Green;
            this.CDacceptBtn.Location = new System.Drawing.Point(278, 332);
            this.CDacceptBtn.Name = "CDacceptBtn";
            this.CDacceptBtn.Size = new System.Drawing.Size(216, 41);
            this.CDacceptBtn.TabIndex = 10;
            this.CDacceptBtn.Text = "Accept";
            this.CDacceptBtn.UseVisualStyleBackColor = true;
            this.CDacceptBtn.Click += new System.EventHandler(this.CDacceptBtn_Click);
            // 
            // CDrejectBtn
            // 
            this.CDrejectBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CDrejectBtn.ForeColor = System.Drawing.Color.Maroon;
            this.CDrejectBtn.Location = new System.Drawing.Point(19, 333);
            this.CDrejectBtn.Name = "CDrejectBtn";
            this.CDrejectBtn.Size = new System.Drawing.Size(216, 41);
            this.CDrejectBtn.TabIndex = 9;
            this.CDrejectBtn.Text = "Reject";
            this.CDrejectBtn.UseVisualStyleBackColor = true;
            this.CDrejectBtn.Click += new System.EventHandler(this.CDrejectBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F);
            this.label5.Location = new System.Drawing.Point(138, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(237, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Coordinator Dashboard";
            // 
            // CDlistview
            // 
            this.CDlistview.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.CDlistview.FullRowSelect = true;
            this.CDlistview.GridLines = true;
            this.CDlistview.HideSelection = false;
            this.CDlistview.Location = new System.Drawing.Point(19, 62);
            this.CDlistview.Name = "CDlistview";
            this.CDlistview.Size = new System.Drawing.Size(475, 228);
            this.CDlistview.TabIndex = 0;
            this.CDlistview.UseCompatibleStateImageBehavior = false;
            this.CDlistview.View = System.Windows.Forms.View.Details;
            this.CDlistview.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.CDlistview_ItemSelectionChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 77;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Student ID";
            this.columnHeader3.Width = 75;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Provisional Status";
            this.columnHeader5.Width = 98;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Final Status";
            this.columnHeader6.Width = 78;
            // 
            // CDselectedApplicant
            // 
            this.CDselectedApplicant.Location = new System.Drawing.Point(19, 297);
            this.CDselectedApplicant.Name = "CDselectedApplicant";
            this.CDselectedApplicant.Size = new System.Drawing.Size(475, 23);
            this.CDselectedApplicant.TabIndex = 11;
            this.CDselectedApplicant.Text = "Selected Applicant: name, studentid, email";
            this.CDselectedApplicant.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CDselectedApplicant.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 43;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 408);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSA (Co-op Support Application)";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox SAFname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SAFsubmitButton;
        private System.Windows.Forms.TextBox SAFemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SAFstuId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView CDlistview;
        private System.Windows.Forms.Button CDacceptBtn;
        private System.Windows.Forms.Button CDrejectBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label CDselectedApplicant;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}

