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
    public class GetAllMenuPricesQuery : IRequest<List<MenuPrice>>
    {
    }

    public class GetAllMenuPricesQueryHandler : IRequestHandler<GetAllMenuPricesQuery, List<MenuPrice>>
    {
        private readonly IFuchaMilkteaContext _context;

        public GetAllMenuPricesQueryHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }
        public Task<List<MenuPrice>> Handle(GetAllMenuPricesQuery request, CancellationToken cancellationToken)
        {
            var allPrices = _context.MenuPrices.Select(p => new MenuPrice
            {
                Id = p.Id,
                Price = p.Price,
                MenuId = p.MenuId,
                MenuCategoryId = p.MenuCategoryId,
                SizeId = p.SizeId,
            }).ToList();

            return Task.FromResult<List<MenuPrice>>(allPrices);
        }
    }
}
