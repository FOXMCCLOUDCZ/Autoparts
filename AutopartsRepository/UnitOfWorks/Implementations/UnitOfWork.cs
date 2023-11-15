using AutopartsRepository.Contexts;
using AutopartsRepository.Repositories.Implementations;
using AutopartsRepository.Repositories.Interfaces;
using AutopartsRepository.UnitOfWorks.Interfaces;

namespace AutopartsRepository.UnitOfWorks.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AutopartsDbContext _context;

        public UnitOfWork(AutopartsDbContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public ValueTask DisposeAsync()
        {
            return _context.DisposeAsync();
        }

        IGenericRepository<T> IUnitOfWork.GetGenericRepository<T>()
        {
            return new GenericRepository<T>(_context);
        }
    }
}