using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using MediatR;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class SearchStockCommand : IRequest<List<StockDTO>>
    {
        public string? Category { get; set; }
        public string? Characters { get; set; }
    }

    public class SearchStockCommandHandler : IRequestHandler<SearchStockCommand, List<StockDTO>>
    {
        private readonly IFuchaMilkteaContext _context;
        public SearchStockCommandHandler(IFuchaMilkteaContext context) 
        { 
            _context = context;
        }

        Task<List<StockDTO>> IRequestHandler<SearchStockCommand, List<StockDTO>>.Handle(SearchStockCommand request, CancellationToken cancellationToken)
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
                //DateAdded = s.DateAdded,
                LastRestocked = s.LastRestocked,
                IsRemoved = s.IsRemoved
            })
                .Where(x => request.Characters.Contains(x.Name))
                .ToList();

            return Task.FromResult(stocksDTO);

        }
    }
}
