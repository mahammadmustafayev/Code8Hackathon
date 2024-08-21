using HackathonPrep.Application.Common.Interfaces;
using MediatR;
using EducationModel = HackathonPrep.Domain.Entities.Education;
using InterestModel = HackathonPrep.Domain.Entities.Interest;


namespace HackathonPrep.Application.Handlers.Student.Command
{
    public class UpdateStudentCommand : IRequest<bool>, IMapFrom<EducationModel>, IMapFrom<InterestModel>
    {
        //interest datas
        public string? EnjoyedSubjects { get; set; } //type -> Enum
        public string? Hobbies { get; set; } //type -> Enum
        public string? CareerEnvision { get; set; } //type -> Enum
        //public int UserId { get; set; }

        //Education datas
        public string? UniversityName { get; set; } = null!;//type -> Enum
        public string? Speciality { get; set; } = null!;//type -> Enum
        public string? CurrentGradeLevel { get; set; } = null!;//type -> Enum
        public double GPA { get; set; }
        public string UserId { get; set; }
    }
}
