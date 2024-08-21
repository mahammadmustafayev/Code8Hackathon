using HackathonPrep.Application.Common.Interfaces;
using HackathonPrep.Domain.Entities;
using HackathonPrep.Domain.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HackathonPrep.Infrastructure.Persistence;

public class ApplicationDbContext : IdentityDbContext<AppUser, AppRole, string>, IApplicationDbContext
{

    public DbSet<Applicant> Applicants { get; set; }
    public DbSet<Education> Educations { get; set; }
    public DbSet<Interest> Interests { get; set; }

    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options
       ) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        //builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        builder.Entity<AppUser>().HasOne(x => x.Interest)
                                  .WithOne(x => x.User)
                                  .HasForeignKey<Interest>(y => y.UserId)
                                  .OnDelete(DeleteBehavior.Restrict)
                              .IsRequired(false);
        builder.Entity<AppUser>().HasOne(x => x.Interest)
                                  .WithOne(x => x.User)
                                  .HasForeignKey<Interest>(y => y.UserId)
                                  .OnDelete(DeleteBehavior.Restrict)
                              .IsRequired(false);
        builder.Entity<AppUser>().HasOne(x => x.Education)
              .WithOne(x => x.User)
              .HasForeignKey<Education>(y => y.UserId)
              .OnDelete(DeleteBehavior.Restrict)
                              .IsRequired(false);

        builder.Entity<Applicant>().HasOne(x => x.User)
                   .WithMany(x => x.Applicants)
                   .HasForeignKey(y => y.UserId)
                   .OnDelete(DeleteBehavior.Restrict)
                          .IsRequired(false);
        base.OnModelCreating(builder);
    }

}
