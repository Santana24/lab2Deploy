using System;
using System.Collections.Generic;
using System.Text;
using Lab1_000780301.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Lab1_000780301.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        //Database Tables

        public DbSet<Team> Teams { get; set; }
    }
}
