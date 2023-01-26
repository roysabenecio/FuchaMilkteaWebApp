using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fucha.DomainClasses
{
    public class Supplier : BaseEntity
    {
        [Required]
        public string? Name { get; set; }
        public string? Address { get; set; }
        [JsonPropertyName("Contact Person")]
        public string? ContactPerson { get; set; }
        [JsonPropertyName("Contact Number")]
        public string? ContactNumber { get; set; }
        public string? Email { get; set; }
        public string? DateAdded { get; set; }
        public bool IsRemoved { get; set; } = false;
    }
}
