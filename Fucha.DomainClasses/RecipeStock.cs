namespace Fucha.DomainClasses
{
    public class RecipeStock : BaseEntity
    {
        public int RecipeId { get; set; }
        public Recipe? Recipe { get; set; }

        public int StockId { get; set; }
        public Stock? Stock { get; set; }
    }
}
