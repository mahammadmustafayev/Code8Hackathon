using HackathonPrep.Application.DTOs;
using MediatR;

namespace HackathonPrep.Application.Handlers.Student.Queries;

public class GetStudentByIdQuery : IRequest<InterestDto>
{
    public string Id { get; set; }

}
