using NTierCalisma1.CORE.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierCalisma1.ENTITIES.Entities
{
    public class Product : CoreEntity
    {
        public string? Name { get; set; }
        public decimal? Price { get; set; }
        public int? Stock { get; set; }
        public string? QuantityPerUnit { get; set; }
        public string? ImagePath { get; set; }
        public Guid CategoryId { get; set; }//FK

        public virtual Category? Category { get; set; }
        public virtual IEnumerable<OrderDetail>? OrderDetails { get; set; }

    }
}
