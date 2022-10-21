using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using MediatR;
using Fucha.Application;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Fucha.DomainClasses;

namespace Fucha.DataLayer.CQRS.Queries
{
    public class GetAllUsersQuery : IRequest<List<UserDTO>>
    {

    }

    public class GetUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<UserDTO>>
    {
        private readonly IFuchaMilkteaContext _dbContext;

        public GetUsersQueryHandler(IFuchaMilkteaContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<UserDTO>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            var allUsers = _dbContext.Users.Select(user => new UserDTO
            {
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                UserName = user.UserName,
                Role = user.Role
            }).ToList();
            return Task.FromResult<List<UserDTO>>(allUsers);
        }
    }
}
