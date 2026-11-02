using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using CourtSide.Data.Persistance;
using CourtSide.Services.Core.Contracts;
using CourtSide.Services.Core.Services;

WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();

string connectionName = builder.Environment.IsDevelopment() ? "SqlServerDev" : "SqlServerConnection";
string? connectionString = builder.Configuration.GetConnectionString(connectionName);

if (string.IsNullOrWhiteSpace(connectionString))
{
    throw new InvalidOperationException($"Connection string '{connectionName}' was not found or is empty in configuration.");
}

builder.Services.AddDbContext<CourtSideDbContext>(options =>
    options.UseSqlServer(connectionString));

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
