using NTierCalisma1.CORE.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NTierCalisma1.DATAACCESS.Repositories.Abstract
{
    public interface IRepository<T> where T : CoreEntity
    {
        Task<bool> AddAsync(T item);
        Task<bool> AddAsync(List<T> items);
        Task<bool> UpdateAsync(T item);
        Task<bool> RemoveAsync(T item);
        Task<bool> RemoveAsync(Guid id);
        Task<bool> RemoveAllAsync(Expression<Func<T, bool>> exp);
        Task<T> GetByIdAsync(Guid id);
        T GetByDefault(Expression<Func<T, bool>> exp);
        Task<List<T>> GetActiveAsync();
        List<T> GetDefault(Expression<Func<T,bool>> exp);
        Task<List<T>> GetAllAsync();
        Task<bool> ActivateAsync(Guid id);
        Task<bool> AnyAsync(Expression<Func<T, bool>> exp);
        Task<int> SaveAsync();
    }
}
