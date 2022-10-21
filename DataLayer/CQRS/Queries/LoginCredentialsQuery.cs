using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.CQRS.Queries
{
    public class LoginCredentialsQuery : IRequest<LoginCredentialsDTO>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class LoginCredentialsQueryHandler : IRequestHandler<LoginCredentialsQuery, LoginCredentialsDTO>
    {
        private readonly IFuchaMilkteaContext _dbContext;

        public LoginCredentialsQueryHandler(IFuchaMilkteaContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<LoginCredentialsDTO> Handle(LoginCredentialsQuery request, CancellationToken cancellationToken)
        {
            //var credentials = _dbContext.Users.Select(user => user.UserName == request.UserName).Include(user => user.UserName).Include(user => user.Password);

            var selectedUser = _dbContext.Users.FirstOrDefault(user => user.UserName == request.UserName);

            //var credentials = _dbContext.Users.Select(user => new LoginCredentialsDTO
            //{
            //    UserName = user.UserName,
            //    Password = user.Password,
            //});

            var credentials = new LoginCredentialsDTO()
            {
                UserName = selectedUser.UserName,
                Password = selectedUser.Password,
            };

            //var response = () => new LoginCredentialsDTO
            //{
            //    UserName = credentials.UserName,
            //    Password = credentials.Password
            //};

            return Task.FromResult<LoginCredentialsDTO>(credentials);
        }
    }
}
