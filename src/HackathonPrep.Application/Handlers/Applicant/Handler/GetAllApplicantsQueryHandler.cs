using AutoMapper;
using HackathonPrep.Application.Common.Interfaces;
using HackathonPrep.Application.DTOs;
using HackathonPrep.Application.Handlers.Applicant.Queries;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace HackathonPrep.Application.Handlers.Applicant.Handler;

public class GetAllApplicantsQueryHandler : IRequestHandler<GetAllApplicantsQuery, List<ApplicantDto>>
{
    private readonly IApplicationDbContext _applicationDbContext;
    private readonly IMapper _mapper;

    public GetAllApplicantsQueryHandler(IApplicationDbContext applicationDbContext, IMapper mapper)
    {
        _applicationDbContext = applicationDbContext;
        _mapper = mapper;
    }

    public async Task<List<ApplicantDto>> Handle(GetAllApplicantsQuery request, CancellationToken cancellationToken)
    {
        var applicants = await _applicationDbContext.Applicants.ToListAsync();
        var applicantDto = new List<ApplicantDto>();
        if (applicants is not null)
        {
            applicantDto = _mapper.Map<List<ApplicantDto>>(applicants);
        }


        return applicantDto;
    }
}
