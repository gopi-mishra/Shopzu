using Shopzu.Entitie;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopzu.Databases
{
    public class SZContext : DbContext
    {
        public SZContext() : base("ShopzuConnection") 
        { 
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
