using HackathonPrep.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace HackathonPrep.Application.Common.Interfaces;

public interface IApplicationDbContext
{
    DbSet<Applicant> Applicants { get; set; }
    DbSet<Education> Educations { get; set; }
    DbSet<Interest> Interests { get; set; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}
