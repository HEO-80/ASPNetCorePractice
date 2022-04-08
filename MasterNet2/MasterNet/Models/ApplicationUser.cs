using Microsoft.AspNetCore.Identity;

namespace MasterNet.Models
{
    public class ApplicationUser : IdentityUser

    {

        public string Name{ get; set; }
        
        public string Surname { get; set; }

        public string Password { get; set; }

        public string Linkedin { get; set; }

        public int Score { get; set; }
    }
}
