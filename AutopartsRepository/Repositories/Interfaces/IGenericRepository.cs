using AutopartsCore.BaseEntities;
using System.Linq.Expressions;

namespace AutopartsRepository.Repositories.Interfaces
{
    public interface IGenericRepository<T> where T : class, IBaseEntity, new()
    {
        Task CreateEntity(T entity);
        void EditEntity(T entity);
        void DeleteEntity(T entity);
        IQueryable<T> ListEntity();
        IQueryable<T> Where(Expression<Func<T, bool>> expression);
        Task<T> FindEntity(int id);
    }
}