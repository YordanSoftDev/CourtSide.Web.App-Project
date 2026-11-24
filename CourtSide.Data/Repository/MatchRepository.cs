namespace CourtSide.Data.Repository
{
    using CourtSide.Data.Models;
    using CourtSide.Data.Persistance;
    using CourtSide.Data.Repository.Common;
    using CourtSide.Data.Repository.Contracts;

    public class MatchRepository : BaseSoftDeleteableRepository<Match>, IMatchRepository
    {
        public MatchRepository(CourtSideDbContext dbContext) : base(dbContext)
        {
        }
    }
}
