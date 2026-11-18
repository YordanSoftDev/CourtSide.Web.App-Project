namespace CourtSide.Services.Core.Contracts
{
    using CourtSide.ViewModels.Matches;

    public interface IMatchService
    {
        public Task<Guid> CreateMatchAsync(MatchFormViewModel matchForm);

        public Task<bool> UpdateMatchAsync(Guid id, MatchFormViewModel matchForm);

        public Task<bool> DeleteMatchAsync(Guid id);

        public Task<MatchDetailsViewModel?> GetMatchDetailsByIdAsync(Guid id);

        public Task<MatchFormViewModel?> GetMatchForEditByIdAsync(Guid id);

        public Task<IEnumerable<MatchInfoViewModel>> GetAllMatchesForIndexAsync();

        Task PopulateMatchFormViewModelAsync(MatchFormViewModel model);
    }
}

