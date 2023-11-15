using AutopartsRepository.Contexts;
using AutopartsRepository.Repositories.Implementations;
using AutopartsRepository.Repositories.Interfaces;
using AutopartsRepository.UnitOfWorks.Implementations;
using AutopartsRepository.UnitOfWorks.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AutopartsRepository.Extensions
{
    public static class RepositoryLayerExtensions
    {
        public static IServiceCollection LoadRepositoryLayerExtensions(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<AutopartsDbContext>(opt => opt.UseSqlServer(config.GetConnectionString("SqlConnection")));

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            return services;
        }
    }
}