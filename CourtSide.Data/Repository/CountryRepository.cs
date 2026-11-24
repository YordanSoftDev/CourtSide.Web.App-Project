using CourtSide.Data.Models;
using CourtSide.Data.Persistance;
using CourtSide.Data.Repository.Common;
using CourtSide.Data.Repository.Contracts;

namespace CourtSide.Data.Repository
{
    public class CountryRepository : BaseSoftDeleteableRepository<Country>, ICountryRepository
    {
        public CountryRepository(CourtSideDbContext dbContext) : base(dbContext)
        {
        }
    }
}
