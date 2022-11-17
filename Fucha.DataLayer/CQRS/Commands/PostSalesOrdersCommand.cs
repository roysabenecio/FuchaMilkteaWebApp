using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using Fucha.DomainClasses.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.CQRS.Commands
{
    //public class PostSalesOrdersCommand : IRequest<Order>
    public class PostSalesOrdersCommand : IRequest<List<Order>>
    {
        public PostSalesOrdersCommand(List<Order> orders)
        {
            Orders = orders;
        }
        //public int Id { get; set; }
        //public List<int> Id { get; set; }
        //public int Quantity { get; set; }
        //public string? Size { get; set; }
        public List<Order> Orders;

    }

    //public class PostSalesOrdersCommandHandler : IRequestHandler<PostSalesOrdersCommand, Order>
    public class PostSalesOrdersCommandHandler : IRequestHandler<PostSalesOrdersCommand, List<Order>>
    {
        private readonly IFuchaMilkteaContext _context;
        public PostSalesOrdersCommandHandler(IFuchaMilkteaContext dbContext)
        {
            _context = dbContext;
        }

        //public Task<Order> Handle(PostSalesOrdersCommand request, CancellationToken cancellationToken)
        public Task<List<Order>> Handle(PostSalesOrdersCommand request, CancellationToken cancellationToken)
        {

            //if (request.Orders.Count != 0)
            //{

            var newSale = new SaleTransaction
            {
                DateSold = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")
            };
            _context.SalesTransaction.Add(newSale);
            _context.SaveChanges();

            var currentSaleId = newSale.Id;
            //}


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
            var newOrders = request.Orders.Select(order => new Order
            {

                Name = order.Name,
                MenuId = order.Id,
                MenuCategoryId = order.MenuCategoryId,
                SaleId = currentSaleId,                   
                AddOn = order.AddOn,
                //AddOnPrice = order.OrderQuantity * _context.AddOns.Select(ao => ao)
                //                            .Where(ao => ao.Name == order.AddOn)
                //                            .Select(ao => ao.AddOnPrice)
                //                            .SingleOrDefault(),
                AddOnPrice = order.AddOnPrice,
                Quantity = order.Quantity,
                SizeId = order.SizeId,
                //OrderPrice = _context.MenuPrices.Select(p => p)
                //                            .Where(p => (p.SizeId == order.SizeId && p.MenuCategoryId == order.MenuCategoryId) || p.MenuId == order.MenuId)
                //                            .Select(x => x.Price)
                //                            .SingleOrDefault() * order.OrderQuantity
                Price = order.Price,
            }).ToList();

            newOrders.ForEach(x =>
            {
                _context.Orders.Add(x);
                _context.SaveChanges();
            });

            //foreach (var order in newOrders)
            //{
            //    _context.Orders.Add(order);
            //    _context.SaveChanges();
            //}
            // addRange() option

            var currentOrdersPrices = _context.Orders.Select(o => o).Where(o => o.SaleId == currentSaleId).Select(o => o.Price).ToList().Sum();
            var currentAddOnsPrices = _context.Orders.Select(o => o).Where(o => o.SaleId == currentSaleId).Select(o => o.AddOnPrice).ToList().Sum();
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

            return Task.FromResult<List<Order>>(newOrders);
        }
    }
}
