using AutopartsEntity.Catalog.ViewModels.BrandViewModel;

namespace AutopartsService.Services.Catalog.Interfaces
{
    public interface IBrandService
    {
        Task<List<BrandListVM>> AllListAsync();
        Task CreateBrandAsync(BrandCreateVM request);
        Task DeleteBrandAsync(int id);
        Task<BrandEditVM> GetBrandById(int id);
        Task EditBrandAsync(BrandEditVM request);
    }
}