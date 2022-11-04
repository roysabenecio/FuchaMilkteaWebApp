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
    public class GetAllMenusQuery : IRequest<List<Menu>>
    {
    }

    public class GetAllMenusQueryHandler : IRequestHandler<GetAllMenusQuery, List<Menu>>
    {
        private readonly IFuchaMilkteaContext _dbContext;
        public GetAllMenusQueryHandler(IFuchaMilkteaContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<List<Menu>> Handle(GetAllMenusQuery request, CancellationToken cancellationToken)
        {
            var allMenus = _dbContext.Menus.Select(menu => new Menu
            {
                Id = menu.Id,
                Name = menu.Name,
                MenuCategory = menu.MenuCategory,
                //Specification = menu.Specification,
                //Size = menu.Size,
                //Price = menu.Price,
            }).ToList();

            return Task.FromResult<List<Menu>>(allMenus);
        }
    }
}
