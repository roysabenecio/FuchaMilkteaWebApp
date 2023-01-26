using System.ComponentModel.DataAnnotations;

namespace Fucha.DomainClasses
{
    public class Recipe : BaseEntity
    {
        [Required]
        public string? Name { get; set; }
        public bool? HasAddOn { get; set; }

        public int? MenuId { get; set; }
        public int? SizeId { get; set; }
        public int? MenuCategoryId { get; set; }
        public List<RecipeStock>? RecipeStocks { get; set; }
    }
}
