using Fucha.DomainClasses.Enums;

namespace Fucha.DomainClasses
{
    public class PORecord: BaseEntity
    { 
        public StockCategory Category { get; set; }
        public double Measure { get; set; }
        public MeasurementUnit MeasurementUnit { get; set; }
        public double Price { get; set; }
        public string? DatePurchased { get; set; }

        public int StockId { get; set; }
        public int PurchaseRecordId { get; set; }
    }
}
