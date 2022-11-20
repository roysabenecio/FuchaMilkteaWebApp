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
        public string StockCategory { get; set; }
        //public string StockStatus { get; set; }
        //dateadded
        //public string Supplier { get; set; }
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

            var newStock = new Stock
            {
                Name = request.Name,
                Measure = request.Measure,
                MeasurementUnit = (MeasurementUnit)Enum.Parse(typeof(MeasurementUnit), request.MeasurementUnit),
                StockCategory = (StockCategory)Enum.Parse(typeof(StockCategory), request.StockCategory),
                DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy"),
                //SupplierId = _context.Suppliers.FirstOrDefault(s => s.Name == request.Supplier).Id,
                SupplierId = 1

            };
            _context.Stocks.Add(newStock);
            _context.SaveChanges();

            var stockAdded = _context.Stocks.FirstOrDefault(x => x.Id == newStock.Id);

            //public string StockCategory { get; set; }
            //public string StockStatus { get; set; }
            //Quantity = request.Quantity,
            //Category = request.Category,
            //Status = request.Status,
   

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
