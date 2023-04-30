namespace Fucha.DataLayer.DTOs
{
    public class OrderDisplayDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Category { get; set; }
        public double Price { get; set; }
        public string? AddOn { get; set; }
        public double AddOnPrice { get; set; }
        public string? Size { get; set; }
    }
}
