using AutopartsEntity.ExtensionForUsers.ViewModels.CurrencyViewModel;

namespace AutopartsEntity.ExtensionForUsers.ViewModels.CountryViewModel
{
    public class CountryListVM
    {
        public int Id { get; set; }
        public string CreateDate { get; set; } = DateTime.Now.ToString("d");
        public string? UpdateDate { get; set; }

        public int NumericCountryCode { get; set; }
        public string ISOAlpha2 { get; set; } = null!;
        public string ISOAlpha3 { get; set; } = null!;
        public string CountryNameCZ { get; set; } = null!;
        public string CountryNameENG { get; set; } = null!;
        public bool IsActive { get; set; } = false;

        public int CurrencyId { get; set; }
        public CurrencyListVM Currency { get; set; } = null!;
    }
}