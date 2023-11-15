using AutopartsEntity.ExtensionForUsers.ViewModels.CurrencyViewModel;

namespace AutopartsService.Services.ExtensionForUsers.Interfaces
{
    public interface ICurrencyService
    {
        Task<List<CurrencyListVM>> AllListAsync();
        Task CreateCurrencyAsync(CurrencyCreateVM request);
        Task DeleteCurrencyAsync(int id);
        Task<CurrencyEditVM> GetCurrencyById(int id);
        Task EditCurrencyAsync(CurrencyEditVM request);
    }
}