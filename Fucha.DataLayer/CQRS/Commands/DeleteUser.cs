using Fucha.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.CQRS.Commands
{
    public class DeleteUser
    {
        private static FuchaMilkteaContext _dbcontext = new FuchaMilkteaContext();

       
        public void DeleteUserCommand(DeleteUserRequest request)
        {
            var selectedUser = _dbcontext.Users.FirstOrDefault(user => user.Id == request.UserId);
            //var selectedUserDTO = 
            _dbcontext.Users.Remove(selectedUser);

            _dbcontext.SaveChanges();
        }
    }

    public class DeleteUserRequest
    {
        public int UserId { get; set; }
    }
}
