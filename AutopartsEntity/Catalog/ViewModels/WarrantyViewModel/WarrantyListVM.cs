namespace AutopartsEntity.Catalog.ViewModels.WarrantyViewModel
{
    public class WarrantyListVM
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
        public DateTime? UpdateDate { get; set; } = DateTime.Now;

        public string Title { get; set; } = null!;
        public bool IsActive { get; set; } = false;
    }
}