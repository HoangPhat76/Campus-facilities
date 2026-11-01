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
    }
}
