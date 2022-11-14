using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fucha.DataLayer.DTOs
{
    public class MenuDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public int MenuCategoryId { get; set; }
        public string MenuCategory { get; set; }
    }
}
