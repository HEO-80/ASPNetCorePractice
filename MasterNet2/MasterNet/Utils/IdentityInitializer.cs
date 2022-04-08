using System;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using MasterNet.Data;
using MasterNet.Models;
using Microsoft.AspNetCore.Identity;

namespace MasterNet.Utils
{
    public class IdentityInitilizer
    {

        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync(roleName: RolesData.Reader).Result)
            {
                var role = new IdentityRole();
                role.Name = RolesData.Reader;
                var roleResult = roleManager.CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync(roleName: RolesData.Writer).Result)
            {
                var role = new IdentityRole();
                role.Name = RolesData.Writer;
                var roleResult = roleManager.CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync(roleName: RolesData.Moderator).Result)
            {
                var role = new IdentityRole();
                role.Name = RolesData.Moderator;
                var roleResult = roleManager.CreateAsync(role).Result;
            }

            if (!roleManager.RoleExistsAsync(roleName: RolesData.Administrator).Result)
            {
                var role = new IdentityRole();
                role.Name = RolesData.Administrator;
                var roleResult = roleManager.CreateAsync(role).Result;
            }

        }

        public static void SeedUsers(UserManager<ApplicationUser> userManager)
        {

            if (userManager.FindByNameAsync(RolesData.Reader).Result == null)
            {
                var user = new ApplicationUser();
                user.UserName = RolesData.Reader;
                user.Email = $"{ RolesData.Reader }@mail.com"; //RolesDAta.Reader + "@mail.com";

                var result = userManager.CreateAsync(user, password: "1234Te$t").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, role: RolesData.Reader).Wait();
                }
            }

            if (userManager.FindByNameAsync(RolesData.Writer).Result == null)
            {
                var user = new ApplicationUser();
                user.UserName = RolesData.Writer;
                user.Email = $"{ RolesData.Writer }@mail.com"; //RolesDAta.Reader + "@mail.com";

                var result = userManager.CreateAsync(user, password: "1234Te$t").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, role: RolesData.Writer).Wait();
                }
            }

            if (userManager.FindByNameAsync(RolesData.Moderator).Result == null)
            {
                var user = new ApplicationUser();
                user.UserName = RolesData.Moderator;
                user.Email = $"{ RolesData.Moderator }@mail.com"; //RolesDAta.Reader + "@mail.com";

                var result = userManager.CreateAsync(user, password: "1234Te$t").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, role: RolesData.Moderator).Wait();
                }
            }

            if (userManager.FindByNameAsync(RolesData.Administrator).Result == null)
            {
                var user = new ApplicationUser();
                user.UserName = RolesData.Administrator;
                user.Email = $"{ RolesData.Administrator }@mail.com"; //RolesDAta.Reader + "@mail.com";

                var result = userManager.CreateAsync(user, password: "1234Te$t").Result;

                if (result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, role: RolesData.Administrator).Wait();
                }
            }
        }

    }
}
