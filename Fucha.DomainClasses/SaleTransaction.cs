﻿using System.ComponentModel.DataAnnotations;

namespace Fucha.DomainClasses
{
    public class SaleTransaction: BaseEntity
    {
        //public int OrderId { get; set; }
        //public List<Order>? Orders { get; set; }
        public int ItemQuantity { get; set; }
        [Required]
        public string? DateSold { get; set; }
        public double TotalSales { get; set; }
        public int UserId { get; set; }

        //public Menu MenuItem { get; set; } //Product

        //public int UserId { get; set; }
        // Cashier / User

    }
}
