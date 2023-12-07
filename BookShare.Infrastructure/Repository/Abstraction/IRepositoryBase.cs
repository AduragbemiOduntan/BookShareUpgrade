using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Infrastructure.Repository.Abstraction
{
    public interface IRepositoryBase<T>
    {
        IQueryable<T> FindAll(bool trackChanges);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> condition, bool trackChanges);
        void Update(T entity);
        void Delete(T entity);
        void DeleteRange(IEnumerable<T> entities);
        Task CreateAsync(T entity);
        Task CreateManyAsync(IEnumerable<T> entity);
        Task SaveChangesAync();
    }
}
