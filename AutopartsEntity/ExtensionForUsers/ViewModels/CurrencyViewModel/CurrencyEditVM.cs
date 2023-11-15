namespace AutopartsEntity.ExtensionForUsers.ViewModels.CurrencyViewModel
{
    public class CurrencyEditVM
    {
        public int Id { get; set; }
        public string? UpdateDate { get; set; }
        public byte[] RowVersion { get; set; } = null!;

        public int NumericCurrencyCode { get; set; }
        public string CurrencyCode { get; set; } = null!;
        public string CurrencyName { get; set; } = null!;
        public bool IsActive { get; set; } = false;
    }
}