﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Models.Models;

namespace TeamFury_API.Data
{
    public class AppDbContext : IdentityDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        
        public DbSet<Request> Requests { get; set; }
        public DbSet<RequestLog> RequestLogs { get; set; }
        public DbSet<RequestType> RequestTypes { get; set; }
        public DbSet<LeaveDays> LeaveDays { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            var hasher = new PasswordHasher<IdentityUser>();

            modelBuilder.Entity<User>().HasData(new User()
            {
                Id = new Guid("6cef773a-6124-4182-a8ad-3567cd037ea7").ToString(),
                UserName = "Admin1",
                Email = "trolllovecookies@gmail.com"
            });

            modelBuilder.Entity<IdentityRole>().HasData(new List<IdentityRole>()
            {
                new IdentityRole()
                {
                    Id = "6c9cfbde-730a-4217-93ea-6d8fba1ee541",
                    Name = "admin",
                    NormalizedName = "ADMIN",
                }
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "6c9cfbde-730a-4217-93ea-6d8fba1ee541",
                UserId = "6cef773a-6124-4182-a8ad-3567cd037ea7"
            });
            
        }
    }
}