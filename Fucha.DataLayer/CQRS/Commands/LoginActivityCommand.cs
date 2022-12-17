using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class LoginActivityCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }

    public class LoginActivityCommandHandler : IRequestHandler<LoginActivityCommand, bool>
    {
        private readonly IFuchaMilkteaContext _context;
        public LoginActivityCommandHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }
        public Task<bool> Handle(LoginActivityCommand request, CancellationToken cancellationToken)
        {
            var description =  "User Logged In";
            var selectUser = _context.Users.FirstOrDefault(u => u.Id == request.Id);

            var newloginHistory = new LoginHistory
            {
                Date = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"),
                Description = description,
                User = selectUser.FirstName + " " + selectUser.LastName,
                Role = selectUser.Role
            };
            _context.LoginHistories.Add(newloginHistory);
            _context.SaveChanges();
            return Task.FromResult(true);
        }
    }
}
