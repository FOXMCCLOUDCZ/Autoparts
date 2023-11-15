namespace AutopartsEntity.ExtensionForUsers.ViewModels.CurrencyViewModel
{
    public class CurrencyListVM
    {
        public int Id { get; set; }
        public string CreateDate { get; set; } = DateTime.Now.ToString("d");
        public string? UpdateDate { get; set; }

        public int NumericCurrencyCode { get; set; }
        public string CurrencyCode { get; set; } = null!;
        public string CurrencyName { get; set; } = null!;
        public bool IsActive { get; set; } = false;
    }
}