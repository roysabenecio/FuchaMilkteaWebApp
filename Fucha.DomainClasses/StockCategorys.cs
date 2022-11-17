using Fucha.DomainClasses.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DomainClasses
{
    public class StockCategorys : BaseEntity
    {
        public string Name { get; set; }
        public MeasurementUnit MeasurementUnit { get; set; }
        public int SupplierId { get; set; }
    }
}
