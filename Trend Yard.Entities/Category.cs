using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trend_Yard.Entities
{
    public class Category:BaseModelEntity
    {
        public List<Product> Products { get; set; } // A category has the list of products and one cateory can be referenced to multiple products.
    }
}
