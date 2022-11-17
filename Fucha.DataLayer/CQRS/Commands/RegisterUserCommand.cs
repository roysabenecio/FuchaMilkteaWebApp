using Fucha.DataLayer.Models;
using MediatR;
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
    }
}
