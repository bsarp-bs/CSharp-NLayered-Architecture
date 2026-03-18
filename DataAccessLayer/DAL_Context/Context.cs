using EntityLayer.Concrete_Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.DAL_Context
{
    public class Context : IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.\\SQLEXPRESS;database=Plant_SaleOOP;integrated security=true;" +
                "TrustServerCertificate=True;");
        }

        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Communication> Communications { get; set; }
        public DbSet<Images> ImagesTable { get; set; }
        public DbSet<Journal> Journals { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }

    }
}
