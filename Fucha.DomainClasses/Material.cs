using Fucha.DomainClasses.Enums;
using System.ComponentModel.DataAnnotations;

namespace Fucha.DomainClasses
{
    public class Material : BaseEntity
    {
        [Required]
        public string? Name { get; set; }
        
        public double Quantity { get; set; } // nullable
        [Required]
        public string? MeasurementType { get; set; } // nullable
        [Required]
        public string? MaterialCategory { get; set; }
        public string? MaterialStatus { get; set; }

        //public Measurement Measurement { get; set; }
        //public DateTime? PurchaseDate { get; set; }
        //public QuantityStatus Status { get; set; }
        //public MaterialCategory Category { get; set; }
    }
}
