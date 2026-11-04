using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Microsoft.Data.SqlClient;

namespace Campus_facilities
{
    internal class IssueManager
    {
        private readonly string connectionString =
            @"Server=(localdb)\MSSQLLocalDB;" +
            @"AttachDbFilename=|DataDirectory|\Data\CampusFacilitiesDB.mdf;" +
            "Integrated Security=True;" +
            "Encrypt=True;" +
            "TrustServerCertificate=True;" +
            "Pooling=False;";

        public DataTable GetAllIssues()
        {
            DataTable issues = new DataTable();

            string sql = @"
                SELECT  
                    IssueId AS IssueID,
                    Location,
                    Description,    
                    Category,
                    DateReported,
                    Priority,
                    Status,
                    ReportedBy
                FROM FacilityIssues
                ORDER BY IssueId DESC;";
            
            using (SqlConnection connection = 
                new SqlConnection(connectionString))
            {
                    using (SqlDataAdapter adapter =
                    new SqlDataAdapter(sql, connection))
                    {
                    connection.Open();
                    adapter.Fill(issues);
                    }
            }
            return issues;
        }
        public int AddIssue(FacilityIssue issue)
        {
            string validationMessage = issue.Validate();

            if (validationMessage != "")
            {
                throw new ArgumentException(validationMessage);
            }

            string sql = @"
                INSERT INTO FacilityIssues
                (
                Location,
                Description,
                Category,
                DateReported,
                Priority,
                Status, 
                ReportedBy
                )
                VALUES
                (
                @Location, 
                @Description, 
                @Category, 
                @DateReported, 
                @Priority, 
                @Status, 
                @ReportedBy
                );";
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@Location", SqlDbType.NVarChar, 100).Value = issue.Location;
                    command.Parameters.Add("@Description", SqlDbType.NVarChar, 500).Value = issue.Description;
                    command.Parameters.Add("@Category", SqlDbType.NVarChar, 50).Value = issue.Category;
                    command.Parameters.Add("@DateReported", SqlDbType.Date).Value = issue.DateReported;
                    command.Parameters.Add("@Priority", SqlDbType.NVarChar, 20).Value = issue.Priority;
                    command.Parameters.Add("@Status", SqlDbType.NVarChar, 20).Value = issue.Status;
                    command.Parameters.Add("@ReportedBy", SqlDbType.NVarChar, 100).Value = issue.ReportedBy;

                    connection.Open();
                    
                    return command.ExecuteNonQuery();
                }
            }
        }
        public int UpdateIssue(FacilityIssue issue)
        {
            if (issue.IssueId <= 0)
            {
                throw new ArgumentException("Issue need to be selected.");
            }

            string validationMessage = issue.Validate();

            if (validationMessage != "")
            {
                throw new ArgumentException(validationMessage);
            }

            string sql = @"
                UPDATE FacilityIssues
                SET 
                    Location = @Location,
                    Description = @Description,
                    Category = @Category,
                    DateReported = @DateReported,
                    Priority = @Priority,
                    Status = @Status,
                    ReportedBy = @ReportedBy
                WHERE IssueID = @IssueID;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@Location", SqlDbType.NVarChar, 100).Value = issue.Location;
                    command.Parameters.Add("@Description", SqlDbType.NVarChar, 500).Value = issue.Description;
                    command.Parameters.Add("@Category", SqlDbType.NVarChar, 50).Value = issue.Category;
                    command.Parameters.Add("@DateReported", SqlDbType.Date).Value = issue.DateReported;
                    command.Parameters.Add("@Priority", SqlDbType.NVarChar, 20).Value = issue.Priority;
                    command.Parameters.Add("@Status", SqlDbType.NVarChar, 20).Value = issue.Status;
                    command.Parameters.Add("@ReportedBy", SqlDbType.NVarChar, 100).Value = issue.ReportedBy;
                    command.Parameters.Add("@IssueID", SqlDbType.Int).Value = issue.IssueId;

                    connection.Open();

                    return command.ExecuteNonQuery();
                }
            }
        }
        public int DeleteIssue(int issueId)
        {
            if (issueId <= 0)
            {
                throw new ArgumentException("Please select an issue to delete.");
            }
            string sql = @"
                DELETE FROM dbo.FacilityIssues
                WHERE IssueID = @IssueID;";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@IssueID", SqlDbType.Int).Value = issueId;
                    connection.Open();
                    return command.ExecuteNonQuery();
                }
            }
        }
        public DataTable SearchIssues(string location, string status)
        {
            location = (location ?? "").Trim();
            status = (status ?? "").Trim();

            if (location.Length > 100)
            {
                throw new ArgumentException("Location search must not exceed 100 characters.");
            }
            
            if (status == "")
            {
                status = "All";            
            }

            if    (status != "All"
                && status != "Outstanding" 
                && status != "Open"
                && status != "In Progress"
                && status != "Resolved")
            {
                throw new ArgumentException("Please select a valid filter.");
            }
            
            DataTable issues = new DataTable();
            
            string sql = @"
                SELECT  
                    IssueId AS IssueID,
                    Location,
                    Description,    
                    Category,
                    DateReported,
                    Priority,
                    Status,
                    ReportedBy
                FROM FacilityIssues
                WHERE 
                    (
                        @Location = N'' OR
                        CHARINDEX(@Location, Location) > 0
                    ) 
                    AND
                    (
                        @Status = N'ALL'
                        OR
                        (
                            @Status = N'Outstanding' 
                            AND Status IN (N'Open', N'In Progress')
                        ) 
                        OR Status = @Status
                    )
                ORDER BY IssueId DESC;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.Add("@Location", SqlDbType.NVarChar, 100).Value = location;
                    command.Parameters.Add("@Status", SqlDbType.NVarChar, 20).Value = status;
                    
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        connection.Open();
                        adapter.Fill(issues);
                    }
                }
            }
            return issues;
        }
    }
}
