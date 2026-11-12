namespace MunicipalServicesApp
{
    partial class ServiceRequestStatusForm
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
            txtRequestId = new TextBox();
            btnSearch = new Button();
            btnShowAll = new Button();
            lblRequestCount = new Label();
            dgvRequests = new DataGridView();
            btnBack = new Button();
            cmbStatus = new ComboBox();
            btnUpdateStatus = new Button();
            btnPrioritise = new Button();
            btnGraphDemo = new Button();
            btnSearchAvl = new Button();
            btnSearchRedBlack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRequests).BeginInit();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(329, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(270, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Service Request Status";
            lblTitle.Click += label1_Click;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(21, 79);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(96, 15);
            lblSearch.TabIndex = 1;
            lblSearch.Text = "Enter Request ID:";
            // 
            // txtRequestId
            // 
            txtRequestId.Location = new Point(21, 97);
            txtRequestId.Name = "txtRequestId";
            txtRequestId.Size = new Size(237, 23);
            txtRequestId.TabIndex = 2;
            txtRequestId.TextChanged += txtRequestId_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(21, 126);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.Location = new Point(577, 331);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(75, 23);
            btnShowAll.TabIndex = 4;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = true;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // lblRequestCount
            // 
            lblRequestCount.AutoSize = true;
            lblRequestCount.Location = new Point(279, 331);
            lblRequestCount.Name = "lblRequestCount";
            lblRequestCount.Size = new Size(92, 15);
            lblRequestCount.TabIndex = 5;
            lblRequestCount.Text = "Total requests: 0";
            // 
            // dgvRequests
            // 
            dgvRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRequests.Location = new Point(279, 79);
            dgvRequests.Name = "dgvRequests";
            dgvRequests.Size = new Size(373, 249);
            dgvRequests.TabIndex = 6;
            dgvRequests.CellContentClick += dgvRequests_CellContentClick;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(21, 415);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(125, 23);
            btnBack.TabIndex = 7;
            btnBack.Text = "Back to Main Menu";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // cmbStatus
            // 
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Location = new Point(684, 79);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(121, 23);
            cmbStatus.TabIndex = 8;
            cmbStatus.SelectedIndexChanged += cmbStatus_SelectedIndexChanged;
            // 
            // btnUpdateStatus
            // 
            btnUpdateStatus.Location = new Point(684, 108);
            btnUpdateStatus.Name = "btnUpdateStatus";
            btnUpdateStatus.Size = new Size(75, 23);
            btnUpdateStatus.TabIndex = 9;
            btnUpdateStatus.Text = "Update Status";
            btnUpdateStatus.UseVisualStyleBackColor = true;
            btnUpdateStatus.Click += btnUpdateStatus_Click;
            // 
            // btnPrioritise
            // 
            btnPrioritise.Location = new Point(684, 137);
            btnPrioritise.Name = "btnPrioritise";
            btnPrioritise.Size = new Size(112, 23);
            btnPrioritise.TabIndex = 10;
            btnPrioritise.Text = "Prioritise Requests";
            btnPrioritise.UseVisualStyleBackColor = true;
            btnPrioritise.Click += btnPrioritise_Click;
            // 
            // btnGraphDemo
            // 
            btnGraphDemo.Location = new Point(699, 415);
            btnGraphDemo.Name = "btnGraphDemo";
            btnGraphDemo.Size = new Size(189, 23);
            btnGraphDemo.TabIndex = 11;
            btnGraphDemo.Text = "Demonstrate Graph Algorithms";
            btnGraphDemo.UseVisualStyleBackColor = true;
            btnGraphDemo.Click += btnGraphDemo_Click;
            // 
            // btnSearchAvl
            // 
            btnSearchAvl.Location = new Point(21, 155);
            btnSearchAvl.Name = "btnSearchAvl";
            btnSearchAvl.Size = new Size(155, 23);
            btnSearchAvl.TabIndex = 12;
            btnSearchAvl.Text = "Search Using AVL Tree";
            btnSearchAvl.UseVisualStyleBackColor = true;
            btnSearchAvl.Click += btnSearchAvl_Click;
            // 
            // btnSearchRedBlack
            // 
            btnSearchRedBlack.Location = new Point(22, 182);
            btnSearchRedBlack.Name = "btnSearchRedBlack";
            btnSearchRedBlack.Size = new Size(189, 23);
            btnSearchRedBlack.TabIndex = 13;
            btnSearchRedBlack.Text = "Search Using Red-Black Tree";
            btnSearchRedBlack.UseVisualStyleBackColor = true;
            btnSearchRedBlack.Click += btnSearchRedBlack_Click;
            // 
            // ServiceRequestStatusForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 450);
            Controls.Add(btnSearchRedBlack);
            Controls.Add(btnSearchAvl);
            Controls.Add(btnGraphDemo);
            Controls.Add(btnPrioritise);
            Controls.Add(btnUpdateStatus);
            Controls.Add(cmbStatus);
            Controls.Add(btnBack);
            Controls.Add(dgvRequests);
            Controls.Add(lblRequestCount);
            Controls.Add(btnShowAll);
            Controls.Add(btnSearch);
            Controls.Add(txtRequestId);
            Controls.Add(lblSearch);
            Controls.Add(lblTitle);
            Name = "ServiceRequestStatusForm";
            Text = "ServiceRequestStatusForm";
            ((System.ComponentModel.ISupportInitialize)dgvRequests).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSearch;
        private TextBox txtRequestId;
        private Button btnSearch;
        private Button btnShowAll;
        private Label lblRequestCount;
        private DataGridView dgvRequests;
        private Button btnBack;
        private ComboBox cmbStatus;
        private Button btnUpdateStatus;
        private Button btnPrioritise;
        private Button btnGraphDemo;
        private Button btnSearchAvl;
        private Button btnSearchRedBlack;
    }
}