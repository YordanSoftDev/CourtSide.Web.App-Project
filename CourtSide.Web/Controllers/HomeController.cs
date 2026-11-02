namespace CourtSide.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using System.Diagnostics;
    using CourtSide.Web.ViewModels;

    [AllowAnonymous]
    public class HomeController : BaseController
    {
        public IActionResult Index()
        {
            if(this.IsUserAuthenticated == false)
            {
                this.RedirectToAction("Index", "Home");
            }
            return this.View();
        }

        public IActionResult Privacy()
        {
            return this.View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return this.View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? this.HttpContext.TraceIdentifier });
        }
    }
}
