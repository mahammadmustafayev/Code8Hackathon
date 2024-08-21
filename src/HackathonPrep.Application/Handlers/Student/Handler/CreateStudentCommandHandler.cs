using HackathonPrep.Application.Common.Interfaces;
using HackathonPrep.Application.Handlers.Student.Command;
using HackathonPrep.Domain.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace HackathonPrep.Application.Handlers.Student.Handler;

public class CreateStudentCommandHandler : IRequestHandler<CreateStudentCommand, bool>
{
    private readonly IApplicationDbContext _context;
    private readonly UserManager<AppUser> _userManager;

    public CreateStudentCommandHandler(IApplicationDbContext context, UserManager<AppUser> userManager)
    {
        _context = context;
        _userManager = userManager;
    }

    public async Task<bool> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
    {
        var result = await _userManager.CreateAsync(new AppUser
        {
            DeviceId = request.DeviceId,
            FullName = request.FirstName + " " + request.LastName,
            Email = request.Email,

        }, request.Password
        );
        return result.Succeeded;
    }
}
