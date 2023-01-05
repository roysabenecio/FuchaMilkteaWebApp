using Fucha.DomainClasses.Enums;

namespace Fucha.DomainClasses
{
    public class PORecord: BaseEntity
    { 
        public string? StockName { get; set; }
        public string? Category { get; set; }
        public double Measure { get; set; }
        public string? MeasurementUnit { get; set; }
        public double Price { get; set; }
        public string? DatePurchased { get; set; }

        public string? Status { get; set; } = "Not Received";
        public int? ReceivedOrders { get; set; } = 0;

        //public int StockId { get; set; }
        public int SupplierId { get; set; }
        public int PurchaseRecordId { get; set; }
    }
}
