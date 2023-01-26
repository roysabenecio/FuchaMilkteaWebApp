using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using MediatR;
using System.Security.Cryptography.X509Certificates;

namespace Fucha.DataLayer.CQRS.Queries
{
    public class GetAllOrdersQuery : IRequest<List<OrderReportDTO>> { }
    public class GetAllOrdersQueryHandler : IRequestHandler<GetAllOrdersQuery, List<OrderReportDTO>>
    {
        private readonly IFuchaMilkteaContext _context;
        public GetAllOrdersQueryHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }

        public Task<List<OrderReportDTO>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
        {
            var allOrders = _context.Orders.Select(o => new OrderReportDTO
            {
                Id = o.Id,
                Name = o.Name,
                Category = o.Category,
                Quantity = o.Quantity,
                Price = o.Price,
                AddOn = o.AddOn,
                AddOnPrice = o.AddOnPrice,
                Size = o.Size,
                SaleId = o.SaleId,
                Date = _context.SalesTransaction.FirstOrDefault(x => x.Id == o.SaleId).DateSold,
                Cashier = _context.Users.FirstOrDefault(x => x.Id == _context.SalesTransaction.FirstOrDefault(st => st.Id == o.SaleId).UserId).FirstName + " " +
                            _context.Users.FirstOrDefault(x => x.Id == _context.SalesTransaction.FirstOrDefault(st => st.Id == o.SaleId).UserId).LastName

            }).OrderByDescending(x => x.Id).ToList();
            return Task.FromResult(allOrders);
        }
    }
}
