using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using MediatR;

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
                Name = o.Name,
                Category = o.Category,
                Price = o.Price,
                AddOn = o.AddOn,
                AddOnPrice = o.AddOnPrice,
                Size = o.Size,
                SaleId = o.SaleId,
                Date = _context.SalesTransaction.FirstOrDefault(x => x.Id == o.SaleId).DateSold
            }).ToList();
            return Task.FromResult(allOrders);
        }
    }
}
