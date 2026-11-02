namespace CourtSide.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Threading.Tasks;
    using CourtSide.Services.Core.Contracts;
    using CourtSide.ViewModels.Tournaments;

    public class TournamentsController : BaseController
    {
        private readonly ITournamentService service;

        public TournamentsController(ITournamentService tournamentService)
        {
            this.service = tournamentService;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Index() //My tournaments
        {
            IEnumerable<TournamentInfoViewModel>? tournaments =
                await this.service
                .GetAllTournamentsForIndexAsync();

            return this.View(tournaments);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id) //Tournament overview
        {
            if (id <= 0)
            {
                return this.BadRequest();
            }

            TournamentDetailsViewModel? tournamentModel = await this
                .service.GetTournamentDetailsByIdAsync(id);

            if (tournamentModel == null)
            {
                return this.NotFound();
            }

            return this.View(tournamentModel);
        }

        [HttpGet]
        public async Task<IActionResult> Create() //Display the form to register a new tournament
        {
            TournamentFormViewModel? model = new TournamentFormViewModel();

            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create //Process and save the new tournament submission 
            (TournamentFormViewModel model)
        {
            if (model.StartDate > model.EndDate)
            {
                this.ModelState.AddModelError(nameof(model.EndDate),
                    "End data cannot be earlier than start date.");
            }

            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            int createdId = await this.service
                .CreateTournamentAsync(model);
            return this.RedirectToAction(nameof(Details), new { id = createdId });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id) //Display the form to edit an existing tournament
        {
            if (id <= 0)
            {
                return this.BadRequest();
            }

            TournamentFormViewModel? model = await this.service
                .GetTournamentForEditByIdAsync(id);

            if (model == null)
            {
                return this.NotFound();
            }

            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TournamentFormViewModel model) //Process and save the updated tournament changes 
        {
            if (id <= 0)
            {
                return this.BadRequest();
            }

            if (model.StartDate > model.EndDate)
            {
                this.ModelState.AddModelError(nameof(model.EndDate),
                    "End date cannot be earlier than start date.");
            }

            if (!this.ModelState.IsValid)
            {
                return this.View(model);
            }

            bool isUpdated = await this.service
                .UpdateTournamentAsync(id, model);

            if (!isUpdated)
            {
                return this.NotFound();
            }

            return this.RedirectToAction(nameof(Details), new { id });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id) //Display the delete confirmation page for a tournament
        {
            if (id <= 0)
            {
                return this.BadRequest();
            }

            TournamentDetailsViewModel? tournamentModel = await
                this.service.GetTournamentDetailsByIdAsync(id);

            if (tournamentModel == null)
            {
                return this.NotFound();
            }

            if (tournamentModel.IsActive)
            {
                this.TempData["ErrorMessage"] = "Active tournaments cannot be deleted.";
                return this.RedirectToAction(nameof(Details), new { id });
            }

            return this.View(tournamentModel);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id) //Process and permanently delete the tournament record
        {
            bool isDeleted = await this.service.DeleteTournamentAsync(id);

            if (!isDeleted)
            {
                return this.NotFound();
            }

            return this.RedirectToAction(nameof(Index));
        }
    }
}