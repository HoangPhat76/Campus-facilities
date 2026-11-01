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
            @"Server=(localdb)\\MSSQLLocalDB;" +
            "Database=CampusFacilitiesDB;" +
            "Integrated Security=True;" +
            "Encrypt=True;" +
            "TrustServerCertificate=True";

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
    }
}
