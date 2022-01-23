using NTierCalisma1.CORE.Entity.Concrete;
using NTierCalisma1.CORE.Enum;
using NTierCalisma1.DATAACCESS.Context;
using NTierCalisma1.DATAACCESS.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace NTierCalisma1.DATAACCESS.Repositories.Concrete.MainRepository
{
    public class Repository<T> : IRepository<T> where T : CoreEntity
    {
        private readonly ApplicationDbContext _context;
        public Repository(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<bool> ActivateAsync(Guid id)
        {
            T activated = await GetByIdAsync(id);
            activated.Status = Status.Active;
            return await UpdateAsync(activated);
        }

        public async Task<bool> AddAsync(T item)
        {
            _context.Set<T>().Add(item);
            return await SaveAsync() > 0;
        }

        public async Task<bool> AddAsync(List<T> items)
        {
            _context.Set<T>().AddRange(items);
            return await SaveAsync() > 0;
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> exp)
        {
            return await Task.Run(
            () => _context.Set<T>().Any(exp));
        }

        public async Task<List<T>> GetActiveAsync()
        {
            return await Task.Run(() => _context.Set<T>().Where(x => x.Status == Status.Active).ToList());
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await Task.Run(() => _context.Set<T>().ToList());
        }

        public T GetByDefault(Expression<Func<T, bool>> exp)
        {
            return _context.Set<T>().Where(exp).FirstOrDefault();
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public List<T> GetDefault(Expression<Func<T, bool>> exp)
        {
            return  _context.Set<T>().Where(exp).ToList();
        }

        public async Task<bool> RemoveAsync(T item)
        {
            item.Status = Status.Deleted;
            return await UpdateAsync(item);
        }

        public async Task<bool> RemoveAsync(Guid id)
        {
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {
                    T deleted = await GetByIdAsync(id);
                    deleted.Status = Status.Deleted;
                    ts.Complete();
                    return await UpdateAsync(deleted);
                }

            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<bool> RemoveAllAsync(Expression<Func<T, bool>> exp)
        {
            try
            {
                using (TransactionScope ts = new TransactionScope())
                {

                    var collection = GetDefault(exp);
                    int count = 0;
                    foreach (var item in collection)
                    {
                        item.Status = Status.Deleted;
                        bool operationalResult = await UpdateAsync(item);
                        if (operationalResult)
                        {
                            count++;
                        }

                    }
                    if (collection.Count == count)
                    {
                        ts.Complete();
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public async Task<bool> UpdateAsync(T item)
        {
            try
            {
                _context.Set<T>().Update(item);
                return await SaveAsync() > 0;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
