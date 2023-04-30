namespace Fucha.DataLayer.DTOs
{
    public class SaleTransactionDTO
    {
        public int Id { get; set; }
        public int ItemQuantity { get; set; }
        public DateTime DateSold { get; set; }
        public double TotalSales { get; set; }
        public string? User { get; set; }
    }
}
