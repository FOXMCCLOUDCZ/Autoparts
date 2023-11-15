using AutoMapper;
using AutoMapper.QueryableExtensions;
using AutopartsEntity.Catalog.Entities;
using AutopartsEntity.Catalog.ViewModels.WarrantyViewModel;
using AutopartsRepository.Repositories.Interfaces;
using AutopartsRepository.UnitOfWorks.Interfaces;
using AutopartsService.Services.Catalog.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutopartsService.Services.Catalog.Implementations
{
    public class WarrantyService : IWarrantyService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Warranty> _repository;

        public WarrantyService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _repository = _unitOfWork.GetGenericRepository<Warranty>();
        }

        public async Task<List<WarrantyListVM>> AllListAsync()
        {
            var warrantyListVM = await _unitOfWork.GetGenericRepository<Warranty>().ListEntity()
                .ProjectTo<WarrantyListVM>(_mapper.ConfigurationProvider)
                .ToListAsync();

            return warrantyListVM;
        }

        public async Task CreateWarrantyAsync(WarrantyCreateVM request)
        {
            var warranty = _mapper.Map<Warranty>(request);
            await _repository.CreateEntity(warranty);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteWarrantyAsync(int id)
        {
            var warranty = await _repository.FindEntity(id);
            _repository.DeleteEntity(warranty);
            await _unitOfWork.CommitAsync();
        }

        public async Task<WarrantyEditVM> GetWarrantyById(int id)
        {
            var warranty = await _repository.Where(x => x.Id == id)
                .ProjectTo<WarrantyEditVM>(_mapper.ConfigurationProvider)
                .SingleAsync();
            return warranty;
        }

        public async Task EditWarrantyAsync(WarrantyEditVM request)
        {
            var warranty = _mapper.Map<Warranty>(request);
            _repository.EditEntity(warranty);
            await _unitOfWork.CommitAsync();
        }
    }
}