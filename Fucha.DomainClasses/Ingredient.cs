using Fucha.DomainClasses.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fucha.DomainClasses
{
    public class Ingredient: BaseEntity
    {
        public string Name { get; set; }
        public string IngredientCategory { get; set; }
        public decimal Quantity { get; set; } // nullable
        public string MeasurementType { get; set; } // nullable
        public string? IngredientStatus { get; set; }

        //[ForeignKey("RecipeId")]
        //public int RecipeId { get; set; }
        public Recipe? Recipe { get; set; }

        //[ForeignKey("RecipeIds")]
        //public List<Recipe>? Recipes { get; set; }

        // last updated purchase date
        //public DateTime? PurchaseDate { get; set; }
        //public int Category { get; set; }
        //public int Status { get; set; }
    }
}
