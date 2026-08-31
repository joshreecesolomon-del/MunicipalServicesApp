using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class ReportIssueForm : Form
    {
        public ReportIssueForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void progressReport_Click(object sender, EventArgs e)
        {

        }

        private void txtLocation_TextChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void UpdateProgress()
        {
            int progress = 0;

            if (!string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                progress += 30;
            }

            if (cmbCategory.SelectedIndex >= 0)
            {
                progress += 30;
            }

            if (!string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                progress += 40;
            }

            progressReport.Value = progress;

            if (progress == 0)
            {
                lblEngagement.Text = "Please start your report.";
            }
            else if (progress == 30)
            {
                lblEngagement.Text = "Good start! Please select a category.";
            }
            else if (progress == 60)
            {
                lblEngagement.Text = "You're making good progress! Add a description.";
            }
            else if (progress == 100)
            {
                if (lblFileName.Text != "No file selected")
                {
                    lblEngagement.Text =
                        "Excellent! Your report includes supporting evidence.";
                }
                else
                {
                    lblEngagement.Text =
                        "Great! Your report is ready to submit.";
                }
            }
        }

        private void rtbDescription_TextChanged(object sender, EventArgs e)
        {
            UpdateProgress();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show(
                    "Please enter the location of the issue.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtLocation.Focus();
                return;
            }

            if (cmbCategory.SelectedIndex == -1)
            {
                MessageBox.Show(
                    "Please select an issue category.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                cmbCategory.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(rtbDescription.Text))
            {
                MessageBox.Show(
                    "Please provide a description of the issue.",
                    "Missing Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                rtbDescription.Focus();
                return;
            }

            Issue newIssue = new Issue
            {
                Location = txtLocation.Text.Trim(),
                Category = cmbCategory.SelectedItem.ToString(),
                Description = rtbDescription.Text.Trim(),
                Attachment = lblFileName.Text,
                DateReported = DateTime.Now
            };

            IssueManager.ReportedIssues.Add(newIssue);

            MessageBox.Show(
                "Your issue has been submitted successfully!\n\n" +
                "Thank you for helping improve your community.",
                "Issue Submitted",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            ClearForm();

        }

        private void ClearForm()
        {
            txtLocation.Clear();
            cmbCategory.SelectedIndex = -1;
            rtbDescription.Clear();

            lblFileName.Text = "No file selected";

            progressReport.Value = 0;

            lblEngagement.Text = "Please start your report.";
        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Select an Image or Document";

                openFileDialog.Filter =
                    "Image Files|*.jpg;*.jpeg;*.png;*.gif|" +
                    "PDF Files|*.pdf|" +
                    "Word Documents|*.doc;*.docx|" +
                    "All Files|*.*";

                openFileDialog.FilterIndex = 1;

                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    lblFileName.Text = System.IO.Path.GetFileName(openFileDialog.FileName);

                    UpdateProgress();

                    lblEngagement.Text =
                        "Excellent! Your report is complete and ready to submit.";
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtLocation.Text) ||
        cmbCategory.SelectedIndex >= 0 ||
        !string.IsNullOrWhiteSpace(rtbDescription.Text) ||
        lblFileName.Text != "No file selected")
            {
                DialogResult result = MessageBox.Show(
                    "You have entered information for this report. " +
                    "Are you sure you want to return to the Main Menu? " +
                    "Your unsaved information will be lost.",
                    "Return to Main Menu",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            this.Close();
        }
    }
}
