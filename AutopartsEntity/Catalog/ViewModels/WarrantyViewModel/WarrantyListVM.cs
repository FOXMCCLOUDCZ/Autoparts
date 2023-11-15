namespace AutopartsEntity.Catalog.ViewModels.WarrantyViewModel
{
    public class WarrantyListVM
    {
        public int Id { get; set; }
        public string CreateDate { get; set; } = DateTime.Now.ToString("d");
        public string? UpdateDate { get; set; }

        public string Title { get; set; } = null!;
        public bool IsActive { get; set; } = false;
    }
}