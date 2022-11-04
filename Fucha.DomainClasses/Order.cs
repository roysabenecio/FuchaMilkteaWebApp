using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DomainClasses
{
    public class Order : BaseEntity
    {
        public int? MenuId { get; set; }
        //public List<Menu>? Menus { get; set; }
        public int? OrderQuantity { get; set; }
        public int? SaleId { get; set; }
        //public Sale? Sale { get; set; }
    }
}
