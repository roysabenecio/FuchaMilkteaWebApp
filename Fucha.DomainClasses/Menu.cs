using System.ComponentModel.DataAnnotations;

namespace Fucha.DomainClasses
{
    public class Menu : BaseEntity
    {
        [Required]
        public string? Name { get; set; }
        public int MenuCategoryId { get; set; }
    }
}
