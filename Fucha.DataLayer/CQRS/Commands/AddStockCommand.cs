using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;

using AutoMapper;
using Fucha.DomainClasses.Enums;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class AddStockCommand : IRequest<Stock>
    {
        public string? Name { get; set; }
        public double? Measure { get; set; }
        public string? MeasurementUnit { get; set; }
        public string? Category { get; set; }
        public double? CriticalLevel { get; set; }
        public double? LowLevel { get; set; }
        public double? OverStockLevel { get; set; }
        public int? StockServingId { get; set; }
        //public string StockStatus { get; set; }
        //dateadded
        public string? Supplier { get; set; }
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
                CriticalLevel = request.CriticalLevel,
                LowLevel = request.LowLevel,
                OverStockLevel = request.OverStockLevel,
                //DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy"),
                //SupplierId = _context.Suppliers.FirstOrDefault(s => s.Name == request.Supplier).Id,
                StockServingId = request.StockServingId,
                SupplierId = supplierId

            };
            _context.Stocks.Add(newStock);

            // Reset Gram Sold if milk tea
            var currentStock = newStock;
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

            if (newStock.Category == StockCategory.Pizza)
            {
                var newPizza = new Menu
                {
                    Name = newStock.Name,
                    MenuCategoryId = 4
                };

                newStock.StockServingId = 1;

                _context.Menus.Add(newPizza);
                _context.SaveChanges();

                var newPrice = new MenuPrice
                {
                    Price = 600,
                    MenuId = newPizza.Id,
                    MenuCategoryId=4
                };

                _context.MenuPrices.Add(newPrice);
                _context.SaveChanges();

                var newRecipe = new Recipe
                {
                    Name = newStock.Name,
                    MenuId = newPrice.MenuId,
                    MenuCategoryId = newPrice.MenuCategoryId
                };

                _context.Recipes.Add(newRecipe);
                _context.SaveChanges();

                var newRecipeStock = new RecipeStock
                {
                    RecipeId = newRecipe.Id,
                    StockId = newStock.Id,
                };

                _context.RecipeStocks.Add(newRecipeStock);
                _context.SaveChanges();
            }

            // add activity on activity history
            var activityDescription = $"Added new stock {newStock.Name} {newStock.Measure} {request.MeasurementUnit}";

            var newActivity = new ActivityHistory
            {
                User = currentUser.FirstName + " " + currentUser.LastName,
                Activity = activityDescription,
                Module = "Inventory",
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