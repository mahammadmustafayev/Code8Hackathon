using AutoMapper;
using HackathonPrep.Application.Common.Interfaces;
using HackathonPrep.Application.DTOs;
using HackathonPrep.Application.Handlers.Applicant.Queries;
using MediatR;

namespace HackathonPrep.Application.Handlers.Applicant.Handler;

public class GetApplicantByIdQueryHandler : IRequestHandler<GetApplicantByIdQuery, ApplicantDto>
{
    private readonly IApplicationDbContext _applicationDbContext;
    private readonly IMapper _mapper;

    public GetApplicantByIdQueryHandler(IApplicationDbContext applicationDbContext, IMapper mapper)
    {
        _applicationDbContext = applicationDbContext;
        _mapper = mapper;
    }

    public async Task<ApplicantDto> Handle(GetApplicantByIdQuery request, CancellationToken cancellationToken)
    {
        var applicant = _applicationDbContext.Applicants.FirstOrDefault(i => i.Id == request.Id);

        var applicantDto = _mapper.Map<ApplicantDto>(applicant);

        return applicantDto;
    }
}
