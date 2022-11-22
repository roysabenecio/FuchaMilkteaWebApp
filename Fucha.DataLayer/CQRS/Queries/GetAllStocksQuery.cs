using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using Fucha.DomainClasses.Enums;
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
            var allPOR = _context.PORecords.Select(por => por).ToList();
            var allPurchaseRecords = _context.PurchaseRecords.Select(pr => pr).ToList();
            var allStocks = _context.Stocks.Select(s => s).ToList();
            var allSuppliers = _context.Suppliers.Select(s => s).ToList();
            var allMenus = _context.Menus.Select(m => m).ToList();
            var allUsers = _context.Users.Select(u => u).ToList();

            var stocksMenusSuppliers = allStocks
                .Join(
                    allMenus,
                    s => s.MenuId,
                    m => m.Id,
                    (s, m) => new
                    {
                        s.Id,
                        m.Name,
                        s.Measure,
                        MeasurementUnit = (MeasurementUnit)s.MeasurementUnit,
                        Category = (StockCategory)s.Category,
                        Status = (QuantityStatus)s.Category,
                        s.DateAdded,
                        s.LastRestocked,
                        s.SupplierId,
                        s.IsRemoved
                    })
                .Join(
                    allSuppliers,
                    sm => sm.SupplierId,
                    s => s.Id,
                    (sm, s) => new
                    {
                        sm.Id,
                        sm.Name,
                        sm.Category,
                        sm.Measure,
                        sm.MeasurementUnit,
                        sm.Status,
                        sm.DateAdded,
                        sm.LastRestocked,
                        Supplier = s.Name,
                        sm.IsRemoved
                    }).ToList();

            var stocksDTO = stocksMenusSuppliers.Select(s => new StockDTO
            {
                Id = s.Id,
                Name = s.Name,
                Measure = s.Measure,
                MeasurementUnit = s.MeasurementUnit.ToString(),
                Category = s.Category.ToString(),
                Supplier = s.Supplier,
                IsRemoved = s.IsRemoved
            }).ToList();

            return Task.FromResult<List<StockDTO>>(stocksDTO);
        }
    }
}
