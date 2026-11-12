using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServicesApp
{
    public class Issue
    {
        public string RequestId { get; set; } =
                    Guid.NewGuid().ToString("N").Substring(0, 8).ToUpper();

        public string Location { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public string Attachment { get; set; }

        public DateTime DateReported { get; set; }

        public string Status { get; set; } = "Submitted";
    }
}
