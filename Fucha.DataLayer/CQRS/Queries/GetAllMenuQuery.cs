using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;

namespace Fucha.DataLayer.CQRS.Queries
{
    public class GetAllMenuQuery : IRequest<List<Menu>>
    {
    }

    public class GetAllMenuQueryHandler : IRequestHandler<GetAllMenuQuery, List<Menu>>
    {
        private readonly IFuchaMilkteaContext _context;
        public GetAllMenuQueryHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }
        public Task<List<Menu>> Handle(GetAllMenuQuery request, CancellationToken cancellationToken)
        {
            var getAllMenu = _context.Menus.Select(menu => new Menu
            {
                Id = menu.Id,
                Name = menu.Name,
                MenuCategoryId = menu.MenuCategoryId
            }).ToList();

            return Task.FromResult<List<Menu>>(getAllMenu);
        }
    }
}
