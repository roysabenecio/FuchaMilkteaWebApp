using Fucha.DomainClasses;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Fucha.DataLayer.Models.sampleSeeder
{
    internal class sampleSupplier
    {
        public sampleSupplier()
        {
            var suppliers = new[]
            {
                new Supplier { Id = 1, Name = "In joy", Address = "157 Josefa Drive Brgy, Corazon De Jesus, San Juan City", ContactNumber = "09178077279", DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Supplier { Id = 2, Name = "PHNI Bubble Tea Store", Address = "208A Banawe St., Brgy Tatalon, Quezon City", ContactNumber = "09175858100", DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Supplier { Id = 3, Name = "MSCS PrimeGoods, Inc.", Address = "San Juan Manila", ContactNumber = "09171284151", DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Supplier { Id = 4, Name = "Fuji Mart Incorporated", Address = "1747 A. Mabini St, Malate, Manila, 1004 Metro Manila", ContactNumber = "(02) 8523 1186", DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Supplier { Id = 5, Name = "Consistent Frozen Solutions", Address = "2329 Juan Luna St, Gagalangin, Manila, Metro Manila", ContactNumber = "09985172380", DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Supplier { Id = 6, Name = "FST Egg Store", Address = "40 Scout Oscar M. Alcaraz St, Santa Mesa Heights, Quezon City, 1114 Metro Manila", ContactNumber = "09171735588", DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Supplier { Id = 7, Name = "Pizza Crust", Address = "#24 F Pasco Aveue Santolan, Pasig", ContactNumber = "09955823086", DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Supplier { Id = 8, Name = "Negosyo Now", Address = "704 Rizal Ave. ext.Caloocan City, Metro Manil, 1403", ContactNumber = "09955823086", DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Supplier { Id = 9, Name = "Vostra Pizza", Address = "Metro Manila", ContactNumber = "09955823086", DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Supplier { Id = 10, Name = "Golden Fishball Factory", Address = "837 Asuncion St, Binondo, Manila, 2006 Metro Manila", ContactNumber = "09971220886", DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Supplier { Id = 11, Name = "Siomai Wholesale Supplier PH", Address = "San Roque, Antipolo", ContactNumber = "09610074035", DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Supplier { Id = 12, Name = "JD FOODS Premium Sauces", Address = "1005 Atlanta Centre Bldg., 31 Annapolis St., Greenhills, San Juan City", ContactNumber = "721-339-47", DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
                new Supplier { Id = 13, Name = "Easy Brand Ph", Address = "7F Steelworld Bldg. 713 N.S. Amoranto Sr. corner Biak na Bato Street, Quezon City", ContactNumber = "09286418135", DateAdded = DateTime.Now.ToString("dddd, dd MMMM yyyy") },
            }; 



        }

    }
}
