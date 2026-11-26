namespace CourtSide.Web
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.AspNetCore.Identity;

    using CourtSide.Data.Persistance;
    using CourtSide.Services.Core.Contracts;
    using CourtSide.Services.Core.Services;
    using CourtSide.Infrastructure.Extensions;
    using CourtSide.Web.Infrastructure.Filters;

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
            {
                cfg.AddMaps
                (typeof(CourtService).Assembly,
                typeof(MatchService).Assembly,
                typeof(PlayerService).Assembly,
                typeof(TournamentService).Assembly,
                typeof(VenueService).Assembly);
            });

            builder.Services.RegisterRepositoriesFromAssembly(typeof(CourtSideDbContext).Assembly);

            builder.Services.AddScoped<IMatchService, MatchService>();
            builder.Services.AddScoped<IPlayerService, PlayerService>();
            builder.Services.AddScoped<ITournamentService, TournamentService>();
            builder.Services.AddScoped<IVenueService, VenueService>();
            builder.Services.AddScoped<ICourtService, CourtService>();

            //builder.Services.AddScoped<ISlugGenerator, SlugGenerator>();

            builder.Services.AddCors(opt =>
            {
                opt.AddPolicy("AllowCourtSideDomain", cfg =>
                {
                    cfg.WithOrigins("https://softuni.bg")
                        .WithMethods("GET", "POST")
                        .AllowAnyHeader();
                });
            });

            builder.Services.AddDefaultIdentity<IdentityUser>(options =>
            {
                ServiceCollectionExtensions.ConfigureIdentityOptions(builder.Configuration, options);
            })
            .AddRoles<IdentityRole>()
            .AddEntityFrameworkStores<CourtSideDbContext>();

            builder.Services.AddScoped<PhoneRequiredActionFilter>();

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

            app.UseDefaultRoles(app.Configuration);

            app.Run();
        } 
    }
}

