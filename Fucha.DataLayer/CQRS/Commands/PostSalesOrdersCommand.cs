using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;
using System;
using System.Collections.Generic;
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
        private readonly IFuchaMilkteaContext _dbContext;
        public PostSalesOrdersCommandHandler(IFuchaMilkteaContext dbContext)
        {
            _dbContext = dbContext;
        }

        //public Task<Order> Handle(PostSalesOrdersCommand request, CancellationToken cancellationToken)
        public Task<List<Order>> Handle(PostSalesOrdersCommand request, CancellationToken cancellationToken)
        {
            //var newOrders = (newOrders => new Order
            //{

            //})
            //var newOrder = new Order();

            //    var sale = new Sale
            //    {
            //        Orders = () => {foreach (var order in request.Orders)
            //            {
            //                new Order
            //                {
            //                    MenuId = order.MenuId
            //                };
            //            }

            //    }
            //}
            var newSale = new Sale();
            _dbContext.Sales.Add(newSale);
            _dbContext.SaveChanges();

            int saleId = newSale.Id;

            //var orders = _dbContext.Orders.Select(id => new Order { MenuId = id.MenuId }).ToList();

            //var newOrder = new Order
            //{
            //    MenuId = request.Id
            //};

            //var newOrders = request.Orders.Select(order => new List<Order>
            //{
            //    Menu = order.MenuId
            //}).ToList();

            var newOrders = request.Orders.Select(order => new Order
            {
                MenuId = order.Id,
                SaleId = saleId,
                //quantity
                //price
                //size
            }).ToList();

            foreach(var order in newOrders)
            {
                _dbContext.Orders.Add(order);
            }
            // addRange() option
            
            _dbContext.SaveChanges();

            //foreach (var t in request)
            //{
            //    var newOrder = new Order
            //    {
            //        MenuId = request.MenuId,
            //        OrderQuantity = request.Quantity
            //    };
            //}

            //var newOrder = new Order();

            //_dbContext.Orders.Add(newOrder);
            //_dbContext.SaveChanges();
            //return Task.FromResult<Order>(newOrder);
            return Task.FromResult<List<Order>>(newOrders);
        }
    }
}
