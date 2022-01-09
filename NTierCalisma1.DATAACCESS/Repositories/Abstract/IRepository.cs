using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NTierCalisma1.DATAACCESS.Repositories.Abstract
{
    public interface IRepository<T> where T : class
    {
        Task<bool> Add(T item);
        Task<bool> Add(List<T> items);
        Task<bool> Update(T item);
        Task<bool> Remove(T item);
        Task<bool> Remove(Guid id);
        Task<bool> RemoveAll(Expression<Func<T, bool>> exp);
        Task<T> GetById(Guid id);
        Task<T> GetByDefault(Expression<Func<T, bool>> exp);
        Task<List<T>> GetActive();
        Task<List<T>> GetDefault(Expression<Func<T,bool>> exp);
        Task<List<T>> GetAll();
        Task<bool> Activate(Guid id);
        Task<bool> Any(Expression<Func<T, bool>> exp);
        Task<int> Save();
    }
}
