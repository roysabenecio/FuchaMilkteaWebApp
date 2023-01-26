using Fucha.DomainClasses.Enums;

namespace Fucha.DomainClasses
{
    public class StockServing : BaseEntity
    {
        public double? RequiredPerServing { get; set; }
        public MeasurementUnit MeasurementUnit { get; set; }
    }
}
