namespace MunicipalServicesApp
{
    partial class LocalEventsForm
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
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            lblCategory = new Label();
            cmbCategory = new ComboBox();
            lblDate = new Label();
            dtpEventDate = new DateTimePicker();
            chkUseDate = new CheckBox();
            lblUpcoming = new Label();
            lvEvents = new ListView();
            lblRecommendations = new Label();
            lvRecommendations = new ListView();
            btnBack = new Button();
            btnShowAll = new Button();
            lblRecommendationInfo = new Label();
            lblRecentSearches = new Label();
            lstRecentSearches = new ListBox();
            lblNextEvent = new Label();
            lblImportantNotice = new Label();
            grpEventDetails = new GroupBox();
            lblDetailDescription = new Label();
            lblDetailLocation = new Label();
            lblDetailCategory = new Label();
            lblDetailDate = new Label();
            lblDetailTitle = new Label();
            lblResultCount = new Label();
            grpEventDetails.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(42, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(850, 31);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Local Events and Announcements";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSearch.Location = new Point(153, 120);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(83, 15);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Search Event:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(153, 138);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(201, 23);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(363, 138);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblCategory.Location = new Point(153, 185);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(62, 15);
            lblCategory.TabIndex = 4;
            lblCategory.Text = "Catergory";
            // 
            // cmbCategory
            // 
            cmbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(153, 203);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(121, 23);
            cmbCategory.TabIndex = 5;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDate.Location = new Point(153, 243);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(34, 15);
            lblDate.TabIndex = 6;
            lblDate.Text = "Date";
            // 
            // dtpEventDate
            // 
            dtpEventDate.Format = DateTimePickerFormat.Short;
            dtpEventDate.Location = new Point(153, 261);
            dtpEventDate.Name = "dtpEventDate";
            dtpEventDate.Size = new Size(200, 23);
            dtpEventDate.TabIndex = 7;
            dtpEventDate.ValueChanged += dtpEventDate_ValueChanged;
            // 
            // chkUseDate
            // 
            chkUseDate.AutoSize = true;
            chkUseDate.Location = new Point(377, 260);
            chkUseDate.Name = "chkUseDate";
            chkUseDate.Size = new Size(94, 19);
            chkUseDate.TabIndex = 8;
            chkUseDate.Text = "Filter by date";
            chkUseDate.UseVisualStyleBackColor = true;
            chkUseDate.CheckedChanged += chkUseDate_CheckedChanged;
            // 
            // lblUpcoming
            // 
            lblUpcoming.AutoSize = true;
            lblUpcoming.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUpcoming.Location = new Point(153, 304);
            lblUpcoming.Name = "lblUpcoming";
            lblUpcoming.Size = new Size(221, 15);
            lblUpcoming.TabIndex = 9;
            lblUpcoming.Text = "Upcoming Events and Announcements";
            // 
            // lvEvents
            // 
            lvEvents.FullRowSelect = true;
            lvEvents.GridLines = true;
            lvEvents.Location = new Point(153, 322);
            lvEvents.Name = "lvEvents";
            lvEvents.Size = new Size(371, 150);
            lvEvents.TabIndex = 10;
            lvEvents.UseCompatibleStateImageBehavior = false;
            lvEvents.View = View.Details;
            lvEvents.SelectedIndexChanged += lvEvents_SelectedIndexChanged;
            // 
            // lblRecommendations
            // 
            lblRecommendations.AutoSize = true;
            lblRecommendations.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRecommendations.Location = new Point(625, 268);
            lblRecommendations.Name = "lblRecommendations";
            lblRecommendations.Size = new Size(122, 15);
            lblRecommendations.TabIndex = 11;
            lblRecommendations.Text = "Recommend For You";
            // 
            // lvRecommendations
            // 
            lvRecommendations.FullRowSelect = true;
            lvRecommendations.GridLines = true;
            lvRecommendations.Location = new Point(625, 322);
            lvRecommendations.Name = "lvRecommendations";
            lvRecommendations.Size = new Size(302, 97);
            lvRecommendations.TabIndex = 12;
            lvRecommendations.UseCompatibleStateImageBehavior = false;
            lvRecommendations.View = View.Details;
            lvRecommendations.SelectedIndexChanged += lvRecommendations_SelectedIndexChanged;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(841, 607);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(86, 23);
            btnBack.TabIndex = 13;
            btnBack.Text = "Back to Main Menu";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(449, 139);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(75, 23);
            btnShowAll.TabIndex = 14;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // lblRecommendationInfo
            // 
            lblRecommendationInfo.AutoSize = true;
            lblRecommendationInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRecommendationInfo.Location = new Point(625, 294);
            lblRecommendationInfo.Name = "lblRecommendationInfo";
            lblRecommendationInfo.Size = new Size(306, 15);
            lblRecommendationInfo.TabIndex = 15;
            lblRecommendationInfo.Text = "Recommendations are based on your recent searches.";
            // 
            // lblRecentSearches
            // 
            lblRecentSearches.AutoSize = true;
            lblRecentSearches.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRecentSearches.Location = new Point(625, 111);
            lblRecentSearches.Name = "lblRecentSearches";
            lblRecentSearches.Size = new Size(100, 15);
            lblRecentSearches.TabIndex = 16;
            lblRecentSearches.Text = "Recent Searches";
            // 
            // lstRecentSearches
            // 
            lstRecentSearches.FormattingEnabled = true;
            lstRecentSearches.ItemHeight = 15;
            lstRecentSearches.Location = new Point(625, 139);
            lstRecentSearches.Name = "lstRecentSearches";
            lstRecentSearches.Size = new Size(302, 94);
            lstRecentSearches.TabIndex = 17;
            // 
            // lblNextEvent
            // 
            lblNextEvent.AutoSize = true;
            lblNextEvent.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNextEvent.Location = new Point(153, 90);
            lblNextEvent.Name = "lblNextEvent";
            lblNextEvent.Size = new Size(133, 15);
            lblNextEvent.TabIndex = 18;
            lblNextEvent.Text = "Next Upcoming Event:";
            // 
            // lblImportantNotice
            // 
            lblImportantNotice.AutoSize = true;
            lblImportantNotice.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblImportantNotice.Location = new Point(153, 65);
            lblImportantNotice.Name = "lblImportantNotice";
            lblImportantNotice.Size = new Size(107, 15);
            lblImportantNotice.TabIndex = 19;
            lblImportantNotice.Text = "Important Notice:";
            // 
            // grpEventDetails
            // 
            grpEventDetails.Controls.Add(lblDetailDescription);
            grpEventDetails.Controls.Add(lblDetailLocation);
            grpEventDetails.Controls.Add(lblDetailCategory);
            grpEventDetails.Controls.Add(lblDetailDate);
            grpEventDetails.Controls.Add(lblDetailTitle);
            grpEventDetails.Location = new Point(153, 485);
            grpEventDetails.Name = "grpEventDetails";
            grpEventDetails.Size = new Size(302, 196);
            grpEventDetails.TabIndex = 20;
            grpEventDetails.TabStop = false;
            grpEventDetails.Text = "Event Details";
            // 
            // lblDetailDescription
            // 
            lblDetailDescription.Location = new Point(9, 122);
            lblDetailDescription.Name = "lblDetailDescription";
            lblDetailDescription.Size = new Size(100, 23);
            lblDetailDescription.TabIndex = 4;
            lblDetailDescription.Text = "Description:";
            // 
            // lblDetailLocation
            // 
            lblDetailLocation.AutoSize = true;
            lblDetailLocation.Location = new Point(9, 81);
            lblDetailLocation.Name = "lblDetailLocation";
            lblDetailLocation.Size = new Size(56, 15);
            lblDetailLocation.TabIndex = 3;
            lblDetailLocation.Text = "Location:";
            // 
            // lblDetailCategory
            // 
            lblDetailCategory.AutoSize = true;
            lblDetailCategory.Location = new Point(9, 66);
            lblDetailCategory.Name = "lblDetailCategory";
            lblDetailCategory.Size = new Size(58, 15);
            lblDetailCategory.TabIndex = 2;
            lblDetailCategory.Text = "Category:";
            // 
            // lblDetailDate
            // 
            lblDetailDate.AutoSize = true;
            lblDetailDate.Location = new Point(9, 51);
            lblDetailDate.Name = "lblDetailDate";
            lblDetailDate.Size = new Size(34, 15);
            lblDetailDate.TabIndex = 1;
            lblDetailDate.Text = "Date:";
            // 
            // lblDetailTitle
            // 
            lblDetailTitle.AutoSize = true;
            lblDetailTitle.Location = new Point(9, 26);
            lblDetailTitle.Name = "lblDetailTitle";
            lblDetailTitle.Size = new Size(164, 15);
            lblDetailTitle.TabIndex = 0;
            lblDetailTitle.Text = "Select an event to view details";
            // 
            // lblResultCount
            // 
            lblResultCount.AutoSize = true;
            lblResultCount.Location = new Point(425, 307);
            lblResultCount.Name = "lblResultCount";
            lblResultCount.Size = new Size(99, 15);
            lblResultCount.TabIndex = 21;
            lblResultCount.Text = "Showing 0 events";
            // 
            // LocalEventsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 711);
            Controls.Add(lblResultCount);
            Controls.Add(grpEventDetails);
            Controls.Add(lblImportantNotice);
            Controls.Add(lblNextEvent);
            Controls.Add(lstRecentSearches);
            Controls.Add(lblRecentSearches);
            Controls.Add(lblRecommendationInfo);
            Controls.Add(btnShowAll);
            Controls.Add(btnBack);
            Controls.Add(lvRecommendations);
            Controls.Add(lblRecommendations);
            Controls.Add(lvEvents);
            Controls.Add(lblUpcoming);
            Controls.Add(chkUseDate);
            Controls.Add(dtpEventDate);
            Controls.Add(lblDate);
            Controls.Add(cmbCategory);
            Controls.Add(lblCategory);
            Controls.Add(btnSearch);
            Controls.Add(txtSearch);
            Controls.Add(lblSearch);
            Controls.Add(lblTitle);
            MinimumSize = new Size(1000, 700);
            Name = "LocalEventsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Local Events and Announcements";
            grpEventDetails.ResumeLayout(false);
            grpEventDetails.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSearch;
        private TextBox txtSearch;
        private Button btnSearch;
        private Label lblCategory;
        private ComboBox cmbCategory;
        private Label lblDate;
        private DateTimePicker dtpEventDate;
        private CheckBox chkUseDate;
        private Label lblUpcoming;
        private ListView lvEvents;
        private Label lblRecommendations;
        private ListView lvRecommendations;
        private Button btnBack;
        private Button btnShowAll;
        private Label lblRecommendationInfo;
        private Label lblRecentSearches;
        private ListBox lstRecentSearches;
        private Label lblNextEvent;
        private Label lblImportantNotice;
        private GroupBox grpEventDetails;
        private Label lblDetailTitle;
        private Label lblDetailDate;
        private Label lblDetailDescription;
        private Label lblDetailLocation;
        private Label lblDetailCategory;
        private Label lblResultCount;
    }
}