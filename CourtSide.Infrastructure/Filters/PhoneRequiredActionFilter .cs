
namespace CourtSide.Web.Infrastructure.Filters
{
    using System.Net;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.AspNetCore.Mvc.Filters;

    public class PhoneRequiredActionFilter : IAsyncActionFilter
    {
        private readonly UserManager<IdentityUser> userManager;

        public PhoneRequiredActionFilter(UserManager<IdentityUser> userManager)
        {
            this.userManager = userManager;
        }

        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (context.HttpContext.User?.Identity?.IsAuthenticated != true)
            {
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                return;
            }

            IdentityUser? dbUser = await this.userManager.GetUserAsync(context.HttpContext.User);
            if (dbUser == null ||
                string.IsNullOrWhiteSpace(dbUser.PhoneNumber) ||
                !dbUser.PhoneNumberConfirmed)
            {
                context.HttpContext.Response.StatusCode = (int)HttpStatusCode.Forbidden;
                return;
            }

            await next();
        }
    }
}