using AutoMapper;
using AutoMapper.QueryableExtensions;
using AutopartsEntity.ExtensionForUsers.Entities;
using AutopartsEntity.ExtensionForUsers.ViewModels.CurrencyViewModel;
using AutopartsRepository.Repositories.Interfaces;
using AutopartsRepository.UnitOfWorks.Interfaces;
using AutopartsService.Services.ExtensionForUsers.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutopartsService.Services.ExtensionForUsers.Implementations
{
    public class CurrencyService : ICurrencyService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Currency> _repository;

        public CurrencyService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _repository = _unitOfWork.GetGenericRepository<Currency>();
        }

        public async Task<List<CurrencyListVM>> AllListAsync()
        {
            var currencyListVM = await _unitOfWork.GetGenericRepository<Currency>().ListEntity()
                .ProjectTo<CurrencyListVM>(_mapper.ConfigurationProvider)
                .ToListAsync();

            return currencyListVM;
        }

        public async Task CreateCurrencyAsync(CurrencyCreateVM request)
        {
            var currency = _mapper.Map<Currency>(request);
            await _repository.CreateEntity(currency);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteCurrencyAsync(int id)
        {
            var currency = await _repository.FindEntity(id);
            _repository.DeleteEntity(currency);
            await _unitOfWork.CommitAsync();
        }

        public async Task<CurrencyEditVM> GetCurrencyById(int id)
        {
            var currency = await _repository.Where(x => x.Id == id)
                .ProjectTo<CurrencyEditVM>(_mapper.ConfigurationProvider)
                .SingleAsync();
            return currency;
        }

        public async Task EditCurrencyAsync(CurrencyEditVM request)
        {
            var currency = _mapper.Map<Currency>(request);
            _repository.EditEntity(currency);
            await _unitOfWork.CommitAsync();
        }
    }
}