using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using Fucha.DomainClasses.Enums;
using MediatR;

namespace Fucha.DataLayer.CQRS.Queries
{
    public class GetAllPurchaseRecordsQuery : IRequest<List<PurchaseRecord>> {}

    public class GetAllPurchaseRecordsQueryHandler : IRequestHandler<GetAllPurchaseRecordsQuery, List<PurchaseRecord>>
    {
        private readonly IFuchaMilkteaContext _context;

        public GetAllPurchaseRecordsQueryHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }
        public Task<List<PurchaseRecord>> Handle(GetAllPurchaseRecordsQuery request, CancellationToken cancellationToken)
        {
            var allPurchaseRecords = _context.PurchaseRecords.Select(x => x).ToList();
            return Task.FromResult(allPurchaseRecords);
        }
    }
}
