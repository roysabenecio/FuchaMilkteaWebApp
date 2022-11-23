using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DomainClasses
{
    public class Order : BaseEntity
    {
        //public int MenuId { get; set; } //
        //public int MenuCategoryId { get; set; }
        ////public string Name { get; set; }
        //public int Quantity { get; set; }
        //public double Price { get; set; }
        //public string? AddOn { get; set; }
        //public double? AddOnPrice { get; set; }
        //public int? SizeId { get; set; }

        //public int? SaleId { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Category { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }
        public string? AddOn { get; set; }
        public double? AddOnPrice { get; set; }
        public string? Size { get; set; }
        public int SaleId { get; set; }
    }
}
