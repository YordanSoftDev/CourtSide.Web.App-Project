namespace CourtSide.Infrastructure.Extensions
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.AspNetCore.Builder;

    using CourtSide.Data.Seeding;

    public static class WebApplicationExtensions
    {
        public static void UseDefaultRoles(this WebApplication app, IConfiguration configuration)
        {
            using IServiceScope serviceScope = app.Services.CreateScope();
            IServiceProvider serviceProvider = serviceScope.ServiceProvider;

            string adminEmail = configuration.GetValue<string>("UserSeed:AdminAccount:Email")
                ?? throw new ArgumentException("Missing configuration value 'UserSeed:AdminAccount:Email'.");

            string adminPassword = configuration.GetValue<string>("UserSeed:AdminAccount:Password")
                ?? throw new ArgumentException("Missing configuration value 'UserSeed:AdminAccount:Password'.");

            IdentitySeeder.SeedRolesAsync(serviceProvider).GetAwaiter().GetResult();
            IdentitySeeder.SeedAdminUserAsync(serviceProvider, adminEmail, adminPassword).GetAwaiter().GetResult();
        }
    }
}