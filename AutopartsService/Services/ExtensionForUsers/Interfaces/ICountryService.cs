using AutopartsEntity.ExtensionForUsers.ViewModels.CountryViewModel;

namespace AutopartsService.Services.ExtensionForUsers.Interfaces
{
    public interface ICountryService
    {
        Task<List<CountryListVM>> AllListAsync();
        Task CreateCountryAsync(CountryCreateVM request);
        Task DeleteCountryAsync(int id);
        Task<CountryEditVM> GetCountryById(int id);
        Task EditCountryAsync(CountryEditVM request);
    }
}