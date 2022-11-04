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
//    public class GetAllMealsQuery : IRequest<List<Meal>>
//    {
//    }

//    public class GetAllMealsQueryHandler : IRequestHandler<GetAllMealsQuery, List<Meal>>
//    {
//        private readonly IFuchaMilkteaContext _dbContext;
//        public GetAllMealsQueryHandler(IFuchaMilkteaContext dbContext)
//        {
//            _dbContext = dbContext;
//        }

//        public Task<List<Meal>> Handle(GetAllMealsQuery request, CancellationToken cancellationToken)
//        {
//            var response = _dbContext.Meals.Select(meal => new Meal
//            {
//                Id = meal.Id,
//                Name = meal.Name,
//                MealCategory = meal.MealCategory,
//                Price = meal.Price
//            }).ToList();
//            return Task.FromResult<List<Meal>>(response);
//        }
//    }
//}
