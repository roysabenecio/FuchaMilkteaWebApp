using Fucha.Application;
using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class LoginUserCommand : IRequest<object>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }

    public class LoginCommandHandler : IRequestHandler<LoginUserCommand, object>
    {
        private readonly IFuchaMilkteaContext _context;
        private readonly IConfiguration _configuration;
        public LoginCommandHandler(IFuchaMilkteaContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }

        public Task<object> Handle(LoginUserCommand request, CancellationToken cancellationToken)
        {
            //var selectedUser = _context.Sample.FirstOrDefault(x => x.Id == request.Id);
            //selectedUser.FirstName = request.User.FirstName;
            //selectedUser.LastName = request.User.LastName;
            //selectedUser.UserName = request.User.UserName;
            //selectedUser.Password = request.User.Password;
            //selectedUser.Role = request.User.Role;
            //selectedUser.UserStatus = request.User.UserStatus;
            //_context.SaveChanges();
            var userInfo = _context.Users.FirstOrDefault(x => x.UserName == request.UserName);

            if (userInfo == null || userInfo.IsRemoved == true)
            {
                string userNotFound = "User Not Found";
                object obj = new { userNotFound };
                return Task.FromResult(obj);
            }
            else
            {
                object obj;
                if (!VerifyPasswordHash(request.Password, userInfo.PasswordHash, userInfo.PasswordSalt))
                {
                    string wrongPassword = "Wrong Password";
                    obj = new { wrongPassword };
                    return Task.FromResult(obj);
                }
                if (userInfo.UserStatus == "Pending")
                {
                    string accountPending = "Account is pending. Please contact the administrator.";
                    obj = new { accountPending };
                    return Task.FromResult(obj);
                }
                string token = CreateToken(userInfo);
                var ok = userInfo;
                obj = new { token, ok };
                return Task.FromResult(obj);
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
        private string CreateToken(User user)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, user.FirstName),
                //new Claim(ClaimTypes.Surname, user.LastName),
                //new Claim(ClaimTypes.Name, user.UserName),
                //new Claim(ClaimTypes.Role, user.Role),
            };

            var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes(
                _configuration.GetSection("AppSettings:Token").Value));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);

            var token = new JwtSecurityToken(
                claims: claims,
                expires: DateTime.Now.AddMinutes(5),
                signingCredentials: creds
                );

            var jwt = new JwtSecurityTokenHandler().WriteToken(token);

            return jwt;
        }
    }
}

