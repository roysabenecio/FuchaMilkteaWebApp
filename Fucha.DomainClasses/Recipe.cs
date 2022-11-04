using Fucha.DomainClasses.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fucha.DomainClasses
{
    public class Recipe: BaseEntity
    {
        public string RecipeCategory { get; set; }
        public string Name { get; set; }

        //formula or measure
        
        public string Size { get; set; }
        //public Measurement RequiredMeasure { get; set; }
        //public decimal RequiredMeasure { get; set; }
        //public string MeasureType { get; set; }

        //[ForeignKey("IngredientId")]
        //
        public Ingredient Ingredient { get; set; }
        public int IngredientId { get; set; }
        //public List<Ingredient>? Ingredients { get; set; }
        //public List<Material>? Materials { get; set; }
        public decimal Price { get; set; }
    }
}
