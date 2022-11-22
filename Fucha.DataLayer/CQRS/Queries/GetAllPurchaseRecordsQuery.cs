using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using Fucha.DomainClasses.Enums;
using MediatR;

namespace Fucha.DataLayer.CQRS.Queries
{
    public class GetAllPurchaseRecordsQuery : IRequest<List<PORecordDTO>>
    {
    }

    public class GetAllPurchaseRecordsQueryHandler : IRequestHandler<GetAllPurchaseRecordsQuery, List<PORecordDTO>>
    {
        private readonly IFuchaMilkteaContext _context;

        public GetAllPurchaseRecordsQueryHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }
        public Task<List<PORecordDTO>> Handle(GetAllPurchaseRecordsQuery request, CancellationToken cancellationToken)
        {
            var allPOR = _context.PORecords.Select(por => por).ToList();
            var allPurchaseRecords = _context.PurchaseRecords.Select(pr => pr).ToList();
            var allStocks = _context.Stocks.Select(s => s).ToList();
            var allSuppliers = _context.Suppliers.Select(s => s).ToList();
            var allMenus = _context.Menus.Select(m => m).ToList();
            var allUsers = _context.Users.Select(u => u).ToList();

            var stocksMenusSupplier = allStocks
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
                        s.SupplierId
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
                        Supplier = s.Name
                    }).ToList();

            var PRUsers = allPurchaseRecords
                .Join(
                    allUsers,
                    pr => pr.UserId,
                    u => u.Id,
                    (pr, u) => new
                    {
                        pr.Id,
                        pr.ItemQuantity,
                        pr.TotalAmount,
                        pr.DatePurchased,
                        User = u.FirstName + " " + u.LastName
                    }).ToList();

            var joinedPORDTO = allPOR
                .Join(
                    stocksMenusSupplier,
                    por => por.StockId,
                    sms => sms.Id,
                    (por, sms) => new
                    {
                        por.Id,
                        sms.Name,
                        sms.Category,
                        sms.Measure,
                        sms.MeasurementUnit,
                        por.Price,
                        por.DatePurchased,
                        por.PurchaseRecordId,
                        sms.Supplier,
                    })
                .Join(
                    PRUsers,
                    por => por.PurchaseRecordId,
                    pru => pru.Id,
                    (por, pru) => new
                    {
                        por.Id,
                        por.Name,
                        por.Category,
                        por.Measure,
                        por.MeasurementUnit,
                        por.Price,
                        por.DatePurchased,
                        por.PurchaseRecordId,
                        por.Supplier,
                        pru.User
                    }).ToList();

            var PORecordsDTO = joinedPORDTO.Select(por => new PORecordDTO
            {
                Id = por.Id,
                Stock = por.Name,
                Category = por.Category.ToString(),
                Measure = por.Measure,
                MeasurementUnit = por.MeasurementUnit.ToString(),
                Price = por.Price,
                DatePurchased = por.DatePurchased,
                Supplier = por.Supplier,
                PurchaseRecordId = por.PurchaseRecordId,
                User = por.User
            }).ToList();

            return Task.FromResult<List<PORecordDTO>>(PORecordsDTO);
        }
    }
}
