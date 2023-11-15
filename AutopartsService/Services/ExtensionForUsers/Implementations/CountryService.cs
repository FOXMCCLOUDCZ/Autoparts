using AutoMapper;
using AutoMapper.QueryableExtensions;
using AutopartsEntity.ExtensionForUsers.Entities;
using AutopartsEntity.ExtensionForUsers.ViewModels.CountryViewModel;
using AutopartsRepository.Repositories.Interfaces;
using AutopartsRepository.UnitOfWorks.Interfaces;
using AutopartsService.Services.ExtensionForUsers.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace AutopartsService.Services.ExtensionForUsers.Implementations
{
    public class CountryService : ICountryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly IGenericRepository<Country> _repository;

        public CountryService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _repository = _unitOfWork.GetGenericRepository<Country>();
        }

        public async Task<List<CountryListVM>> AllListAsync()
        {
            var countryListVM = await _unitOfWork.GetGenericRepository<Country>().ListEntity()
                .ProjectTo<CountryListVM>(_mapper.ConfigurationProvider)
                .ToListAsync();

            return countryListVM;
        }

        public async Task CreateCountryAsync(CountryCreateVM request)
        {
            var country = _mapper.Map<Country>(request);
            await _repository.CreateEntity(country);
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteCountryAsync(int id)
        {
            var country = await _repository.FindEntity(id);
            _repository.DeleteEntity(country);
            await _unitOfWork.CommitAsync();
        }

        public async Task<CountryEditVM> GetCountryById(int id)
        {
            var country = await _repository.Where(x => x.Id == id)
                .ProjectTo<CountryEditVM>(_mapper.ConfigurationProvider)
                .SingleAsync();
            return country;
        }

        public async Task EditCountryAsync(CountryEditVM request)
        {
            var country = _mapper.Map<Country>(request);
            _repository.EditEntity(country);
            await _unitOfWork.CommitAsync();
        }
    }
}