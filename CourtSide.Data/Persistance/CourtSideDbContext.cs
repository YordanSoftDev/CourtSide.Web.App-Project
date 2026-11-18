namespace CourtSide.Data.Persistance
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using CourtSide.Data.Models;
    using Microsoft.AspNetCore.Identity;

    public partial class CourtSideDbContext : IdentityDbContext<IdentityUser>
    {
        public CourtSideDbContext(DbContextOptions<CourtSideDbContext> options)
        : base(options)
        {
        }

        public DbSet<IdentityUser> IdentityUsers { get; set; }
        public virtual DbSet<Coach> Coaches { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<Court> Courts { get; set; } = null!;
        public virtual DbSet<Match> Matches { get; set; } = null!;
        public virtual DbSet<Player> Players { get; set; } = null!;
        public virtual DbSet<Tournament> Tournaments { get; set; } = null!;
        public virtual DbSet<TournamentVenue> TournamentVenues { get; set; } = null!;
        public virtual DbSet<Venue> Venues { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var playerEntityType = modelBuilder.Model.FindEntityType(typeof(Player));
            if (playerEntityType != null)
            {
                var seeds = playerEntityType.GetSeedData();
                foreach (var seed in seeds)
                {
                    System.Diagnostics.Debug.WriteLine($"Player Seed -> ID: {seed["Id"]}, Name: {(seed.ContainsKey("FirstName") ? seed["FirstName"] : "N/A")} {(seed.ContainsKey("LastName") ? seed["LastName"] : "")}");
                }
            }

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CourtSideDbContext).Assembly);

            this.OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
