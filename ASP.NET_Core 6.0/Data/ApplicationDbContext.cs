﻿using ASP.NET_Core_6._0.Models;
using ASP.NET_Core_6._0.Enums;
using ASP.NET_Core_6._0.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ASP.NET_Core_6._0.Data;


public class ApplicationDbContext : IdentityUserContext<ApplicationUser>
{
    public DbSet<Page> Pages => Set<Page>();

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed AspNetUsers table with default admin user
        var hasher = new PasswordHasher<ApplicationUser>();

        var adminEmail = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("SiteSettings")["AdminEmail"];
        var adminPassword = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("SiteSettings")["AdminPassword"];

        modelBuilder.Entity<ApplicationUser>().HasData(
            new ApplicationUser
            {
                Id = "80c8b6b1-e2b6-45e8-b044-8f2178a90111", // primary key
                UserName = "admin",
                NormalizedUserName = adminEmail.ToUpper(),
                PasswordHash = hasher.HashPassword(null, adminPassword),
                Email = adminEmail,
                NormalizedEmail = adminEmail.ToUpper(),
                Role = Role.Admin
            }
        );
    }
}