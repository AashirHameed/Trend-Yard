using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trend_Yard.Entities
{
    public class Product:BaseModelEntity
    {
        public decimal price { get; set; }
        public Category Categoryyy{ get; set; } // One/Each product will be referenced to only one category.
    }
}
