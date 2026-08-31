namespace MunicipalServicesApp
{
    partial class ReportIssueForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblTitle = new Label();
            lblLocation = new Label();
            txtLocation = new TextBox();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblDescription = new Label();
            rtbDescription = new RichTextBox();
            lblAttachment = new Label();
            btnAttach = new Button();
            lblFileName = new Label();
            lblProgress = new Label();
            progressReport = new ProgressBar();
            lblEngagement = new Label();
            btnSubmit = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(43, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(700, 45);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Report a Municipal Issue";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(96, 74);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(53, 15);
            lblLocation.TabIndex = 1;
            lblLocation.Text = "Location";
            lblLocation.Click += label1_Click;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(94, 101);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(500, 23);
            txtLocation.TabIndex = 2;
            txtLocation.TextChanged += txtLocation_TextChanged;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(96, 141);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 3;
            lblCategory.Text = "Category";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Items.AddRange(new object[] { "Sanitation", "", "Roads", "", "Water", "", "Electricity", "", "Waste Management", "", "Street Lighting", "", "Other" });
            cmbCategory.Location = new Point(94, 169);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(500, 23);
            cmbCategory.TabIndex = 4;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(94, 217);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 5;
            lblDescription.Text = "Description";
            lblDescription.Click += label1_Click_1;
            // 
            // rtbDescription
            // 
            rtbDescription.Location = new Point(94, 246);
            rtbDescription.Name = "rtbDescription";
            rtbDescription.Size = new Size(600, 120);
            rtbDescription.TabIndex = 6;
            rtbDescription.Text = "";
            rtbDescription.TextChanged += rtbDescription_TextChanged;
            // 
            // lblAttachment
            // 
            lblAttachment.AutoSize = true;
            lblAttachment.Location = new Point(94, 395);
            lblAttachment.Name = "lblAttachment";
            lblAttachment.Size = new Size(70, 15);
            lblAttachment.TabIndex = 7;
            lblAttachment.Text = "Attachment";
            // 
            // btnAttach
            // 
            btnAttach.Location = new Point(94, 425);
            btnAttach.Name = "btnAttach";
            btnAttach.Size = new Size(95, 23);
            btnAttach.TabIndex = 8;
            btnAttach.Text = "Choose File";
            btnAttach.UseVisualStyleBackColor = true;
            btnAttach.Click += btnAttach_Click;
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Location = new Point(206, 433);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(88, 15);
            lblFileName.TabIndex = 9;
            lblFileName.Text = "No file selected";
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Location = new Point(96, 471);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(93, 15);
            lblProgress.TabIndex = 10;
            lblProgress.Text = "Report Progress:";
            // 
            // progressReport
            // 
            progressReport.Location = new Point(98, 493);
            progressReport.Name = "progressReport";
            progressReport.Size = new Size(600, 25);
            progressReport.TabIndex = 11;
            progressReport.Click += progressReport_Click;
            // 
            // lblEngagement
            // 
            lblEngagement.AutoSize = true;
            lblEngagement.Location = new Point(94, 536);
            lblEngagement.Name = "lblEngagement";
            lblEngagement.Size = new Size(229, 15);
            lblEngagement.TabIndex = 12;
            lblEngagement.Text = "Please complete the required information.";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(94, 565);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(150, 40);
            btnSubmit.TabIndex = 13;
            btnSubmit.Text = "Submit Issue";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(548, 565);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 40);
            btnBack.TabIndex = 14;
            btnBack.Text = "Back to Main Menu";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ReportIssueForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 611);
            Controls.Add(btnBack);
            Controls.Add(btnSubmit);
            Controls.Add(lblEngagement);
            Controls.Add(progressReport);
            Controls.Add(lblProgress);
            Controls.Add(lblFileName);
            Controls.Add(btnAttach);
            Controls.Add(lblAttachment);
            Controls.Add(rtbDescription);
            Controls.Add(lblDescription);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Controls.Add(txtLocation);
            Controls.Add(lblLocation);
            Controls.Add(lblTitle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "ReportIssueForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Report an Issue";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblLocation;
        private TextBox txtLocation;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblDescription;
        private RichTextBox rtbDescription;
        private Label lblAttachment;
        private Button btnAttach;
        private Label lblFileName;
        private Label lblProgress;
        private ProgressBar progressReport;
        private Label lblEngagement;
        private Button btnSubmit;
        private Button btnBack;
    }
}