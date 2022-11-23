using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.CQRS.Queries
{
    public class GetAllOrdersQuery : IRequest<List<Order>> { }
    public class GetAllOrdersQueryHandler : IRequestHandler<GetAllOrdersQuery, List<Order>>
    {
        private readonly IFuchaMilkteaContext _context;
        public GetAllOrdersQueryHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }

        public Task<List<Order>> Handle(GetAllOrdersQuery request, CancellationToken cancellationToken)
        {
            var allOrders = _context.Orders.Select(o => new Order
            {
                Name = o.Name,
                Category = o.Category,
                Quantity = o.Quantity,
                Price = o.Price,
                AddOn = o.AddOn,
                AddOnPrice = o.AddOnPrice,
                Size = o.Size,
                SaleId = o.SaleId

            }).ToList();
            return Task.FromResult(allOrders);
        }
    }
}
