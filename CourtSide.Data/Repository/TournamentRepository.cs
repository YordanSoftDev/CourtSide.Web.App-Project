namespace CourtSide.Data.Repository
{
    using CourtSide.Data.Models;
    using CourtSide.Data.Persistance;
    using CourtSide.Data.Repository.Common;
    using CourtSide.Data.Repository.Contracts;

    public class TournamentRepository : BaseSoftDeleteableRepository<Tournament>, ITournamentRepository
    {
        public TournamentRepository(CourtSideDbContext dbContext) : base(dbContext)
        {
        }
    }
}
