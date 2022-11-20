using Fucha.DomainClasses;
using Fucha.DomainClasses.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.DTOs
{
    public class StockDTO : BaseEntity
    {
        public string Name { get; set; }
        public double Measure { get; set; } // nullable
        public string MeasurementUnit { get; set; } // nullable
        public string StockCategory { get; set; }
        public string StockStatus { get; set; }
        //public string? ItemStatus { get; set; }
        public string? DateAdded { get; set; }
        public string? LastRestocked { get; set; }

        public string Supplier { get; set; }
    }
}
