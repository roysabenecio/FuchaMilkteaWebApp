using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DomainClasses
{
    public class MilkTea : BaseEntity
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public decimal Price { get; set; }
    }
}
