using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.DTOs
{
    public class SaleTransactionDTO
    {
        public int Id { get; set; }
        public int ItemQuantity { get; set; }
        public string? DateSold { get; set; }
        public double TotalSales { get; set; }
        public string? User{ get; set; }
    }
}
