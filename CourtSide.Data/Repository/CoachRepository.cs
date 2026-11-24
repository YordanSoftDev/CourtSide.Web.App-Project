namespace CourtSide.Data.Repository
{
    using CourtSide.Data.Models;
    using CourtSide.Data.Persistance;
    using CourtSide.Data.Repository.Common;
    using CourtSide.Data.Repository.Contracts;


    public class CoachRepository : BaseSoftDeleteableRepository<Coach>, ICoachRepository
    {
        public CoachRepository(CourtSideDbContext dbContext) : base(dbContext)
        {
        }
    }
}
