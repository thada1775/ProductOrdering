using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrdering.Models.ViewModels
{
    public class DashboardViewModel
    {
        public int AllOrder { get; set; }
        public int CompleteOrder { get; set; }
        public int SendingOrder { get; set; }
        public int CancelOrder { get; set; }
        public IEnumerable<ApplicationUser> AllUser { get; set; }
        public List<int> OrderLastYear { get; set; }
        public List<int> OrderCurrentYear { get; set; }
    }
}
