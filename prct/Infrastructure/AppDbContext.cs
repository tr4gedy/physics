using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Xml.Linq;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using prct.Models;
namespace prct.Infrastructure
{
    internal class AppDbContext : DbContext
    {

        public DbSet<Topics> Topics { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=prct;Username=postgres;Password=sa");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Topics>()
                .ToTable("Topics");

            modelBuilder.Entity<Topics>()
                .Property(t => t.Id)
                .HasColumnName("id")
                .UseIdentityAlwaysColumn();

            modelBuilder.Entity<Topics>()
                .Property(t => t.Name)
                .HasColumnName("name")
                .HasMaxLength(50)
                .HasColumnType("VARCHAR(50)");

            modelBuilder.Entity<Topics>()
                .Property(t => t.Description)
                .HasColumnName("description")
                .HasMaxLength(250)
                .HasColumnType("VARCHAR(250)");

            modelBuilder.Entity<Topics>()
                .Property(t => t.CreatedAt)
                .HasColumnName("created_at")
                .HasColumnType("DATE");
        }
        public AppDbContext()
        {
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){
      
        }
      
        
    }
}
