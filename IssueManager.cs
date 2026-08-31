using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MunicipalServicesApp
{
    public static class IssueManager
    {
        public static List<Issue> ReportedIssues { get; } = new List<Issue>();
    }
}
