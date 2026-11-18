namespace CourtSide.Services.Core.Services
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;

    using CourtSide.Data.Models;
    using CourtSide.Data.Persistance;
    using CourtSide.Services.Core.Contracts;
    using CourtSide.ViewModels.Courts;
    using CourtSide.ViewModels.Matches;
    using CourtSide.ViewModels.Players;
    using CourtSide.ViewModels.Tournaments;



    public class MatchService : IMatchService
    {
        private readonly CourtSideDbContext context;
        private readonly IMapper mapper;
        private readonly IPlayerService playerService;
        private readonly ITournamentService tournamentService;
        private readonly ICourtService courtService;

        public MatchService(CourtSideDbContext context,
        IMapper mapper, IPlayerService playerService, ITournamentService tournamentService, ICourtService courtService)
        {
            this.context = context;
            this.mapper = mapper;
            this.playerService = playerService;
            this.tournamentService = tournamentService;
            this.courtService = courtService;
        }

        public async Task<Guid> CreateMatchAsync(MatchFormViewModel matchForm)
        {
            Match newMatch = this.mapper.Map<Match>(matchForm);

            this.context.Matches.Add(newMatch);
            await this.context.SaveChangesAsync();

            return newMatch.Id;
        }

        public async Task<bool> UpdateMatchAsync(Guid id, MatchFormViewModel matchForm)
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

        public async Task<bool> DeleteMatchAsync(Guid id)
        {
            int rowsAffected = await this.context.Matches
                .Where(m => m.Id == id)
                .ExecuteDeleteAsync();

            return rowsAffected > 0;
        }

        public async Task<MatchDetailsViewModel?> GetMatchDetailsByIdAsync(Guid id)
        {
            return await this.context.Matches
                .AsNoTracking()
                .Where(m => m.Id == id)
                .ProjectTo<MatchDetailsViewModel>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
        }
        public async Task<MatchFormViewModel?> GetMatchForEditByIdAsync(Guid id)
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
            if (!string.IsNullOrWhiteSpace(model.Tour))
            {
                model.Tournaments = await this.tournamentService.GetTournamentsByTourWithVenueAsync(model.Tour)
                    ?? Enumerable.Empty<TournamentSelectItemViewModel>();

                IEnumerable<PlayerSelectViewModel>? tourPlayers = await this.playerService.GetPlayersByTourAsync(model.Tour);
                model.Players = tourPlayers.Select(p => new SelectListItem
                {
                    Value = p.Id.ToString(),
                    Text = p.FullName
                });
            }
            else
            {
                model.Tournaments = Enumerable.Empty<TournamentSelectItemViewModel>();
                IEnumerable<PlayerSelectViewModel>? players = await this.playerService.GetPlayersForSelectAsync();
                model.Players = players.Select(p => new SelectListItem
                {
                    Value = p.Id.ToString(),
                    Text = p.FullName
                });
            }
        }
    }
}

