Municipal Services Application

1.Project Overview

The Municipal Services Application is a C# Windows Forms application that allows South African citizens to interact with municipal services.

The application includes:

- Reporting municipal service issues.
- Viewing local events and announcements.
- Searching and filtering events.
- Viewing event details.
- Receiving event recommendations based on search preferences.
- Viewing recent searches.
- Viewing important and upcoming events.

The Service Request Status feature is currently disabled and is planned for future development.

2. Technologies Used

- C#
- .NET Framework
- Windows Forms
- Visual Studio
- OpenFileDialog
- Stack
- Queue
- Dictionary
- SortedDictionary
- HashSet

3. Requirements

The following are required:

- Microsoft Visual Studio
- The .NET Framework version used by the project
- Windows operating system

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

The Main Menu provides access to the application's features.

Select "Report an Issue" to report a municipal problem.

Select "Local Events and Announcements" to view upcoming municipal events.

"Service Request Status" is currently disabled and is planned for future development.

Step 2: Report an Issue

Enter:

- Location
- Category
- Description

The application checks that the required information has been completed.

Step 3: Add an Attachment

Select "Choose File" to attach an optional image or document.

Supported formats include:

- JPG, JPEG, PNG, GIF
- PDF
- DOC, DOCX

Step 4: Submit an Issue

Select "Submit Issue".

If the information is valid, the report is added to the application's issue list and a confirmation message is displayed.

Step 5: View Local Events and Announcements

Select "Local Events and Announcements" from the Main Menu.

The application displays upcoming events and announcements.

Users can:

- Search for events using keywords.
- Filter events by category.
- Filter events by date.
- Select an event to view its details.
- View recent searches.
- View recommended events.
- View important notices.
- View the next upcoming event.

Step 6: Search and Filter Events

Enter a keyword into the search box and select "Search".

Users can also select a category or enable the date filter to narrow the results.

Select "Show All" to remove the filters and display all events.

Step 7: Recommendations

The application records user searches and category preferences.

The recommendation feature uses these preferences to identify event categories that the user searches for most often and displays related events.

Before any searches are made, general recommendations are displayed using important upcoming events.

7. User Engagement Feature

The Report Issues section uses a "ProgressBar and encouraging messages" to guide users through the reporting process.

Messages include:

- "Please start your report."
- "Good start! Please select a category."
- "You're making good progress! Add a description."
- "Great! Your report is ready to submit."
- "Excellent! Your report includes supporting evidence."

The Local Events section also provides feedback through search results, event details, recent searches and recommendations.

8. Data Handling

The `Issue` class stores:

- Location
- Category
- Description
- Attachment
- Date reported

Reported issues are stored using a `List<Issue>` while the application is running.

The event section uses several data structures:

- `Stack<string>` for recent searches.
- `Queue<MunicipalEvent>` for upcoming events.
- `Dictionary<int, MunicipalEvent>` for event lookup.
- `SortedDictionary<DateTime, List<MunicipalEvent>>` for organising events by date.
- `HashSet<string>` for unique event categories.
- `SortedDictionary<int, Queue<MunicipalEvent>>` for event priorities.
- `Dictionary<string, int>` for recording search preferences.

9. Project Structure

- `MainForm.cs` – Main menu.
- `ReportIssueForm.cs` – Issue reporting.
- `LocalEventsForm.cs` – Local events and announcements.
- `Issue.cs` – Issue data model.
- `IssueManager.cs` – Manages reported issues.
- `MunicipalEvent.cs` – Event data model.
- `EventManager.cs` – Manages events, data structures and recommendations.
- `Program.cs` – Starts the application.
- `README.md` – Project instructions.

10. Future Improvements

Possible future improvements include:

- Service request tracking.
- Database storage.
- User accounts.
- SMS/email notifications.
- Municipal staff management.
- Cloud storage for attachments.

11. Author

Municipal Services Application  
South Africa
