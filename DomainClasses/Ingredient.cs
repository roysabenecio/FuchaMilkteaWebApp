using Fucha.DomainClasses.Enums;

namespace Fucha.DomainClasses
{
    public class Ingredient: BaseEntity
    {
        public string Name { get; set; }
        public decimal Quantity { get; set; }

        // last updated purchase date
        public DateTime? PurchaseDate { get; set; }
        public IngredientCategory Category { get; set; }
        public QuantityStatus Status { get; set; }
    }
}
