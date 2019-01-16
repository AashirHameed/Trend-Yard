using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trend_Yard.Entities;

namespace Trend_Yard.Database
{
    class TYContext : DbContext
    { // TYContext class will tell DBContext about the business entities. 

        public TYContext() : base("TrendYardConnection")
        {

        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
