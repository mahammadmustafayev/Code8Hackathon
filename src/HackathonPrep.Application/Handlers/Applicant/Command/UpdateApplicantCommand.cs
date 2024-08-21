using HackathonPrep.Application.Common.Interfaces;
using HackathonPrep.Application.DTOs;
using MediatR;
using ApplicantModel = HackathonPrep.Domain.Entities.Applicant;
namespace HackathonPrep.Application.Handlers.Applicant.Command;

public class UpdateApplicantCommand : IRequest<ApplicantDto>, IMapFrom<ApplicantModel>
{
    public int Id { get; set; }
    // public string Name { get; set; } = null!;
    public string Status { get; set; }

    //public AppUser User { get; set; }
    public DateTime? AppointmentDate { get; set; }
    //public string UserId { get; set; }
}
