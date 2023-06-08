using Shopzu.Entities;
using System.Data.Entity;

namespace Shopzu.Database
{
    public class SZContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}