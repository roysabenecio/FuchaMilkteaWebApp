using Fucha.DataLayer.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.CQRS.Queries
{
    public class CalculateStockMeasureQuery : IRequest<double>
    {
        public int Id;
        public long Quantity;
    }

    public class CalculateStockMeasureQueryHandler : IRequestHandler<CalculateStockMeasureQuery, double>
    {
        private readonly IFuchaMilkteaContext _context;
        public CalculateStockMeasureQueryHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }
        public Task<double> Handle(CalculateStockMeasureQuery request, CancellationToken cancellationToken)
        {
            var getRecipe = _context.Recipes.FirstOrDefault(r => r.MenuId == request.Id);
            var getStock = _context.Stocks.FirstOrDefault(s => s.MenuId == request.Id);
            //var joinedStockRecipe = 
            var requiredMeasure = getRecipe.RequiredMeasure * 10.0;
            var calculatedStockMeasure = getStock.Measure - requiredMeasure;
            return Task.FromResult(calculatedStockMeasure);
        }
    }
}
