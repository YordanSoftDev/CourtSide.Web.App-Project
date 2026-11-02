namespace CourtSide.Services.Core.Contracts
{
    using CourtSide.ViewModels.Tournaments;

    public interface ITournamentService
    {
        public Task<int> CreateTournamentAsync(TournamentFormViewModel tournamentForm);

        public Task<bool> UpdateTournamentAsync(int id, TournamentFormViewModel tournamentForm);

        public Task<bool> DeleteTournamentAsync(int id);

        public Task<TournamentDetailsViewModel?> GetTournamentDetailsByIdAsync(int id);

        public Task<TournamentFormViewModel?> GetTournamentForEditByIdAsync(int id);

        public Task<IEnumerable<TournamentInfoViewModel>> GetAllTournamentsForIndexAsync();
    }
}
