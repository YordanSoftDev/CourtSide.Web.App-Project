namespace CourtSide.Services.Core.Services
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Microsoft.EntityFrameworkCore;

    using CourtSide.Common.MatchEnumerations;
    using CourtSide.Data.Models;
    using CourtSide.Data.Repository.Contracts;
    using CourtSide.Services.Core.Contracts;
    using CourtSide.ViewModels.Players;

    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository playerRepository;
        private readonly ITournamentRepository tournamentRepository;
        private readonly IMapper mapper;

        public PlayerService(IPlayerRepository playerRepository,
            ITournamentRepository tournamentRepository,
        IMapper mapper)
        {
            this.playerRepository = playerRepository;
            this.tournamentRepository = tournamentRepository;
            this.mapper = mapper;
        }

        public async Task<Guid> CreatePlayerAsync(PlayerFormViewModel playerForm)
        {
            Player newPlayer = this.mapper.Map<Player>(playerForm);

            await this.playerRepository.AddAsync(newPlayer);
            await this.playerRepository.SaveChangesAsync();

            return newPlayer.Id;
        }

        public async Task<bool> UpdatePlayerAsync(Guid id, PlayerFormViewModel playerForm)
        {
            Player? playerToUpdate = await this.playerRepository.All().FirstOrDefaultAsync(m => m.Id == id);

            if (playerToUpdate == null)
            {
                return false;
            }

            this.mapper.Map(playerForm, playerToUpdate);

            await this.playerRepository.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeletePlayerAsync(Guid id)
        {
            Player? playerToDelete = await this.playerRepository.All()
                .Where(m => m.Id == id)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (playerToDelete == null)
            {
                return false;
            }

            try
            {
                this.playerRepository.Remove(playerToDelete);
                await this.playerRepository.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateException ex)
            {
                throw new InvalidOperationException("This player cannot be deleted because it has associated coach(es) records.", ex);
            }
        }

        public async Task<PlayerDetailsViewModel?> GetPlayerDetailsByIdAsync(Guid id)
        {
            return await this.playerRepository
                .AllAsNoTracking()
                .Where(m => m.Id == id)
                .ProjectTo<PlayerDetailsViewModel>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
        }
        public async Task<PlayerFormViewModel?> GetPlayerForEditByIdAsync(Guid id)
        {
            return await this.playerRepository
                .AllAsNoTracking()
                .Where(m => m.Id == id)
                .ProjectTo<PlayerFormViewModel>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<PlayerInfoViewModel>> GetAllMensPlayersForIndexAsync()
        {
            return await this.playerRepository
                .AllAsNoTracking()
                .Where(p => p.Gender == Gender.Male)
                .OrderBy(p => p.Rank)
                .ThenBy(p => p.Id)
                .Take(100)
                .ProjectTo<PlayerInfoViewModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<IEnumerable<PlayerInfoViewModel>> GetAllWomensPlayersForIndexAsync()
        {
            return await this.playerRepository
                .AllAsNoTracking()
                .Where(p => p.Gender == Gender.Female)
                .OrderBy(p => p.Rank)
                .ThenBy(p => p.Id)
                .Take(100)
                .ProjectTo<PlayerInfoViewModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<IEnumerable<PlayerSelectItemViewModel>> GetPlayersForSelectAsync()
        {
            return await this.playerRepository
                .AllAsNoTracking()
                .OrderBy(p => p.LastName)
                .ThenBy(p => p.FirstName)
                .ProjectTo<PlayerSelectItemViewModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<IEnumerable<PlayerSelectItemViewModel>> GetPlayersByTournamentIdAsync(Guid tournamentId)
        {
            var tournament = await this.tournamentRepository
                .AllAsNoTracking()
                .FirstOrDefaultAsync(t => t.Id == tournamentId);

            if (tournament == null)
            {
                return Enumerable.Empty<PlayerSelectItemViewModel>();
            }

            var query = this.playerRepository.AllAsNoTracking();

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
                .ProjectTo<PlayerSelectItemViewModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<IEnumerable<PlayerSelectItemViewModel>> GetPlayersByTourAsync(string tour)
        {
            IQueryable<Player>? query = this.playerRepository.AllAsNoTracking();

            if (!string.IsNullOrEmpty(tour))
            {
                if (tour.Equals("WTA", StringComparison.OrdinalIgnoreCase))
                {
                    query = query.Where(p => p.Gender == Gender.Female);
                }
                else if (tour.Equals("ATP", StringComparison.OrdinalIgnoreCase))
                {
                    query = query.Where(p => p.Gender == Gender.Male);
                }
            }

            return await query
                .OrderBy(p => p.LastName)
                .ThenBy(p => p.FirstName)
                .ProjectTo<PlayerSelectItemViewModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
