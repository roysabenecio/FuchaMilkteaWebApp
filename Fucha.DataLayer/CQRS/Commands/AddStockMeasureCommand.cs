using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using Fucha.DomainClasses.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class AddStockMeasureCommand : IRequest<bool> 
    {
        public int UserId { get; set; }

        public int StockId { get; set; }
        public double Measure { get; set; }
    }
    public class AddStockMeasureCommandHandler : IRequestHandler<AddStockMeasureCommand, bool> 
    {
        private readonly IFuchaMilkteaContext _context;
        public AddStockMeasureCommandHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }

        public Task<bool> Handle(AddStockMeasureCommand request, CancellationToken cancellationToken)
        {
            var currentUser = _context.Users.FirstOrDefault(u => u.Id == request.UserId);
            var currentStock = _context.Stocks.FirstOrDefault(x => x.Id == request.StockId);
            currentStock.Measure += request.Measure;

            // Edit Stock's Last Restocked Date
            currentStock.LastRestocked = DateTime.Now.ToString("dddd, dd MMMM yyyy");

            var activityDescription = $"Added {request.Measure} {(MeasurementUnit)currentStock.MeasurementUnit} of {currentStock.Name}" ;

            // add activity on activity history
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
    }
}
