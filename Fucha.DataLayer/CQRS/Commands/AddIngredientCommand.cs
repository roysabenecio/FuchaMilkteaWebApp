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
    public class AddIngredientCommand : IRequest<Ingredient>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        //public DateTime? PurchaseDate { get; set; }
        //public int Category { get; set; }
        //public int Status { get; set; }
    }

    public class AddIngredientCommandHandler : IRequestHandler<AddIngredientCommand, Ingredient>
    {
        private readonly IFuchaMilkteaContext _dbContext;
        public AddIngredientCommandHandler(IFuchaMilkteaContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<Ingredient> Handle(AddIngredientCommand request, CancellationToken cancellationToken)
        {
            var newIngredient = new Ingredient
            {
                Name = request.Name,
                //Quantity = request.Quantity,
                //UserName = request.UserName,
                //Password = request.Password,
                //Role = 0,
                //Status = 0,
                //Created = DateTime.Now
            };
            //_dbContext.Ingredients.Add(newIngredient);
            //    _dbContext.SaveChanges();
            return Task.FromResult(newIngredient);
        }
    }
}
