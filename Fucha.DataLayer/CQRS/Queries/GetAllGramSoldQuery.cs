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
                GramsSold = x.Grams,
                ResetDate = x.ResetDate,
                PreviousMeasure = x.PreviousMeasure,
                Status = _context.Stocks.FirstOrDefault(s => s.Name == x.Name).Status.ToString()
            }).ToList();

            return Task.FromResult(allGramSold);
        }
    }
}
