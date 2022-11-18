using Fucha.DomainClasses.Enums;
using Fucha.DomainClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.DTOs
{
    public class PurchaseRecordsDTO
    {
        public int Id { get; set; }
        public string Item { get; set; }
        public string Category { get; set; }
        public double Measure { get; set; } // nullable
        public string MeasurementUnit { get; set; } // nullable
        public string Supplier { get; set; }
        public double Price { get; set; }
        public string DatePurchased { get; set; }
        //public string Status { get; set; }
        public int PurchaseRecordId { get; set; }
    }
}
