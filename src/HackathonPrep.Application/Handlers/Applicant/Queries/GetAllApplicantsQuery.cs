using HackathonPrep.Application.DTOs;
using MediatR;

namespace HackathonPrep.Application.Handlers.Applicant.Queries;

public class GetAllApplicantsQuery : IRequest<List<ApplicantDto>>
{

}
