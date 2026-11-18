namespace CourtSide.Services.Core.Contracts
{
    using CourtSide.ViewModels.Players;

    public interface IPlayerService
    {
        public Task<Guid> CreatePlayerAsync(PlayerFormViewModel playerForm);

        public Task<bool> UpdatePlayerAsync(Guid id, PlayerFormViewModel playerForm);

        public Task<bool> DeletePlayerAsync(Guid id);

        public Task<PlayerDetailsViewModel?> GetPlayerDetailsByIdAsync(Guid id);

        public Task<PlayerFormViewModel?> GetPlayerForEditByIdAsync(Guid id);

        public Task<IEnumerable<PlayerInfoViewModel>> GetAllMensPlayersForIndexAsync();

        public Task<IEnumerable<PlayerInfoViewModel>> GetAllWomensPlayersForIndexAsync();

        public Task<IEnumerable<PlayerSelectViewModel>> GetPlayersForSelectAsync();

        public Task<IEnumerable<PlayerSelectViewModel>> GetPlayersByTournamentIdAsync(Guid tournamentId);

        public Task<IEnumerable<PlayerSelectViewModel>> GetPlayersByTourAsync(string tour);
    }
}
