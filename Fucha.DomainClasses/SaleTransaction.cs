namespace Fucha.DomainClasses
{
    public class SaleTransaction: BaseEntity
    {
        //public int OrderId { get; set; }
        //public List<Order>? Orders { get; set; }
        public string DateSold { get; set; }
        public double TotalAmount { get; set; }

        //public Menu MenuItem { get; set; } //Product

        //public int UserId { get; set; }
        // Cashier / User

    }
}
