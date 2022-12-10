using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using MediatR;

namespace Fucha.DataLayer.CQRS.Queries
{
    public class GetAllGramSoldQuery : IRequest<List<MTGramSoldDTO>> { }

    public class GetAllGramSoldQueryHandler : IRequestHandler<GetAllGramSoldQuery, List<MTGramSoldDTO>>
    {
        private readonly IFuchaMilkteaContext _context;
        public GetAllGramSoldQueryHandler(IFuchaMilkteaContext context) 
        {
            _context = context;
        }

        public Task<List<MTGramSoldDTO>> Handle(GetAllGramSoldQuery request, CancellationToken cancellationToken)
        {
            var allGramSold = _context.MTGramSolds.Select(x => new MTGramSoldDTO
            {
                Id = x.Id,
                Name = x.Name,
                Grams = x.Grams,
                ResetDate = x.ResetDate,
            }).ToList();

            return Task.FromResult(allGramSold);
        }
    }
}
