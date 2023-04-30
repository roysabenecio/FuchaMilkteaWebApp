namespace Fucha.DomainClasses
{
    public class MTGramSold : BaseEntity
    {
        public int StockId { get; set; }
        public string? Name { get; set; }
        public double? Grams { get; set; }
        public string? ResetDate { get; set; }
        public double? PreviousMeasure { get; set; }
    }
}