using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSA406
{
    public partial class Form1: Form
    {
        List<Applicant> allApplicants;
        Applicant selectedApplicant;

        public Form1()
        {
            allApplicants = Data.getApplicants(); // this gets all the applicants before the form loaded

            InitializeComponent();

            refreshListView();
        }

        void refreshListView()
        {
            CDlistview.Items.Clear();
            foreach (Applicant applicant in allApplicants)
            {
                ListViewItem item = new ListViewItem(applicant.ID);
                item.SubItems.Add(applicant.Name);
                item.SubItems.Add(applicant.StudentID);
                item.SubItems.Add(applicant.Email);
                item.SubItems.Add(applicant.Status);
                item.SubItems.Add(applicant.FinalDecision);
                item.SubItems.Add(applicant.SubmissionDate);
                item.SubItems.Add(applicant.LastModified);
                CDlistview.Items.Add(item);
            }

            selectedApplicant = null;
            CDselectedApplicant.Visible = false;
        }

        private void SAFsubmitButton_Click(object sender, EventArgs e)
        {
            Applicant applicant;
            try
            {
                applicant = StudentApplication.Apply(SAFname.Text, SAFstuId.Text, SAFemail.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "An Error Occured with your Application!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            allApplicants.Add(applicant);
            SAFemail.Text = "";
            SAFname.Text = "";
            SAFstuId.Text = "";
            MessageBox.Show("Application Submitted Successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            refreshListView();
        }

        private void CDlistview_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            // change selectedapplicant to the one selected in the listview
            if (e.IsSelected)
            {
                string selectedId = e.Item.SubItems[0].Text;
                selectedApplicant = allApplicants.FirstOrDefault(a => a.ID == selectedId);
            }

            CDselectedApplicant.Visible = true;
            CDselectedApplicant.Text = String.Format($"Selected Applicant: {selectedApplicant.Name}, {selectedApplicant.StudentID}, {selectedApplicant.Email} (Status: {selectedApplicant.Status})");
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
    }
}
