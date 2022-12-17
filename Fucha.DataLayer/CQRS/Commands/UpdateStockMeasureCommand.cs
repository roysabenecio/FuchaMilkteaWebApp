using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using Fucha.DomainClasses.Enums;
using MediatR;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class UpdateStockMeasureCommand : IRequest<bool> 
    {
        public int UserId { get; set; }
        public string? StockName{ get; set; }
        public double Measure { get; set; }
    }
    public class UpdateStockMeasureCommandHandler : IRequestHandler<UpdateStockMeasureCommand, bool> 
    {
        private readonly IFuchaMilkteaContext _context;
        public UpdateStockMeasureCommandHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }

        public Task<bool> Handle(UpdateStockMeasureCommand request, CancellationToken cancellationToken)
        {
            var currentUser = _context.Users.FirstOrDefault(u => u.Id == request.UserId);
            var currentStock = _context.Stocks.FirstOrDefault(x => x.Name == request.StockName);
            var computedMeasure = request.Measure - currentStock.Measure;

            if (computedMeasure > 0)
            {
                // Add Stock Quantity
                currentStock.Measure += computedMeasure;

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
                    var overStock = MTStock.Measure >= MTStock.OverStockLevel;
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
                    var overStock = currentStock.Measure >= currentStock.OverStockLevel;
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

                // Edit Stock's Last Restocked Date
                currentStock.LastRestocked = DateTime.Now.ToString("dddd, dd MMMM yyyy");

                // add activity on activity history
                var activityDescription = $"Added {computedMeasure} {(MeasurementUnit)currentStock.MeasurementUnit} of {currentStock.Name}";
                var newActivity = new ActivityHistory
                {
                    User = currentUser.FirstName + " " + currentUser.LastName,
                    Activity = activityDescription,
                    Date = DateTime.Now.ToString("MM/dd/yyyy HH:mm"),
                };
                _context.ActivityHistories.Add(newActivity);
                _context.SaveChanges();
                return Task.FromResult(true);

            }
            if (computedMeasure < 0)
            {
                // Deduct Stock Quantity
                currentStock.Measure += computedMeasure;

                // Reset Gram Sold if milk tea
                if (currentStock.Category == StockCategory.MilkTeaFlavor)
                {
                    var currentGS = _context.MTGramSolds.FirstOrDefault(gs => gs.Name == currentStock.Name);
                    // Update grams sold info
                    currentGS.PreviousMeasure = currentGS.Grams;
                    currentGS.ResetDate = DateTime.Now.ToString("MM/dd/yyyy HH:mm");
                    currentGS.Grams = 0;

                    // Set Milktea status
                    var GSInKg = currentGS.Grams / 1000; // current gram sold convert to kg because of UOM of the stock
                    var MTStock = currentStock;
                    var RemainingMeasure = (MTStock.Measure - GSInKg);

                    var isLow = RemainingMeasure > MTStock.CriticalLevel && RemainingMeasure <= MTStock.LowLevel;
                    var isCritical = RemainingMeasure > 0 && RemainingMeasure <= MTStock.CriticalLevel;
                    var overStock = MTStock.Measure >= MTStock.OverStockLevel;
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

                if (currentStock.Category != StockCategory.MilkTeaFlavor)
                {
                    var isLow = currentStock.Measure > currentStock.CriticalLevel && currentStock.Measure <= currentStock.LowLevel;
                    var isCritical = currentStock.Measure > 0 && currentStock.Measure <= currentStock.CriticalLevel;
                    var overStock = currentStock.Measure >= currentStock.OverStockLevel;
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

                // add activity on activity history
                var activityDescription = $"Deducted {computedMeasure * -1} {(MeasurementUnit)currentStock.MeasurementUnit} of {currentStock.Name}";
                var newActivity = new ActivityHistory
                {
                    User = currentUser.FirstName + " " + currentUser.LastName,
                    Activity = activityDescription,
                    Date = DateTime.Now.ToString("MM/dd/yyyy HH:mm"),
                };
                _context.ActivityHistories.Add(newActivity);
                _context.SaveChanges();
                return Task.FromResult(true);

            }
            if (currentStock.Measure - request.Measure == 0)
            {
                return Task.FromResult(false);
            }

            return Task.FromResult(true);
        }
    }
}
