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
            @"Server=(localdb)\MSSQLLocalDB;
            Database=CampusFacilitiesDB;
            Integrated Security=True;Encrypt=True;
            TrustServerCertificate=True;";

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
                    command.Parameters.Add("@Location", SqlDbType.NVarChar, 100);
                    command.Parameters.Add("@Description", SqlDbType.NVarChar, 500);
                    command.Parameters.Add("@Category", SqlDbType.NVarChar, 50);
                    command.Parameters.Add("@DateReported", SqlDbType.Date).Value = issue.DateReported;
                    command.Parameters.Add("@Priority", SqlDbType.Int);
                    command.Parameters.Add("@Status", SqlDbType.NVarChar, 50);
                    command.Parameters.Add("@ReportedBy", SqlDbType.NVarChar, 100);
                    
                    connection.Open();
                    
                    return command.ExecuteNonQuery();
                }
            }
        }
    }
}
