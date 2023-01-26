using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using MediatR;
using System.Security.Cryptography;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class EditProfileCommand : IRequest<bool>
    {
        public EditProfileCommand(int id, ProfileDTO profile)
        {
            UserId = id;
            Profile = profile;
        }
        public int UserId { get; set; }
        public ProfileDTO Profile { get; set; }
    }

    public class EditProfileCommandHandler : IRequestHandler<EditProfileCommand, bool>
    {
        private readonly IFuchaMilkteaContext _context;
        public EditProfileCommandHandler(IFuchaMilkteaContext context)
        {
            _context = context;
        }

        public Task<bool> Handle(EditProfileCommand request, CancellationToken cancellationToken)
        {
            var user = _context.Users.FirstOrDefault(u => u.Id == request.UserId);

            if (VerifyPasswordHash(request.Profile.CurrentPassword, user.PasswordHash, user.PasswordSalt))
            {
                CreatePasswordHash(request.Profile.NewPassword, out byte[] passwordHash, out byte[] passwordSalt);
                user.PasswordHash = passwordHash;
                user.PasswordSalt = passwordSalt;
                user.FirstName = request.Profile.FirstName;
                user.LastName = request.Profile.LastName;
                user.UserName = request.Profile.UserName;

                _context.SaveChanges();

                return Task.FromResult(true);
            }
            else
            {
                return Task.FromResult(false);
            }
        }

        private bool VerifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new HMACSHA256(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
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
