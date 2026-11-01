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
            lblSavedIssues = new Label();
            grpIssueDetails = new GroupBox();
            lblSearchLocation = new Label();
            lblFilterStatus = new Label();
            textBox1 = new TextBox();
            this.lblFilterHelp = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
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
            grpFindIssues.Controls.Add(button2);
            grpFindIssues.Controls.Add(button1);
            grpFindIssues.Controls.Add(comboBox1);
            grpFindIssues.Controls.Add(this.lblFilterHelp);
            grpFindIssues.Controls.Add(textBox1);
            grpFindIssues.Controls.Add(lblFilterStatus);
            grpFindIssues.Controls.Add(lblSearchLocation);
            grpFindIssues.Location = new Point(20, 90);
            grpFindIssues.Name = "grpFindIssues";
            grpFindIssues.Size = new Size(1120, 115);
            grpFindIssues.TabIndex = 2;
            grpFindIssues.TabStop = false;
            grpFindIssues.Text = "Find Issues";
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
            // lblSearchLocation
            // 
            lblSearchLocation.AutoSize = true;
            lblSearchLocation.Location = new Point(18, 25);
            lblSearchLocation.Name = "lblSearchLocation";
            lblSearchLocation.Size = new Size(101, 19);
            lblSearchLocation.TabIndex = 0;
            lblSearchLocation.Text = "Search location";
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
            // textBox1
            // 
            textBox1.Location = new Point(243, 50);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 25);
            textBox1.TabIndex = 2;
            // 
            // lblFilterHelp
            // 
            this.lblFilterHelp.AutoSize = true;
            this.lblFilterHelp.Location = new Point(145, 52);
            this.lblFilterHelp.Name = "lblFilterHelp";
            this.lblFilterHelp.Size = new Size(441, 19);
            this.lblFilterHelp.TabIndex = 3;
            this.lblFilterHelp.Text = "Outstanding = Open + In Progress. Show All includes resolved records";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(471, 39);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 25);
            comboBox1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(752, 53);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(896, 60);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
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
        private Button button2;
        private Button button1;
        private ComboBox comboBox1;
        private Label label3;
        private TextBox textBox1;
        private Label lblFilterStatus;
        private Label lblSearchLocation;
    }
}
