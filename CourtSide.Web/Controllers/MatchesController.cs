namespace CourtSide.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using CourtSide.Common.MatchEnumerations;
    using CourtSide.Services.Core.Contracts;
    using CourtSide.ViewModels.Matches;
    using CourtSide.ViewModels.Players;
    using CourtSide.ViewModels.Tournaments;
    using CourtSide.ViewModels.Venues;

    public class MatchesController : BaseController
    {
        private readonly IMatchService matchService;
        private readonly IPlayerService playerService;
        private readonly ITournamentService tournamentService;
        private readonly IVenueService venueService;

        public MatchesController(
            IMatchService matchService,
            ITournamentService tournamentService,
            IVenueService venueService, IPlayerService playerService)
        {
            this.matchService = matchService;
            this.tournamentService = tournamentService;
            this.venueService = venueService;
            this.playerService = playerService;
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
            await this.PopulateDropdownsAsync(model);

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
                await this.PopulateDropdownsAsync(matchForm);
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

            await this.PopulateDropdownsAsync(matchForm);
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

            // 1. Scheduled matches MUST NOT have a score result
            if (matchForm.MatchStatus == MatchStatus.Scheduled && !string.IsNullOrWhiteSpace(matchForm.ScoreResult))
            {
                this.ModelState.AddModelError(nameof(matchForm.ScoreResult), "Score result cannot be entered for a scheduled match.");
            }

            // 2. Completed OR InProgress matches MUST have a score result
            bool isCompleted = matchForm.MatchStatus == MatchStatus.Completed;
            bool isInProgress = matchForm.MatchStatus == MatchStatus.InProgress;

            if ((isCompleted || isInProgress) && string.IsNullOrWhiteSpace(matchForm.ScoreResult))
            {
                this.ModelState.AddModelError(nameof(matchForm.ScoreResult), "Score result is required when status is Completed or In Progress.");
            }

            // 3. Winner validations for Completed status
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

            // 4. Validate ModelState after all checks
            if (!this.ModelState.IsValid)
            {
                await this.PopulateDropdownsAsync(matchForm);
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

        private async Task PopulateDropdownsAsync(MatchFormViewModel model)
        {
            IEnumerable<PlayerSelectViewModel>? players = await this.playerService.GetPlayersForSelectAsync();
            model.Players = players.Select(p => new SelectListItem
            {
                Value = p.Id.ToString(),
                Text = p.FullName
            });

            IEnumerable<TournamentInfoViewModel>? tournaments = await this.tournamentService.GetAllTournamentsForIndexAsync();
            model.Tournaments = tournaments.Select(t => new SelectListItem
            {
                Value = t.Id.ToString(),
                Text = $"{t.TournamentName} ({t.TournamentType})"
            });

            IEnumerable<VenueSelectViewModel>? venues = await this.venueService.GetAllVenuesAsync();
            model.Venues = venues.Select(v => new SelectListItem
            {
                Value = v.Id.ToString(),
                Text = v.Name
            });
        }

        [HttpGet]
        public async Task<IActionResult> GetPlayersByTournament(int? tournamentId)
        {
            IEnumerable<PlayerSelectViewModel> players;

            if (!tournamentId.HasValue || tournamentId.Value <= 0)
            {
                players = await this.playerService.GetPlayersForSelectAsync();
            }
            else
            {
                players = await this.playerService.GetPlayersByTournamentIdAsync(tournamentId.Value);
            }

            var result = players.Select(p => new
            {
                id = p.Id,
                fullName = p.FullName
            });

            return this.Json(result);
        }
    }
}
