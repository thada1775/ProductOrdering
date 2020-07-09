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
        public UserDetail UserDetail { get; set; }
        public ICollection<Ordering> Orderings { get; }
        public ICollection<ApplicationUserRole> UserRoles { get; set; }

        [NotMapped]
        [Display(Name = "สิทธิ์ผู้ใช้")]
        public string DisplayingAllRole
        {
            get
            {
                string allRole = "";
                if(UserRoles != null)
                {
                    foreach (var role in UserRoles)
                    {
                        allRole = allRole + "," + role.Role.Name;
                    }
                }
                
                return allRole;
            }
        }

    }
}
