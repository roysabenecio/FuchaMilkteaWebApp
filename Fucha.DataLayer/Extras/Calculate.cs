namespace Fucha.DataLayer.Extras
{
    public class Calculate
    {
        public double AutoCalculate(double? requiredMeasure, int recipeMeasurementUnit, int stockMeasurementUnit)
        {
            var value = 0.0;
            if (recipeMeasurementUnit == 0 && stockMeasurementUnit == 1)
            {
                value = GToKg((double)requiredMeasure);
            }
            if (recipeMeasurementUnit == 3 && stockMeasurementUnit == 3)
            {
                value = (double)requiredMeasure;
            }

            return value;
        }
        public double GToKg(double kg)
        {
            return kg /= 1000;
        }

        public double KgToG(double g)
        {
            return g *= 1000;
        }
    }
}
