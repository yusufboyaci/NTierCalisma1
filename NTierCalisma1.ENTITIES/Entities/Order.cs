using NTierCalisma1.CORE.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierCalisma1.ENTITIES.Entities
{
    public class Order : CoreEntity
    {
        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }
        public Guid UserId { get; set; }
        public bool Confirmed { get; set; }

        public virtual User User { get; set; }
        public virtual IEnumerable<OrderDetail> OrderDetails { get; set; }
    }
}
