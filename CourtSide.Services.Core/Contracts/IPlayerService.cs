namespace CourtSide.Services.Core.Contracts
{
    using CourtSide.ViewModels.Players;

    public interface IPlayerService
    {
        public Task<int> CreatePlayerAsync(PlayerFormViewModel playerForm);

        public Task<bool> UpdatePlayerAsync(int id, PlayerFormViewModel playerForm);

        public Task<bool> DeletePlayerAsync(int id);

        public Task<PlayerDetailsViewModel?> GetPlayerDetailsByIdAsync(int id);

        public Task<PlayerFormViewModel?> GetPlayerForEditByIdAsync(int id);

        public Task<IEnumerable<PlayerInfoViewModel>> GetAllMensPlayersForIndexAsync();

        public Task<IEnumerable<PlayerInfoViewModel>> GetAllWomensPlayersForIndexAsync();

        public Task<IEnumerable<PlayerSelectViewModel>> GetPlayersForSelectAsync();

        public Task<IEnumerable<PlayerSelectViewModel>> GetPlayersByTournamentIdAsync(int tournamentId);
    }
}
