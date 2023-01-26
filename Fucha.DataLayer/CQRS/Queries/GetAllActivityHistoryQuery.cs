using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;

namespace Fucha.DataLayer.CQRS.Queries
{
    public class GetAllActivityHistoryQuery : IRequest<List<ActivityHistory>> { }
    public class GetAllActivityHistoryQueryHandler : IRequestHandler<GetAllActivityHistoryQuery, List<ActivityHistory>>
    {
        private readonly IFuchaMilkteaContext _context;

        public GetAllActivityHistoryQueryHandler (IFuchaMilkteaContext context)
        {
            _context = context;
        }

        public Task<List<ActivityHistory>> Handle(GetAllActivityHistoryQuery request, CancellationToken cancellationToken)
        {
            var allActivityHistory = _context.ActivityHistories.Select(x => x).OrderByDescending(x => x.Id).ToList();

            return Task.FromResult(allActivityHistory);
        }
    }

}
