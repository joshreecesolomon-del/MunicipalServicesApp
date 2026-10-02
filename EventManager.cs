using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServicesApp
{
    public static class EventManager
    {
        public static List<MunicipalEvent> GetAllEvents()
        {
            List<MunicipalEvent> allEvents =
                new List<MunicipalEvent>();

            foreach (KeyValuePair<DateTime, List<MunicipalEvent>> entry
                in EventsByDate)
            {
                foreach (MunicipalEvent municipalEvent in entry.Value)
                {
                    allEvents.Add(municipalEvent);
                }
            }

            return allEvents;
        }

        public static List<MunicipalEvent> GetRecommendations()
        {
            List<MunicipalEvent> recommendations =
                new List<MunicipalEvent>();

            // If the user has not searched enough yet,
            // return priority events as general recommendations.
            if (SearchPreferences.Count == 0)
            {
                foreach (KeyValuePair<int, Queue<MunicipalEvent>> entry
                    in PriorityEvents)
                {
                    foreach (MunicipalEvent municipalEvent in entry.Value)
                    {
                        if (!recommendations.Contains(municipalEvent))
                        {
                            recommendations.Add(municipalEvent);
                        }

                        if (recommendations.Count == 3)
                        {
                            return recommendations;
                        }
                    }
                }

                return recommendations;
            }

            // Find the category searched most often.
            string favouriteCategory = "";
            int highestSearchCount = 0;

            foreach (KeyValuePair<string, int> preference
                in SearchPreferences)
            {
                if (preference.Value > highestSearchCount)
                {
                    highestSearchCount = preference.Value;
                    favouriteCategory = preference.Key;
                }
            }

            // Find events belonging to the preferred category.
            foreach (MunicipalEvent municipalEvent in GetAllEvents())
            {
                if (municipalEvent.Category.Equals(
                    favouriteCategory,
                    StringComparison.OrdinalIgnoreCase))
                {
                    recommendations.Add(municipalEvent);
                }
            }

            return recommendations;
        }
        public static void LoadSampleEvents()
        {
            // Prevent duplicate events if the form is opened more than once.
            if (EventsById.Count > 0)
            {
                return;
            }

            AddEvent(new MunicipalEvent
            {
                EventId = 1,
                Title = "Community Clean-Up Day",
                Description = "Join residents in cleaning public areas and promoting a cleaner community.",
                Category = "Community",
                Location = "Municipal Park",
                EventDate = new DateTime(2026, 9, 26),
                Priority = 2
            });

            AddEvent(new MunicipalEvent
            {
                EventId = 2,
                Title = "Heritage Celebration",
                Description = "A community event celebrating South African heritage, culture and traditions.",
                Category = "Cultural",
                Location = "Community Hall",
                EventDate = new DateTime(2026, 9, 27),
                Priority = 2
            });

            AddEvent(new MunicipalEvent
            {
                EventId = 3,
                Title = "Recycling Workshop",
                Description = "Learn practical ways to recycle household waste and keep the community clean.",
                Category = "Environment",
                Location = "Municipal Library",
                EventDate = new DateTime(2026, 10, 3),
                Priority = 3
            });

            AddEvent(new MunicipalEvent
            {
                EventId = 4,
                Title = "Youth Career Information Day",
                Description = "Information about careers, education opportunities and skills development.",
                Category = "Education",
                Location = "Civic Centre",
                EventDate = new DateTime(2026, 10, 10),
                Priority = 3
            });

            AddEvent(new MunicipalEvent
            {
                EventId = 5,
                Title = "Community Sports Day",
                Description = "A community sports programme for residents and local youth.",
                Category = "Sports",
                Location = "Municipal Sports Grounds",
                EventDate = new DateTime(2026, 10, 17),
                Priority = 3
            });

            AddEvent(new MunicipalEvent
            {
                EventId = 6,
                Title = "Planned Water Maintenance",
                Description = "Residents are advised of planned municipal water maintenance.",
                Category = "Municipal Notice",
                Location = "Selected Municipal Areas",
                EventDate = new DateTime(2026, 9, 25),
                Priority = 1
            });

            AddEvent(new MunicipalEvent
            {
                EventId = 7,
                Title = "Ward Community Meeting",
                Description = "Residents are invited to discuss local service delivery matters.",
                Category = "Community",
                Location = "Community Centre",
                EventDate = new DateTime(2026, 10, 5),
                Priority = 2
            });

            AddEvent(new MunicipalEvent
            {
                EventId = 8,
                Title = "Library Reading Programme",
                Description = "A reading and literacy programme for children and young residents.",
                Category = "Education",
                Location = "Municipal Library",
                EventDate = new DateTime(2026, 10, 12),
                Priority = 3
            });

            BuildUpcomingEventsQueue();
        }
        public static void BuildUpcomingEventsQueue()
        {
            UpcomingEvents.Clear();

            foreach (KeyValuePair<DateTime, List<MunicipalEvent>> entry
                in EventsByDate)
            {
                foreach (MunicipalEvent municipalEvent in entry.Value)
                {
                    UpcomingEvents.Enqueue(municipalEvent);
                }
            }
        }

        public static MunicipalEvent GetNextUpcomingEvent()
        {
            if (UpcomingEvents.Count > 0)
            {
                return UpcomingEvents.Peek();
            }

            return null;
        }
        public static MunicipalEvent GetHighestPriorityEvent()
        {
            foreach (KeyValuePair<int, Queue<MunicipalEvent>> entry
                in PriorityEvents)
            {
                if (entry.Value.Count > 0)
                {
                    return entry.Value.Peek();
                }
            }

            return null;
        }
        public static void AddEvent(MunicipalEvent municipalEvent)
        {
            // Add event to Dictionary using its ID.
            if (!EventsById.ContainsKey(municipalEvent.EventId))
            {
                EventsById.Add(municipalEvent.EventId, municipalEvent);
            }

            // Add event to SortedDictionary using its date.
            DateTime date = municipalEvent.EventDate.Date;

            if (!EventsByDate.ContainsKey(date))
            {
                EventsByDate.Add(date, new List<MunicipalEvent>());
            }

            EventsByDate[date].Add(municipalEvent);

            // Add unique category to HashSet.
            Categories.Add(municipalEvent.Category);

            // Add event to the appropriate priority Queue.
            if (!PriorityEvents.ContainsKey(municipalEvent.Priority))
            {
                PriorityEvents.Add(
                    municipalEvent.Priority,
                    new Queue<MunicipalEvent>());
            }

            PriorityEvents[municipalEvent.Priority].Enqueue(municipalEvent);
        }

        public static SortedDictionary<DateTime, List<MunicipalEvent>>
            EventsByDate = new SortedDictionary<DateTime, List<MunicipalEvent>>();

        public static Dictionary<int, MunicipalEvent> EventsById =
        
            new Dictionary<int, MunicipalEvent>();

        public static HashSet<string> Categories =
        
            new HashSet<string>();

        public static Stack<string> SearchHistory =
        
            new Stack<string>();

        public static Queue<MunicipalEvent> UpcomingEvents =
        
            new Queue<MunicipalEvent>();

        public static SortedDictionary<int, Queue<MunicipalEvent>>
            PriorityEvents = new SortedDictionary<int, Queue<MunicipalEvent>>();

        public static Dictionary<string, int> SearchPreferences =
    
            new Dictionary<string, int>();
    }

}
