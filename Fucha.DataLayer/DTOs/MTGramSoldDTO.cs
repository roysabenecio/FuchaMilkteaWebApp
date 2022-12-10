using Fucha.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.DTOs
{
    public class MTGramSoldDTO
    {
        public int Id { get; set; }
        //public int StockId { get; set; }
        public string? Name { get; set; }
        public double? Grams { get; set; }
        public string? ResetDate { get; set; }

    }
}
