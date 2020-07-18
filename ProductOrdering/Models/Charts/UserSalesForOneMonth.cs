using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrdering.Models.Charts
{
    public class UserSalesForOneMonth
    {
        public int NumDay { get; set; }
        public int Quantity { get; set; }

        public List<UserSalesForOneMonth> GetListDayOfMonth(int allDaysOfMonth)
        {
            List<UserSalesForOneMonth> userSales = new List<UserSalesForOneMonth>();

            for (int i = 1; i <= allDaysOfMonth; i++)
            {
                userSales.Add(new UserSalesForOneMonth {NumDay = i,Quantity = 0 });
            }

            return userSales;
        }
    }
}
