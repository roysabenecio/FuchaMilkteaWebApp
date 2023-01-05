using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using Fucha.DomainClasses.Enums;
using MediatR;

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
                DatePurchased = DateTime.Now.ToString("dddd, dd MMMM yyyy"),
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
                Status = "Not Received",
                ReceivedOrders = POR.ReceivedOrders,
                DatePurchased = DateTime.Now.ToString("dddd, dd MMMM yyyy"),
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
            //newPurchaseOrders.ForEach(po => _context.Stocks.FirstOrDefault(s => s.Name == po.StockName).Measure += po.Measure);


            newPurchaseOrders.ForEach(po =>
            {
                var currentStock = _context.Stocks.FirstOrDefault(s => s.Name == po.StockName && s.SupplierId == po.SupplierId);

                // Edit Gram Sold if milk tea
                if (currentStock.Category == StockCategory.MilkTeaFlavor)
                {
                    var currentGS = _context.MTGramSolds.FirstOrDefault(gs => gs.Name == currentStock.Name);

                    // Set Milktea status
                    var GSInKg = currentGS.Grams / 1000; // current gram sold convert to kg because of UOM of the stock
                    var MTStock = currentStock;
                    var RemainingMeasure = (MTStock.Measure - GSInKg);

                    var isLow = RemainingMeasure > MTStock.CriticalLevel && RemainingMeasure <= MTStock.LowLevel;
                    var isCritical = RemainingMeasure > 0 && RemainingMeasure <= MTStock.CriticalLevel;
                    var overStock = MTStock.Measure > MTStock.Ceiling;
                    var outOfStock = RemainingMeasure <= 0;

                    if (isLow)
                    {
                        MTStock.Status = QuantityStatus.Low;
                    }
                    if (isCritical)
                    {
                        MTStock.Status = QuantityStatus.Critical;
                    }
                    if (outOfStock)
                    {
                        MTStock.Status = QuantityStatus.OutOfStock;
                    }
                    if (overStock)
                    {
                        MTStock.Status = QuantityStatus.OverStock;
                    }
                    if (!outOfStock && !isLow && !isCritical && !overStock)
                    {
                        MTStock.Status = QuantityStatus.Sufficient;
                    }
                    _context.SaveChanges();
                }

                // Edit stock status if not milk tea
                if (currentStock.Category != StockCategory.MilkTeaFlavor)
                {
                    var isLow = currentStock.Measure > currentStock.CriticalLevel && currentStock.Measure <= currentStock.LowLevel;
                    var isCritical = currentStock.Measure > 0 && currentStock.Measure <= currentStock.CriticalLevel;
                    var overStock = currentStock.Measure > currentStock.Ceiling;
                    var outOfStock = currentStock.Measure <= 0;

                    if (isLow)
                    {
                        currentStock.Status = QuantityStatus.Low;
                    }
                    if (isCritical)
                    {
                        currentStock.Status = QuantityStatus.Critical;
                    }
                    if (outOfStock)
                    {
                        currentStock.Status = QuantityStatus.OutOfStock;
                    }
                    if (overStock)
                    {
                        currentStock.Status = QuantityStatus.OverStock;
                    }
                    if (!outOfStock && !isLow && !isCritical && !overStock)
                    {
                        currentStock.Status = QuantityStatus.Sufficient;
                    }
                    _context.SaveChanges();
                }
            });

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
                Module = "Reorder",
                Date = DateTime.Now.ToString("MM/dd/yyyy HH:mm"),
            };

            _context.ActivityHistories.Add(newActivity);
            _context.SaveChanges();

            object obj = new { activity };

            return Task.FromResult(true);
        }
    }
}
