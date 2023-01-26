using System.ComponentModel.DataAnnotations;

namespace Fucha.DomainClasses
{
    public class Size : BaseEntity
    {
        [Required]
        public string? Name { get; set; }
    }
}
