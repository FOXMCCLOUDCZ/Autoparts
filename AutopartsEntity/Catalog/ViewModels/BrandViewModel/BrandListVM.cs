using AutopartsEntity.ExtensionForUsers.ViewModels.CountryViewModel;

namespace AutopartsEntity.Catalog.ViewModels.BrandViewModel
{
    public class BrandListVM
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; } = DateTime.Now;

        public int? TecDoc { get; set; }
        public string Title { get; set; } = null!;
        public string? LogoPath { get; set; }
        public string? WebSite { get; set; }
        public string? GeneralInformation { get; set; }
        public bool IsActive { get; set; } = false;

        public int CountryId { get; set; }
        public CountryListVM Country { get; set; } = null!;
    }
}