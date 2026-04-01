using System;
using System.Windows.Forms;

namespace CSA406
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            Data.seedDefaultUsers();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            User user = Data.authenticateUser(username, password);
            if (user == null)
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.Hide();
            Form dashboard = null;

            switch (user.Role)
            {
                case "Student":
                    dashboard = new StudentDashboard(user);
                    break;
                case "Employer":
                    dashboard = new EmployerDashboard(user);
                    break;
                case "Coordinator":
                    dashboard = new Form1();
                    break;
                default:
                    MessageBox.Show("Unknown user role.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Show();
                    return;
            }

            dashboard.FormClosed += (s, args) => this.Close();
            dashboard.Show();
        }

        private void btnNewApplication_Click(object sender, EventArgs e)
        {
            ApplicationForm appForm = new ApplicationForm();
            appForm.ShowDialog();
        }
    }
}
