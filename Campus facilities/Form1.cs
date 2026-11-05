using Microsoft.Data.SqlClient;
using System.Data;
using System.Net.NetworkInformation;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Campus_facilities
{
    public partial class Form1 : Form
    {
        private readonly IssueManager issueManager = new IssueManager();
        private int selectedIssueId = 0;

        public Form1()
        {
            InitializeComponent();
        }

        // Loads every issue from the database and displays the results in the grid.
        private void btnShowAll_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable issues = issueManager.GetAllIssues();

                dgvIssues.DataSource = issues;
                dgvIssues.AutoGenerateColumns = true;

                ResetIssueInputs();

                txtSearchLocation.Clear();
                cboFilterStatus.SelectedItem = "All";

                lblMessage.Text =
                    $"Database is connected. There are {issues.Rows.Count} issue(s) displayed.";
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

        // Runs when the Add Issue button is clicked: collects the form values,
        // saves the issue to the database, clears the input fields, and refreshes the issue list.
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
        // Clears the issue form and returns the buttons to their default state.
        private void ResetIssueInputs()
        {
            selectedIssueId = 0;

            txtLocation.Clear();
            txtDescription.Clear();
            txtIssueID.Clear();
            txtReportedBy.Clear();

            cboCategory.SelectedIndex = -1;
            dtpDateReported.Value = DateTime.Today;
            cboPriority.SelectedIndex = -1;
            cboStatus.SelectedItem = null;
            txtReportedBy.Clear();

            txtLocation.Focus();

            btnAddIssue.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }

        // Copies the selected grid row into the form so it can be updated or deleted.
        private void dgvIssues_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= dgvIssues.Rows.Count)
            {
                return;
            }

            DataGridViewRow selectedRow = dgvIssues.Rows[e.RowIndex];

            if (selectedRow.IsNewRow)
            {
                return;
            }

            selectedIssueId = Convert.ToInt32(selectedRow.Cells["IssueID"].Value);
            txtIssueID.Text = selectedIssueId.ToString();
            txtLocation.Text = Convert.ToString(selectedRow.Cells["Location"].Value);
            txtDescription.Text = Convert.ToString(selectedRow.Cells["Description"].Value);
            cboCategory.Text = Convert.ToString(selectedRow.Cells["Category"].Value);
            dtpDateReported.Value = Convert.ToDateTime(selectedRow.Cells["DateReported"].Value);
            cboPriority.Text = Convert.ToString(selectedRow.Cells["Priority"].Value);
            cboStatus.Text = Convert.ToString(selectedRow.Cells["Status"].Value);
            txtReportedBy.Text = Convert.ToString(selectedRow.Cells["ReportedBy"].Value);

            btnAddIssue.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;

            lblMessage.Text = $"Issue #{selectedIssueId} selected for editing";
        }

        // Clears the current form values and prepares the form for a new issue.
        private void btnClear_Click(object sender, EventArgs e)
        {
            ResetIssueInputs();
            lblMessage.Text = "Ready to enter a new issue";
        }

        // Updates the selected issue in the database and reloads the issue list.
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedIssueId <= 0)
            {
                MessageBox.Show(
                    "Please select an issue to update.",
                    "No Issue Selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            FacilityIssue issue = new FacilityIssue();

            issue.IssueId = selectedIssueId;
            issue.Location = txtLocation.Text;
            issue.Description = txtDescription.Text;
            issue.Category = cboCategory.Text;
            issue.DateReported = dtpDateReported.Value;
            issue.Priority = cboPriority.Text;
            issue.Status = cboStatus.Text;
            issue.ReportedBy = txtReportedBy.Text;

            try
            {
                int affectedRows = issueManager.UpdateIssue(issue);

                if (affectedRows == 0)
                {
                    MessageBox.Show(
                        "The selected issue was not found." +
                        "Click Show All and select an issue again.",
                        "Issue Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    ResetIssueInputs();
                    lblMessage.Text = "No records updated.";
                    return;
                }

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
                    "Could not update the issue.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            try
            {
                DataTable issues = issueManager.GetAllIssues();

                dgvIssues.AutoGenerateColumns = true;
                dgvIssues.DataSource = issues;
                dgvIssues.ClearSelection();
                dgvIssues.CurrentCell = null;

                lblMessage.Text =
                    $"Issue #{selectedIssueId} updated successfully. Showing all {issues.Rows.Count} issue(s).";
            }
            catch (SqlException ex)
            {
                lblMessage.Text = $"Issue #{selectedIssueId} updated, but the list could not be refreshed.";
                MessageBox.Show(
                    "The update was saved, but the list could not refresh.\n" +
                    "Click Show All to reload.\n\n" +
                    ex.Message,
                    "Refresh Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // Confirms deletion, removes the selected issue, and refreshes the grid.
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedIssueId <= 0)
            {
                MessageBox.Show(
                    "Please Select an issue to delete.",
                    "No issue selected",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int deletedIssueId = selectedIssueId;

            DialogResult answer = MessageBox.Show(
                $"Delete Issue #{deletedIssueId} permanently?\n\n" +
                "This action cannot be undone through the application.",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button2);

            if (answer != DialogResult.Yes)
            {
                return;
            }
            try
            {
                int affectedRows =
                    issueManager.DeleteIssue(deletedIssueId);

                if (affectedRows == 0)
                {
                    ResetIssueInputs();
                    lblMessage.Text = "No records deleted. Click Show All to refresh the list.";

                    MessageBox.Show(
                        "The selected issue was not found.\n" +
                        "Click Show All and to refresh the list.",
                        "Issue Not Found",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    return;
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Check your selection",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            ResetIssueInputs();
            txtSearchLocation.Clear();
            cboFilterStatus.SelectedItem = "All";

            try
            {
                DataTable issue = issueManager.GetAllIssues();

                dgvIssues.AutoGenerateColumns = true;
                dgvIssues.DataSource = issue;
                dgvIssues.ClearSelection();
                dgvIssues.CurrentCell = null;

                lblMessage.Text =
                    $"Issue #{deletedIssueId} deleted successfully. " +
                    $"Showing all {issue.Rows.Count} issue(s).";

            }
            catch (SqlException ex)
            {
                lblMessage.Text = $"Issue #{deletedIssueId} deleted, but the list could not be refreshed.";

                MessageBox.Show(
                    "The issue was deleted, but the list could not be refreshed.\n" +
                    "Click Show All to reload.\n\n" +
                    ex.Message,
                    "Refresh Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                throw;
            }
        }

        // Searches the database using the entered location and selected status filter.
        private void btnSearchFilter_Click(object sender, EventArgs e)
        {
            string location = txtSearchLocation.Text.Trim();
            string status = cboFilterStatus.Text;

            if (string.IsNullOrWhiteSpace(status))
            {
                status = "All";
            }

            try
            {
                DataTable issues = issueManager.SearchIssues(location, status);

                dgvIssues.AutoGenerateColumns = true;
                dgvIssues.DataSource = issues;

                ResetIssueInputs();

                cboFilterStatus.SelectedItem = status;

                if (issues.Rows.Count == 0)
                {
                    lblMessage.Text = "No issue match the current filters.";
                }
                else
                {
                    lblMessage.Text = $"{issues.Rows.Count} issue(s) displayed." + $"Status filter; {status}.";
                }
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Check your search",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (SqlException ex)
            {
                lblMessage.Text = "Could not load the issues";
                MessageBox.Show(
                    "Could not search the issues from the database.\n\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
