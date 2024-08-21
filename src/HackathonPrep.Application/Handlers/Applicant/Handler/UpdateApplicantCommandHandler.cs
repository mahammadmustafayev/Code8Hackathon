using AutoMapper;
using HackathonPrep.Application.Common.Interfaces;
using HackathonPrep.Application.DTOs;
using HackathonPrep.Application.Handlers.Applicant.Command;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HackathonPrep.Application.Handlers.Applicant.Handler;

public class UpdateApplicantCommandHandler : IRequestHandler<UpdateApplicantCommand, ApplicantDto>
{
    private readonly IApplicationDbContext _context;
    private readonly IMapper _mapper;

    public UpdateApplicantCommandHandler(IApplicationDbContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<ApplicantDto> Handle(UpdateApplicantCommand request, CancellationToken cancellationToken)
    {
        var applicant = await _context.Applicants.FirstOrDefaultAsync(x => x.Id == request.Id);
        applicant.Status = request.Status;
        applicant.AppointmentDate = request.AppointmentDate;
        await _context.SaveChangesAsync(cancellationToken);
        return _mapper.Map<ApplicantDto>(applicant);
    }
}
