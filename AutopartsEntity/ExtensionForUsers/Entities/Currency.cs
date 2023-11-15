using AutopartsCore.BaseEntities;

namespace AutopartsEntity.ExtensionForUsers.Entities
{
    public class Currency : BaseEntity
    {
        public int NumericCurrencyCode { get; set; }
        public string CurrencyCode { get; set; } = null!;
        public string CurrencyName { get; set; } = null!;
        public bool IsActive { get; set; } = false;
    }
}