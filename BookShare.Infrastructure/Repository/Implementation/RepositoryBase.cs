using BookShare.Domain.Model;
using BookShare.Infrastructure.ApplicationContext;
using BookShare.Infrastructure.Repository.Abstraction;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace BookShare.Infrastructure.Repository.Implementation
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly BookShareContext _context;
        public RepositoryBase(BookShareContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
        }

        public async Task CreateManyAsync(IEnumerable<T> entity)
        {
            await _context.Set<T>().AddRangeAsync(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entities)
        {
            _context.Set<T>().RemoveRange(entities);
        }

        public IQueryable<T> FindAll(bool trackChanges)
        {
            return trackChanges ? _context.Set<T>() : _context.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> condition, bool trackChanges)
        {
            return trackChanges ? _context.Set<T>().Where(condition) : _context.Set<T>().Where(condition).AsNoTracking();
        }
        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public async Task SaveChangesAync()
        {
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {

                throw;
            }
        }
    }
}
