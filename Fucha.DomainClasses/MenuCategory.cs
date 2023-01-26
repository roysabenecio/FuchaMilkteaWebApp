using System.ComponentModel.DataAnnotations;

namespace Fucha.DomainClasses
{
    public class MenuCategory : BaseEntity
    {
        [Required]
        public string? Name { get; set; }
    }
}
