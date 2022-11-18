using Fucha.DomainClasses.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fucha.DomainClasses
{
    public class PurchaseRecord : BaseEntity
    {
        public int ItemQuantity { get; set; }
        public double TotalAmount { get; set; }
        public string? DatePurchased { get; set; }
        //public PRStatus Status { get; set; }

        public int SupplierId { get; set; }

        //public int PurchaseRecordId { get; set; }

        //public User? User { get; set; }
    }
}
