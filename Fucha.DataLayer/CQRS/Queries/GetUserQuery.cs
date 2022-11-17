using Fucha.DataLayer.DTOs;
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
    public class GetUserQuery : IRequest<User>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, User>
    {
        private readonly IFuchaMilkteaContext _dbContext;

        public GetUserQueryHandler(IFuchaMilkteaContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<User> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {


            var selectedUser = _dbContext.Users.FirstOrDefault(user => user.UserName == request.UserName);
            if (selectedUser == null || (selectedUser.Password != request.Password && selectedUser.UserName != request.UserName))
            {
                selectedUser = new User();
                return Task.FromResult<User>(selectedUser);
            }

            return Task.FromResult<User>(selectedUser);

            //if (selectedUser.UserName == request.UserName && selectedUser.Password == request.Password)
            //{
            //    return Task.FromResult<User>(selectedUser);
            //} 
            //else
            //{
            //    return null;
            //}
            //var response = _dbContext.Users.FirstOrDefault(user => user.UserName == request.UserName);

        }
    }
}
