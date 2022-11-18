using Fucha.DomainClasses.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fucha.DomainClasses
{
    public class PORecord: BaseEntity
    { 
        public int StockId { get; set; }
        public StockCategory Category { get; set; }
        public double Quantity { get; set; }
        public MeasurementUnit MeasurementUnit { get; set; } // nullable

        public double Price { get; set; }
        public string? DatePurchased { get; set; }
        public int PurchaseRecordId { get; set; }

        //supplier, to follow
        //public User? User { get; set; }
    }
}
