using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSA406
{
    public partial class EmployerDashboard : Form
    {
        private User currentUser;
        private List<Applicant> acceptedStudents;

        public EmployerDashboard(User user)
        {
            currentUser = user;
            InitializeComponent();
            lblWelcome.Text = "Welcome, " + currentUser.Name;
            LoadStudents();
        }

        private void LoadStudents()
        {
            acceptedStudents = Data.getAcceptedApplicants();
            cmbStudents.Items.Clear();
            foreach (var student in acceptedStudents)
            {
                cmbStudents.Items.Add(student.Name + " (" + student.StudentID + ")");
            }
        }

        private void btnSubmitEval_Click(object sender, EventArgs e)
        {
            if (cmbStudents.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a student to evaluate.",
                    "No Student Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(txtComments.Text))
            {
                MessageBox.Show("Please provide comments for the evaluation.",
                    "Comments Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Applicant selected = acceptedStudents[cmbStudents.SelectedIndex];

            var evaluation = new Evaluation
            {
                ID = Guid.NewGuid().ToString(),
                StudentID = selected.StudentID,
                EmployerName = currentUser.Name,
                TechnicalSkills = (int)nudTechnical.Value,
                Professionalism = (int)nudProfessionalism.Value,
                Comments = txtComments.Text
            };

            Data.saveEvaluation(evaluation);

            MessageBox.Show("Evaluation submitted successfully for " + selected.Name + "!",
                "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            cmbStudents.SelectedIndex = -1;
            nudTechnical.Value = 1;
            nudProfessionalism.Value = 1;
            txtComments.Text = "";
        }
    }
}
