using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class RemoveStockCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public int UserId { get; set; }
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
            var actor = _context.Users.FirstOrDefault(x => x.Id == request.UserId);
            //var stockDTO = new StockDTO
            //{
            //    Id = selectedStock.Id,
            //    Name = selectedStock.Name,
            //    Measure = selectedStock.Measure,
            //    MeasurementUnit = selectedStock.MeasurementUnit.ToString(),
            //    StockCategory = selectedStock.StockCategory.ToString()

            //};
            selectedStock.IsRemoved = true;

            // Add activity
            var activityDescription = $"Removed stock {selectedStock.Name}";
            var newActivity = new ActivityHistory
            {
                User = actor.FirstName + " " + actor.LastName,
                Activity = activityDescription,
                Module = "Inventory",
                Date = DateTime.Now.ToString("MM/dd/yyyy HH:mm")
            };

            //_context.Stocks.Remove(selectedStock);
            _context.SaveChanges();

            return Task.FromResult(true);
        }
    }
}
