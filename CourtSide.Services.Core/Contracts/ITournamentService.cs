namespace CourtSide.Services.Core.Contracts
{
    using CourtSide.ViewModels.Tournaments;

    public interface ITournamentService
    {
        public Task<Guid> CreateTournamentAsync(TournamentFormViewModel tournamentForm);

        public Task<bool> UpdateTournamentAsync(Guid id, TournamentFormViewModel tournamentForm);

        public Task<bool> DeleteTournamentAsync(Guid id);

        public Task<TournamentDetailsViewModel?> GetTournamentDetailsByIdAsync(Guid id);

        public Task<TournamentFormViewModel?> GetTournamentForEditByIdAsync(Guid id);

        public Task<IEnumerable<TournamentInfoViewModel>> GetAllTournamentsForIndexAsync();

        Task<IEnumerable<TournamentSelectItemViewModel>> GetTournamentsByTourWithVenueAsync(string tour);
    }
}
