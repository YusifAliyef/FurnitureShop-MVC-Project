using Fs.Entity.Commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Fs.DataAccessLayer.EntityFrameworkCore.Abstract
{
    public interface IGenericRepository<T> where T: BaseEntity
    {
        Task<IEnumerable<T>> GetAllAsync(bool tracking=true);
        Task<T> GetByIdAsync(int id);
        public IQueryable<T> GetWhereAsync(Expression <Func<T, bool>> expression);
        Task<bool> AddAsync(T entity);
        Task SaveChangesAsync();
        bool Update(T entity);
        bool Remove(T entity);
        
        Task<IDictionary<TKey, TElement>> GetDictionaryAsync<TKey, TElement>(Func<T, TKey> keySelector, Func<T, TElement> valueSelector);
    }
}
