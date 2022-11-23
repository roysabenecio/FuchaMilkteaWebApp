using System.ComponentModel.DataAnnotations;

namespace Fucha.DomainClasses
{
    public class AddOn : BaseEntity
    {
        [Required]
        public string? Name { get; set; }
        public double AddOnPrice { get; set; }
    }
}
