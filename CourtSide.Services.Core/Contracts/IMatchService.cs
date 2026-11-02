namespace CourtSide.Services.Core.Contracts
{
    using CourtSide.ViewModels.Matches;
    using CourtSide.ViewModels.Players;

    public interface IMatchService
    {
        public Task<int> CreateMatchAsync(MatchFormViewModel matchForm);

        public Task<bool> UpdateMatchAsync(int id, MatchFormViewModel matchForm);

        public Task<bool> DeleteMatchAsync(int id);

        public Task<MatchDetailsViewModel?> GetMatchDetailsByIdAsync(int id);

        public Task<MatchFormViewModel?> GetMatchForEditByIdAsync(int id);

        public Task<IEnumerable<MatchInfoViewModel>> GetAllMatchesForIndexAsync();
    }
}

