using System.ComponentModel.DataAnnotations;

namespace Fucha.DomainClasses
{
    public class Supplier : BaseEntity
    {
        [Required]
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? ContactNumber { get; set; }
        public string? DateAdded { get; set; }
        public bool IsRemoved { get; set; } = false;
    }
}
