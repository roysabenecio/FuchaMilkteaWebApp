using Fucha.DomainClasses.Enums;
using System.ComponentModel.DataAnnotations;

namespace Fucha.DomainClasses
{
    public class Stock : BaseEntity
    {
        [Required]
        public string? Name { get; set; }
        public double? Measure { get; set; }
        public MeasurementUnit MeasurementUnit { get; set; }
        public StockCategory Category { get; set; }
        public QuantityStatus? Status { get; set; }
        public string? DateAdded { get; set; }
        public string? LastRestocked { get; set; }
        public bool IsRemoved { get; set; } = false;

        public int? SupplierId { get; set; }
        public int? StockServingId { get; set; }
    }
}
