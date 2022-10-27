using Fucha.DomainClasses.Enums;

namespace Fucha.DomainClasses
{
    public class Ingredient: BaseEntity
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Quantity { get; set; }
        public string? IngredientStatus { get; set; }

        // last updated purchase date
        //public DateTime? PurchaseDate { get; set; }
        //public int Category { get; set; }
        //public int Status { get; set; }
    }
}
