using AutopartsEntity.ExtensionForUsers.ViewModels.CountryViewModel;

namespace AutopartsEntity.Catalog.ViewModels.BrandViewModel
{
    public class BrandCreateVM
    {
        public int? TecDoc { get; set; }
        public string Title { get; set; } = null!;
        public string? LogoPath { get; set; }
        public string? WebSite { get; set; }
        public string? GeneralInformation { get; set; }
        public bool IsActive { get; set; } = false;

        public int CountryId { get; set; }
        public CountryCreateVM Country { get; set; } = null!;
    }
}