using AutoMapper;
using HackathonPrep.Application.Common.Interfaces;
using HackathonPrep.Application.DTOs;
using HackathonPrep.Application.Handlers.Student.Queries;
using HackathonPrep.Domain.Identity;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HackathonPrep.Application.Handlers.Student.Handler;

public class GetStudentByIdQueryHandler : IRequestHandler<GetStudentByIdQuery, InterestDto>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;
    private readonly UserManager<AppUser> _userManager;

    public GetStudentByIdQueryHandler(IApplicationDbContext context, IMapper mapper, UserManager<AppUser> userManager)
    {
        _context = context;
        _mapper = mapper;
        _userManager = userManager;
    }

    public async Task<InterestDto> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
    {
        var student = await _userManager.Users.FirstOrDefaultAsync(x => x.Id == request.Id);
        return _mapper.Map<InterestDto>(student);
    }
}
