using Fucha.DataLayer.DTOs;
using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class EditUser
    {
        private static FuchaMilkteaContext _dbcontext = new FuchaMilkteaContext();

        public void EditUserCommand(EditUserRequest request)
        {
            var selectedUser = _dbcontext.Users.FirstOrDefault(user => user.Id == request.Id);

            selectedUser.FirstName = request.FirstName;
            selectedUser.LastName = request.LastName;
            selectedUser.Email = request.Email;
            selectedUser.Password = request.Password;
            selectedUser.Role = request.Role;

            _dbcontext.SaveChanges();

        }
    }

    public class EditUserRequest : User
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; } // for consideration
        public string? UserName { get; set; }
        public string? Password { get; set; }
    }
}
