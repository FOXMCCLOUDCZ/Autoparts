namespace AutopartsCore.BaseEntities
{
    public abstract class BaseEntity : IBaseEntity
    {
        public virtual int Id { get; set; }
        public virtual DateTime CreateDate { get; set; } = DateTime.Now;
        public virtual DateTime? UpdateDate { get; set; }
        public virtual byte[] RowVersion { get; set; } = null!;
    }
}