namespace AutopartsEntity.Catalog.ViewModels.WarrantyViewModel
{
    public class WarrantyEditVM
    {
        public int Id { get; set; }
        public string UpdateDate { get; set; } = DateTime.Now.ToString("d");
        public byte[] RowVersion { get; set; } = null!;

        public string Title { get; set; } = null!;
        public bool IsActive { get; set; } = false;
    }
}