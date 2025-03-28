using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TCSA.V2026.Data.Models;

namespace TCSA.V2026.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
{
    public virtual DbSet<ApplicationUser> AspNetUsers { get; set; }
    public virtual DbSet<AppUserActivity> UserActivity { get; set; }
    public virtual DbSet<DashboardProject> DashboardProjects { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<AppUserActivity>()
            .HasOne(aua => aua.DashboardProject)
            .WithMany()
            .HasForeignKey(aua => aua.ProjectId)
            .HasPrincipalKey(dp => dp.ProjectId);

        modelBuilder.Entity<AppUserActivity>()
            .HasOne(aua => aua.ApplicationUser)
            .WithMany(u => u.UserActivity)
            .HasForeignKey(aua => aua.AppUserId);
    }
}