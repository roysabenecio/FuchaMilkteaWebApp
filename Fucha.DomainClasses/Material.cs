using Fucha.DomainClasses.Enums;

namespace Fucha.DomainClasses
{
    public class Material : BaseEntity
    {
        public string Name { get; set; }
        public decimal Quantity { get; set; }

        public Measurement Measurement { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public QuantityStatus Status { get; set; }
        public MaterialCategory Category { get; set; }
    }
}
