using AutoMapper;
using HackathonPrep.Application.Common.Interfaces;
using HackathonPrep.Application.DTOs;
using HackathonPrep.Application.Handlers.Interest.Queries;
using MediatR;

namespace HackathonPrep.Application.Handlers.Interest.Handler
{
    public class GetInterestByIdQueryHandler : IRequestHandler<GetInterestByIdQuery, InterestDto>
    {
        private readonly IApplicationDbContext _applicationDbContext;
        private readonly IMapper _mapper;

        public GetInterestByIdQueryHandler(IApplicationDbContext applicationDbContext, IMapper mapper)
        {
            _applicationDbContext = applicationDbContext;
            _mapper = mapper;
        }

        async Task<InterestDto> IRequestHandler<GetInterestByIdQuery, InterestDto>.Handle(GetInterestByIdQuery request, CancellationToken cancellationToken)
        {
            var interest = _applicationDbContext.Interests.FirstOrDefault(i => i.Id == request.Id);

            var interestDto = _mapper.Map<InterestDto>(interest);

            return interestDto;
        }

        //public async Task<InterestDto> Handle(GetInterestByIdQuery request, CancellationToken cancellationToken)
        //{
        //    var interest = _applicationDbContext.Interests.FirstOrDefault(i => i.UserId == request.Id);

        //    var interestDto = await _mapper.Map<InterestDto>(interest);

        //    return interestDto;
        //}
    }
}
