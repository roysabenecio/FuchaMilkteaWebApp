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
    public class RemoveUserCommand : IRequest<User>
    {
        public int Id { get; set; }
    }

    public class RemoveUserCommmandHandler : IRequestHandler<RemoveUserCommand, User>
    {
        private readonly IFuchaMilkteaContext _dbContext;
        public RemoveUserCommmandHandler(IFuchaMilkteaContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<User> Handle(RemoveUserCommand request, CancellationToken cancellationToken)
        {
            var selectedUser = _dbContext.Users.FirstOrDefault(user => user.Id == request.Id);
            _dbContext.Users.Remove(selectedUser);
            _dbContext.SaveChanges();
            return Task.FromResult(selectedUser);
        }
    }

}
