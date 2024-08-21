using HackathonPrep.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace HackathonPrep.Domain.Identity;
public class AppUser : IdentityUser
{
    public string? FullName { get; set; }
    public DateTime? BirthDate { get; set; }
    public bool? Gender { get; set; }

    public string? DeviceId { get; set; }

    public Education? Education { get; set; }
    public Interest? Interest { get; set; }
    public ICollection<Applicant>? Applicants { get; set; }
}