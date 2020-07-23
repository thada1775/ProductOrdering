using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrdering.Models
{
    public class ApplicationUser : IdentityUser
    {
        public bool IsEnabled { get; set; }
        public UserDetail UserDetail { get; set; } = new UserDetail();
        public ICollection<Ordering> Orderings { get; }
        //public List<ApplicationUserRole> UserRoles { get; set; }

        [NotMapped]
        public List<string> Roles { get; set; }

        [NotMapped]
        [Display(Name = "สิทธิ์ผู้ใช้")]
        public string DisplayingAllRole
        {
            get
            {

                string allRole = "";
                if(Roles != null)
                {
                    bool firstRole = true;
                    foreach (var role in Roles)
                    {

                        if(!firstRole)
                        {
                            allRole = allRole + "," + role;
                        }
                        else
                        {
                            allRole = role;
                            firstRole = false;
                        }
                        
                    }
                }
                
                return allRole;
            }
        }


    }
}
