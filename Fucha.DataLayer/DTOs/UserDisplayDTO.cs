using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.DTOs
{
    public class UserDisplayDTO
    {
        public int Id { get; set; }

        public string? FirstName { get; set; }

        public string? LastName { get; set; }

        public string? UserName { get; set; }
        //public string? Password { get; set; }
        //public string? Password { get; set; }

        public string? Role { get; set; }
        public string? UserStatus { get; set; }
        public string? DateCreated { get; set; }
        public bool IsRemoved { get; set; }
    }
}
