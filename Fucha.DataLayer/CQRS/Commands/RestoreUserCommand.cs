using Fucha.DataLayer.Models;
using MediatR;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class RestoreUserCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }

    public class RestoreUserCommandHandler : IRequestHandler<RestoreUserCommand, bool>
    {
        private readonly IFuchaMilkteaContext _dbContext;
        public RestoreUserCommandHandler(IFuchaMilkteaContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<bool> Handle(RestoreUserCommand request, CancellationToken cancellationToken)
        {
            var selectedUser = _dbContext.Users.FirstOrDefault(user => user.Id == request.Id);
            selectedUser.IsRemoved = false;
            _dbContext.SaveChanges();
            return Task.FromResult(selectedUser.IsRemoved);
        }
    }

}
