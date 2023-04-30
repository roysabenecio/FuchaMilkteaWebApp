using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using Fucha.DomainClasses.Enums;
using MediatR;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class UpdatePRCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Status { get; set; }
        public int ReceivedOrders { get; set; }
    }

    public class UpdatePRCommandHandler : IRequestHandler<UpdatePRCommand, bool>
    {
        private readonly IFuchaMilkteaContext _context;
        public UpdatePRCommandHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }

        public Task<bool> Handle(UpdatePRCommand request, CancellationToken cancellationToken)
        {
            var selectedPor = _context.PORecords.FirstOrDefault(por => por.Id == request.Id);
            //selectedPor.Status = request.Status;

            // Update Stock's measure
            var currentStock = _context.Stocks.FirstOrDefault(stock => stock.Name == selectedPor.StockName);
            currentStock.Measure -= selectedPor.ReceivedOrders;

            selectedPor.ReceivedOrders = request.ReceivedOrders;

            currentStock.Measure += request.ReceivedOrders;

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

            if (selectedPor.ReceivedOrders == selectedPor.Measure)
            {
                selectedPor.Status = "Received";
            }
            else
            {
                selectedPor.Status = "Not Received";
            }

            // Save an activity
            var selectedUser = _context.Users.FirstOrDefault(u => u.Id == request.UserId);
            var FullName = selectedUser.FirstName + " " + selectedUser.LastName;
            var activity = $"Updated Purchase Record Number {selectedPor.Id}";

            var newActivity = new ActivityHistory
            {
                User = FullName,
                Activity = activity,
                Module = "Reorder",
                Date = DateTime.Now.ToString("MM/dd/yyyy HH:mm"),
            };

            _context.ActivityHistories.Add(newActivity);

            _context.SaveChanges();

            return Task.FromResult(true);
        }
    }
}
