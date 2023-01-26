using Fucha.DomainClasses.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fucha.DomainClasses
{
    public class Menu : BaseEntity
    {
        [Required]
        public string? Name { get; set; }
        public int MenuCategoryId { get; set; }
    }
}
