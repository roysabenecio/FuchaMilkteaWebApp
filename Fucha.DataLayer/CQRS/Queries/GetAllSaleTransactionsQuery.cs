using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;

namespace Fucha.DataLayer.CQRS.Queries
{
    public class GetAllSaleTransactionsQuery : IRequest<List<SaleTransaction>>
    {
    }
    public class GetAllSaleTransactionsQueryHandler : IRequestHandler<GetAllSaleTransactionsQuery, List<SaleTransaction>>
    {
        private readonly IFuchaMilkteaContext _context;
        public GetAllSaleTransactionsQueryHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }
        public Task<List<SaleTransaction>> Handle(GetAllSaleTransactionsQuery request, CancellationToken cancellationToken)
        {
            var allSaleTransactions = _context.SalesTransaction.Select(st => st).ToList();
            return Task.FromResult(allSaleTransactions);
        }
    }
}
