using MasterNet.Data;
using MasterNet.Models;
using MasterNet.Utils;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MasterNet.Controllers
{
    //[Authorize(Roles = RolesData.Administrator)]
    [AllowAnonymous]
    public class SeedController : Controller
    {

        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;


        public SeedController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }


        public IActionResult Roles()
        {
            IdentityInitilizer.SeedRoles(_roleManager);

            return Ok("Seed Roles completed sucessfully");
        }

        public IActionResult Users()
        {
            IdentityInitilizer.SeedUsers(_userManager);

            return Ok("Seed Users completed sucessfully");
        }
    }
}