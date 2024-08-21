using AutoMapper;
using HackathonPrep.Application.Common.Interfaces;
using HackathonPrep.Application.DTOs;
using HackathonPrep.Application.Handlers.Interest.Command;
using MediatR;
using InterestModel = HackathonPrep.Domain.Entities.Interest;

namespace HackathonPrep.Application.Handlers.Interest.Handler
{
    public class CreateInterestCommandHander : IRequestHandler<CreateInterestCommand, InterestDto>, IMapFrom<InterestModel>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public CreateInterestCommandHander(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<InterestDto> Handle(CreateInterestCommand request, CancellationToken cancellationToken)
        {
            InterestModel interest = _mapper.Map<InterestModel>(request);
            var result = await _context.Interests.AddAsync(interest);
            await _context.SaveChangesAsync(cancellationToken);
            return _mapper.Map<InterestDto>(result);
        }
    }
}
