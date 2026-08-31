Municipal Services Application

1. Project Overview

The Municipal Services Application is a C# Windows Forms application that allows South African citizens to report municipal service issues.

The application allows users to:

Report an issue and select its category.
Enter the issue location and description.
Attach an image or document.
View their reporting progress.
Receive feedback when completing a report.
Submit a report and return to the main menu.

Local Events and Announcements and Service Request Status are included in the main menu but are currently disabled for future development.

2. Technologies Used

C#
.NET Framework
Windows Forms
Visual Studio
OpenFileDialog
`List<Issue>` data structure

3. Requirements

The following are required:

* Microsoft Visual Studio
* The .NET Framework version used by the project
* Windows operating system


4. How to Compile the Application

1. Open the `MunicipalServicesApp` solution in Visual Studio.
2. Select "Build → Rebuild Solution".
3. Make sure there are no build errors.

5. How to Run the Application

1. Open the project in Visual Studio.
2. Press "F5" or select "Start".
3. The Main Menu will appear.

6. How to Use the Application

Step 1: Main Menu

Select "Report an Issue". The other two options are disabled because they are planned for future versions.

Step 2: Report an Issue

Enter:

* Location
* Category
* Description

The application checks that the required information has been completed.

Step 3: Add an Attachment

Select "Choose File" to attach an optional image or document.

Supported formats include:

* JPG, JPEG, PNG, GIF
* PDF
* DOC, DOCX

Step 4: Submit

Select "Submit Issue". If the information is valid, the report is added to the application's issue list and a confirmation message is displayed.

Step 5: Return to Main Menu

Select "Back to Main Menu". If information has been entered, the application asks for confirmation before leaving.

7. User Engagement Feature

The application uses a "ProgressBar and encouraging messages" to guide users through the reporting process.

Messages include:

* "Please start your report."
* "Good start! Please select a category."
* "You're making good progress! Add a description."
* "Great! Your report is ready to submit."
* "Excellent! Your report includes supporting evidence."

This helps users understand their progress and encourages them to complete the report.

8. Data Handling

The `Issue` class stores:

* Location
* Category
* Description
* Attachment
* Date reported

Reported issues are stored using a `List<Issue>` while the application is running.

9. Project Structure

* MainForm.cs – Main menu.
* ReportIssueForm.cs – Issue reporting.
* Issue.cs – Issue data model.
* IssueManager.cs – Manages reported issues.
* Program.cs – Starts the application.
* README.md – Project instructions.

10. Future Improvements

Possible future improvements include:

* Service request tracking.
* Database storage.
* User accounts.
* SMS/email notifications.
* Municipal staff management.
* Cloud storage for attachments.

11. Author

Municipal Services Application
South Africa
