namespace CSA406
{
    partial class EmployerDashboard
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
            this.lblSelectStudent = new System.Windows.Forms.Label();
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.grpEvaluation = new System.Windows.Forms.GroupBox();
            this.lblTechnical = new System.Windows.Forms.Label();
            this.nudTechnical = new System.Windows.Forms.NumericUpDown();
            this.lblProfessionalism = new System.Windows.Forms.Label();
            this.nudProfessionalism = new System.Windows.Forms.NumericUpDown();
            this.lblComments = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.btnSubmitEval = new System.Windows.Forms.Button();
            this.grpEvaluation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTechnical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProfessionalism)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(0, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Employer Dashboard";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblWelcome.Location = new System.Drawing.Point(25, 55);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(100, 17);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome";
            // 
            // lblSelectStudent
            // 
            this.lblSelectStudent.AutoSize = true;
            this.lblSelectStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblSelectStudent.Location = new System.Drawing.Point(25, 90);
            this.lblSelectStudent.Name = "lblSelectStudent";
            this.lblSelectStudent.Size = new System.Drawing.Size(88, 15);
            this.lblSelectStudent.TabIndex = 2;
            this.lblSelectStudent.Text = "Select Student:";
            // 
            // cmbStudents
            // 
            this.cmbStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudents.Location = new System.Drawing.Point(130, 88);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(330, 21);
            this.cmbStudents.TabIndex = 3;
            // 
            // grpEvaluation
            // 
            this.grpEvaluation.Controls.Add(this.lblTechnical);
            this.grpEvaluation.Controls.Add(this.nudTechnical);
            this.grpEvaluation.Controls.Add(this.lblProfessionalism);
            this.grpEvaluation.Controls.Add(this.nudProfessionalism);
            this.grpEvaluation.Controls.Add(this.lblComments);
            this.grpEvaluation.Controls.Add(this.txtComments);
            this.grpEvaluation.Controls.Add(this.btnSubmitEval);
            this.grpEvaluation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.grpEvaluation.Location = new System.Drawing.Point(25, 125);
            this.grpEvaluation.Name = "grpEvaluation";
            this.grpEvaluation.Size = new System.Drawing.Size(450, 290);
            this.grpEvaluation.TabIndex = 4;
            this.grpEvaluation.TabStop = false;
            this.grpEvaluation.Text = "Evaluation Form";
            // 
            // lblTechnical
            // 
            this.lblTechnical.AutoSize = true;
            this.lblTechnical.Location = new System.Drawing.Point(20, 35);
            this.lblTechnical.Name = "lblTechnical";
            this.lblTechnical.Size = new System.Drawing.Size(128, 16);
            this.lblTechnical.TabIndex = 0;
            this.lblTechnical.Text = "Technical Skills (1-5):";
            // 
            // nudTechnical
            // 
            this.nudTechnical.Location = new System.Drawing.Point(200, 33);
            this.nudTechnical.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            this.nudTechnical.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudTechnical.Name = "nudTechnical";
            this.nudTechnical.Size = new System.Drawing.Size(60, 22);
            this.nudTechnical.TabIndex = 1;
            this.nudTechnical.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblProfessionalism
            // 
            this.lblProfessionalism.AutoSize = true;
            this.lblProfessionalism.Location = new System.Drawing.Point(20, 70);
            this.lblProfessionalism.Name = "lblProfessionalism";
            this.lblProfessionalism.Size = new System.Drawing.Size(143, 16);
            this.lblProfessionalism.TabIndex = 2;
            this.lblProfessionalism.Text = "Professionalism (1-5):";
            // 
            // nudProfessionalism
            // 
            this.nudProfessionalism.Location = new System.Drawing.Point(200, 68);
            this.nudProfessionalism.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            this.nudProfessionalism.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.nudProfessionalism.Name = "nudProfessionalism";
            this.nudProfessionalism.Size = new System.Drawing.Size(60, 22);
            this.nudProfessionalism.TabIndex = 3;
            this.nudProfessionalism.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblComments
            // 
            this.lblComments.AutoSize = true;
            this.lblComments.Location = new System.Drawing.Point(20, 105);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(76, 16);
            this.lblComments.TabIndex = 4;
            this.lblComments.Text = "Comments:";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(20, 125);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComments.Size = new System.Drawing.Size(410, 100);
            this.txtComments.TabIndex = 5;
            // 
            // btnSubmitEval
            // 
            this.btnSubmitEval.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSubmitEval.Location = new System.Drawing.Point(20, 240);
            this.btnSubmitEval.Name = "btnSubmitEval";
            this.btnSubmitEval.Size = new System.Drawing.Size(410, 35);
            this.btnSubmitEval.TabIndex = 6;
            this.btnSubmitEval.Text = "Submit Evaluation";
            this.btnSubmitEval.UseVisualStyleBackColor = true;
            this.btnSubmitEval.Click += new System.EventHandler(this.btnSubmitEval_Click);
            // 
            // EmployerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 440);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblSelectStudent);
            this.Controls.Add(this.cmbStudents);
            this.Controls.Add(this.grpEvaluation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EmployerDashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSA - Employer Dashboard";
            this.grpEvaluation.ResumeLayout(false);
            this.grpEvaluation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTechnical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudProfessionalism)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblSelectStudent;
        private System.Windows.Forms.ComboBox cmbStudents;
        private System.Windows.Forms.GroupBox grpEvaluation;
        private System.Windows.Forms.Label lblTechnical;
        private System.Windows.Forms.NumericUpDown nudTechnical;
        private System.Windows.Forms.Label lblProfessionalism;
        private System.Windows.Forms.NumericUpDown nudProfessionalism;
        private System.Windows.Forms.Label lblComments;
        private System.Windows.Forms.TextBox txtComments;
        private System.Windows.Forms.Button btnSubmitEval;
    }
}
