using AutoMapper;
using AutoMapper.QueryableExtensions;
using AutopartsEntity.Catalog.Entities;
using AutopartsEntity.Catalog.ViewModels.BrandViewModel;
using AutopartsRepository.Repositories.Interfaces;
using AutopartsRepository.UnitOfWorks.Interfaces;
using AutopartsService.Services.Catalog.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutopartsService.Services.Catalog.Implementations
{
    public class BrandService : IBrandService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Brand> _repository;

        public BrandService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _repository = _unitOfWork.GetGenericRepository<Brand>();
        }

        public async Task<List<BrandListVM>> AllListAsync()
        {
            var brandListVM = await _unitOfWork.GetGenericRepository<Brand>().ListEntity()
                .ProjectTo<BrandListVM>(_mapper.ConfigurationProvider)
                .ToListAsync();

            return brandListVM;
        }

        public async Task CreateBrandAsync(BrandCreateVM request)
        {
            var brand = _mapper.Map<Brand>(request);
            await _repository.CreateEntity(brand);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteBrandAsync(int id)
        {
            var brand = await _repository.FindEntity(id);
            _repository.DeleteEntity(brand);
            await _unitOfWork.CommitAsync();
        }

        public async Task<BrandEditVM> GetBrandById(int id)
        {
            var brand = await _repository.Where(x => x.Id == id)
                .ProjectTo<BrandEditVM>(_mapper.ConfigurationProvider)
                .SingleAsync();
            return brand;
        }

        public async Task EditBrandAsync(BrandEditVM request)
        {
            var brand = _mapper.Map<Brand>(request);
            _repository.EditEntity(brand);
            await _unitOfWork.CommitAsync();
        }
    }
}