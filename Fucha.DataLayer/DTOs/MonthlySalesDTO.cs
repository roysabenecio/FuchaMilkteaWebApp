using Fucha.DomainClasses.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.DTOs
{
    public class MonthlySalesDTO
    {
        public string Month { get; set; }
        public double TotalSale { get; set; }
    }
}
