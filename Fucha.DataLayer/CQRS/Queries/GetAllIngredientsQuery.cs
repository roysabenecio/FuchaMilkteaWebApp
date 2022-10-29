using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.CQRS.Queries
{
    public class GetAllIngredientsQuery : IRequest<List<Ingredient>>
    {
    }

    public class GetAllIngredientsQueryHandler : IRequestHandler<GetAllIngredientsQuery, List<Ingredient>>
    {
        private readonly IFuchaMilkteaContext _dbContext;
        public GetAllIngredientsQueryHandler(IFuchaMilkteaContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<Ingredient>> Handle(GetAllIngredientsQuery request, CancellationToken cancellationToken)
        {
            var response = _dbContext.Ingredients.Select(ingredient => new Ingredient
            {
                Id = ingredient.Id,
                Name = ingredient.Name,
                IngredientCategory = ingredient.IngredientCategory,
                Quantity = ingredient.Quantity,
                MeasurementType = ingredient.MeasurementType,
            }).ToList();
            return Task.FromResult<List<Ingredient>>(response);
        }
    }
}
