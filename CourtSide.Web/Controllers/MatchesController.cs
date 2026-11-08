namespace CourtSide.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    using CourtSide.Common.MatchEnumerations;
    using CourtSide.Services.Core.Contracts;
    using CourtSide.ViewModels.Matches;
    using CourtSide.ViewModels.Players;

    public class MatchesController : BaseController
    {
        private readonly IMatchService matchService;
        private readonly IPlayerService playerService;
        private readonly ITournamentService tournamentService;
        private readonly IVenueService venueService;
        private readonly ICourtService courtService;

        public MatchesController(
            IMatchService matchService,
            ITournamentService tournamentService,
            IVenueService venueService,
            IPlayerService playerService,
            ICourtService courtService)
        {
            this.matchService = matchService;
            this.tournamentService = tournamentService;
            this.venueService = venueService;
            this.playerService = playerService;
            this.courtService = courtService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            IEnumerable<MatchInfoViewModel> matches = await
                this.matchService.GetAllMatchesForIndexAsync();

            return this.View(matches);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            if (id <= 0)
            {
                return this.BadRequest();
            }

            MatchDetailsViewModel? matchDetails = await
                this.matchService.GetMatchDetailsByIdAsync(id);

            if (matchDetails == null)
            {
                return this.NotFound();
            }

            return this.View(matchDetails);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create()
        {
            MatchFormViewModel model = new MatchFormViewModel();
            await this.matchService.PopulateMatchFormViewModelAsync(model);

            return this.View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MatchFormViewModel matchForm)
        {
            if (matchForm.MatchStatus == MatchStatus.Scheduled && !string.IsNullOrWhiteSpace(matchForm.ScoreResult))
            {
                this.ModelState.AddModelError(nameof(matchForm.ScoreResult), "Score result cannot be entered for a scheduled match.");
            }

            bool isCompleted = matchForm.MatchStatus == MatchStatus.Completed;
            bool isInProgress = matchForm.MatchStatus == MatchStatus.InProgress;

            if ((isCompleted || isInProgress) && string.IsNullOrWhiteSpace(matchForm.ScoreResult))
            {
                this.ModelState.AddModelError(nameof(matchForm.ScoreResult), "Score result is required when status is Completed or In Progress.");
            }

            if (isCompleted && !matchForm.WinnerId.HasValue)
            {
                this.ModelState.AddModelError(nameof(matchForm.WinnerId),
                    "A winner must be selected when the match status is Completed.");
            }

            if (!isCompleted && matchForm.WinnerId.HasValue)
            {
                this.ModelState.AddModelError(nameof(matchForm.WinnerId),
                    "A winner can only be assigned if the match status is Completed.");
            }

            if (!this.ModelState.IsValid)
            {
                await this.matchService.PopulateMatchFormViewModelAsync(matchForm);
                return this.View(matchForm);
            }

            int createdMatchId = await this.matchService
                .CreateMatchAsync(matchForm);

            return this.RedirectToAction(nameof(Details),
                new { id = createdMatchId });
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(int id)
        {
            if (id <= 0)
            {
                return this.BadRequest();
            }

            MatchFormViewModel? matchForm = await this.matchService
                .GetMatchForEditByIdAsync(id);

            if (matchForm == null)
            {
                return this.NotFound();
            }

            await this.matchService.PopulateMatchFormViewModelAsync(matchForm);
            return this.View(matchForm);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, MatchFormViewModel matchForm)
        {
            if (id <= 0)
            {
                return this.BadRequest();
            }

            if (matchForm.MatchStatus == MatchStatus.Scheduled && !string.IsNullOrWhiteSpace(matchForm.ScoreResult))
            {
                this.ModelState.AddModelError(nameof(matchForm.ScoreResult), "Score result cannot be entered for a scheduled match.");
            }

            bool isCompleted = matchForm.MatchStatus == MatchStatus.Completed;
            bool isInProgress = matchForm.MatchStatus == MatchStatus.InProgress;

            if ((isCompleted || isInProgress) && string.IsNullOrWhiteSpace(matchForm.ScoreResult))
            {
                this.ModelState.AddModelError(nameof(matchForm.ScoreResult), "Score result is required when status is Completed or In Progress.");
            }

            if (isCompleted && !matchForm.WinnerId.HasValue)
            {
                this.ModelState.AddModelError(nameof(matchForm.WinnerId),
                    "A winner must be selected when the match status is Completed.");
            }

            if (!isCompleted && matchForm.WinnerId.HasValue)
            {
                this.ModelState.AddModelError(nameof(matchForm.WinnerId),
                    "A winner can only be assigned if the match status is Completed.");
            }

            if (!this.ModelState.IsValid)
            {
                await this.matchService.PopulateMatchFormViewModelAsync(matchForm);
                return this.View(matchForm);
            }

            bool isUpdated = await this.matchService.UpdateMatchAsync(id, matchForm);

            if (!isUpdated)
            {
                return this.NotFound();
            }

            return this.RedirectToAction(nameof(Details),
                new { id = id });
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
            {
                return this.BadRequest();
            }

            MatchDetailsViewModel? matchDetails = await this.matchService
                .GetMatchDetailsByIdAsync(id);

            if (matchDetails == null)
            {
                return this.NotFound();
            }

            return this.View(matchDetails);
        }

        [HttpPost, ActionName("DeleteConfirmed")]
        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            bool isDeleted = await this.matchService.DeleteMatchAsync(id);

            if (!isDeleted)
            {
                return this.NotFound();
            }

            return this.RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> GetPlayersByTournament(int? tournamentId, string? tour)
        {
            IEnumerable<PlayerSelectViewModel> players;

            if (tournamentId.HasValue && tournamentId.Value > 0)
            {
                players = await this.playerService.GetPlayersByTournamentIdAsync(tournamentId.Value);
            }
            else if (!string.IsNullOrWhiteSpace(tour))
            {
                players = await this.playerService.GetPlayersByTourAsync(tour);
            }
            else
            {
                players = await this.playerService.GetPlayersForSelectAsync();
            }

            var result = players.Select(p => new
            {
                id = p.Id,
                fullName = p.FullName
            });

            return this.Json(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetTournamentsByTour(string tour)
        {
            var tournaments = await this.tournamentService.GetTournamentsByTourWithVenueAsync(tour);
            return this.Json(tournaments);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllVenues()
        {
            var venues = await this.venueService.GetAllVenuesAsync();

            var result = venues.Select(v => new
            {
                id = v.Id,
                name = v.Name
            });

            return this.Json(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetPlayersByTour(string tour)
        {
            IEnumerable<PlayerSelectViewModel> players = await this.playerService.GetPlayersByTourAsync(tour);

            var result = players.Select(p => new
            {
                id = p.Id,
                fullName = p.FullName
            });

            return this.Json(result);
        }

        [HttpGet]
        public async Task<IActionResult> GetCourtsByVenue(int venueId)
        {
            var courts = await this.courtService.GetCourtsByVenueIdAsync(venueId);
            return this.Json(courts);
        }
    }
}