using System.ComponentModel.DataAnnotations;

namespace Fucha.DataLayer.DTOs
{
    public class OrderReportDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        [Required]
        public string? Category { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string? AddOn { get; set; }
        public double? AddOnPrice { get; set; }
        public string? Size { get; set; }
        public string? Date { get; set; }
        public string? Cashier { get; set; }
        public int SaleId { get; set; }
    }
}
