using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class Report_Wrong
    {
        public string Title { get; set; }
        public string Body { get; set; }

        public void PrintReport()
        {
            // print code
        }

        public void SaveReport()
        {
            // code save to database
        }
    }

    // In this example, the Report class is responsible for both creating the report and printing and saving the report.
    // This confuses the responsibilities of the class and can cause maintenance difficulties when changes are made.
}
