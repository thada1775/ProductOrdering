using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace ProductOrdering.Models.ViewModels
{
    public class ReportViewModel
    {
        public UserDetail UserDetail { get; set; }
        public List<Ordering> orderings { get; set; }

        //public List<Status> AllStatus { get; set; }
        public bool SearchByMonth { get; set; } = false;
        public JsonResult? orderingsByMonthJson { get; set; } // for display chart
        public DateTime DisplayingTime { get; set; }

        public List<Ordering> orderingCompleteOfUser { get; set; }
        public List<Ordering> orderingCancelOfUser { get; set; }
        public List<Ordering> orderingSendingOfUser { get; set; }

        public string ShowingTime
        {
            get
            {
                Thread.CurrentThread.CurrentCulture = new CultureInfo("th-TH");
                
                return DisplayingTime.ToString("MMMM yyyy"); 
            }
        }
    }
}
