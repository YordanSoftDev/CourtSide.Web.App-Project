namespace CourtSide.Web
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity;

    using CourtSide.Data.Persistance;
    using CourtSide.Services.Core.Contracts;
    using CourtSide.Services.Core.Services;
    using CourtSide.Infrastructure.Extensions;

    public class Program
    {
        private static void Main(string[] args)
        {
            WebApplicationBuilder? builder = WebApplication.CreateBuilder(args);

            string connectionName = builder.Environment.IsDevelopment() ? "SqlServerDev" : "SqlServerConnection";
            string? connectionString = builder.Configuration.GetConnectionString(connectionName);

            if (string.IsNullOrWhiteSpace(connectionString))
            {
                throw new InvalidOperationException($"Connection string '{connectionName}' was not found or is empty in configuration.");
            }

            builder.Services.AddDbContext<CourtSideDbContext>(options =>
                options.UseSqlServer(connectionString));

            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddAutoMapper(cfg =>
                cfg.AddMaps(typeof(CourtService).Assembly));
            builder.Services.AddAutoMapper(cfg =>
                cfg.AddMaps(typeof(MatchService).Assembly));
            builder.Services.AddAutoMapper(cfg =>
                cfg.AddMaps(typeof(PlayerService).Assembly));
            builder.Services.AddAutoMapper(cfg =>
                cfg.AddMaps(typeof(TournamentService).Assembly));
            builder.Services.AddAutoMapper(cfg =>
                cfg.AddMaps(typeof(VenueService).Assembly));

            builder.Services.RegisterRepositoriesFromAssembly(typeof(CourtSideDbContext).Assembly);

            builder.Services.AddScoped<IMatchService, MatchService>();
            builder.Services.AddScoped<IPlayerService, PlayerService>();
            builder.Services.AddScoped<ITournamentService, TournamentService>();
            builder.Services.AddScoped<IVenueService, VenueService>();
            builder.Services.AddScoped<ICourtService, CourtService>();

            //builder.Services.AddScoped<ISlugGenerator, SlugGenerator>();

            builder.Services.AddCors(opt =>
            {
                opt.AddPolicy("AllowSoftUniDomain", cfg =>
                {
                    cfg.WithOrigins("https://softuni.bg")
                        .WithMethods("GET", "POST")
                        .AllowAnyHeader();
                });
            });

            builder.Services.AddDefaultIdentity<IdentityUser>(options =>
            {
                ConfigureIdentityOptions(builder.Configuration, options);
            })
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<CourtSideDbContext>();

            //builder.Services.AddScoped<PhoneRequiredActionFilter>();

            //builder.Services.AddIdentity<IdentityUser, IdentityRole>(options =>
            //{
            //    ConfigureIdentityOptions(builder.Configuration, options);
            //})
            //    .AddRoles<IdentityRole>()
            //    .AddUserManager<UserManager<IdentityUser>>()
            //    .AddSignInManager<SignInManager<IdentityUser>>()
            //    .AddDefaultTokenProviders()
            //    .AddDefaultUI()
            //    .AddEntityFrameworkStores<CinemaAppDbContext>();

            builder.Services.Configure<SecurityStampValidatorOptions>(opt =>
            {
                opt.ValidationInterval = TimeSpan.FromMinutes(1);
            });

            //builder.Services
            //    .AddHttpContextAccessor()
            //    .AddDefaultSitemapServices<HttpContextBaseUrlProvider>()
            //    .AddSitemapMiddleware(opt =>
            //    {
            //        opt.EndpointInclusionMode = EndpointInclusionMode.OptOut;
            //        opt.CacheEnabled = true;
            //    });

            builder.Services.AddEndpointsApiExplorer();

            //builder.Services.AddSwaggerGen();

            builder.Services.AddControllersWithViews();
            builder.Services.AddRazorPages();

            WebApplication? app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();

                //app.UseSwagger();
                //app.UseSwaggerUI();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseStatusCodePagesWithReExecute("/Home/Error", "?statusCode={0}");

            app.UseAuthentication();
            app.UseAuthorization();

            app.MapStaticAssets();

            //app.UseAdminHomePageRedirection("/Admin/Home");

            app.UseCors("AllowCourtSideDomain");

            //app.UseSitemap();

            //app.MapControllerRoute(
            //    name: "areas",
            //    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

            //app.MapControllerRoute(
            //    name: "slug",
            //    pattern: "{controller=Matches}/{action=Index}/{slug:exists}/{id:exists}");

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.MapRazorPages();

            //UseDefaultRoles(app, app.Configuration);

            app.Run();
        }

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

        //private static void UseDefaultRoles(WebApplication app, IConfiguration configuration)
        //{
        //    using IServiceScope serviceScope = app.Services.CreateScope();
        //    IServiceProvider serviceProvider = serviceScope.ServiceProvider;

        //    string adminEmail = configuration.GetValue<string>("UserSeed:AdminAccount:Email")
        //                        ?? throw new ArgumentException();
        //    string adminPassword = configuration.GetValue<string>("UserSeed:AdminAccount:Password")
        //                           ?? throw new ArgumentException();

        //    IdentitySeeder.SeedRoles(serviceProvider);
        //    IdentitySeeder.SeedAdminUser(serviceProvider, adminEmail, adminPassword);
        //}
    }
}

