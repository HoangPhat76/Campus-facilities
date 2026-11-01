namespace Campus_facilities
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblInstructions = new Label();
            grpFindIssues = new GroupBox();
            btnShowAll = new Button();
            btnSearchFilter = new Button();
            cboFilterStatus = new ComboBox();
            lblFilterHelp = new Label();
            txtSearchLocation = new TextBox();
            lblFilterStatus = new Label();
            lblSearchLocation = new Label();
            lblSavedIssues = new Label();
            grpIssueDetails = new GroupBox();
            grpFindIssues.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(20, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(320, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Campus Facilities Issue Register";
            // 
            // lblInstructions
            // 
            lblInstructions.AutoSize = true;
            lblInstructions.Location = new Point(20, 58);
            lblInstructions.Name = "lblInstructions";
            lblInstructions.Size = new Size(317, 19);
            lblInstructions.TabIndex = 1;
            lblInstructions.Text = "Find an issue, select its row, then update its details";
            // 
            // grpFindIssues
            // 
            grpFindIssues.Controls.Add(btnShowAll);
            grpFindIssues.Controls.Add(btnSearchFilter);
            grpFindIssues.Controls.Add(cboFilterStatus);
            grpFindIssues.Controls.Add(lblFilterHelp);
            grpFindIssues.Controls.Add(txtSearchLocation);
            grpFindIssues.Controls.Add(lblFilterStatus);
            grpFindIssues.Controls.Add(lblSearchLocation);
            grpFindIssues.Location = new Point(20, 90);
            grpFindIssues.Name = "grpFindIssues";
            grpFindIssues.Size = new Size(1120, 115);
            grpFindIssues.TabIndex = 2;
            grpFindIssues.TabStop = false;
            grpFindIssues.Text = "Find Issues";
            // 
            // btnShowAll
            // 
            btnShowAll.AutoSize = true;
            btnShowAll.Location = new Point(890, 46);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(210, 33);
            btnShowAll.TabIndex = 6;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            // 
            // btnSearchFilter
            // 
            btnSearchFilter.AutoSize = true;
            btnSearchFilter.Location = new Point(692, 46);
            btnSearchFilter.Name = "btnSearchFilter";
            btnSearchFilter.Size = new Size(180, 33);
            btnSearchFilter.TabIndex = 5;
            btnSearchFilter.Text = "Search / Filter";
            btnSearchFilter.UseVisualStyleBackColor = true;
            // 
            // cboFilterStatus
            // 
            cboFilterStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cboFilterStatus.FormattingEnabled = true;
            cboFilterStatus.Items.AddRange(new object[] { "All", "Outstanding", "Open", "In Progress", "Resolved" });
            cboFilterStatus.Location = new Point(405, 48);
            cboFilterStatus.Name = "cboFilterStatus";
            cboFilterStatus.Size = new Size(265, 25);
            cboFilterStatus.TabIndex = 4;
            // 
            // lblFilterHelp
            // 
            lblFilterHelp.AutoSize = true;
            lblFilterHelp.Location = new Point(18, 87);
            lblFilterHelp.Name = "lblFilterHelp";
            lblFilterHelp.Size = new Size(441, 19);
            lblFilterHelp.TabIndex = 3;
            lblFilterHelp.Text = "Outstanding = Open + In Progress. Show All includes resolved records";
            // 
            // txtSearchLocation
            // 
            txtSearchLocation.Location = new Point(18, 48);
            txtSearchLocation.Name = "txtSearchLocation";
            txtSearchLocation.Size = new Size(365, 25);
            txtSearchLocation.TabIndex = 2;
            // 
            // lblFilterStatus
            // 
            lblFilterStatus.AutoSize = true;
            lblFilterStatus.Location = new Point(405, 25);
            lblFilterStatus.Name = "lblFilterStatus";
            lblFilterStatus.Size = new Size(81, 19);
            lblFilterStatus.TabIndex = 1;
            lblFilterStatus.Text = "Filter Status";
            // 
            // lblSearchLocation
            // 
            lblSearchLocation.AutoSize = true;
            lblSearchLocation.Location = new Point(18, 25);
            lblSearchLocation.Name = "lblSearchLocation";
            lblSearchLocation.Size = new Size(101, 19);
            lblSearchLocation.TabIndex = 0;
            lblSearchLocation.Text = "Search location";
            // 
            // lblSavedIssues
            // 
            lblSavedIssues.AutoSize = true;
            lblSavedIssues.Font = new Font("Segoe UI", 11F);
            lblSavedIssues.Location = new Point(20, 220);
            lblSavedIssues.Name = "lblSavedIssues";
            lblSavedIssues.Size = new Size(91, 20);
            lblSavedIssues.TabIndex = 3;
            lblSavedIssues.Text = "Saved Issues";
            // 
            // grpIssueDetails
            // 
            grpIssueDetails.Location = new Point(20, 381);
            grpIssueDetails.Name = "grpIssueDetails";
            grpIssueDetails.Size = new Size(1120, 285);
            grpIssueDetails.TabIndex = 4;
            grpIssueDetails.TabStop = false;
            grpIssueDetails.Text = "Issue Details";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 876);
            Controls.Add(grpIssueDetails);
            Controls.Add(lblSavedIssues);
            Controls.Add(grpFindIssues);
            Controls.Add(lblInstructions);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 10F);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Campus facilities Issue Register";
            grpFindIssues.ResumeLayout(false);
            grpFindIssues.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblInstructions;
        private GroupBox grpFindIssues;
        private Label lblSavedIssues;
        private GroupBox grpIssueDetails;
        private Button btnShowAll;
        private Button btnSearchFilter;
        private ComboBox cboFilterStatus;
        private Label lblFilterHelp;
        private TextBox txtSearchLocation;
        private Label lblFilterStatus;
        private Label lblSearchLocation;
    }
}
