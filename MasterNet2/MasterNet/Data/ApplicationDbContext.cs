using MasterNet.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MasterNet.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {



        }


        public DbSet<Post> Posts {get; set;}
        public DbSet<Tag> Tags { get; set; }

        public DbSet<ApplicationUser>  ApplicationUsers{ get; set; }



    }
}
