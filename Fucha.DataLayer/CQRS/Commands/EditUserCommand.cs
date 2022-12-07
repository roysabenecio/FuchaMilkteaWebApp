using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;
using System.Security.Cryptography;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class EditUserCommand : IRequest<User>
    {
        public EditUserCommand(int id, UserDTO user)
        {
            Id = id;
            User = user;
        }
        public int Id { get; set; }
        public UserDTO User { get; set; }
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
            CreatePasswordHash(request.User.Password, out byte[] passwordHash, out byte[] passwordSalt);

            var selectedUser = _context.Users.FirstOrDefault(x => x.Id == request.Id);
            selectedUser.FirstName = request.User.FirstName;
            selectedUser.LastName = request.User.LastName;
            selectedUser.UserName = request.User.UserName;
            selectedUser.PasswordHash = passwordHash;
            selectedUser.PasswordSalt = passwordSalt;
            selectedUser.Role = request.User.Role;
            selectedUser.UserStatus = request.User.UserStatus;
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
