using MediatR;
using Domain;
using Persistance;
using Microsoft.EntityFrameworkCore;
using Application.core;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace Application.Activitites
{
    public class List
    {
        public class Query : IRequest<Result<List<ActivityDto>>> {}

        public class Handler : IRequestHandler<Query, Result<List<ActivityDto>>>
        {
            private readonly DataContext _context;
        private readonly IMapper _mapper;

            public Handler(DataContext context, IMapper mapper)
            {
            _mapper = mapper;
                _context = context;
            }

            public async Task<Result<List<ActivityDto>>> Handle(Query request, CancellationToken cancellationToken)
            {
                return Result<List<ActivityDto>>.Success(await _context.Activities.ProjectTo<ActivityDto>(_mapper.ConfigurationProvider).ToListAsync());
            }
        }
    }
}