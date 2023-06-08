using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopzu.Entitie
{
    public class Category : BaseEntity
    {
        public List<Product> Product { get; set; }
    }
}
