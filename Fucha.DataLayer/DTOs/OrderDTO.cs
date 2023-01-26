using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Fucha.DataLayer.DTOs
{
    public class OrderDTO
    {
        [JsonPropertyName("id")]
        public int MenuId { get; set; }
        public int MenuCategoryId { get; set; }
        [Required]
        public string? Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string? AddOn { get; set; }
        public double? AddOnPrice { get; set; }
        public int? SizeId { get; set; }
    }
}
