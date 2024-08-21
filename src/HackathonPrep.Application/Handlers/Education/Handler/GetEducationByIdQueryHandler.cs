using AutoMapper;
using HackathonPrep.Application.Common.Interfaces;
using HackathonPrep.Application.DTOs;
using HackathonPrep.Application.Handlers.Education.Queries;
using MediatR;

namespace HackathonPrep.Application.Handlers.Education.Handler;

public class GetEducationByIdQueryHandler : IRequestHandler<GetEducationByIdquery, EducationDto>
{
    private readonly IApplicationDbContext _applicationDbContext;
    private readonly IMapper _mapper;

    public GetEducationByIdQueryHandler(IApplicationDbContext applicationDbContext, IMapper mapper)
    {
        _applicationDbContext = applicationDbContext;
        _mapper = mapper;
    }

    public async Task<EducationDto> Handle(GetEducationByIdquery request, CancellationToken cancellationToken)
    {
        var education = _applicationDbContext.Educations.FirstOrDefault(i => i.Id == request.Id);

        var educationDto = _mapper.Map<EducationDto>(education);

        return educationDto;
    }
}
