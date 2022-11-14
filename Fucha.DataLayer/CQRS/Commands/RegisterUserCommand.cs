using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using Fucha.DomainClasses.Enums;
using Fucha.DomainClasses;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class RegisterUserCommand : IRequest<User>
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public int UserStatus { get; set; }
    }

    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, User>
    {
        //public IMapper Mapper { get; set; }

        private readonly IFuchaMilkteaContext _dbContext;

        public RegisterUserCommandHandler(IFuchaMilkteaContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<User> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            //(request.Role ? "admin" : 0)
            var newUser = new User
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                UserName = request.UserName,
                Password = request.Password,
                Role = request.Role,
                UserStatus = "Approved",
                DateCreated = DateTime.Now.ToString("dddd, dd MMMM yyyy")
            };
            _dbContext.Users.Add(newUser);
            _dbContext.SaveChanges();
            return Task.FromResult(newUser);
        }

        //public Task<IngredientDTO> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        //{

        //    var ingredient = new Ingredient()
        //    {
        //        Id = request.Id,
        //        Name = request.Name,
        //        Quantity = request.Quantity,
        //        //Category = request.Category,
        //        //Status = request.Status,
        //    };

        //    //var mapper = new Mapper(config);
        //    //return mapper.Map<IngredientDTO>(newIngredient);
        //    //IngredientDTO ingredientDTO = mapper.Map<Ingredient, IngredientDTO>(newIngredient);

        //    //AutoMapper mapper;

        //    //return Task.FromResult<IngredientDTO>(ingredientDTO);
        //    IngredientDTO ingredientDTO = Mapper.Map<IngredientDTO>(ingredient);
        //    return Task.FromResult(ingredientDTO);

        //}

        //public Task<UserDTODTO> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        //{
        //    var userDTODTO = new UserDTODTO
        //    {
        //        FirstName = request.FirstName,
        //        LastName = request.LastName,
        //        UserName = request.UserName,
        //        Password = request.Password,
        //        Role = request.Role,
        //        Status = request.Status,
        //        DateCreated = DateTime.Now()
        //    };
        //    _dbContext.SaveChanges();
        //    return Task.FromResult(userDTODTO);
        //}


    }
}
