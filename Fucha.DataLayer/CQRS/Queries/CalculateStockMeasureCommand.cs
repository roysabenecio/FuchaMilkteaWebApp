//using Fucha.DataLayer.Models;
//using MediatR;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Fucha.DataLayer.CQRS.Queries
//{
//    public class CalculateStockMeasureCommand : IRequest<double?>
//    {
//        public int Id { get; set; }
//        public double Quantity { get; set; }
//    }

//    public class CalculateStockMeasureCommandHandler : IRequestHandler<CalculateStockMeasureCommand, double?>
//    {
//        private readonly IFuchaMilkteaContext _context;
//        public CalculateStockMeasureCommandHandler(IFuchaMilkteaContext context)
//        {
//            _context = context;
//        }
//        public Task<double?> Handle(CalculateStockMeasureCommand request, CancellationToken cancellationToken)
//        {
//            var getRecipe = _context.Recipes.FirstOrDefault(r => r.MenuId == request.Id);
//            var getStock = _context.Stocks.FirstOrDefault(s => s.MenuId == request.Id);
//            //var joinedStockRecipe = 
//            var requiredMeasure = getRecipe.RequiredMeasure * request.Quantity;
//            var calculatedStockMeasure = getStock.Measure - requiredMeasure;
//            return Task.FromResult(calculatedStockMeasure);
//        }
//    }
//}
