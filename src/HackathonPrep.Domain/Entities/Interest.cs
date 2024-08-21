using HackathonPrep.Domain.Common;
using HackathonPrep.Domain.Identity;

namespace HackathonPrep.Domain.Entities;
public class Interest : BaseAuditable
{
    public string EnjoyedSubjects { get; set; } //type -> Enum
    public string Hobbies { get; set; } //type -> Enum
    public string CareerEnvision { get; set; } //type -> Enum

    public AppUser User { get; set; }
    public string UserId { get; set; }
}