using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRoll.Persistance
{
    public static class DataSeedingInitializer
    {
        public static async Task UserAndRoleSeedAsync(UserManager<IdentityUser> userManager, 
                                                  RoleManager<IdentityRole> roleManager)
        {
            string[] roles = { "Admin", "Manager", "Staff" };
            foreach(var role in roles)
            {
                var roleExist = await roleManager.RoleExistsAsync(role);
                if (!roleExist)
                {
                    IdentityResult result = await roleManager.CreateAsync(new IdentityRole(role));
                }
            }

            //Creating Admin User
            if (userManager.FindByEmailAsync("admin@payroll.com").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "admin@payroll.com",
                    Email = "admin@payroll.com"
                };
                IdentityResult identityResult = userManager.CreateAsync(user, "password").Result;
                if (identityResult.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }
            //Creating Manager User
            if (userManager.FindByEmailAsync("manager@payroll.com").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "manager@payroll.com",
                    Email = "manager@payroll.com"
                };
                IdentityResult identityResult = userManager.CreateAsync(user, "password").Result;
                if (identityResult.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Manager").Wait();
                }
            }

            //Creating Staff User
            if (userManager.FindByEmailAsync("staff@payroll.com").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "staff@payroll.com",
                    Email = "staff@payroll.com"
                };
                IdentityResult identityResult = userManager.CreateAsync(user, "password").Result;
                if (identityResult.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Staff").Wait();
                }
            }

            //Creating User Without Role
            if (userManager.FindByEmailAsync("user@payroll.com").Result == null)
            {
                IdentityUser user = new IdentityUser
                {
                    UserName = "user@payroll.com",
                    Email = "user@payroll.com"
                };
                IdentityResult identityResult = userManager.CreateAsync(user, "password").Result;
                
            }
        }
    }
}
