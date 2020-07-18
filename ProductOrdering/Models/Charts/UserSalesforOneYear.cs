using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrdering.Models.Charts
{
    public class UserSalesforOneYear
    {
        public string Month { get; set; }
        public int Quantity { get; set; }

        public UserSalesforOneYear()
        {

        }

        public List<UserSalesforOneYear> GetUserSalesforOneYearsList()
        {
            List<UserSalesforOneYear> userSalesforOneYears = new List<UserSalesforOneYear>()
            {
                new UserSalesforOneYear {Month="Jan",Quantity=0},
                new UserSalesforOneYear {Month="Feb",Quantity=0},
                new UserSalesforOneYear {Month="Mach",Quantity=0},
                new UserSalesforOneYear {Month="Apil",Quantity=0},
                new UserSalesforOneYear {Month="May",Quantity=0},
                new UserSalesforOneYear {Month="June",Quantity=0},
                new UserSalesforOneYear {Month="July",Quantity=0},
                new UserSalesforOneYear {Month="Aug",Quantity=0},
                new UserSalesforOneYear {Month="Seb",Quantity=0},
                new UserSalesforOneYear {Month="Oct",Quantity=0},
                new UserSalesforOneYear {Month="Nov",Quantity=0},
                new UserSalesforOneYear {Month="Dec",Quantity=0}

                //new UserSalesforOneYear {Month=1,Quantity=0},
                //new UserSalesforOneYear {Month=2,Quantity=0},
                //new UserSalesforOneYear {Month=3,Quantity=0},
                //new UserSalesforOneYear {Month=4,Quantity=0},
                //new UserSalesforOneYear {Month=5,Quantity=0}

            };
            return userSalesforOneYears;
        }
    }
}
