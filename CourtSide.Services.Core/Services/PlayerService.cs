namespace CourtSide.Services.Core.Services
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using CourtSide.Common.MatchEnumerations;
    using CourtSide.Data.Models;
    using CourtSide.Data.Persistance;
    using CourtSide.Services.Core.Contracts;
    using CourtSide.ViewModels.Players;
    using Microsoft.EntityFrameworkCore;

    public class PlayerService : IPlayerService
    {
        private readonly CourtSideDbContext context;
        private readonly IMapper mapper;

        public PlayerService(CourtSideDbContext context,
        IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<int> CreatePlayerAsync(PlayerFormViewModel playerForm)
        {
            Player newPlayer = this.mapper.Map<Player>(playerForm);

            this.context.Players.Add(newPlayer);
            await this.context.SaveChangesAsync();

            return newPlayer.Id;
        }

        public async Task<bool> UpdatePlayerAsync(int id, PlayerFormViewModel playerForm)
        {
            Player? playerToUpdate = await this.context.Players.FindAsync(id);

            if (playerToUpdate == null)
            {
                return false;
            }

            this.mapper.Map(playerForm, playerToUpdate);

            await this.context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeletePlayerAsync(int id)
        {
            int rowsAffected = await this.context.Players
                .Where(m => m.Id == id)
                .ExecuteDeleteAsync();

            return rowsAffected > 0;
        }

        public async Task<PlayerDetailsViewModel?> GetPlayerDetailsByIdAsync(int id)
        {
            return await this.context.Players
                .AsNoTracking()
                .Where(m => m.Id == id)
                .ProjectTo<PlayerDetailsViewModel>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
        }
        public async Task<PlayerFormViewModel?> GetPlayerForEditByIdAsync(int id)
        {
            return await this.context.Players
                .AsNoTracking()
                .Where(m => m.Id == id)
                .ProjectTo<PlayerFormViewModel>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<PlayerInfoViewModel>> GetAllMensPlayersForIndexAsync()
        {
            return await this.context.Players
                .Where(p=> p.Id > 0 && p.Id < 133)
                .AsNoTracking()
                .OrderBy(p => p.Rank)
                .ThenBy(p => p.Id)
                .Take(100)
                .ProjectTo<PlayerInfoViewModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<IEnumerable<PlayerInfoViewModel>> GetAllWomensPlayersForIndexAsync()
        {
            return await this.context.Players
                .Where(p => p.Id > 1000)
                .AsNoTracking()
                .OrderBy(p => p.Rank)
                .ThenBy(p => p.Id)
                .Take(100)
                .ProjectTo<PlayerInfoViewModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<IEnumerable<PlayerSelectViewModel>> GetPlayersForSelectAsync()
        {
            return await this.context.Players
                .AsNoTracking()
                .OrderBy(p => p.LastName)
                .ThenBy(p => p.FirstName)
                .ProjectTo<PlayerSelectViewModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<IEnumerable<PlayerSelectViewModel>> GetPlayersByTournamentIdAsync(int tournamentId)
        {
            var tournament = await this.context.Tournaments
                .AsNoTracking()
                .FirstOrDefaultAsync(t => t.Id == tournamentId);

            if (tournament == null)
            {
                return Enumerable.Empty<PlayerSelectViewModel>();
            }

            var query = this.context.Players.AsNoTracking();

            string type = tournament.TournamentType;

            if (type.StartsWith("WTA", StringComparison.OrdinalIgnoreCase) ||
                type.Equals("ITF Women", StringComparison.OrdinalIgnoreCase))
            {
                query = query.Where(p => p.Gender == Gender.Female);
            }
            else if (type.StartsWith("ATP", StringComparison.OrdinalIgnoreCase) ||
                     type.Equals("ITF Men", StringComparison.OrdinalIgnoreCase))
            {
                query = query.Where(p => p.Gender == Gender.Male);
            }

            return await query
                .OrderBy(p => p.LastName)
                .ThenBy(p => p.FirstName)
                .ProjectTo<PlayerSelectViewModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
