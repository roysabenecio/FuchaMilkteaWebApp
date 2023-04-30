using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;

namespace Fucha.DataLayer.CQRS.Queries
{
    public class GetAllAddOnsQuery : IRequest<List<AddOn>>
    {

    }

    public class GetAllAddOnsQueryHandler : IRequestHandler<GetAllAddOnsQuery, List<AddOn>>
    {
        private readonly IFuchaMilkteaContext _context;

        public GetAllAddOnsQueryHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }

        public Task<List<AddOn>> Handle(GetAllAddOnsQuery request, CancellationToken cancellationToken)
        {
            var allAddOns = _context.AddOns.Select(a => new AddOn
            {
                Id = a.Id,
                Name = a.Name,
                AddOnPrice = a.AddOnPrice
            }).ToList();

            return Task.FromResult<List<AddOn>>(allAddOns);
        }
    }
}
