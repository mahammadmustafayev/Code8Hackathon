using HackathonPrep.Application.DTOs;
using MediatR;

namespace HackathonPrep.Application.Handlers.Education.Queries;

public class GetEducationByIdquery : IRequest<EducationDto>
{
    public int Id { get; set; }
}
