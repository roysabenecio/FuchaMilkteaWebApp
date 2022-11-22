using Fucha.DomainClasses.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fucha.DomainClasses
{
    public class User : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public string Role { get; set; }
        public string UserStatus { get; set; }
        public string? DateCreated { get; set; }
        public bool isRemoved{ get; set; } = false;

    }
}
