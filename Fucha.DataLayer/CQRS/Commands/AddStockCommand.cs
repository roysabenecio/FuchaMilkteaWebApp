using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;

using AutoMapper;
using Fucha.DomainClasses.Enums;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class AddStockCommand : IRequest<Stock>
    {
        public string Name { get; set; }
        public double Measure { get; set; }
        public string MeasurementUnit { get; set; }
        public string Category { get; set; }
        public int StockServingId { get; set; }
        //public string StockStatus { get; set; }
        //dateadded
        public string Supplier { get; set; }
        public int UserId { get; set; }
    }

    public class AddStockCommandHandler : IRequestHandler<AddStockCommand, Stock>
    {
        private readonly IFuchaMilkteaContext _context;

        public AddStockCommandHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }

        public Task<Stock> Handle(AddStockCommand request, CancellationToken cancellationToken)
        {
            var supplierId = _context.Suppliers.FirstOrDefault(x => x.Name == request.Supplier).Id;

            var currentUser = _context.Users.FirstOrDefault(u => u.Id == request.UserId);



            var newStock = new Stock
            {
                Name = request.Name,
                Measure = request.Measure,
                MeasurementUnit = (MeasurementUnit)Enum.Parse(typeof(MeasurementUnit), request.MeasurementUnit),
                Category = (StockCategory)Enum.Parse(typeof(StockCategory), request.Category),
                //DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy"),
                //SupplierId = _context.Suppliers.FirstOrDefault(s => s.Name == request.Supplier).Id,
                StockServingId = request.StockServingId,
                SupplierId = supplierId

            };
            _context.Stocks.Add(newStock);

            // add activity on activity history
            var activityDescription = $"Added new stock {newStock.Name} {newStock.Measure} {request.MeasurementUnit}";

            var newActivity = new ActivityHistory
            {
                User = currentUser.FirstName + " " + currentUser.LastName,
                Activity = activityDescription,
                Date = DateTime.Now.ToString("MM/dd/yyyy HH:mm"),
            };
            _context.ActivityHistories.Add(newActivity);
            _context.SaveChanges();

            var stockAdded = _context.Stocks.FirstOrDefault(x => x.Id == newStock.Id);

            //var mapper = new Mapper(config);
            //return mapper.Map<IngredientDTO>(newIngredient);
            //IngredientDTO ingredientDTO = mapper.Map<Ingredient, IngredientDTO>(newIngredient);

            //AutoMapper mapper;
            //return Task.FromResult<IngredientDTO>(ingredientDTO);
            //IngredientDTO ingredientDTO = Mapper.Map<IngredientDTO>(ingredient);
            return Task.FromResult(stockAdded);
        }
    }
}