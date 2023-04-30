using Fucha.DataLayer.Models;
using MediatR;
using Fucha.DomainClasses;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class RegisterCommand : IRequest<bool>
    {
        //public int UserId { get; set; } = 10;
        //public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        //public string UserStatus { get; set; }
    }

    public class RegisterUserCommandHandler : IRequestHandler<RegisterCommand, bool>
    {
        //public IMapper Mapper { get; set; }
        private readonly IFuchaMilkteaContext _dbContext;

        public RegisterUserCommandHandler(IFuchaMilkteaContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<bool> Handle(RegisterCommand request, CancellationToken cancellationToken)
        {
            //var actor = _dbContext.Users.FirstOrDefault(x => x.Id == request.UserId);
            var actor = _dbContext.Users.FirstOrDefault(x => x.Id == 0);
            CreatePasswordHash(request.Password, out byte[] passwordHash, out byte[] passwordSalt);
            var newUser = new User
            {
                FirstName = request.FirstName,
                LastName = request.LastName,
                UserName = request.UserName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Role = request.Role,
                //UserStatus = actor != null ? "Approved" : request.UserStatus,
                UserStatus = "Pending",
                DateCreated = DateTime.Now.ToString("dddd, dd MMMM yyyy")
            };
            _dbContext.Users.Add(newUser);

            if (actor != null)
            {
                // Add activity
                var actorFullName = actor.FirstName + " " + actor.LastName;
                var newUserFullName = newUser.FirstName + " " + newUser.LastName;
                var activityDescription = $"Added user {newUserFullName}";
                var newActivity = new ActivityHistory
                {
                    User = actorFullName,
                    Activity = activityDescription,
                    Module = "User",
                    Date = DateTime.Now.ToString("MM/dd/yyyy HH:mm")
                };
                _dbContext.ActivityHistories.Add(newActivity);
            }
            
            _dbContext.SaveChanges();
            return Task.FromResult(true);
        }

        private void CreatePasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA256())
            {
                passwordSalt = hmac.Key;
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }
    }
}
