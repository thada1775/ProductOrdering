using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using ProductOrdering.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductOrdering.Data
{
    public class SampleData
    {
        public static async Task InitializeAsync(IServiceProvider serviceProvider)
        {
            var dbContext = serviceProvider.GetService<ApplicationDbContext>();
            var UserManager = serviceProvider.GetService<UserManager<ApplicationUser>>();
            var RoleManager = serviceProvider.GetService<RoleManager<IdentityRole>>();

            string[] roles = new String[] { "Administrator", "User", "Printer" };

            foreach(var role in roles)
            {
                var isExist = await RoleManager.RoleExistsAsync(role);
                if(!isExist)
                {
                    await RoleManager.CreateAsync(new IdentityRole(role));
                }
            }
            var userDetailOfAdmin = new UserDetail
            {
                FirstName = "ธาดา",
                LastName = "ใจประดิษฐ์",
                Tel = "0823518608",
                Address = "7 หมู่ 2",
                Province_id = 57,
                Aumphure_id = 804,
                District_id = 720801

            };
            var adminUser = new ApplicationUser
            {
                Email = "thada1775@gmail.com",
                UserName = "thada1775@gmail.com",
                EmailConfirmed = true,
                IsEnabled = true,
                UserDetail = userDetailOfAdmin,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var currentUser = await UserManager.FindByEmailAsync(adminUser.Email);

            if(currentUser == null)
            {
                await UserManager.CreateAsync(adminUser,"Secret123!");
                currentUser = await UserManager.FindByEmailAsync(adminUser.Email);
            }

            var isAdmin = await UserManager.IsInRoleAsync(adminUser, "Administrator");
            if(!isAdmin)
            {
                await UserManager.AddToRolesAsync(currentUser, roles);
            }
        }

    }
}
