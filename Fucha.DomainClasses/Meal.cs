using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DomainClasses
{
    public class Meal : BaseEntity
    {
        public string Name { get; set; }
        public string MealCategory { get; set; }
        public decimal Price { get; set; }

    }
}
