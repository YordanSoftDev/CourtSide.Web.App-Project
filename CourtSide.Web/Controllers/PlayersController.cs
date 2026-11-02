namespace CourtSide.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using CourtSide.Services.Core.Contracts;
    using CourtSide.ViewModels.Players;

    public class PlayersController : BaseController
    {
        private readonly IPlayerService service;

        public PlayersController(IPlayerService service)
        {
            this.service = service;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Index(string category = "ATP")
        {
            IEnumerable<PlayerInfoViewModel> players;

            if (category == "WTA")
            {
                players = await
                    this.service.GetAllWomensPlayersForIndexAsync();
            }
            else
            {
                players = await
                    this.service.GetAllMensPlayersForIndexAsync();
            }

            return this.View(players);

        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            if (id <= 0)
            {
                return this.BadRequest();
            }

            PlayerDetailsViewModel? playerDetails = await
                this.service.GetPlayerDetailsByIdAsync(id);

            if (playerDetails == null)
            {
                return this.NotFound();
            }

            return this.View(playerDetails);
        }

        [HttpGet]
        public IActionResult Create()
        {
            PlayerFormViewModel playerForm = new PlayerFormViewModel();

            return this.View(playerForm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PlayerFormViewModel playerForm)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View(playerForm);
            }

            int createdPlayerId = await this.service
                .CreatePlayerAsync(playerForm);

            return this.RedirectToAction(nameof(Details),
                new { id = createdPlayerId });
        }

        [HttpGet]
        public async Task<IActionResult?> Edit(int id)
        {
            if (id <= 0)
            {
                return this.BadRequest();
            }

            PlayerFormViewModel? playerForm = await
                this.service.GetPlayerForEditByIdAsync(id);

            if (playerForm == null)
            {
                return this.NotFound();
            }

            return this.View(playerForm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, PlayerFormViewModel playerForm)
        {
            if (id <= 0)
            {
                return this.BadRequest();
            }

            if (!this.ModelState.IsValid)
            {
                return this.View(playerForm);
            }

            bool isUpdated = await this.service
                .UpdatePlayerAsync(id, playerForm);

            if (!isUpdated)
            {
                return this.NotFound();
            }

            return this.RedirectToAction(nameof(Details),
                new { id = id });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
            {
                return this.BadRequest();
            }

            PlayerDetailsViewModel? playerDetails = await this.service
                .GetPlayerDetailsByIdAsync(id);

            if (playerDetails == null)
            {
                return this.NotFound();
            }

            return this.View(playerDetails);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            bool isDeleted = await this.service.DeletePlayerAsync(id);

            if (!isDeleted)
            {
                return this.NotFound();
            }

            return this.RedirectToAction(nameof(Index));
        }


    }
}
