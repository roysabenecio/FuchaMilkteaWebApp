using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using Fucha.DomainClasses.Enums;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class PostSalesOrdersCommand : IRequest<OrderDTO>
    //public class PostSalesOrdersCommand : IRequest<List<Order>>
    {
        public int UserId { get; set; }
        public List<OrderDTO> Orders { get; set; }
    }

    public class PostSalesOrdersCommandHandler : IRequestHandler<PostSalesOrdersCommand, OrderDTO>
    //public class PostSalesOrdersCommandHandler : IRequestHandler<PostSalesOrdersCommand, List<Order>>
    {
        private readonly IFuchaMilkteaContext _context;
        public PostSalesOrdersCommandHandler(IFuchaMilkteaContext dbContext)
        {
            _context = dbContext;
        }

        public Task<OrderDTO> Handle(PostSalesOrdersCommand request, CancellationToken cancellationToken)
        //public Task<List<Order>> Handle(PostSalesOrdersCommand request, CancellationToken cancellationToken)
        {
            var allPOR = _context.PORecords.Select(por => por).ToList();
            var allPurchaseRecords = _context.PurchaseRecords.Select(pr => pr).ToList();
            var allStocks = _context.Stocks.Select(s => s).ToList();
            var allSuppliers = _context.Suppliers.Select(s => s).ToList();
            var allMenus = _context.Menus.Select(m => m).ToList();
            var allUsers = _context.Users.Select(u => u).ToList();

            //var id = request.UserId;

            //if (request.Orders.Count != 0)
            //{
            //var t = request.Orders;
            var newSale = new SaleTransaction
            {
                DateSold = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss")
            };
            _context.SalesTransaction.Add(newSale);
            _context.SaveChanges();

            var currentSaleId = newSale.Id;
            //}

            //var orders = new Order();

            //request.Orders.ForEach(dto => )


            //request.Orders.Select(dto =>
            //{
            //    if (dto.MenuCategoryId == 1 || dto.MenuCategoryId == 2)
            //    {
            //        new Order
            //        {
            //            Name = _context.Menus.FirstOrDefault(m => m.Id == dto.MenuId).Name,
            //            Category = _context.MenuCategories.FirstOrDefault(mc => mc.Id == dto.MenuCategoryId).Name,
            //            Quantity = dto.Quantity,
            //            Price = dto.Price,
            //            AddOn = dto.AddOn,
            //            AddOnPrice = dto.AddOnPrice,
            //            Size = _context.Sizes.FirstOrDefault(s => s.Id == dto.SizeId).Name,
            //            SaleId = currentSaleId
            //        }.ToList();
            //    }
            //    else
            //    {
            //        new Order
            //        {

            //            Name = _context.Menus.FirstOrDefault(m => m.Id == dto.MenuId).Name,
            //            Category = _context.MenuCategories.FirstOrDefault(mc => mc.Id == dto.MenuCategoryId).Name,
            //            Quantity = dto.Quantity,
            //            Price = dto.Price,
            //            SaleId = currentSaleId
            //        }
            //    }

            //});

            //var orders = request.Orders.Select(dto => new Order
            //{
            //    Name = _context.Menus.FirstOrDefault(m => m.Id == dto.MenuId).Name,
            //    Category = _context.MenuCategories.FirstOrDefault(mc => mc.Id == dto.MenuCategoryId).Name,
            //    Quantity = dto.Quantity,
            //    Price = dto.Price,
            //    AddOn = dto.AddOn ?? null,
            //    AddOnPrice = dto.AddOnPrice ?? null,
            //    Size = _context.Sizes.FirstOrDefault(s => s.Id == dto.SizeId).Name ?? null,
            //    SaleId = currentSaleId
            //}).ToList();

            request.Orders.ForEach(o =>
            {
                if (o.MenuCategoryId == 1 || o.MenuCategoryId == 2)
                {
                    _context.Orders.Add(new Order
                    {
                        Name = _context.Menus.FirstOrDefault(m => m.Id == o.MenuId).Name,
                        Category = _context.MenuCategories.FirstOrDefault(mc => mc.Id == o.MenuCategoryId).Name,
                        Quantity = o.Quantity,
                        Price = o.Price,
                        AddOn = o.AddOn ?? null,
                        AddOnPrice = o.AddOnPrice ?? null,
                        Size = _context.Sizes.FirstOrDefault(s => s.Id == o.SizeId).Name ?? null,
                        SaleId = currentSaleId
                    });
                }
                else
                {
                    _context.Orders.Add(new Order
                    {
                        Name = _context.Menus.FirstOrDefault(m => m.Id == o.MenuId).Name,
                        Category = _context.MenuCategories.FirstOrDefault(mc => mc.Id == o.MenuCategoryId).Name,
                        Quantity = o.Quantity,
                        Price = o.Price,
                        SaleId = currentSaleId
                    });
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

            //newOrders.ForEach(x =>
            //{
            //    _context.Orders.Add(x);
            //    _context.SaveChanges();
            //});

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

            OrderDTO isT = new OrderDTO();

            return Task.FromResult<OrderDTO>(isT);
        }
    }
}
