using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;

namespace Fucha.DataLayer.CQRS.Queries
{
    public class GetAllMenuCategoriesQuery : IRequest<List<MenuCategory>> { }
    public class GetAllMenuCategoriesQueryHandler : IRequestHandler<GetAllMenuCategoriesQuery, List<MenuCategory>>
    {
        private readonly IFuchaMilkteaContext _context;
        public GetAllMenuCategoriesQueryHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }
        public Task<List<MenuCategory>> Handle(GetAllMenuCategoriesQuery request, CancellationToken cancellationToken) 
        {
            var menuCategories = _context.MenuCategories.Select(mc => mc).ToList();
            return Task.FromResult(menuCategories);
        }
    }
}
