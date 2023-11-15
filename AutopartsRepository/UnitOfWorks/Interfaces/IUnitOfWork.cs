using AutopartsCore.BaseEntities;
using AutopartsRepository.Repositories.Interfaces;

namespace AutopartsRepository.UnitOfWorks.Interfaces
{
    public interface IUnitOfWork
    {
        void Commit();
        Task CommitAsync();
        IGenericRepository<T> GetGenericRepository<T>() where T : class, IBaseEntity, new();
        ValueTask DisposeAsync();
    }
}