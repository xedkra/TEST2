using System;
using Microsoft.EntityFrameworkCore;
using TEST2.Models;

namespace TEST2
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(
                "server=localhost;userid=root;password=Fgtkmcby2308;database=KPB",
                new MySqlServerVersion(new Version(8, 0, 43)) 
            );
        }

        public DbSet<User> Users { get; set; }
        public DbSet<LoginPassword> LoginPasswords { get; set; }
        public DbSet<AccessLevel> AccessLevels { get; set; }
        public DbSet<JobTitle> JobTitles { get; set; }
        public DbSet<Organization> Organizations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(u => u.LoginPassword)
                .WithMany()
                .HasForeignKey(u => u.Login_password_ID);

            modelBuilder.Entity<User>()
                .HasOne(u => u.AccessLevel)
                .WithMany()
                .HasForeignKey(u => u.LvL_ID);
        }
    }
}   