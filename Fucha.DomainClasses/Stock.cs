using Fucha.DomainClasses.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DomainClasses
{
    public class Stock : BaseEntity
    {
        public string Name { get; set; }
        public double Measure { get; set; } // nullable
        public MeasurementUnit MeasurementUnit { get; set; } // nullable
        public StockCategory StockCategory { get; set; }
        public QuantityStatus StockStatus { get; set; }
        //public string? ItemStatus { get; set; }
        public string? DateAdded { get; set; }
        public string? LastRestocked { get; set; }

        public int SupplierId { get; set; }
    }
}
