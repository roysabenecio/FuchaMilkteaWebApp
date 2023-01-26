using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;

namespace Fucha.DataLayer.CQRS.Queries
{
    public class GetAllSaleTransactionsQuery : IRequest<List<SaleTransactionDTO>>
    {
    }
    public class GetAllSaleTransactionsQueryHandler : IRequestHandler<GetAllSaleTransactionsQuery, List<SaleTransactionDTO>>
    {
        private readonly IFuchaMilkteaContext _context;
        public GetAllSaleTransactionsQueryHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }
        public Task<List<SaleTransactionDTO>> Handle(GetAllSaleTransactionsQuery request, CancellationToken cancellationToken)
        {
            var allSaleTransactions = _context.SalesTransaction.Select(st => new SaleTransactionDTO
            {
                Id = st.Id,
                ItemQuantity = st.ItemQuantity,
                TotalSales = st.TotalSales,
                DateSold = st.DateSold,
                User = _context.Users.FirstOrDefault(x => x.Id == st.UserId).FirstName + " " + _context.Users.FirstOrDefault(x => x.Id == st.UserId).LastName
            }).OrderByDescending(x => x.Id).ToList();
            return Task.FromResult(allSaleTransactions);
        }
    }
}
