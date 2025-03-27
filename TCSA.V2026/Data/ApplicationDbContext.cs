using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TCSA.V2026.Data.Models;

namespace TCSA.V2026.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public virtual DbSet<AppUserActivity> UserActivity { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<AppUserActivity>()
            .HasOne(aua => aua.ApplicationUser)       // Specify the navigation property
            .WithMany(u => u.UserActivity)                               // Specify the relationship (e.g., one-to-many or one-to-one)
            .HasForeignKey(aua => aua.AppUserId);   // Map the foreign key

    }
}