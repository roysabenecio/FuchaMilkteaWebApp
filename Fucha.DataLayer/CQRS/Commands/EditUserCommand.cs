using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;
using System.Security.Cryptography;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class EditUserCommand : IRequest<bool>
    {
        //public EditUserCommand(int id, UserDTO user)
        //{
        //    Id = id;
        //    User = user;
        //}
        //public int Id { get; set; }
        //public UserDTO User { get; set; }
        public int Id { get; set; }
        public int ActorId { get; set; }

        public string? FirstName { get; set; }
        
        public string? LastName { get; set; }

        public string? UserName { get; set; }
        //public string? Password { get; set; }
        //public string Password { get; set; }

        public string? Role { get; set; }
        public string? UserStatus { get; set; }
        public string? DateCreated { get; set; }
        //public bool IsRemoved { get; set; }
    }

    public class EditUserCommandHandler : IRequestHandler<EditUserCommand, bool>
    {
        private readonly IFuchaMilkteaContext _context;
        public EditUserCommandHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }

        public Task<bool> Handle(EditUserCommand request, CancellationToken cancellationToken)
        {
            //CreatePasswordHash(request.User.Password, out byte[] passwordHash, out byte[] passwordSalt);

            var actor = _context.Users.FirstOrDefault(x => x.Id == request.ActorId);

            var selectedUser = _context.Users.FirstOrDefault(x => x.Id == request.Id);
            selectedUser.FirstName = request.FirstName != null ? request.FirstName : selectedUser.FirstName;
            selectedUser.LastName = request.LastName != null ? request.LastName : selectedUser.LastName;
            selectedUser.UserName = request.UserName != null ? request.UserName : selectedUser.UserName;
            //selectedUser.PasswordHash = passwordHash;
            //selectedUser.PasswordSalt = passwordSalt;
            selectedUser.Role = request.Role != null ? request.Role : selectedUser.Role;
            selectedUser.UserStatus = request.UserStatus != null ? request.UserStatus : selectedUser.UserStatus;

            // Add activity
            var fullName = selectedUser.FirstName + " " + selectedUser.LastName;
            var activityDescription = $"Edited user {fullName}";
            var newActivity = new ActivityHistory
            {
                User = actor.FirstName + " " + actor.LastName,
                Activity = activityDescription,
                Module = "User",
                Date = DateTime.Now.ToString("MM/dd/yyyy HH:mm")
            };
            _context.ActivityHistories.Add(newActivity);
            _context.SaveChanges();

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
