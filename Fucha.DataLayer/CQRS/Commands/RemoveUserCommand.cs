using Fucha.DataLayer.Models;
using MediatR;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class RemoveUserCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }

    public class RemoveUserCommmandHandler : IRequestHandler<RemoveUserCommand, bool>
    {
        private readonly IFuchaMilkteaContext _dbContext;
        public RemoveUserCommmandHandler(IFuchaMilkteaContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<bool> Handle(RemoveUserCommand request, CancellationToken cancellationToken)
        {
            if (request.Id == 1)
            {
                return Task.FromResult(false);
            }
            var selectedUser = _dbContext.Users.FirstOrDefault(user => user.Id == request.Id);
            selectedUser.IsRemoved = true;
            _dbContext.SaveChanges();
            return Task.FromResult(selectedUser.IsRemoved);
        }
    }

}