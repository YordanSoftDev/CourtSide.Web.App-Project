using CourtSide.Data.Configurations;
using CourtSide.Data.Persistance;
using CourtSide.Services.Core.Contracts;
using CourtSide.Services.Core.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);

SeedingValidator.ValidateSeedConsistency();

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

string connectionName = builder.Environment.IsDevelopment() ? "SqlServerDev" : "SqlServerConnection";
string? connectionString = builder.Configuration.GetConnectionString(connectionName);

if (string.IsNullOrWhiteSpace(connectionString))
{
    throw new InvalidOperationException($"Connection string '{connectionName}' was not found or is empty in configuration.");
}

builder.Services.AddDbContext<CourtSideDbContext>(options =>
    options.UseSqlServer(connectionString).EnableSensitiveDataLogging().EnableDetailedErrors());

builder.Services.AddDefaultIdentity<IdentityUser>(options =>
{
    ConfigureIdentityOptions(builder.Configuration, options);
})
.AddRoles<IdentityRole>()
.AddEntityFrameworkStores<CourtSideDbContext>();

builder.Services.AddAutoMapper(cfg =>
    cfg.AddMaps(typeof(MatchService).Assembly));

builder.Services.AddScoped<IMatchService, MatchService>();
builder.Services.AddScoped<IPlayerService, PlayerService>();
builder.Services.AddScoped<ITournamentService, TournamentService>();
builder.Services.AddScoped<IVenueService, VenueService>();
builder.Services.AddScoped<ICourtService, CourtService>();

WebApplication? app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

app.MapRazorPages();

app.Run();

static void ConfigureIdentityOptions(ConfigurationManager 
    configuration, IdentityOptions options)
{
    options.SignIn.RequireConfirmedAccount = configuration
        .GetValue<bool>("IdentitySettings:SignIn:RequireConfirmedAccount");

    options.Password.RequireDigit = configuration
        .GetValue<bool>("IdentitySettings:Password:RequireDigit");
    options.Password.RequireLowercase = configuration
        .GetValue<bool>("IdentitySettings:Password:RequireLowercase");
    options.Password.RequireUppercase = configuration
        .GetValue<bool>("IdentitySettings:Password:RequireUppercase");
    options.Password.RequireNonAlphanumeric = configuration
        .GetValue<bool>("IdentitySettings:Password:RequireNonAlphanumeric");
    options.Password.RequiredLength = configuration
        .GetValue<int>("IdentitySettings:Password:RequiredLength");
    options.Password.RequiredUniqueChars = configuration
        .GetValue<int>("IdentitySettings:Password:RequiredUniqueChars");

    options.User.RequireUniqueEmail = configuration
        .GetValue<bool>("IdentitySettings:User:RequireUniqueEmail");
}

public static class SeedingValidator
{
    public static void ValidateSeedConsistency()
    {
        // 1. Gather all valid Venue IDs from VenueConfiguration
        var venueIds = VenueConfiguration.DefaultVenues.Select(v => v.Id).ToHashSet();

        // 2. Collect all Tournament Venues
        var tournamentVenues = TournamentVenueConfiguration.DefaultMensTournamentVenues
            .Concat(TournamentVenueConfiguration.DefaultWomensTournamentVenues)
            .ToList();

        // 3. Find any TournamentVenue pointing to a Venue ID that doesn't exist
        var orphanVenues = tournamentVenues
            .Where(tv => !venueIds.Contains(tv.VenueId))
            .ToList();

        if (orphanVenues.Any())
        {
            throw new InvalidOperationException($"Found {orphanVenues.Count} TournamentVenue(s) with missing Venue seed records!");
        }

        // 4. Do the same for Courts if desired
        var orphanCourts = CourtConfiguration.DefaultCourts
            .Where(c => !venueIds.Contains(c.VenueId))
            .ToList();

        if (orphanCourts.Any())
        {
            throw new InvalidOperationException($"Found {orphanCourts.Count} Court(s) with missing Venue seed records!");
        }

        Console.WriteLine("All seed relationships are 100% synchronized!");
    }
}
