using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class RemoveStockCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }

    public class RemoveStockCommandHandler: IRequestHandler<RemoveStockCommand, bool>
    {
        private readonly IFuchaMilkteaContext _context;
        public RemoveStockCommandHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }

        public Task<bool> Handle(RemoveStockCommand request, CancellationToken cancellationToken)
        {
            var selectedStock = _context.Stocks.FirstOrDefault(x => x.Id == request.Id);

            //var stockDTO = new StockDTO
            //{
            //    Id = selectedStock.Id,
            //    Name = selectedStock.Name,
            //    Measure = selectedStock.Measure,
            //    MeasurementUnit = selectedStock.MeasurementUnit.ToString(),
            //    StockCategory = selectedStock.StockCategory.ToString()

            //};

            _context.Stocks.Remove(selectedStock);
            _context.SaveChanges();

            return Task.FromResult(true);
        }
    }
}
