using Fucha.DomainClasses.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fucha.DomainClasses
{
    public class Recipe : BaseEntity
    {
        public int MenuId { get; set; }
        //public string Name { get; set; }

        //public int MenuCategoryId { get; set; }

        //formula or measure
        
        public int? SizeId { get; set; }
        public int? AddOnId { get; set; }
        public double RequiredMeasure { get; set; }

        public MeasurementUnit MeasurementUnit { get; set; }
        //public Measurement RequiredMeasure { get; set; }
        //public decimal RequiredMeasure { get; set; }
        //public string MeasureType { get; set; }

        //[ForeignKey("IngredientId")]
        //
        //public Ingredient Ingredient { get; set; }
        //public int IngredientId { get; set; }
        //public List<Ingredient>? Ingredients { get; set; }
        //public List<Material>? Materials { get; set; }
        //public double Price { get; set; }
    }
}
