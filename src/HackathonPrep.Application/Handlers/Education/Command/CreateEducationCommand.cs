using HackathonPrep.Application.Common.Interfaces;
using HackathonPrep.Application.DTOs;
using MediatR;
using EducationModel = HackathonPrep.Domain.Entities.Education;


namespace HackathonPrep.Application.Handlers.Education.Command;

public class CreateEducationCommand : IRequest<EducationDto>, IMapFrom<EducationModel>
{
    public string? UniversityName { get; set; } = null!;//type -> Enum
    public string? Speciality { get; set; } = null!;//type -> Enum
    public string? CurrentGradeLevel { get; set; } = null!;//type -> Enum
    public double GPA { get; set; }

    //public InterestDto User { get; set; }
    public string UserId { get; set; }
}
