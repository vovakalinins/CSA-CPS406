using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace CSA406
{
    public partial class StudentDashboard : Form
    {
        private User currentUser;
        private Applicant applicant;

        public StudentDashboard(User user)
        {
            currentUser = user;
            applicant = Data.getApplicantByStudentID(user.LinkedStudentID);
            InitializeComponent();
            RefreshStatus();
        }

        private void RefreshStatus()
        {
            lblWelcome.Text = "Welcome, " + currentUser.Name;

            if (applicant == null)
            {
                lblStatus.Text = "Status: No application found for your Student ID.";
                lblReportStatus.Text = "";
                btnUploadReport.Enabled = false;
                return;
            }

            string displayStatus = applicant.FinalDecision == "Finally Accepted"
                ? "Finally Accepted"
                : applicant.Status;
            lblStatus.Text = "Current Status: " + displayStatus;

            bool isAccepted = applicant.Status == "Provisionally Accepted"
                || applicant.Status == "Finally Accepted";

            if (!isAccepted)
            {
                lblReportStatus.Text = "You must be Provisionally Accepted before uploading a report.";
                lblReportStatus.ForeColor = Color.Gray;
                btnUploadReport.Enabled = false;
                return;
            }

            if (!string.IsNullOrEmpty(applicant.ReportFilePath))
            {
                lblReportStatus.Text = "Report: Uploaded (" + Path.GetFileName(applicant.ReportFilePath) + ")";
                lblReportStatus.ForeColor = Color.Green;
                btnUploadReport.Enabled = false;
            }
            else
            {
                lblReportStatus.Text = "Report: Not yet uploaded";
                lblReportStatus.ForeColor = Color.OrangeRed;
            }
        }

        private void btnUploadReport_Click(object sender, EventArgs e)
        {
            if (applicant == null || (applicant.Status != "Provisionally Accepted"
                && applicant.Status != "Finally Accepted"))
            {
                MessageBox.Show("You must be Provisionally Accepted before uploading a report.",
                    "Not Accepted", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "PDF Files (*.pdf)|*.pdf";
                ofd.Title = "Select your Work Term Report";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string uploadsDir = Path.Combine(Application.StartupPath, "Uploads");
                    if (!Directory.Exists(uploadsDir))
                    {
                        Directory.CreateDirectory(uploadsDir);
                    }

                    string fileName = applicant.StudentID + "_" + Path.GetFileName(ofd.FileName);
                    string destPath = Path.Combine(uploadsDir, fileName);
                    File.Copy(ofd.FileName, destPath, true);

                    Data.updateApplicantReport(applicant.StudentID, destPath);
                    applicant = Data.getApplicantByStudentID(currentUser.LinkedStudentID);
                    RefreshStatus();
                    MessageBox.Show("Report uploaded successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
