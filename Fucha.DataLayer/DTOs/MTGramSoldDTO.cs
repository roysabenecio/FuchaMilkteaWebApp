namespace Fucha.DataLayer.DTOs
{
    public class MTGramSoldDTO
    {
        public int Id { get; set; }
        //public int StockId { get; set; }
        public string? Name { get; set; }
        public double? GramsSold { get; set; }
        public string? ResetDate { get; set; }
        public double? PreviousMeasure { get; set; }
        public string? Status { get; set; }

    }
}
