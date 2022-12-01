using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using Fucha.DomainClasses.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class EditStockCommand : IRequest<StockDTO>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Measure { get; set; }
        public string MeasurementUnit { get; set; }
        public string StockCategory { get; set; }
        //public string StockStatus { get; set; }
        //dateadded
        //public string Supplier { get; set; }
    }

    public class EditStockCommandHandler : IRequestHandler<EditStockCommand, StockDTO>
    {
        private readonly IFuchaMilkteaContext _context;
        public EditStockCommandHandler(FuchaMilkteaContext context)
        {
            _context = context;
        }

        public Task<StockDTO> Handle(EditStockCommand request, CancellationToken cancellationToken)
        {
            var selectedStock = _context.Stocks.FirstOrDefault(x => x.Id == request.Id);
            selectedStock.Measure = request.Measure;
            selectedStock.MeasurementUnit = (MeasurementUnit)Enum.Parse(typeof(MeasurementUnit), request.MeasurementUnit);
            selectedStock.Category = (StockCategory)Enum.Parse(typeof(StockCategory), request.StockCategory);
            _context.SaveChanges();
            var editedStock = new StockDTO
            {
                Id = selectedStock.Id,
                Measure = (double)selectedStock.Measure,
                MeasurementUnit = selectedStock.MeasurementUnit.ToString(),
                Category = selectedStock.Category.ToString()
            };
            
            return Task.FromResult(editedStock);
        }
    }
}
