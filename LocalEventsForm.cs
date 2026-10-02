using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MunicipalServicesApp
{
    public partial class LocalEventsForm : Form
    {
        public LocalEventsForm()
        {
            InitializeComponent();

            dtpEventDate.Value = DateTime.Today;
            dtpEventDate.Enabled = false;

            SetupEventList();
            SetupRecommendationList();

            LoadEventData();

            ClearEventDetails();

            DisplayNextUpcomingEvent();
            DisplaySearchHistory();
            DisplayRecommendations();
            DisplayImportantNotice();
        }

        private void DisplayImportantNotice()
        {
            MunicipalEvent priorityEvent =
                EventManager.GetHighestPriorityEvent();

            if (priorityEvent != null)
            {
                lblImportantNotice.Text =
                    "Important Notice: " +
                    priorityEvent.Title +
                    " - " +
                    priorityEvent.EventDate.ToString("dd MMM yyyy");
            }
            else
            {
                lblImportantNotice.Text =
                    "No important notices available.";
            }
        }
                private void ClearEventDetails()
        {
            lblDetailTitle.Text =
                "Select an event to view details";

            lblDetailDate.Text =
                "Date:";

            lblDetailCategory.Text =
                "Category:";

            lblDetailLocation.Text =
                "Location:";

            lblDetailDescription.Text =
                "Description:";
        }
        private void DisplayEventDetails(
            MunicipalEvent municipalEvent)
        {
            lblDetailTitle.Text =
                municipalEvent.Title;

            lblDetailDate.Text =
                "Date: " +
                municipalEvent.EventDate.ToString("dd MMMM yyyy");

            lblDetailCategory.Text =
                "Category: " +
                municipalEvent.Category;

            lblDetailLocation.Text =
                "Location: " +
                municipalEvent.Location;

            lblDetailDescription.Text =
                "Description: " +
                municipalEvent.Description;
        }

        private void DisplayNextUpcomingEvent()
        {
            MunicipalEvent nextEvent =
                EventManager.GetNextUpcomingEvent();

            if (nextEvent != null)
            {
                lblNextEvent.Text =
                    "Next Upcoming Event: " +
                    nextEvent.Title +
                    " - " +
                    nextEvent.EventDate.ToString("dd MMM yyyy");
            }
            else
            {
                lblNextEvent.Text =
                    "No upcoming events available.";
            }
        }

        private void SetupEventList()
        {
            lvEvents.View = View.Details;
            lvEvents.FullRowSelect = true;
            lvEvents.GridLines = true;
            lvEvents.MultiSelect = false;
            lvEvents.HideSelection = false;

            lvEvents.Columns.Clear();

            lvEvents.Columns.Add("Date", 110);
            lvEvents.Columns.Add("Event", 220);
            lvEvents.Columns.Add("Category", 130);
            lvEvents.Columns.Add("Location", 200);
        }

        private void SetupRecommendationList()
        {
            lvRecommendations.View = View.Details;
            lvRecommendations.FullRowSelect = true;
            lvRecommendations.GridLines = true;
            lvRecommendations.MultiSelect = false;
            lvRecommendations.HideSelection = false;

            lvRecommendations.Columns.Clear();

            lvRecommendations.Columns.Add("Date", 100);
            lvRecommendations.Columns.Add("Event", 200);
            lvRecommendations.Columns.Add("Category", 120);
            lvRecommendations.Columns.Add("Location", 180);
        }

        private void DisplayRecommendations()
        {
            lvRecommendations.Items.Clear();

            List<MunicipalEvent> recommendations =
                EventManager.GetRecommendations();

            foreach (MunicipalEvent municipalEvent in recommendations)
            {
                ListViewItem item =
                    new ListViewItem(
                        municipalEvent.EventDate.ToString("dd/MM/yyyy"));

                item.SubItems.Add(municipalEvent.Title);
                item.SubItems.Add(municipalEvent.Category);
                item.SubItems.Add(municipalEvent.Location);

                item.Tag = municipalEvent;

                lvRecommendations.Items.Add(item);
            }

            UpdateRecommendationMessage();
        }

        private void UpdateRecommendationMessage()
        {
            if (EventManager.SearchPreferences.Count == 0)
            {
                lblRecommendationInfo.Text =
                    "Popular and important upcoming events.";
            }
            else
            {
                lblRecommendationInfo.Text =
                    "Recommendations based on your search preferences.";
            }
        }

        private void LoadEventData()
        {
            EventManager.LoadSampleEvents();

            DisplayEvents(EventManager.GetAllEvents());

            LoadCategories();
        }

        private void LoadCategories()
        {
            cmbCategory.Items.Clear();

            cmbCategory.Items.Add("All Categories");

            foreach (string category in EventManager.Categories)
            {
                cmbCategory.Items.Add(category);
            }

            cmbCategory.SelectedIndex = 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchEvents();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DisplayEvents(List<MunicipalEvent> events)
        {
            lvEvents.Items.Clear();

            foreach (MunicipalEvent municipalEvent in events)
            {
                ListViewItem item =
                    new ListViewItem(
                        municipalEvent.EventDate.ToString("dd/MM/yyyy"));

                item.SubItems.Add(municipalEvent.Title);
                item.SubItems.Add(municipalEvent.Category);
                item.SubItems.Add(municipalEvent.Location);

                item.Tag = municipalEvent;

                lvEvents.Items.Add(item);
            }

            lblResultCount.Text =
                "Showing " + events.Count + " event(s)";
        }

        private void SearchEvents()
        {
            string searchText = txtSearch.Text.Trim().ToLower();

            string selectedCategory = "";

            if (cmbCategory.SelectedItem != null)
            {
                selectedCategory = cmbCategory.SelectedItem.ToString();
            }

            bool useDate = chkUseDate.Checked;
            DateTime selectedDate = dtpEventDate.Value.Date;

            List<MunicipalEvent> results =
                new List<MunicipalEvent>();

            foreach (MunicipalEvent municipalEvent
                in EventManager.GetAllEvents())
            {
                bool matchesText =
                    string.IsNullOrWhiteSpace(searchText) ||
                    municipalEvent.Title.ToLower().Contains(searchText) ||
                    municipalEvent.Description.ToLower().Contains(searchText) ||
                    municipalEvent.Location.ToLower().Contains(searchText) ||
                    municipalEvent.Category.ToLower().Contains(searchText);

                bool matchesCategory =
                    string.IsNullOrWhiteSpace(selectedCategory) ||
                    selectedCategory == "All Categories" ||
                    municipalEvent.Category == selectedCategory;

                bool matchesDate =
                    !useDate ||
                    municipalEvent.EventDate.Date == selectedDate;

                if (matchesText &&
                    matchesCategory &&
                    matchesDate)
                {
                    results.Add(municipalEvent);
                }
            }

            DisplayEvents(results);

            RecordSearch(searchText, selectedCategory);

            DisplaySearchHistory();
            DisplayRecommendations();

            if (results.Count == 0)
            {
                MessageBox.Show(
                    "No events were found that match your search.",
                    "No Results",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }
        private void RecordSearch(
            string searchText,
            string selectedCategory)
        {
            if (!string.IsNullOrWhiteSpace(searchText))
            {
                EventManager.SearchHistory.Push(searchText);
            }
            else if (!string.IsNullOrWhiteSpace(selectedCategory) &&
                     selectedCategory != "All Categories")
            {
                EventManager.SearchHistory.Push(
                    "Category: " + selectedCategory);
            }

            bool categoryRecorded = false;

            if (!string.IsNullOrWhiteSpace(selectedCategory) &&
                selectedCategory != "All Categories")
            {
                IncreasePreference(selectedCategory);
                categoryRecorded = true;
            }

            if (!categoryRecorded &&
                !string.IsNullOrWhiteSpace(searchText))
            {
                foreach (string category in EventManager.Categories)
                {
                    string lowerCategory =
                        category.ToLower();

                    if (lowerCategory.Contains(searchText) ||
                        searchText.Contains(lowerCategory))
                    {
                        IncreasePreference(category);
                        break;
                    }
                }
            }
        }

        private void IncreasePreference(string category)
        {
            string key = category.ToLower();

            if (EventManager.SearchPreferences.ContainsKey(key))
            {
                EventManager.SearchPreferences[key]++;
            }
            else
            {
                EventManager.SearchPreferences.Add(key, 1);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();

            if (cmbCategory.Items.Count > 0)
            {
                cmbCategory.SelectedIndex = 0;
            }

            chkUseDate.Checked = false;

            ClearEventDetails();

            DisplayEvents(EventManager.GetAllEvents());
        }

        private void dtpEventDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void chkUseDate_CheckedChanged(object sender, EventArgs e)
        {
            dtpEventDate.Enabled = chkUseDate.Checked;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchEvents();

                e.SuppressKeyPress = true;
            }
        }

        private void DisplaySearchHistory()
        {
            lstRecentSearches.Items.Clear();

            int count = 0;

            foreach (string search in EventManager.SearchHistory)
            {
                lstRecentSearches.Items.Add(search);

                count++;

                if (count == 5)
                {
                    break;
                }
            }

            if (lstRecentSearches.Items.Count == 0)
            {
                lstRecentSearches.Items.Add("No recent searches");
            }
        }

        private void lvEvents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvEvents.SelectedItems.Count == 0)
            {
                return;
            }

            MunicipalEvent selectedEvent =
                lvEvents.SelectedItems[0].Tag as MunicipalEvent;

            if (selectedEvent != null)
            {
                DisplayEventDetails(selectedEvent);
            }
        }

        private void lvRecommendations_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvRecommendations.SelectedItems.Count == 0)
            {
                return;
            }

            MunicipalEvent selectedEvent =
                lvRecommendations.SelectedItems[0].Tag
                as MunicipalEvent;

            if (selectedEvent != null)
            {
                DisplayEventDetails(selectedEvent);
            }
        }
    }
}
