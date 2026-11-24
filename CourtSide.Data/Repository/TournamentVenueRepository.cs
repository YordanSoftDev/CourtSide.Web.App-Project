namespace CourtSide.Data.Repository
{
    using CourtSide.Data.Models;
    using CourtSide.Data.Persistance;
    using CourtSide.Data.Repository.Common;
    using CourtSide.Data.Repository.Contracts;

    public class TournamentVenueRepository : BaseSoftDeleteableRepository<TournamentVenue>, ITournamentVenueRepository
    {
        public TournamentVenueRepository(CourtSideDbContext dbContext) : base(dbContext)
        {
        }
    }
}
