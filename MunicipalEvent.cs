using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServicesApp
{
    public class MunicipalEvent
    {
        public int EventId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Category { get; set; }

        public string Location { get; set; }

        public DateTime EventDate { get; set; }

        public int Priority { get; set; }

        public override string ToString()
        {
            return Title + " - " +
                   EventDate.ToString("dd MMM yyyy") +
                   " - " + Category;
        }
    }
}