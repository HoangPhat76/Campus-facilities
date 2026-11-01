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
    }
}
