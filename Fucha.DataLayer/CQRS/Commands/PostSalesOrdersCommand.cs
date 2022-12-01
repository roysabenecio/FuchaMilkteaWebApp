using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Extras;
using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class PostSalesOrdersCommand : IRequest<OrderDTO>
    {
        public int UserId { get; set; }
        [Required]
        public List<OrderDTO>? Orders { get; set; }
    }

    public class PostSalesOrdersCommandHandler : IRequestHandler<PostSalesOrdersCommand, OrderDTO>
    {
        private readonly IFuchaMilkteaContext _context;
        public PostSalesOrdersCommandHandler(IFuchaMilkteaContext dbContext)
        {
            _context = dbContext;
        }

        public Task<OrderDTO> Handle(PostSalesOrdersCommand request, CancellationToken cancellationToken)
        {
            Calculate calculate = new();
            var allRecipes = _context.Recipes.Select(r => r).ToList();
            var checkRecipe = (int menuId) => _context.Recipes.FirstOrDefault(r => r.MenuId == menuId);
            //var checkStock = (int menuId) => _context.Stocks.FirstOrDefault(s => s.MenuId == menuId);
            var isMilkTea = (int catId) => catId == 1 || catId == 2;
            
            var allStocks = _context.Stocks.Select(s => s).ToList();
            var allStockServings = _context.StockServings.Select(ss => ss).ToList();

            var joinedStockServing = allStocks
                .Join(
                    allStockServings,
                    s => s.StockServingId,
                    ss => ss.Id,
                    (s, ss) => new
                    {
                        s.Id,
                        s.Measure,
                        ss.RequiredPerServing,
                        ss.MeasurementUnit
                    });
            //request.Orders.ForEach(order =>
            //{
            //    var currentRecipe = checkRecipe(order.MenuId);
            //    var currentStock = checkStock(order.MenuId);
            //    currentStock.Measure -= calculate.AutoCalculate((order.Quantity * currentRecipe.RequiredMeasure), (int)currentRecipe.MeasurementUnit, (int)currentStock.MeasurementUnit);
            //    _context.SaveChanges();
            //});

            var newSale = new SaleTransaction
            {
                ItemQuantity = request.Orders.Count,
                DateSold = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"),
                UserId = request.UserId
            };
            _context.SalesTransaction.Add(newSale);
            _context.SaveChanges();

            var currentSaleId = newSale.Id;

            request.Orders.ForEach(o =>
            {
                if (isMilkTea(o.MenuCategoryId))
                {
                    _context.Orders.Add(new Order
                    {
                        Name = _context.Menus.First(m => m.Id == o.MenuId).Name,
                        Category = _context.MenuCategories.First(mc => mc.Id == o.MenuCategoryId).Name,
                        Quantity = o.Quantity,
                        Price = o.Price,
                        AddOn = o.AddOn ?? null,
                        AddOnPrice = o.AddOnPrice ?? null,
                        Size = _context.Sizes.First(s => s.Id == o.SizeId).Name ?? null,
                        SaleId = currentSaleId
                    });

                    //Deduct milktea in stocks
                    //var currentRecipe = checkRecipe(o.MenuId);
                    //var currentStock = checkStock(o.MenuId);
                    //currentStock.Measure -= calculate.AutoCalculate(
                    //    (o.Quantity * currentRecipe.RequiredMeasure), 
                    //    (int)currentRecipe.MeasurementUnit, 
                    //    (int)currentStock.MeasurementUnit);

                    //var currentRecipe = checkRecipe(o.MenuId);
                    //var currentStock = checkStock(o.MenuId);
                    //var getAllRecipeStock = _context.RecipeStocks.Include(rs => rs.Stock).ThenInclude(s => s.Measure);
                    //var selectRecipeStock = getAllRecipeStock.FirstOrDefault(r => r.RecipeId == currentRecipe.Id && r.StockId == currentStock.Id);

                    // Get Recipe by size and add on
                    var currentRecipe = _context.Recipes
                                                .FirstOrDefault(r => r.SizeId == o.SizeId && 
                                                o.AddOn != null);

                    // Get RecipeStock by RecipeId
                    // to get all stocks included in recipe
                    var currentRecipeStock = _context.RecipeStocks
                                                 .Select(rs => rs)
                                                 .Where(rs => rs.RecipeId == currentRecipe.Id)
                                                 .ToList();
                    //var getRecipeStock = _context.RecipeStocks.Include(rs => rs.Stock).ThenInclude(s => s.Measure).Select(rs => rs).Where(rs => rs.RecipeId == currentRecipe.Id);
                    //var getRecipeStock = _context.RecipeStocks.Select(rs=>rs).Where(rs => rs.RecipeId == currentRecipe.Id);
                    //var getStock = getRecipeStock.Select(rs =>
                    //getRecipeStock.ForEachAsync(rs => rs.Stock.Measure -= 1);

                    // Get All Stocks
                    var currentStockIds = currentRecipeStock.Select(rs => rs.StockId).ToList();
                    var currentStocks = new List<Stock>();

                    // Added Stocks from Stock Id
                    currentStockIds.ForEach(sId => currentStocks.Add(_context.Stocks.FirstOrDefault(s => s.Id == sId)));

                    // Deduct Stocks based on StockServing
                    currentStocks.ForEach(s => s.Measure -= (o.Quantity * joinedStockServing.FirstOrDefault(ss => ss.Id == s.Id).RequiredPerServing));
                    
                    //currentStockIds.ForEach(sId => 
                    //    joinedStockServing.FirstOrDefault(ss => ss.Id == sId).Measure -=
                    //    (joinedStockServing.FirstOrDefault(ss => ss.Id == sId).RequiredPerServing)
                            
                    //);

                    //var selectedStock = currentStockId.ForEach(sId => _context.Stocks.Select(s => s).Where(s => s.Id == sId));
                    // Get StockServingId from all Stocks
                    //var selectedStockServingId = selectedStock.Select(ss => ss.StockServingId).ToList();
                    //var selectStockServing = selectedStock.Select(ss => ss)

                    //var selectedStockServings = _context.StockServings.Select(ss => ss).ToList();

                    //selectedStockServings.ForEach(ss => 
                    //    _context.Stocks.FirstOrDefault(s => s.StockServingId == ss.Id).Measure -= o.Quantity
                    //);
                    //selectedStock.ForEach(s => s.Measure -= (o.Quantity * _context.StockServings.FirstOrDefault(ss => ss.Id == s.StockServingId).RequiredPerServing));

                    _context.SaveChanges();
                }
                else
                {
                    _context.Orders.Add(new Order
                    {
                        Name = _context.Menus.First(m => m.Id == o.MenuId).Name,
                        Category = _context.MenuCategories.First(mc => mc.Id == o.MenuCategoryId).Name,
                        Quantity = o.Quantity,
                        Price = o.Price,
                        SaleId = currentSaleId
                    });

                    //Deduct menu in stocks

                    // Get Recipe by menu id
                    var currentRecipe = _context.Recipes
                                                .FirstOrDefault(r => r.MenuId == o.MenuId);

                    // Get RecipeStock by RecipeId
                    // to get all stocks included in recipe
                    var currentRecipeStock = _context.RecipeStocks
                                                 .Select(rs => rs)
                                                 .Where(rs => rs.RecipeId == currentRecipe.Id)
                                                 .ToList();

                    // Get All Stocks
                    var currentStockIds = currentRecipeStock.Select(rs => rs.StockId).ToList();
                    var currentStocks = new List<Stock>();

                    // Added Stocks from Stock Id
                    currentStockIds.ForEach(sId => currentStocks.Add(_context.Stocks.FirstOrDefault(s => s.Id == sId)));

                    // Deduct Stocks based on StockServing
                    currentStocks.ForEach(s => s.Measure -= (o.Quantity * joinedStockServing.FirstOrDefault(ss => ss.Id == s.Id).RequiredPerServing));

                    //var currentRecipe = checkRecipe(o.MenuId);
                    //var currentStock = checkStock(o.MenuId);
                    //currentStock.Measure -= calculate.AutoCalculate(
                    //    (o.Quantity * currentRecipe.RequiredMeasure),
                    //    (int)currentRecipe.MeasurementUnit,
                    //    (int)currentStock.MeasurementUnit);
                }
            });

            _context.SaveChanges();
            //var getAddOn = AddOns.Select(a => a).Where(a => a.Name == pearl).Select(a => a.AddOnsPrice);
            //_dbContext.AddOns.Select(a => a).Where(a => a.Name == order.AddOn).Select(a => a.AddOnsPrice);
            //var getAddOn = _dbContext.AddOns.Select(a => a).Where(a => a.Name == "Pearl").Select(a => a.AddOnsPrice);

            //var getAddOnPrice = _context.AddOns.Select(a => a).Where(a => a.Name == "Pearl").Select(a => a.AddOnPrice).ToList();

            //var addOnPrice = 0.00;
            //foreach (var v in getAddOnPrice)
            //{
            //    //Console.WriteLine(v);
            //    addOnPrice = v;
            //}

            //var t = 0;
            //var getOrderPrice = _context.Prices.Select(x => x).Where(p => p.SizeId == sizeId && p.CategoryId == catId).SingleOrDefault();
            //var newOrders = request.Orders.Select(order => new Order
            //{

            //    Name = order.Name,
            //    MenuId = order.Id,
            //    MenuCategoryId = order.MenuCategoryId,
            //    SaleId = currentSaleId,                   
            //    AddOn = order.AddOn,
            //    //AddOnPrice = order.OrderQuantity * _context.AddOns.Select(ao => ao)
            //    //                            .Where(ao => ao.Name == order.AddOn)
            //    //                            .Select(ao => ao.AddOnPrice)
            //    //                            .SingleOrDefault(),
            //    AddOnPrice = order.AddOnPrice,
            //    Quantity = order.Quantity,
            //    SizeId = order.SizeId,
            //    //OrderPrice = _context.MenuPrices.Select(p => p)
            //    //                            .Where(p => (p.SizeId == order.SizeId && p.MenuCategoryId == order.MenuCategoryId) || p.MenuId == order.MenuId)
            //    //                            .Select(x => x.Price)
            //    //                            .SingleOrDefault() * order.OrderQuantity
            //    Price = order.Price,
            //}).ToList();

            var currentOrdersPrices = _context.Orders
                .Select(o => o)
                .Where(o => o.SaleId == currentSaleId)
                .Select(o => o.Price)
                .ToList()
                .Sum();
            var currentAddOnsPrices = _context.Orders
                .Select(o => o)
                .Where(o => o.SaleId == currentSaleId)
                .Select(o => o.AddOnPrice)
                .ToList()
                .Sum();
            var totalPrice = currentAddOnsPrices + currentOrdersPrices;
            //foreach (var price in currentOrdersPrices)
            //{
            //    totalPrice += price;
            //}

            //_dbContext.Sales.Update(s => s.TotalAmount);
            //var currentSale = _dbContext.Sales.Single(sale => new SaleTransaction
            //{
            //    Id = sale.Id

            //}).Where(x => x.Id == saleId);
            //SaleTransaction currentSale = new SaleTransaction();
            var currentSale = _context.SalesTransaction.Single(s => s.Id == currentSaleId);
            currentSale.TotalSales = (double) totalPrice;
            _context.SaveChanges();

            OrderDTO isT = new();

            return Task.FromResult<OrderDTO>(isT);
        }
    }
}
