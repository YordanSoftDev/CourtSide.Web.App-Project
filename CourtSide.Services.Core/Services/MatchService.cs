namespace CourtSide.Services.Core.Services
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;

    using CourtSide.Data.Models;
    using CourtSide.Data.Persistance;
    using CourtSide.Services.Core.Contracts;
    using CourtSide.ViewModels.Matches;


    public class MatchService : IMatchService
    {
        private readonly CourtSideDbContext context;
        private readonly IMapper mapper;
        private readonly IPlayerService playerService;
        private readonly ITournamentService tournamentService;

        public MatchService(CourtSideDbContext context,
        IMapper mapper, IPlayerService playerService, ITournamentService tournamentService)
        {
            this.context = context;
            this.mapper = mapper;
            this.playerService = playerService;
            this.tournamentService = tournamentService;
        }

        public async Task<int> CreateMatchAsync(MatchFormViewModel matchForm)
        {
            Match newMatch = this.mapper.Map<Match>(matchForm);

            this.context.Matches.Add(newMatch);
            await this.context.SaveChangesAsync();

            return newMatch.Id;
        }

        public async Task<bool> UpdateMatchAsync(int id, MatchFormViewModel matchForm)
        {
            Match? matchToUpdate = await this.context.Matches.FindAsync(id);

            if (matchToUpdate == null)
            {
                return false;
            }

            this.mapper.Map(matchForm, matchToUpdate);

            var entry = this.context.Entry(matchToUpdate);

            await this.context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteMatchAsync(int id)
        {
            int rowsAffected = await this.context.Matches
                .Where(m => m.Id == id)
                .ExecuteDeleteAsync();

            return rowsAffected > 0;
        }

        public async Task<MatchDetailsViewModel?> GetMatchDetailsByIdAsync(int id)
        {
            return await this.context.Matches
                .AsNoTracking()
                .Where(m => m.Id == id)
                .ProjectTo<MatchDetailsViewModel>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
        }
        public async Task<MatchFormViewModel?> GetMatchForEditByIdAsync(int id)
        {
            return await this.context.Matches
                .AsNoTracking()
                .Where(m => m.Id == id)
                .ProjectTo<MatchFormViewModel>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<MatchInfoViewModel>> GetAllMatchesForIndexAsync()
        {
            return await this.context.Matches
                .AsNoTracking()
               .OrderByDescending(m => m.DateTime)
               .ThenByDescending(m => m.Id)
               .ProjectTo<MatchInfoViewModel>(this.mapper.ConfigurationProvider)
               .ToListAsync();
        }

        public async Task PopulateMatchFormViewModelAsync(MatchFormViewModel model)
        {
            var players = await this.playerService.GetPlayersForSelectAsync();
            model.Players = players.Select(p => new SelectListItem
            {
                Value = p.Id.ToString(),
                Text = p.FullName
            });

            var tournaments = await this.tournamentService.GetAllTournamentsForIndexAsync();
            model.Tournaments = tournaments.Select(t => new SelectListItem
            {
                Value = t.Id.ToString(),
                Text = $"{t.TournamentName} ({t.TournamentType})"
            });

            model.Venues = Enumerable.Empty<SelectListItem>();
        }
    }
}
