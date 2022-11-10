using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DomainClasses
{
    public class AddOn : BaseEntity
    {
        public string Name { get; set; }
        public double AddOnPrice { get; set; }
    }
}
