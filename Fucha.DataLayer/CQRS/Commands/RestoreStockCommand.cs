using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class RestoreStockCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
    }

    public class RestoreStockCommandHandler : IRequestHandler<RestoreStockCommand, bool>
    {
        private readonly IFuchaMilkteaContext _context;
        public RestoreStockCommandHandler(IFuchaMilkteaContext dbContext)
        {
            _context = dbContext;
        }
        public Task<bool> Handle(RestoreStockCommand request, CancellationToken cancellationToken)
        {
            var actor = _context.Users.FirstOrDefault(x => x.Id == request.UserId);

            var selectedStock = _context.Stocks.FirstOrDefault(x => x.Id == request.Id);
            selectedStock.IsRemoved = false;

            // Add activity
            var fullName = actor.FirstName + " " + actor.LastName;
            var activityDescription = $"Restored stock {selectedStock.Name}";
            var newActivity = new ActivityHistory
            {
                User = actor.FirstName + " " + actor.LastName,
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
