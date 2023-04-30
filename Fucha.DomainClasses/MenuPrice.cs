namespace Fucha.DomainClasses
{
    public class MenuPrice : BaseEntity
    {
        public double Price { get; set; }
        public int? MenuId { get; set; }
        public int MenuCategoryId { get; set; }
        public int? SizeId { get; set; }
    }
}
