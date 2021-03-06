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
    public class ProductRepository : Repository<Product>
    {
        public readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
