using HackathonPrep.Application.Common.Interfaces;
using HackathonPrep.Application.Handlers.Education.Command;
using HackathonPrep.Application.Handlers.Interest.Command;
using HackathonPrep.Application.Handlers.Student.Command;
using MediatR;

namespace HackathonPrep.Application.Handlers.Student.Handler
{
    public class UpdateStudentCommandHandler : IRequestHandler<UpdateStudentCommand, bool>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMediator _mediatr;

        public UpdateStudentCommandHandler(IApplicationDbContext context, IMediator mediatr)
        {
            _context = context;
            _mediatr = mediatr;
        }

        public async Task<bool> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            var interest = _mediatr.Send(new CreateInterestCommand
            {
                CareerEnvision = request.CareerEnvision,
                EnjoyedSubjects = request.EnjoyedSubjects,
                Hobbies = request.Hobbies,
                UserId = request.UserId
            });
            var education = _mediatr.Send(new CreateEducationCommand
            {
                UserId = request.UserId,
                CurrentGradeLevel = request.CurrentGradeLevel,
                GPA = request.GPA,
                Speciality = request.Speciality,
                UniversityName = request.UniversityName
            });
            return true;
        }
    }
}
