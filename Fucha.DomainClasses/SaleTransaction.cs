using System.ComponentModel.DataAnnotations;

namespace Fucha.DomainClasses
{
    public class SaleTransaction: BaseEntity
    {
        public int ItemQuantity { get; set; }
        [Required]
        public string? DateSold { get; set; }
        public double TotalSales { get; set; }
        public int UserId { get; set; }
    }
}
