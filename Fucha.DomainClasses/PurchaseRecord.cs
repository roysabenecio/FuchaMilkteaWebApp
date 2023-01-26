namespace Fucha.DomainClasses
{
    public class PurchaseRecord : BaseEntity
    {
        public int? ItemQuantity { get; set; }
        public double? TotalAmount { get; set; }
        public string? DatePurchased { get; set; }

        public int? SupplierId { get; set; }
        public int UserId { get; set; }
    }
}
