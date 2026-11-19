namespace CourtSide.Data.Repository.Contracts
{
    using CourtSide.Data.Repository.Contracts.Common;
    using CourtSide.Data.Models;

    public interface IMatchRepository : ISoftDeleteableRepository<Match>
    {
    }
}
