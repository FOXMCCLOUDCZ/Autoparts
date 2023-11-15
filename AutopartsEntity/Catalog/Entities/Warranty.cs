using AutopartsCore.BaseEntities;

namespace AutopartsEntity.Catalog.Entities
{
    public class Warranty : BaseEntity
    {
        public string Title { get; set; } = null!;
        public bool IsActive { get; set; } = false;
    }
}