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
            dtpDateReported = new DateTimePicker();
            cboCategory = new ComboBox();
            txtLocation = new TextBox();
            txtIssueID = new TextBox();
            lblDateReported = new Label();
            lblCategory = new Label();
            lblLocation = new Label();
            lblIssueID = new Label();
            dgvIssues = new DataGridView();
            grpFindIssues.SuspendLayout();
            grpIssueDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIssues).BeginInit();
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
            grpIssueDetails.Controls.Add(dtpDateReported);
            grpIssueDetails.Controls.Add(cboCategory);
            grpIssueDetails.Controls.Add(txtLocation);
            grpIssueDetails.Controls.Add(txtIssueID);
            grpIssueDetails.Controls.Add(lblDateReported);
            grpIssueDetails.Controls.Add(lblCategory);
            grpIssueDetails.Controls.Add(lblLocation);
            grpIssueDetails.Controls.Add(lblIssueID);
            grpIssueDetails.Location = new Point(20, 490);
            grpIssueDetails.Name = "grpIssueDetails";
            grpIssueDetails.Size = new Size(1120, 285);
            grpIssueDetails.TabIndex = 4;
            grpIssueDetails.TabStop = false;
            grpIssueDetails.Text = "Issue Details";
            // 
            // dtpDateReported
            // 
            dtpDateReported.Format = DateTimePickerFormat.Short;
            dtpDateReported.Location = new Point(820, 60);
            dtpDateReported.Name = "dtpDateReported";
            dtpDateReported.Size = new Size(280, 25);
            dtpDateReported.TabIndex = 7;
            // 
            // cboCategory
            // 
            cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCategory.FormattingEnabled = true;
            cboCategory.Items.AddRange(new object[] { "Lighting", "Furniture", "Heating", "Other" });
            cboCategory.Location = new Point(520, 60);
            cboCategory.Name = "cboCategory";
            cboCategory.Size = new Size(278, 25);
            cboCategory.TabIndex = 6;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(190, 60);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(308, 25);
            txtLocation.TabIndex = 5;
            txtLocation.TabStop = false;
            // 
            // txtIssueID
            // 
            txtIssueID.Location = new Point(18, 60);
            txtIssueID.Name = "txtIssueID";
            txtIssueID.ReadOnly = true;
            txtIssueID.Size = new Size(150, 25);
            txtIssueID.TabIndex = 4;
            // 
            // lblDateReported
            // 
            lblDateReported.AutoSize = true;
            lblDateReported.Location = new Point(820, 35);
            lblDateReported.Name = "lblDateReported";
            lblDateReported.Size = new Size(95, 19);
            lblDateReported.TabIndex = 3;
            lblDateReported.Text = "Date reported";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(520, 35);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(65, 19);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "Category";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(190, 35);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(61, 19);
            lblLocation.TabIndex = 1;
            lblLocation.Text = "Location";
            // 
            // lblIssueID
            // 
            lblIssueID.AutoSize = true;
            lblIssueID.Location = new Point(18, 35);
            lblIssueID.Name = "lblIssueID";
            lblIssueID.Size = new Size(131, 19);
            lblIssueID.TabIndex = 0;
            lblIssueID.Text = "Issue ID (automatic)";
            // 
            // dgvIssues
            // 
            dgvIssues.AllowUserToAddRows = false;
            dgvIssues.AllowUserToDeleteRows = false;
            dgvIssues.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvIssues.BackgroundColor = SystemColors.Window;
            dgvIssues.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvIssues.Location = new Point(20, 250);
            dgvIssues.MultiSelect = false;
            dgvIssues.Name = "dgvIssues";
            dgvIssues.ReadOnly = true;
            dgvIssues.RowHeadersVisible = false;
            dgvIssues.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvIssues.Size = new Size(1120, 215);
            dgvIssues.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 876);
            Controls.Add(dgvIssues);
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
            grpIssueDetails.ResumeLayout(false);
            grpIssueDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvIssues).EndInit();
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
        private DataGridView dgvIssues;
        private Label lblDateReported;
        private Label lblCategory;
        private Label lblLocation;
        private Label lblIssueID;
        private DateTimePicker dtpDateReported;
        private ComboBox cboCategory;
        private TextBox txtLocation;
        private TextBox txtIssueID;
    }
}
