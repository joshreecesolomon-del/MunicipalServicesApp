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
- Tracking and managing service requests.

The Local Events and Announcements section allows users to search and filter events, view event details, view recent searches, receive recommendations based on search preferences, and identify important and upcoming events.
The Service Request Status section extends the application by allowing users to search for submitted requests, view and update request statuses, and prioritise requests using data structures and algorithms.

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
- Binary Search Tree (BST)
- AVL Tree
- Red-Black Tree
- Binary Max-Heap
- Graphs, Breadth-First Search (BFS), Depth-First Search (DFS), and Kruskal's Minimum Spanning Tree algorithm

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
4. Select the feaature you want to use.


6. How to Use the Application

Step 1: Main Menu

The Main Menu provides access to the application's features.

Report an Issue
Local Events and Announcements
Service Request Status

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

Step 8: View Service Request Status

Select "Service Request Status" from the Main Menu.

The status screen allows users to:

-View submitted service requests.
-Identify requests using their unique request IDs.
-Search for requests using a binary search tree.
-Search using an AVL tree.
-Search using a red-black tree.
-Update a selected request's status.
-Display requests in priority order using a binary max-heap.
-Demonstrate graph traversal and minimum spanning tree algorithms.

Available status values are:

-Submitted
-In Progress
-Completed

The priority heap places Submitted requests first, followed by In Progress and Completed requests. Older requests are prioritised within the same status.

The graph demonstration uses sample service areas and distances to demonstrate BFS, DFS and Kruskal's algorithm.

7. User Engagement Feature

The Report Issues section uses a "ProgressBar and encouraging messages" to guide users through the reporting process.

Messages include:

- "Please start your report."
- "Good start! Please select a category."
- "You're making good progress! Add a description."
- "Great! Your report is ready to submit."
- "Excellent! Your report includes supporting evidence."

The Local Events section also provides feedback through search results, event details, recent searches and recommendations.

The Service Request Status section provides feedback when searches succeed or fail, when statuses are updated, and when the user demonstrates the graph algorithms.

8. Data Handling and Data Structures

8.1 Issue Management

The `Issue` class stores:

- Request ID
- Location
- Category
- Description
- Attachment
- Date reported
- Current Status

The IssueManager class manages reported issues using a List<Issue>.

8.2 Event Management

The event section uses several data structures:

- Stack<string> for recent searches.
- Queue<MunicipalEvent> for upcoming events.
- Dictionary<int, MunicipalEvent> for event lookup.
- SortedDictionary<DateTime, List<MunicipalEvent>> for organising events by date.
- HashSet<string> for unique event categories.
- SortedDictionary<int, Queue<MunicipalEvent>> for event priorities.
- Dictionary<string, int> for recording search preferences.

8.3 Binary Search Tree

The RequestSearchTree class organises requests by request ID and supports insertion and searching.

Average search and insertion time is O(log n) when the tree is reasonably balanced. Worst-case time is O(n).

8.4 AVL Tree

The RequestAvlTree class is a self-balancing binary search tree. It uses node heights, balance factors and rotations to maintain balance following insertion.

Search and insertion take O(log n) time.

8.5 Red-Black Tree

The RequestRedBlackTree class maintains balance using red and black node colours, recolouring and rotations.

Search and insertion take O(log n) time.

8.6 Binary Max-Heap

The RequestPriorityHeap class prioritises requests according to their status and report date.

- Enqueue: O(log n)
- Peek: O(1)
- Dequeue: O(log n)
- Produce the complete priority order: O(n log n)

8.7 Graph Algorithms

The ServiceAreaGraph class represents connections between service areas using an adjacency-list representation.

- Breadth-First Search (BFS): explores connected areas level by level.
- Depth-First Search (DFS): explores a path before backtracking.
- Kruskal's Minimum Spanning Tree: selects low-distance connections without creating cycles, using a disjoint-set structure.

BFS and DFS take O(V + E) time, where V is the number of vertices and E is the number of edges. Kruskal's algorithm takes O(E log E) time, dominated by edge sorting.

9. Project Structure

- `MainForm.cs` – Main menu.
- `ReportIssueForm.cs` – Issue reporting.
- `LocalEventsForm.cs` – Local events and announcements.
- `ServiceRequestStatusForm.cs` - Request search, status updates, prioritisation and algorithm demoonstrations.
- `Issue.cs` – Issue data model.
- `IssueManager.cs` – Manages reported issues.
- `MunicipalEvent.cs` – Event data model.
- `EventManager.cs` – Manages events, data structures and recommendations.
- `RequestSearchTree.cs` - Binary search tree implementation.
- `RequestAvlTree.cs` - AVL tree implementation.
- `RequestRedBlackTree.cs` - Red-black tree implementation
- `RequestPriorityHeap.cs` - Priority heap implementation.
- `ServiceAreaGraph.cs` - Graph representation and graph algorithms.
- `Program.cs` – Starts the application.
- `README.md` – Project instructions.

10. Testing

The following features have been tested during development:

- Building the application after adding the data structure classes.
- Searching for requests using the binary search tree.
- Searching for requests using the AVL and red-black trees.
- Prioritising requests using the binary max-heap.
- Demonstrating BFS, DFS, and Kruskal's minimum spanning tree.
- Opening the Service Request Status screen.

11. Limitations

Reported issues are stored in memory using a static list. Consequently, request records and status updates are not automatically retained after the application closes.

The graph uses illustrative service areas and distances rather than real municipal infrastructure data. The priority rules are demonstration rules and do not replace a real municipal urgency-assessment process.

The tree structures are rebuilt from the current issue list when their search buttons are used.

12. Future Improvements

Possible future improvements include:

- Persistent database storage.
- User accounts and authentication
- SMS and email notifications.
- Municipal staff management features.
- Secure cloud storage for attachments.
- More realistic request urgency and prioritisation rules.
- Integration with real municipal service-area information.

13. Author

Municipal Services Application  
South Africa