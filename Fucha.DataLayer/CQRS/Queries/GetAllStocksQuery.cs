using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;

namespace Fucha.DataLayer.CQRS.Queries
{
    public class GetAllStocksQuery : IRequest<List<StockDTO>>
    {
    }

    public class GetAllStocksQueryHandler : IRequestHandler<GetAllStocksQuery, List<StockDTO>>
    {
        private readonly IFuchaMilkteaContext _context;
        public GetAllStocksQueryHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }

        public Task<List<StockDTO>> Handle(GetAllStocksQuery request, CancellationToken cancellationToken)
        {
            var allStocks = _context.Stocks.Select(s => s).ToList();
            var allSuppliers = _context.Suppliers.Select(s => s).ToList();

            var stocksSuppliers = allStocks
                .Join(
                    allSuppliers,
                    stock => stock.SupplierId,
                    supp => supp.Id,
                    (stock, supp) => new
                    {
                        stock.Id,
                        stock.Name,
                        stock.Measure,
                        stock.MeasurementUnit,
                        stock.Category,
                        stock.Status,
                        stock.CriticalLevel,
                        stock.LowLevel,
                        stock.OverStockLevel,
                        //stock.DateAdded,
                        stock.LastRestocked,
                        Supplier = supp.Name,
                        stock.IsRemoved
                    }
                );

            var stocksDTO = stocksSuppliers.Select(s => new StockDTO
            {
                Id = s.Id,
                Name = s.Name,
                Measure = (double)s.Measure,
                MeasurementUnit = s.MeasurementUnit.ToString(),
                Category = s.Category.ToString(),
                Status = s.Status.ToString(),
                Supplier = s.Supplier,
                CriticalLevel = s.CriticalLevel,
                LowLevel = s.LowLevel,
                OverStockLevel = s.OverStockLevel,
                //DateAdded = s.DateAdded,
                LastRestocked = s.LastRestocked,
                IsRemoved = s.IsRemoved
            }).ToList(); 

            return Task.FromResult<List<StockDTO>>(stocksDTO);
        }
    }
}
