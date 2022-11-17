//using Fucha.DataLayer.Models;
//using Fucha.DomainClasses;
//using MediatR;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Fucha.DataLayer.CQRS.Queries
//{
//    public class GetAllItemsQuery : IRequest<List<Stocks>>
//    {
//    }

//    public class GetAllItemsQueryHandler : IRequestHandler<GetAllItemsQuery, List<Stocks>>
//    {
//        private readonly IFuchaMilkteaContext _dbContext;
//        public GetAllItemsQueryHandler(IFuchaMilkteaContext dbContext)
//        {
//            _dbContext = dbContext;
//        }

//        public Task<List<Stocks>> Handle(GetAllItemsQuery request, CancellationToken cancellationToken)
//        {
//            var allItems = _dbContext.Items.Select(item => new Stocks
//            {
//                Id = item.Id,
//                Name = item.Name,
//                MeasurementUnit = item.MeasurementUnit,
//                ItemCategory = item.ItemCategory
//            }).ToList();
//            return Task.FromResult<List<Stocks>>(allItems);
//        }
//    }
//}
