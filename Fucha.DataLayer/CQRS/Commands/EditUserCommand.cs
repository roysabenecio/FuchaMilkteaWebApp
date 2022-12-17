using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;
using System.Security.Cryptography;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class EditUserCommand : IRequest<User>
    {
        //public EditUserCommand(int id, UserDTO user)
        //{
        //    Id = id;
        //    User = user;
        //}
        //public int Id { get; set; }
        //public UserDTO User { get; set; }
        public int Id { get; set; }
        public int UserId { get; set; }

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

    public class EditUserCommandHandler : IRequestHandler<EditUserCommand, User>
    {
        private readonly IFuchaMilkteaContext _context;
        public EditUserCommandHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }

        public Task<User> Handle(EditUserCommand request, CancellationToken cancellationToken)
        {
            //CreatePasswordHash(request.User.Password, out byte[] passwordHash, out byte[] passwordSalt);

            var actor = _context.Users.FirstOrDefault(x => x.Id == request.UserId);

            var selectedUser = _context.Users.FirstOrDefault(x => x.Id == request.Id);
            selectedUser.FirstName = request.FirstName;
            selectedUser.LastName = request.LastName;
            selectedUser.UserName = request.UserName;
            //selectedUser.PasswordHash = passwordHash;
            //selectedUser.PasswordSalt = passwordSalt;
            selectedUser.Role = request.Role;
            selectedUser.UserStatus = request.UserStatus;

            // Add activity
            var fullName = actor.FirstName + " " + actor.LastName;
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

            return Task.FromResult(selectedUser);
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
