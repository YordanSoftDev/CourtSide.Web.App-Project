namespace CourtSide.Common.Models
{
    public interface ISoftDeleteableEntity
    {
        public bool IsDeleted { get; set; }
    }
}
