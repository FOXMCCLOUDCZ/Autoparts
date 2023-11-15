using AutopartsCore.BaseEntities;
using AutopartsRepository.Contexts;
using AutopartsRepository.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace AutopartsRepository.Repositories.Implementations
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class, IBaseEntity, new()
    {
        private readonly AutopartsDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(AutopartsDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public async Task CreateEntity(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void EditEntity(T entity)
        {
            _dbSet.Update(entity);
        }

        public void DeleteEntity(T entity)
        {
            _dbSet.Remove(entity);
        }

        public IQueryable<T> ListEntity()
        {
            return _dbSet.AsNoTracking().AsQueryable();
        }

        public IQueryable<T> Where(Expression<Func<T, bool>> expression)
        {
            return _dbSet.Where(expression);
        }

        public async Task<T> FindEntity(int id)
        {
            return await _dbSet.FindAsync(id);
        }
    }
}