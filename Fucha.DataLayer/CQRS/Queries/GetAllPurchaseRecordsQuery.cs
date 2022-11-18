using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using Fucha.DomainClasses.Enums;
using MediatR;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.CQRS.Queries
{
    public class GetAllPurchaseRecordsQuery : IRequest<List<PurchaseRecordsDTO>>
    {
    }

    public class GetAllPurchaseRecordsQueryHandler : IRequestHandler<GetAllPurchaseRecordsQuery, List<PurchaseRecordsDTO>>
    {
        private readonly IFuchaMilkteaContext _context;

        public GetAllPurchaseRecordsQueryHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }
        public Task<List<PurchaseRecordsDTO>> Handle(GetAllPurchaseRecordsQuery request, CancellationToken cancellationToken)
        {
            var getAllPOR = _context.PORecords.Select(pr => pr).ToList();
            var getAllStocks = _context.Stocks.Select(s => s).ToList();
            var getAllSuppliers = _context.Suppliers.Select(s => s).ToList();

            var PurchaseRecordDTO = getAllStocks
                        .Join(
                            getAllPOR,
                            s => s.Id,
                            pr => pr.StockId,
                            (s, por) => new
                            {
                                por.Id,
                                Item = s.Name,
                                Category = (StockCategory)s.StockCategory,
                                s.Measure,
                                MeasurementUnit = (MeasurementUnit)s.MeasurementUnit,
                                Price = 100,
                                s.SupplierId,
                                por.DatePurchased,
                                por.PurchaseRecordId
                            })
                        .Join(
                        getAllSuppliers,
                        joined => joined.SupplierId,
                        supplier => supplier.Id,
                        (joined, supplier) => new
                        {
                            Id = joined.Id,
                            joined.PurchaseRecordId,
                            joined.Item,
                            joined.Category,
                            joined.Measure,
                            joined.MeasurementUnit,
                            joined.Price,
                            Supplier = supplier.Name,
                            joined.DatePurchased
                        }).ToList();

            var allPurchaseRecords = PurchaseRecordDTO.Select(pr => new PurchaseRecordsDTO
            {
                Id = pr.Id,
                PurchaseRecordId = pr.PurchaseRecordId,
                Item = pr.Item,
                Category = pr.Category.ToString(),
                Measure = pr.Measure,
                MeasurementUnit = pr.MeasurementUnit.ToString(),
                Price = pr.Price,
                Supplier = pr.Supplier,
                DatePurchased = pr.DatePurchased,
            }).ToList();

            return Task.FromResult<List<PurchaseRecordsDTO>>(allPurchaseRecords);
        }
    }
}
