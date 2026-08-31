namespace MunicipalServicesApp
{
    partial class MainForm
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
            lblWelcome = new Label();
            btnReportIssues = new Button();
            btnEvents = new Button();
            btnStatus = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(214, 47);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(367, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Municipal Services Application";
            lblTitle.Click += label1_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWelcome.Location = new Point(247, 96);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(283, 21);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "Welcome to the Municipal Services App";
            lblWelcome.Click += label2_Click;
            // 
            // btnReportIssues
            // 
            btnReportIssues.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportIssues.Location = new Point(252, 151);
            btnReportIssues.Name = "btnReportIssues";
            btnReportIssues.Size = new Size(137, 23);
            btnReportIssues.TabIndex = 2;
            btnReportIssues.Text = "Report Issues";
            btnReportIssues.UseVisualStyleBackColor = true;
            btnReportIssues.Click += btnReportIssues_Click;
            // 
            // btnEvents
            // 
            btnEvents.Enabled = false;
            btnEvents.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEvents.Location = new Point(422, 151);
            btnEvents.Name = "btnEvents";
            btnEvents.Size = new Size(108, 79);
            btnEvents.TabIndex = 3;
            btnEvents.Text = "Local Events and Announcements";
            btnEvents.UseVisualStyleBackColor = true;
            // 
            // btnStatus
            // 
            btnStatus.Enabled = false;
            btnStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStatus.Location = new Point(252, 181);
            btnStatus.Name = "btnStatus";
            btnStatus.Size = new Size(137, 49);
            btnStatus.TabIndex = 4;
            btnStatus.Text = "Service Request Status";
            btnStatus.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.Red;
            btnExit.FlatAppearance.BorderColor = SystemColors.ControlText;
            btnExit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(343, 303);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 5;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExit);
            Controls.Add(btnStatus);
            Controls.Add(btnEvents);
            Controls.Add(btnReportIssues);
            Controls.Add(lblWelcome);
            Controls.Add(lblTitle);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblWelcome;
        private Button btnReportIssues;
        private Button btnEvents;
        private Button btnStatus;
        private Button btnExit;
    }
}
