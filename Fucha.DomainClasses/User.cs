using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fucha.DomainClasses
{
    public class User : BaseEntity
    {
        //[ForeignKey("Role")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; } // for consideration
        public string UserName { get; set; }
        public string Password { get; set; }

        public DateTime? Created { get; set; }
        public Role Role { get; set; }
        //public PurchaseRecord? PurchaseRecord { get; set; }
    }
}
