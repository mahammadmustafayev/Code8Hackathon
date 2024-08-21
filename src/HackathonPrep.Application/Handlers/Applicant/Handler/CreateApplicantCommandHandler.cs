using AutoMapper;
using HackathonPrep.Application.Common.Interfaces;
using HackathonPrep.Application.DTOs;
using HackathonPrep.Application.Handlers.Applicant.Command;
using MediatR;
using ApplicantModel = HackathonPrep.Domain.Entities.Applicant;


namespace HackathonPrep.Application.Handlers.Applicant.Handler;

public class CreateApplicantCommandHandler : IRequestHandler<CreateApplicantCommand, ApplicantDto>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public CreateApplicantCommandHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<ApplicantDto> Handle(CreateApplicantCommand request, CancellationToken cancellationToken)
    {
        ApplicantModel applicant = _mapper.Map<ApplicantModel>(request);
        var result = await _context.Applicants.AddAsync(applicant);
        await _context.SaveChangesAsync(cancellationToken);
        return _mapper.Map<ApplicantDto>(result);
    }
}
