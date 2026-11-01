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
            set { location = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public DateTime DateReported
        {
            get { return dateReported; }
            set { dateReported = value; }
        }

        public string Priority
        {
            get { return priority; }
            set { priority = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public string ReportedBy
        {
            get { return reportedBy; }
            set { reportedBy = value; }
        }

        public string Validate()
        {
            if (string.IsNullOrWhiteSpace(location))
                return "Location is required.";
            if (string.IsNullOrWhiteSpace(description))
                return "Description is required.";
            if (string.IsNullOrWhiteSpace(category))
                return "Category is required.";
            if (string.IsNullOrWhiteSpace(priority))
                return "Priority is required.";
            if (string.IsNullOrWhiteSpace(reportedBy))
                return "Reported By is required.";
            return null; // No validation errors
        }
    }
}
