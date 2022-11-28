using Fucha.DomainClasses.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DomainClasses
{
    public class R : BaseEntity
    {
        public int MenuId { get; set; }
        public int? SizeId { get; set; }
        public int? AddOnId { get; set; }
        //public double RequiredMeasure { get; set; }

        //public MeasurementUnit MeasurementUnit { get; set; }
        public List<Stock>? Stocks { get; set; }
    }
}
