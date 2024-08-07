using FluentMappingStudyProject.Data.Mappings;
using FluentMappingStudyProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentMappingStudyProject.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Post> Posts{ get; set; }
        public DbSet<User> Users{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer(
                "Server=localhost,1433;Database=FluentBlog;User ID=sa;Password=1q2w3e4r@#$;TrustServerCertificate=true");
        //options.LogTo(Console.WriteLine); //// Modo de Debug do Entity Framework

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new UserMap());
            modelBuilder.ApplyConfiguration(new PostMap());
        }
    }
}
