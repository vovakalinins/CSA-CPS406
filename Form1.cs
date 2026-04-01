using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CSA406
{
    public partial class Form1 : Form
    {
        List<Applicant> allApplicants;
        Applicant selectedApplicant;

        public Form1()
        {
            allApplicants = Data.getApplicants();
            InitializeComponent();
            refreshListView();
        }

        void refreshListView()
        {
            CDlistview.Items.Clear();
            List<Evaluation> evaluations = Data.getEvaluations();

            foreach (Applicant applicant in allApplicants)
            {
                ListViewItem item = new ListViewItem(applicant.ID);
                item.SubItems.Add(applicant.Name);
                item.SubItems.Add(applicant.StudentID);
                item.SubItems.Add(applicant.Email);
                item.SubItems.Add(applicant.Status);
                item.SubItems.Add(applicant.FinalDecision);
                item.SubItems.Add(!string.IsNullOrEmpty(applicant.ReportFilePath) ? "Yes" : "No");
                item.SubItems.Add(evaluations.Any(e => e.StudentID == applicant.StudentID) ? "Yes" : "No");
                CDlistview.Items.Add(item);
            }

            selectedApplicant = null;
            CDselectedApplicant.Visible = false;
            CDfinalAcceptBtn.Enabled = false;
        }

        private void CDlistview_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                string selectedId = e.Item.SubItems[0].Text;
                selectedApplicant = allApplicants.FirstOrDefault(a => a.ID == selectedId);
            }

            if (selectedApplicant == null) return;

            CDselectedApplicant.Visible = true;
            CDselectedApplicant.Text = string.Format("Selected: {0}, {1}, {2} (Status: {3})",
                selectedApplicant.Name, selectedApplicant.StudentID,
                selectedApplicant.Email, selectedApplicant.Status);

            bool isProvisionallyAccepted = selectedApplicant.Status == "Provisionally Accepted";
            bool reportUploaded = !string.IsNullOrEmpty(selectedApplicant.ReportFilePath);
            bool evalReceived = Data.hasEvaluation(selectedApplicant.StudentID);
            CDfinalAcceptBtn.Enabled = isProvisionallyAccepted && reportUploaded && evalReceived;
        }

        private void CDacceptBtn_Click(object sender, EventArgs e)
        {
            if (selectedApplicant == null)
            {
                MessageBox.Show("Please Select an Applicant", "An Error Occured with your Decision!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            allApplicants = Data.updateApplicant(selectedApplicant, true);
            refreshListView();
        }

        private void CDrejectBtn_Click(object sender, EventArgs e)
        {
            if (selectedApplicant == null)
            {
                MessageBox.Show("Please Select an Applicant", "An Error Occured with your Decision!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            allApplicants = Data.updateApplicant(selectedApplicant, false);
            refreshListView();
        }

        private void CDfinalAcceptBtn_Click(object sender, EventArgs e)
        {
            if (selectedApplicant == null)
            {
                MessageBox.Show("Please Select an Applicant", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Data.finalAcceptApplicant(selectedApplicant.ID);
            allApplicants = Data.getApplicants();
            refreshListView();
            MessageBox.Show("Student has been Finally Accepted!", "Final Acceptance", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
