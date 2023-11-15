namespace AutopartsCore.BaseEntities
{
    public abstract class BaseEntity : IBaseEntity
    {
        public virtual int Id { get; set; }
        public virtual string CreateDate { get; set; } = DateTime.Now.ToString("d");
        public virtual string? UpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; } = null!;
    }
}