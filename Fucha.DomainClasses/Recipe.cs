using Fucha.DomainClasses.Enums;

namespace Fucha.DomainClasses
{
    public class Recipe: BaseEntity
    {
        public string Name { get; set; }

        //formula or measure
        public Size Size { get; set; }
        public Measurement RequiredMeasure { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<Material> Materials { get; set; }
    }
}
