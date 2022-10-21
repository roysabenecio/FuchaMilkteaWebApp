using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fucha.DomainClasses
{
    public class PurchaseRecord: BaseEntity
    {
        
        public string ItemName { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        DateTime DatePurchased { get; set; }

        //supplier, to follow
        public User User { get; set; }
    }
}
