namespace CourtSide.Data.Repository
{
    using CourtSide.Data.Models;
    using CourtSide.Data.Persistance;
    using CourtSide.Data.Repository.Common;
    using CourtSide.Data.Repository.Contracts;

    public class PlayerRepository : BaseSoftDeleteableRepository<Player>, IPlayerRepository
    {
        public PlayerRepository(CourtSideDbContext dbContext) : base(dbContext)
        {
        }
    }
}
