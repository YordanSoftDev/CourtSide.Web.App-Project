namespace CourtSide.Data.Repository.Contracts
{
    using CourtSide.Data.Models;
    using CourtSide.Data.Repository.Contracts.Common;
    public interface IPlayerRepository : ISoftDeleteableRepository<Player>
    {
    }
}
