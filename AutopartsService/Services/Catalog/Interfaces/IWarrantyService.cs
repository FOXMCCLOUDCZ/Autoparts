using AutopartsEntity.Catalog.ViewModels.WarrantyViewModel;

namespace AutopartsService.Services.Catalog.Interfaces
{
    public interface IWarrantyService
    {
        Task<List<WarrantyListVM>> AllListAsync();
        Task CreateWarrantyAsync(WarrantyCreateVM request);
        Task DeleteWarrantyAsync(int id);
        Task<WarrantyEditVM> GetWarrantyById(int id);
        Task EditWarrantyAsync(WarrantyEditVM request);
    }
}