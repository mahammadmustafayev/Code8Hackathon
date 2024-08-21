using HackathonPrep.Application.Common.Interfaces;
using HackathonPrep.Application.DTOs;
using HackathonPrep.Domain.Identity;
using MediatR;
using ApplicantModel = HackathonPrep.Domain.Entities.Applicant;

namespace HackathonPrep.Application.Handlers.Applicant.Command;

public class CreateApplicantCommand : IRequest<ApplicantDto>, IMapFrom<ApplicantModel>
{
    //public string Name { get; set; } = null!;
    public string Status { get; set; } = "Analizing";

    public AppUser User { get; set; }
    public DateTime? AppointmentDate { get; set; }
    //public string UserId { get; set; }
}
