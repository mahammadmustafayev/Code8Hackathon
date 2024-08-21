using HackathonPrep.Application.Common.Interfaces;
using HackathonPrep.Application.DTOs;
using MediatR;
using InterestModel = HackathonPrep.Domain.Entities.Interest;


namespace HackathonPrep.Application.Handlers.Interest.Command
{
    public class CreateInterestCommand : IRequest<InterestDto>, IMapFrom<InterestModel>
    {
        public string? EnjoyedSubjects { get; set; } //type -> Enum
        public string? Hobbies { get; set; } //type -> Enum
        public string? CareerEnvision { get; set; } //type -> Enum
        public string UserId { get; set; }
    }
}
