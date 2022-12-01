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
            var allOrders = _context.Orders.Select(o => o).ToList();
            return Task.FromResult(allOrders);
        }
    }
}
