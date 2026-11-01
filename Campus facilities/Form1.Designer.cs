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
            btnDelete = new Button();
            btnUpdate = new Button();
            button2 = new Button();
            btnClear = new Button();
            txtDescription = new RichTextBox();
            textBox2 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            lblStatus = new Label();
            lblPriority = new Label();
            lblReportedBy = new Label();
            lblDescription = new Label();
            dtpDateReported = new DateTimePicker();
            cboCategory = new ComboBox();
            txtLocation = new TextBox();
            txtIssueID = new TextBox();
            lblDateReported = new Label();
            lblCategory = new Label();
            lblLocation = new Label();
            lblIssueID = new Label();
            dgvIssues = new DataGridView();
            lblMessage = new Label();
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
            btnShowAll.Click += btnShowAll_Click;
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
            grpIssueDetails.Controls.Add(btnDelete);
            grpIssueDetails.Controls.Add(btnUpdate);
            grpIssueDetails.Controls.Add(button2);
            grpIssueDetails.Controls.Add(btnClear);
            grpIssueDetails.Controls.Add(txtDescription);
            grpIssueDetails.Controls.Add(textBox2);
            grpIssueDetails.Controls.Add(comboBox2);
            grpIssueDetails.Controls.Add(comboBox1);
            grpIssueDetails.Controls.Add(lblStatus);
            grpIssueDetails.Controls.Add(lblPriority);
            grpIssueDetails.Controls.Add(lblReportedBy);
            grpIssueDetails.Controls.Add(lblDescription);
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
            // btnDelete
            // 
            btnDelete.Location = new Point(820, 240);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(280, 33);
            btnDelete.TabIndex = 20;
            btnDelete.Text = "Delete Selected";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(520, 240);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(278, 33);
            btnUpdate.TabIndex = 19;
            btnUpdate.Text = "Update Selected";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(190, 240);
            button2.Name = "button2";
            button2.Size = new Size(150, 33);
            button2.TabIndex = 18;
            button2.Text = "Add Issue";
            button2.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(18, 240);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(150, 33);
            btnClear.TabIndex = 17;
            btnClear.Text = "New / Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(18, 135);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(480, 90);
            txtDescription.TabIndex = 16;
            txtDescription.Text = "";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(520, 195);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(580, 25);
            textBox2.TabIndex = 15;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Open", "In Progress", "Resolved" });
            comboBox2.Location = new Point(820, 135);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(280, 25);
            comboBox2.TabIndex = 14;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Low", "Medium", "High" });
            comboBox1.Location = new Point(520, 135);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(278, 25);
            comboBox1.TabIndex = 13;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(820, 110);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(47, 19);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "Status";
            // 
            // lblPriority
            // 
            lblPriority.AutoSize = true;
            lblPriority.Location = new Point(520, 110);
            lblPriority.Name = "lblPriority";
            lblPriority.Size = new Size(53, 19);
            lblPriority.TabIndex = 10;
            lblPriority.Text = "Priority";
            // 
            // lblReportedBy
            // 
            lblReportedBy.AutoSize = true;
            lblReportedBy.Location = new Point(520, 170);
            lblReportedBy.Name = "lblReportedBy";
            lblReportedBy.Size = new Size(84, 19);
            lblReportedBy.TabIndex = 9;
            lblReportedBy.Text = "Reported by";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(18, 110);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(78, 19);
            lblDescription.TabIndex = 8;
            lblDescription.Text = "Description";
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
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(20, 785);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(173, 19);
            lblMessage.TabIndex = 6;
            lblMessage.Text = "Ready to enter a new issue";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1144, 876);
            Controls.Add(lblMessage);
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
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label lblStatus;
        private Label lblPriority;
        private Label lblReportedBy;
        private Label lblDescription;
        private RichTextBox txtDescription;
        private TextBox textBox2;
        private Button btnDelete;
        private Button btnUpdate;
        private Button button2;
        private Button btnClear;
        private Label lblMessage;
    }
}
