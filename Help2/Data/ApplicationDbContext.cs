using System;
using System.Collections.Generic;
using System.Text;
using Help2.DbFolder;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Help2.Data
{
    public class AppDb : IdentityDbContext<User>
    {
        public AppDb(DbContextOptions<AppDb> options)
            : base(options)
        {

        }



        public DbSet<Help> Helps { get; set; }
        public DbSet<City> Cities { get; set; }
    }
}
