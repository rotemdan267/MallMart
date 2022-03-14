using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MallMartDB.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Category Category { get; set; }
        public float? UnitPrice { get; set; }
        public int? UnitsInStock { get; set; }
        public int? UnitsOnOrder { get; set; }  // כמה יחידות הוזמנו ועדיין לא סופקו - בדרך...
        public string Description { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }

    }
}
