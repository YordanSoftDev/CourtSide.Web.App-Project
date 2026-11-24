namespace CourtSide.Services.Core.Services
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;

    using CourtSide.Data.Models;
    using CourtSide.Services.Core.Contracts;
    using CourtSide.ViewModels.Matches;
    using CourtSide.ViewModels.Players;
    using CourtSide.ViewModels.Tournaments;
    using CourtSide.Data.Repository.Contracts;

    public class MatchService : IMatchService
    {
        private readonly IMatchRepository matchRepository;
        private readonly IMapper mapper;
        private readonly IPlayerService playerService;
        private readonly ITournamentService tournamentService;

        public MatchService(IMatchRepository matchRepository,
        IMapper mapper, IPlayerService playerService, ITournamentService tournamentService, ICourtService courtService)
        {
            this.matchRepository = matchRepository;
            this.mapper = mapper;
            this.playerService = playerService;
            this.tournamentService = tournamentService;
        }

        public async Task<Guid> CreateMatchAsync(MatchFormViewModel matchForm)
        {
            Match newMatch = this.mapper.Map<Match>(matchForm);

            await this.matchRepository.AddAsync(newMatch);
            await this.matchRepository.SaveChangesAsync();

            return newMatch.Id;
        }

        public async Task<bool> UpdateMatchAsync(Guid id, MatchFormViewModel matchForm)
        {
            Match? matchToUpdate = await this.matchRepository.All().FirstOrDefaultAsync(m => m.Id == id); 

            if (matchToUpdate == null)
            {
                return false;
            }

            this.mapper.Map(matchForm, matchToUpdate);

            await this.matchRepository.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteMatchAsync(Guid id)
        {
            int rowsAffected = await this.matchRepository.All()
                .Where(m => m.Id == id)
                .ExecuteDeleteAsync();

            return rowsAffected > 0;
        }

        public async Task<MatchDetailsViewModel?> GetMatchDetailsByIdAsync(Guid id)
        {
            return await this.matchRepository
                .AllAsNoTracking()
                .Where(m => m.Id == id)
                .ProjectTo<MatchDetailsViewModel>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
        }
        public async Task<MatchFormViewModel?> GetMatchForEditByIdAsync(Guid id)
        {
            return await this.matchRepository
                .AllAsNoTracking()
                .Where(m => m.Id == id)
                .ProjectTo<MatchFormViewModel>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<MatchInfoViewModel>> GetAllMatchesForIndexAsync()
        {
            return await this.matchRepository
                .AllAsNoTracking()
               .OrderByDescending(m => m.DateTime)
               .ThenByDescending(m => m.Id)
               .ProjectTo<MatchInfoViewModel>(this.mapper.ConfigurationProvider)
               .ToListAsync();
        }

        public async Task PopulateMatchFormViewModelAsync(MatchFormViewModel model)
        {
            IEnumerable<PlayerSelectItemViewModel> players;

            if (!string.IsNullOrWhiteSpace(model.Tour))
            {
                model.Tournaments = await this.tournamentService.GetTournamentsByTourWithVenueAsync(model.Tour)
                    ?? Enumerable.Empty<TournamentSelectItemViewModel>();

                players = await this.playerService.GetPlayersByTourAsync(model.Tour)
                    ?? Enumerable.Empty<PlayerSelectItemViewModel>();
            }
            else
            {
                model.Tournaments = Enumerable.Empty<TournamentSelectItemViewModel>();

                players = await this.playerService.GetPlayersForSelectAsync()
                    ?? Enumerable.Empty<PlayerSelectItemViewModel>();
            }

            model.Players = this.mapper.Map<IEnumerable<SelectListItem>>(players);
        }
    }
}

