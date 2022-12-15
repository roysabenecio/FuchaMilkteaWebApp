using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;
using System.Security.Cryptography.X509Certificates;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class AddPurchaseRecordCommand : IRequest<bool> 
    { 
        public int UserId { get; set; }
        public List<PORecordDTO> PurchaseRec { get; set; }
    }

    public class AddPurchaseRecordCommandHandler : IRequestHandler<AddPurchaseRecordCommand, bool>
    {
        private readonly IFuchaMilkteaContext _context;

        public AddPurchaseRecordCommandHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }

        public Task<bool> Handle(AddPurchaseRecordCommand request, CancellationToken cancellationToken)
        {
            // Create Purchase Record First
            var newPurchaseRecord = new PurchaseRecord 
            {
                ItemQuantity = 0,
                TotalAmount = 0,
                DatePurchased = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"),
                SupplierId = _context.Suppliers.FirstOrDefault(s => s.Name == request.PurchaseRec[0].Supplier).Id,
                UserId = request.UserId,
            };
            _context.PurchaseRecords.Add(newPurchaseRecord);
            _context.SaveChanges();

            // Create Purchase Orders
            var newPurchaseOrders = new List<PORecord>();

            request.PurchaseRec.ForEach(POR => newPurchaseOrders.Add(new PORecord
            {
                StockName = POR.Stock,
                Category = POR.Category,
                Measure = POR.Measure,
                MeasurementUnit = POR.MeasurementUnit,
                DatePurchased = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"),
                Price = POR.Price,
                SupplierId = _context.Suppliers.FirstOrDefault(s => s.Name == POR.Supplier).Id,
                PurchaseRecordId = newPurchaseRecord.Id // Get the new Purchase Record Id
            }));
 
            // Save New Purchase Orders
            _context.PORecords.AddRange(newPurchaseOrders);

            // Get Total for purchase record
            var currentPuchaseRecord = _context.PurchaseRecords.FirstOrDefault(pr => pr.Id == newPurchaseRecord.Id);
            var totalAmount = newPurchaseOrders.Select(pr => pr.Price).Sum();
            currentPuchaseRecord.TotalAmount = totalAmount;

            // Get Item Quantity for purchase record
            currentPuchaseRecord.ItemQuantity = newPurchaseOrders.Count;

            // Add Stock's Measure
            newPurchaseOrders.ForEach(po => _context.Stocks.FirstOrDefault(s => s.Name == po.StockName).Measure += po.Measure);

            // Edit Stock's Last Restocked Date
            newPurchaseOrders.ForEach(po => _context.Stocks.FirstOrDefault(s => s.Name == po.StockName).LastRestocked = DateTime.Now.ToString("dddd, dd MMMM yyyy"));

            // Save an activity
            var selectedUser = _context.Users.FirstOrDefault(u => u.Id == request.UserId);
            var FullName = selectedUser.FirstName + " " + selectedUser.LastName;
            var activity = $"Reordered {currentPuchaseRecord.ItemQuantity} Stock/s from {_context.Suppliers.FirstOrDefault(s => s.Id == currentPuchaseRecord.SupplierId).Name}";

            var newActivity = new ActivityHistory
            {
                User = FullName,
                Activity = activity,
                Date = DateTime.Now.ToString("MM/dd/yyyy HH:mm"),
            };

            _context.ActivityHistories.Add(newActivity);
            _context.SaveChanges();

            object obj = new { activity };

            return Task.FromResult(true);
        }
    }
}
