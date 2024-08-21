using AutoMapper;
using HackathonPrep.Application.Common.Interfaces;
using HackathonPrep.Application.DTOs;
using HackathonPrep.Application.Handlers.Education.Command;
using MediatR;
using EducationModel = HackathonPrep.Domain.Entities.Education;


namespace HackathonPrep.Application.Handlers.Education.Handler;

public class CreateEducationCommandHandler : IRequestHandler<CreateEducationCommand, EducationDto>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public CreateEducationCommandHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<EducationDto> Handle(CreateEducationCommand request, CancellationToken cancellationToken)
    {
        EducationModel education = _mapper.Map<EducationModel>(request);
        var result = await _context.Educations.AddAsync(education);
        await _context.SaveChangesAsync(cancellationToken);
        return _mapper.Map<EducationDto>(result);
    }
}
