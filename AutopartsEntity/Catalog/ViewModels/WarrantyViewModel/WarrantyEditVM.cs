namespace AutopartsEntity.Catalog.ViewModels.WarrantyViewModel
{
    public class WarrantyEditVM
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; } = DateTime.Now;
        public byte[] RowVersion { get; set; } = null!;

        public string Title { get; set; } = null!;
        public bool IsActive { get; set; } = false;
    }
}