﻿namespace Fucha.DomainClasses
{
    public class Sale: BaseEntity
    {
        public DateTime DateSold { get; set; }
        public decimal TotalAmount { get; set; }

        public Menu MenuItem { get; set; } //Product

        public int UserId { get; set; }
        // Cashier / User

    }
}
