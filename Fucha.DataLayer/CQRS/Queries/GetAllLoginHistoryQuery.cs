using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;

namespace Fucha.DataLayer.CQRS.Queries
{
    public class GetAllLoginHistoryQuery : IRequest<List<LoginHistory>> { }
    public class GetAllLoginHistoryQueryHandler : IRequestHandler<GetAllLoginHistoryQuery, List<LoginHistory>>
    {
        private readonly IFuchaMilkteaContext _context;
        public GetAllLoginHistoryQueryHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }
        public Task<List<LoginHistory>> Handle(GetAllLoginHistoryQuery request, CancellationToken cancellationToken)
        {
            var allLoginHistory = _context.LoginHistories.Select(x => x).OrderByDescending(x => x.Id).ToList();
            return Task.FromResult(allLoginHistory);
        }
    }
}
