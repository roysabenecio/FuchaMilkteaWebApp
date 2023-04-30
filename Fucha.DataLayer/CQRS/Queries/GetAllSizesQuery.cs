using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;

namespace Fucha.DataLayer.CQRS.Queries
{
    public class GetAllSizesQuery : IRequest<List<Size>>
    {
    }

    public class GetAllSizesQueryHandler : IRequestHandler<GetAllSizesQuery, List<Size>>
    {
        private readonly IFuchaMilkteaContext _context;

        public GetAllSizesQueryHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }
        public Task<List<Size>> Handle(GetAllSizesQuery request, CancellationToken cancellationToken)
        {
            var allSizes = _context.Sizes.Select(size => new Size
            {
                Id = size.Id,
                Name = size.Name,
                //Label = size.Label,
                //MenuCategoryId = size.MenuCategoryId
            }).ToList();

            return Task.FromResult<List<Size>>(allSizes);
        }
    }
}
