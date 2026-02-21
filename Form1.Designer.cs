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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.SAFname = new System.Windows.Forms.TextBox();
            this.SAFstuId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SAFemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SAFsubmitButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Coordinator Dashboard";
            this.tabPage2.UseVisualStyleBackColor = true;
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
            // SAFname
            // 
            this.SAFname.Location = new System.Drawing.Point(181, 122);
            this.SAFname.Name = "SAFname";
            this.SAFname.Size = new System.Drawing.Size(232, 20);
            this.SAFname.TabIndex = 1;
            // 
            // SAFstuId
            // 
            this.SAFstuId.Location = new System.Drawing.Point(181, 153);
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
            // SAFsubmitButton
            // 
            this.SAFsubmitButton.Location = new System.Drawing.Point(102, 237);
            this.SAFsubmitButton.Name = "SAFsubmitButton";
            this.SAFsubmitButton.Size = new System.Drawing.Size(311, 23);
            this.SAFsubmitButton.TabIndex = 6;
            this.SAFsubmitButton.Text = "Submit";
            this.SAFsubmitButton.UseVisualStyleBackColor = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 408);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
    }
}

