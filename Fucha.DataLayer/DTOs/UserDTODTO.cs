using Fucha.DomainClasses;
using Fucha.DomainClasses.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.DTOs
{
    public class UserDTODTO
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public string Email { get; set; } // for consideration
        public string UserName { get; set; }
        public string Password { get; set; }

        public Role Role { get; set; }
        public UserStatus Status { get; set; }
    }
}
