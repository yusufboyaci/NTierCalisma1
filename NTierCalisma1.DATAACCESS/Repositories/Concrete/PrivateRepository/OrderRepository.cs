using NTierCalisma1.CORE.Enum;
using NTierCalisma1.DATAACCESS.Context;
using NTierCalisma1.DATAACCESS.Repositories.Concrete.MainRepository;
using NTierCalisma1.ENTITIES.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierCalisma1.DATAACCESS.Repositories.Concrete.PrivateRepository
{
    public class OrderRepository : Repository<Order>
    {
        private readonly ApplicationDbContext _context;
        public OrderRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public List<Order> ListPendingOrders()
        {
            return GetDefault(x => x.Status == Status.Active && x.Confirmed == false).OrderByDescending(x => x.CreatedDate).ToList();
        }

        public int PendingOrdersCount()
        {
            return ListPendingOrders().Count();
        }
    }
}
