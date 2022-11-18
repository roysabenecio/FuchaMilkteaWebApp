using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DomainClasses
{
    public class Supplier : BaseEntity
    {
        public string Name { get; set; }
        public string? Address { get; set; }
        //public string? ContactPerson { get; set; }
        public long ContactNumber { get; set; }
        public string DateAdded { get; set; }


        //string? DatePurchased { get; set; }

        ////supplier, to follow
        //public User User { get; set; }
    }
}
