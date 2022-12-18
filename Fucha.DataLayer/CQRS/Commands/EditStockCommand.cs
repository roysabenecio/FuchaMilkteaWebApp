using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using Fucha.DomainClasses.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class EditStockCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        //public double Measure { get; set; }
        //public string? MeasurementUnit { get; set; }
        public string? Category { get; set; }
        public double? CriticalLevel { get; set; }
        public double? LowLevel { get; set; }
        public double? OverStockLevel { get; set; }
        public int? StockServingId { get; set; }

        public string? Supplier { get; set; }
        public int UserId { get; set; }
    }

    public class EditStockCommandHandler : IRequestHandler<EditStockCommand, bool>
    {
        private readonly IFuchaMilkteaContext _context;
        public EditStockCommandHandler(FuchaMilkteaContext context)
        {
            _context = context;
        }

        public Task<bool> Handle(EditStockCommand request, CancellationToken cancellationToken)
        {
            var selectedSupplier = _context.Suppliers.FirstOrDefault(s => s.Name == request.Supplier);
            var selectedUser = _context.Users.FirstOrDefault(u => u.Id == request.UserId);
            var selectedStock = _context.Stocks.FirstOrDefault(x => x.Id == request.Id);
            //selectedStock.Measure = request.Measure;
            //selectedStock.MeasurementUnit = (MeasurementUnit)Enum.Parse(typeof(MeasurementUnit), request.MeasurementUnit);
            //selectedStock.Category = (StockCategory)Enum.Parse(typeof(StockCategory), request.Category);
            selectedStock.Name = request.Name;
            selectedStock.LowLevel = request.LowLevel;
            selectedStock.CriticalLevel = request.CriticalLevel;
            selectedStock.OverStockLevel = request.OverStockLevel;
            selectedStock.SupplierId = selectedSupplier.Id;
            //selectedStock.StockServingId = request.StockServingId != null ? request.StockServingId : null;
            //_context.SaveChanges();

            var editedStock = new StockDTO
            {
                Id = selectedStock.Id,
                Measure = (double)selectedStock.Measure,
                MeasurementUnit = selectedStock.MeasurementUnit.ToString(),
                Category = selectedStock.Category.ToString()
            };

            // Reset Gram Sold if milk tea
            var currentStock = selectedStock;
            //if (currentStock.Category == StockCategory.MilkTeaFlavor)
            //{
                var currentGS = _context.MTGramSolds.FirstOrDefault(gs => gs.Name == currentStock.Name);

                // Set Milktea status
                var MTStock = currentStock;
                var RemainingMeasure = MTStock.Measure;
                if (currentGS != null)
                {
                    var GSInKg = currentGS.Grams / 1000; // current gram sold convert to kg because of UOM of the stock
                    RemainingMeasure = (MTStock.Measure - GSInKg);
                }

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
            //}

            // Add activity
            var activityDescription = $"Edited Stock {selectedStock.Name}";
            var newActivity = new ActivityHistory
            {
                User = selectedUser.FirstName + " " + selectedUser.LastName,
                Activity = activityDescription,
                Module = "Inventory",
                Date = DateTime.Now.ToString("MM/dd/yyyy HH:mm")
            };
            _context.ActivityHistories.Add(newActivity);
            _context.SaveChanges();

            return Task.FromResult(true);
        }
    }
}
