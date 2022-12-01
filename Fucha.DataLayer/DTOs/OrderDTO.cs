using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Fucha.DataLayer.DTOs
{
    public class OrderDTO
    {
        //[Key]
        //public int OrderId { get; set; }
        //[ForeignKey("Menu")]
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

        //public int? SaleId { get; set; } = 100;
    }
}
