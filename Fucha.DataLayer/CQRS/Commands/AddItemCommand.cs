using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class AddItemCommand : IRequest<IngredientDTO>
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Quantity { get; set; }
        //public int Category { get; set; }
        //public int Status { get; set; } 
    }

    public class AddItemCommandHandler : IRequestHandler<AddItemCommand, IngredientDTO>
    {
        public IMapper Mapper { get; set; }

        private readonly IFuchaMilkteaContext _dbContext;

        public AddItemCommandHandler(IFuchaMilkteaContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<IngredientDTO> Handle(AddItemCommand request, CancellationToken cancellationToken)
        {
            //var config = new MapperConfiguration(cfg =>
            //    cfg.CreateMap<Ingredient, IngredientDTO>()
            //);

            //var newIngredient = new Ingredient();

            //using (var trans = new FuchaMilkteaContext())
            //{

            //    try
            //    {

            //        newIngredient = new Ingredient()
            //        {
            //            Id = request.Id,
            //            Name = request.Name,
            //            Quantity = request.Quantity,
            //            Category = request.Category,
            //            Status = request.Status,
            //        };

            //        _dbContext.Ingredients.Add(newIngredient);
            //        _dbContext.SaveChanges();


            //        _dbContext.SaveChanges();

            //    }

            //    catch (Exception error)
            //    {
            //        throw new Exception("Something went wrong");
            //    }

            //}

            var ingredient = new Ingredient()
            {
                Id = request.Id,
                Name = request.Name,
                Quantity = request.Quantity,
                //Category = request.Category,
                //Status = request.Status,
            };


            //var mapper = new Mapper(config);
            //return mapper.Map<IngredientDTO>(newIngredient);
            //IngredientDTO ingredientDTO = mapper.Map<Ingredient, IngredientDTO>(newIngredient);

            //AutoMapper mapper;



            //return Task.FromResult<IngredientDTO>(ingredientDTO);
            IngredientDTO ingredientDTO = Mapper.Map<IngredientDTO>(ingredient);
            return Task.FromResult(ingredientDTO);


        }
    }
}
