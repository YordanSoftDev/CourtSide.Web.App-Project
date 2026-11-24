namespace CourtSide.Data.Repository
{
    using CourtSide.Data.Models;
    using CourtSide.Data.Persistance;
    using CourtSide.Data.Repository.Common;
    using CourtSide.Data.Repository.Contracts;

    public class VenueRepository : BaseSoftDeleteableRepository<Venue>, IVenueRepository
    {
        public VenueRepository(CourtSideDbContext dbContext) : base(dbContext)
        {
        }
    }
}
