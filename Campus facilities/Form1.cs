using System.Data;
using Microsoft.Data.SqlClient;

namespace Campus_facilities
{
    public partial class Form1 : Form
    {
        private readonly IssueManager issueManager = new IssueManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable issues = issueManager.GetAllIssues();

                dgvIssues.DataSource = issues;
                dgvIssues.AutoGenerateColumns = true;

                dgvIssues.ClearSelection();
                dgvIssues.CurrentCell = null;

                txtSearchLocation.Clear();
                cboFilterStatus.SelectedItem = "All";

                lblMessage.Text =
                    $"Database connected. {issues.Rows.Count} issue(s) displayed.";
            }
            catch (SqlException ex)
            {
                lblMessage.Text = "Could not load the issues";

                MessageBox.Show(
                    "Could not load issues from the database.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnAddIssue_Click(object sender, EventArgs e)
        {
            FacilityIssue issue = new FacilityIssue();

                issue.Location = txtLocation.Text;
                issue.Description = txtDescription.Text;
                issue.Category = cboCategory.Text;
                issue.DateReported = dtpDateReported.Value.Date;
                issue.Priority = cboPriority.Text;
                issue.Status = cboStatus.Text;
                issue.ReportedBy = txtReportedBy.Text;

            try
            {
                issueManager.AddIssue(issue);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Check your input",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Could not save the issue.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            ResetIssueInputs();

            txtSearchLocation.Clear();
            cboFilterStatus.SelectedItem = "All";

            try
            {
                DataTable issues = issueManager.GetAllIssues();

                dgvIssues.AutoGenerateColumns = true;
                dgvIssues.DataSource = issues;
                dgvIssues.ClearSelection();
                dgvIssues.CurrentCell = null;

                lblMessage.Text =
                    $"Issue added successfully. Showing all {issues.Rows.Count} issue(s).";
            }
            catch (SqlException ex)
            {
                lblMessage.Text = "Issue saved, but the list could not refresh. Click Show All.";

                MessageBox.Show(
                    "Could not load issues from the database.\n" +
                    "Do not ad it again. Click Show All to reload.\n\n" +
                    ex.Message,
                    "Refresh Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }
    }
}
