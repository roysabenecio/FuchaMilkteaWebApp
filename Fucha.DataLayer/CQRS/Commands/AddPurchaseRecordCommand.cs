using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;
using System.Security.Cryptography.X509Certificates;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class AddPurchaseRecordCommand : IRequest<bool> 
    { 
        public AddPurchaseRecordCommand(int id, List<object> obj)
        {
            UserId = id;
            PORecords = obj;
        }

        public int UserId { get; set; }
        public List<object> PORecords { get; set; }
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
                UserId= request.UserId,
            };
            _context.PurchaseRecords.Add(newPurchaseRecord);
            _context.SaveChanges();

            // Create Purchase Orders
            var newPurchaseOrders = new List<PORecord>();

            request.PORecords.ForEach(POR => newPurchaseOrders.Add(new PORecord
            {

                PurchaseRecordId = newPurchaseRecord.Id // Get the new Purchase Record Id
            }));
 
            // Save New Purchase Orders
            _context.PORecords.AddRange(newPurchaseOrders);

            var currentPuchaseRecord = _context.PurchaseRecords.FirstOrDefault(pr => pr.Id == newPurchaseRecord.Id);
            currentPuchaseRecord.ItemQuantity = newPurchaseOrders.Count;
            var totalAmount = newPurchaseOrders.Select(pr => pr.Price).Sum();
            currentPuchaseRecord.TotalAmount = totalAmount;

            // Add Stock's Measure
            //var POStockMeasure = _context.Stocks.Select(s => s).Where(s => newPurchaseOrders.Select(po => po).Where(po => po.StockName == s.Name).ToList();
            newPurchaseOrders.ForEach(po => _context.Stocks.FirstOrDefault(s => s.Name == po.StockName).Measure += po.Measure);

            // Edit Stock's Last Restocked Date
            newPurchaseOrders.ForEach(po => _context.Stocks.FirstOrDefault(s => s.Name == po.StockName).LastRestocked = DateTime.Now.ToString("dddd, dd MMMM yyyy"));


            // Save an activity
            var selectedUser = _context.Users.FirstOrDefault(u => u.Id == request.UserId);
            var FullName = selectedUser.FirstName + " " + selectedUser.LastName;
            var activity = $"Added a Purchase Record with {currentPuchaseRecord.ItemQuantity} Stock/s";

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
