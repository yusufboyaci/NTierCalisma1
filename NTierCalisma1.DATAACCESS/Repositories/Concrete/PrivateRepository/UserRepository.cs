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
    public class UserRepository : Repository<User>
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }
        public User FindByUserName(string userName)
        {
            return GetByDefault(x => x.UserName == userName);
        }
        public bool CheckCredential(string userName, string password)
        {
            return Any(x => x.UserName == userName && x.Password == password);
        }
    }
}
