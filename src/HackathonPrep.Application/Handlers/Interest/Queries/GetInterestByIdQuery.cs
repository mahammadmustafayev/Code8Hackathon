using HackathonPrep.Application.DTOs;
using MediatR;

namespace HackathonPrep.Application.Handlers.Interest.Queries;

internal class GetInterestByIdQuery : IRequest<InterestDto>
{
    public int Id { get; set; }
}
