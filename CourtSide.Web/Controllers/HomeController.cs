namespace CourtSide.Web.Controllers
{
    using CourtSide.Web.ViewModels;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc;
    using System.Diagnostics;

    [AllowAnonymous]
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> logger;
        private readonly UserManager<IdentityUser> userManager;

        public HomeController(ILogger<HomeController> logger, UserManager<IdentityUser> userManager)
        {
            this.logger = logger;
            this.userManager = userManager;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Index()
        {
            if(this.IsUserAuthenticated == false)
            {
                this.RedirectToAction("Index", "Home");
            }
            return this.View();
        }

        [AllowAnonymous]
        [HttpGet]
        //[ServiceFilter(typeof(PhoneRequiredActionFilter))]
        public IActionResult Privacy()
        {
            return this.View();
        }

        [AllowAnonymous]
        [HttpGet]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int? statusCode)
        {
            this.ViewData["RequestId"] = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier;

            switch (statusCode)
            {
                case StatusCodes.Status400BadRequest:
                    return this.View("BadRequest");
                case StatusCodes.Status403Forbidden:
                    return this.View("Forbidden");
                case StatusCodes.Status404NotFound:
                    return this.View("NotFound");
                case null:
                case StatusCodes.Status500InternalServerError:
                    return this.View("ServerError");
            }

            return this.View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
