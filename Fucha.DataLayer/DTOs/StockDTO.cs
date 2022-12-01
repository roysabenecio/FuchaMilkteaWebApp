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
        public string? Name { get; set; }
        public double Measure { get; set; }
        public string MeasurementUnit { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
        public string? DateAdded { get; set; }
        public string? LastRestocked { get; set; }
        public string? Supplier { get; set; }
        public bool IsRemoved { get; set; }
    }
}
