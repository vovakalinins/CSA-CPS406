using System;
using System.Windows.Forms;

namespace CSA406
{
    public partial class ApplicationForm : Form
    {
        public ApplicationForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MessageBox.Show("Password is required to create your account.",
                    "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Applicant applicant = StudentApplication.Apply(txtName.Text, txtStudentID.Text, txtEmail.Text);

                Data.registerUser(new User
                {
                    Username = txtStudentID.Text.Trim(),
                    Password = txtPassword.Text,
                    Role = "Student",
                    LinkedStudentID = txtStudentID.Text.Trim(),
                    Name = txtName.Text.Trim()
                });

                txtName.Text = "";
                txtStudentID.Text = "";
                txtEmail.Text = "";
                txtPassword.Text = "";
                MessageBox.Show("Application submitted and account created!\nYou can now login using your Student ID and Password.",
                    "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
