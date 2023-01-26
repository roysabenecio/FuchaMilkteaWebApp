using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using Fucha.DomainClasses.Enums;
using MediatR;

namespace Fucha.DataLayer.CQRS.Queries
{
    public class GetAllPORecordsQuery : IRequest<List<PORecordDisplayDTO>> { }

    public class GetAllPORecordsQueryHandler : IRequestHandler<GetAllPORecordsQuery, List<PORecordDisplayDTO>>
    {
        private readonly IFuchaMilkteaContext _context;

        public GetAllPORecordsQueryHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }
        public Task<List<PORecordDisplayDTO>> Handle(GetAllPORecordsQuery request, CancellationToken cancellationToken)
        {
            var allPORecords = _context.PORecords.Select(por => new PORecordDisplayDTO
            {
                Id = por.Id,
                Stock = por.StockName,
                Category = por.Category,
                Measure = por.Measure,
                MeasurementUnit = por.MeasurementUnit.ToString(),
                Price = por.Price,
                DatePurchased = por.DatePurchased,
                Status = por.Status,
                ReceivedOrders = por.ReceivedOrders,
                Supplier = _context.Suppliers.FirstOrDefault(s => s.Id == por.SupplierId).Name,
                User = _context.Users.FirstOrDefault(u => u.Id == _context.PurchaseRecords.FirstOrDefault(pr => pr.Id == por.PurchaseRecordId).UserId).FirstName + " " +
                    _context.Users.FirstOrDefault(u => u.Id == _context.PurchaseRecords.FirstOrDefault(pr => pr.Id == por.PurchaseRecordId).UserId).LastName
            }).OrderByDescending(x => x.Id).ToList();
            return Task.FromResult(allPORecords);
        }
    }
}
