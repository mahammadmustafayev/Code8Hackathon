using HackathonPrep.Application.DTOs;
using MediatR;

namespace HackathonPrep.Application.Handlers.Applicant.Queries;

public class GetApplicantByIdQuery : IRequest<ApplicantDto>
{
    public int Id { get; set; }
}
