using System;
using System.Collections.Generic;
using System.Text;

namespace Campus_facilities
{
    public class FacilityIssue
    {
        private int issueId;
        private string location = "";
        private string description = "";
        private string category = "";
        private DateTime dateReported = DateTime.Today;
        private string priority = "";
        private string status = "Open";
        private string reportedBy = "";


        public int IssueId
        {
            get { return issueId; }
            set { issueId = value; }
        }

        public string Location
        {
            get { return location; }
            set { location = (value ?? "").Trim(); }
        }

        public string Description
        {
            get { return description; }
            set { description = (value ?? "").Trim(); }
        }

        public string Category
        {
            get { return category; }
            set { category = (value ?? "").Trim(); }
        }

        public DateTime DateReported
        {
            get { return dateReported; }
            set { dateReported = value.Date; }
        }

        public string Priority
        {
            get { return priority; }
            set { priority = (value ?? "").Trim(); }
        }

        public string Status
        {
            get { return status; }
            set { status = (value ?? "").Trim(); }
        }

        public string ReportedBy
        {
            get { return reportedBy; }
            set { reportedBy = (value ?? "").Trim(); }
        }

        public string Validate()
        {
            if (string.IsNullOrWhiteSpace(location))
                return "Please enter a issue location.";

            if (location.Length > 100)
                return "Location cannot exceed 100 characters.";

            if (string.IsNullOrWhiteSpace(description))
                return "Please describe the issue.";
            
            if (description.Length > 500)
                return "Description cannot exceed 500 characters.";

            if (category != "Lighting" 
                && category != "Furniture" 
                && category != "Heating" 
                && category != "Other")
            {
                return "Please select a valid issue category.";
            }

            if (priority != "Low"
                && priority != "Medium"
                && priority != "High")
            {
                return "Please select a valid issue priority.";
            }

            if (status != "Open"
                && status != "In Progress"
                && status != "Resolved")
            {
                return "Please select a valid issue status.";
            }

            if (dateReported > DateTime.Today)
            {
                return "Date reported cannot be in the future.";
            }

            if (string.IsNullOrWhiteSpace(reportedBy))
            {
                return "Reported By is required.";
            }

            if (reportedBy.Length > 100)
            {
                return "Reported By cannot exceed 100 characters.";
            }

            return "";
        }
    }
}
