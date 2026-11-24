namespace CourtSide.Data.Repository
{
    using CourtSide.Data.Models;
    using CourtSide.Data.Persistance;
    using CourtSide.Data.Repository.Common;
    using CourtSide.Data.Repository.Contracts;
    public class CourtRepository : BaseSoftDeleteableRepository<Court>, ICourtRepository
    {
        public CourtRepository(CourtSideDbContext dbContext) : base(dbContext)
        {
        }
    }
}
