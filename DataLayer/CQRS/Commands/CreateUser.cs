using Fucha.DataLayer.Models;
using Fucha.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class CreateUser
    {
        private FuchaMilkteaContext _dbcontext = new FuchaMilkteaContext();

        public void CreateUserCommand(User userInfo)
        {
            //var newUser = new User();

            var newUser = new User
            {
                Id = userInfo.Id,
                FirstName = userInfo.FirstName,
                LastName = userInfo.LastName,
                Email = userInfo.Email,
                UserName = userInfo.UserName,
                Password = userInfo.Password,
                //Created = DateTime.Now,
                Role = userInfo.Role
            };

            _dbcontext.Users.Add(newUser);
            _dbcontext.SaveChanges();
            //return newUser;
        }
    }
}
