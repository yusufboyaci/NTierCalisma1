using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NTierCalisma1.CORE.Entity.Concrete;

namespace NTierCalisma1.ENTITIES.Entities
{
    public class Category : CoreEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }

        public virtual IEnumerable<Product>? Products { get; set; }

    }
}
