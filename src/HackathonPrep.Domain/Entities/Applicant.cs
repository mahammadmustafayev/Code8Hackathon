using HackathonPrep.Domain.Common;
using HackathonPrep.Domain.Identity;

namespace HackathonPrep.Domain.Entities;
public class Applicant : BaseAuditable
{
    //public string Name { get; set; } = null!;
    public string Status { get; set; }

    public AppUser User { get; set; }
    public string UserId { get; set; }
    public DateTime? AppointmentDate { get; set; }
}