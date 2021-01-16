using LenaProject.Entites.ORM.Entities.Concrete;
using LenaProject.Map.Option;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenaProject.DAL.Context
{
    public class ProjectContext:IdentityDbContext<AppUser,AppRole,int>
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer("Server=.; Database=LenaProject; integrated security=true");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new AppUserMapping());
            builder.ApplyConfiguration(new FormsMapping());

            base.OnModelCreating(builder);
        }

        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<AppRole> AppRole { get; set; }

        public DbSet<Forms> Forms { get; set; }

        public DbSet<FormsDetails> FormsDetails { get; set; }
    }
}
