using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Extras;
using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using Fucha.DomainClasses.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class PostSalesOrdersCommand : IRequest<List<Order>>
    {
        public int UserId { get; set; }
        [Required]
        public List<OrderDTO>? Orders { get; set; }
    }

    public class PostSalesOrdersCommandHandler : IRequestHandler<PostSalesOrdersCommand, List<Order>>
    {
        private readonly IFuchaMilkteaContext _context;
        public PostSalesOrdersCommandHandler(IFuchaMilkteaContext dbContext)
        {
            _context = dbContext;
        }

        public Task<List<Order>> Handle(PostSalesOrdersCommand request, CancellationToken cancellationToken)
        {
            Calculate calculate = new();
            var allRecipes = _context.Recipes.Select(r => r).ToList();
            var checkRecipe = (int menuId) => _context.Recipes.FirstOrDefault(r => r.MenuId == menuId);
            var isMilkTea = (int catId) => catId == 1 || catId == 2;
            
            var allStocks = _context.Stocks.Select(s => s).ToList();
            var allStockServings = _context.StockServings.Select(ss => ss).ToList();

            var gramSold = _context.MTGramSolds.Select(gs => gs).ToList();

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

            var newSale = new SaleTransaction
            {
                ItemQuantity = request.Orders.Select(x => x.Quantity).Sum(),
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

                    // Get All Stocks
                    var currentStockIds = currentRecipeStock.Select(rs => rs.StockId).ToList();
                    var currentStocks = new List<Stock>();

                    // Added Stocks from Stock Id
                    currentStockIds.ForEach(sId => currentStocks.Add(_context.Stocks.FirstOrDefault(s => s.Id == sId)));

                    // Deduct Stocks based on StockServing
                    currentStocks.ForEach(s => s.Measure -= (o.Quantity * joinedStockServing.FirstOrDefault(ss => ss.Id == s.Id).RequiredPerServing));

                    // Add info on GramSold table
                    var currentGS = gramSold.FirstOrDefault(gs => gs.Name == o.Name);
                    if (o.SizeId == 1)
                    {
                        currentGS.Grams += (30 * o.Quantity);
                    }
                    if (o.SizeId == 2)
                    {
                        currentGS.Grams += (30 * o.Quantity);
                    }
                    if (o.SizeId == 3)
                    {
                        currentGS.Grams += (60 * o.Quantity);
                    }
                    if (o.SizeId == 4)
                    {
                        currentGS.Grams += (90 * o.Quantity);
                    }

                    // Set Milktea status
                    var GSInKg = currentGS.Grams / 1000; // current gram sold convert to kg because of UOM of the stock
                    var MTStock= _context.Stocks.FirstOrDefault(s => s.Name == o.Name);
                    var RemainingMeasure = (MTStock.Measure - GSInKg);

                    if (MTStock.LowLevel != null && MTStock.CriticalLevel != null && MTStock.Ceiling != null)
                    {
                        var isLow = RemainingMeasure > MTStock.CriticalLevel && RemainingMeasure <= MTStock.LowLevel;
                        var isCritical = RemainingMeasure > 0 && RemainingMeasure <= MTStock.CriticalLevel;
                        var overStock = MTStock.Measure > MTStock.Ceiling;
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
                    }
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

                    // Set Stock status
                    var stock = _context.Stocks.FirstOrDefault(s => s.Name == o.Name);

                    if (stock != null)
                    //if (stock.LowLevel != null && stock.CriticalLevel != null && stock.Ceiling != null)
                        {
                        var isLow = stock.Measure > stock.CriticalLevel && stock.Measure <= stock.LowLevel;
                        var isCritical = stock.Measure > 0 && stock.Measure <= stock.CriticalLevel;
                        var overStock = stock.Measure > stock.Ceiling;
                        var outOfStock = stock.Measure <= 0;

                        if (isLow)
                        {
                            stock.Status = QuantityStatus.Low;
                        }
                        if (isCritical)
                        {
                            stock.Status = QuantityStatus.Critical;
                        }
                        if (outOfStock)
                        {
                            stock.Status = QuantityStatus.OutOfStock;
                        }
                        if (overStock)
                        {
                            stock.Status = QuantityStatus.OverStock;
                        }
                        if (!outOfStock && !isLow && !isCritical && !overStock)
                        {
                            stock.Status = QuantityStatus.Sufficient;
                        }
                        _context.SaveChanges();
                    }
                    _context.SaveChanges();
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
            var currentSale = _context.SalesTransaction.Single(s => s.Id == currentSaleId);
            currentSale.TotalSales = (double) totalPrice;
            _context.SaveChanges();

            var bill = _context.Orders.Select(x => x).Where(x => x.SaleId == currentSaleId).ToList();

            return Task.FromResult(bill);
        }
    }
}
