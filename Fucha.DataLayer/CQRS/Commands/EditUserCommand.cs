using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class EditUserCommand : IRequest<User>
    {
        public EditUserCommand(int id, User user)
        {
            Id = id;
            User = user;
        }
        public int Id { get; set; }
        public User User { get; set; }
    }

    public class EditUserCommandHandler : IRequestHandler<EditUserCommand, User>
    {
        private readonly IFuchaMilkteaContext _context;
        public EditUserCommandHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }

        public Task<User> Handle(EditUserCommand request, CancellationToken cancellationToken)
        {
            var selectedUser = _context.Users.FirstOrDefault(x => x.Id == request.Id);
            selectedUser.FirstName = request.User.FirstName;
            selectedUser.LastName = request.User.LastName;
            selectedUser.LastName = request.User.LastName;
            selectedUser.Password = request.User.Password;
            selectedUser.Role = request.User.Role;
            selectedUser.UserStatus = request.User.UserStatus;
            _context.SaveChanges();

            return Task.FromResult(selectedUser);
        }
    }
}
