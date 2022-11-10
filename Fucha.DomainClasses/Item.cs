using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DomainClasses
{
    public class Item : BaseEntity
    {
        public string Name { get; set; }
        public double Quantity { get; set; } // nullable
        public string MeasurementUnit { get; set; } // nullable
        public string ItemCategory { get; set; }
        public string? ItemStatus { get; set; }
    }
}
