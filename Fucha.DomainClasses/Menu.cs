using Fucha.DomainClasses.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fucha.DomainClasses
{
    public class Menu : BaseEntity
    {
        //public string Name { get; set; }
        ////public MilkTeaSpecification Specification { get; set; }
        //public int MenuCategoryId { get; set; }
        //public int? SizeId { get; set; }
        //public string? Size { get; set; }
        //public double Price { get; set; }

        //public decimal? AddOnsPrice { get; set; }

        //public MenuStatus MenuStatus { get; set; }
        //List<string>? AddOns { get; set; }

        //List<Recipe> Recipes { get; set; }

        public string Name { get; set; }
        public int MenuCategoryId { get; set; }
    }
}
