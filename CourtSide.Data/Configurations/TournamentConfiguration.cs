namespace CourtSide.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using CourtSide.Common.MatchEnumerations;
    using CourtSide.Data.Models;

    public class TournamentConfiguration : IEntityTypeConfiguration<Tournament>
    {
        public void Configure(EntityTypeBuilder<Tournament> builder)
        {
            builder.Property(t => t.CourtSurface)
                .HasConversion<string>();

            builder.Property(t => t.CourtEnvironment)
               .HasConversion<string>();

            builder.HasMany(v => v.TournamentVenues)
           .WithOne(tv => tv.Tournament)
           .HasForeignKey(tv => tv.TournamentId)
           .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(DefaultMensTournaments.Concat(DefaultWomensTournaments));
        }
        public static IEnumerable<Tournament> DefaultMensTournaments =>
             new List<Tournament>
             {
                 new Tournament
                 {
                     Id = 1,
                     TournamentName = "Lyon Open",
                     Location = "Lyon, France",
                     StartDate = new DateTime(2026,  10,      19,      0, 0, 0,    DateTimeKind.Utc),
                     EndDate = new DateTime(2026, 10,     25,        0,     0, 0,     DateTimeKind.Utc),
                     TournamentType = "ATP 250",
                     CourtSurface = CourtSurface.Hard,
                     CourtEnvironment = CourtEnvironment.Indoor,
                 },
                 new Tournament
                 {
                     Id = 2,
                     TournamentName = "Rolex Paris Masters",
                     Location = "Paris, France",
                     StartDate = new DateTime(2026, 11, 2, 0, 0, 0, DateTimeKind.Utc),
                     EndDate = new DateTime(2026, 11, 8, 0, 0, 0, DateTimeKind.Utc),
                     TournamentType = "ATP 1000",
                     CourtSurface = CourtSurface.Hard,
                     CourtEnvironment = CourtEnvironment.Indoor,
                 },
                 new Tournament
                 {
                     Id = 3,
                     TournamentName = "US Open",
                     Location = "New York, USA",
                     StartDate = new DateTime(2026, 8, 31, 0, 0, 0, DateTimeKind.Utc),
                     EndDate = new DateTime(2026, 9, 13, 0, 0, 0, DateTimeKind.Utc),
                     TournamentType = "Grand Slam Mens",
                     CourtSurface = CourtSurface.Hard,
                     CourtEnvironment = CourtEnvironment.Outdoor,
                 },
                 new Tournament
                 {
                     Id = 4,
                     TournamentName = "Almaty Open",
                     Location = "Almaty, Kazakhstan",
                     StartDate = new DateTime(2026, 10, 19, 0, 0, 0, DateTimeKind.Utc),
                     EndDate = new DateTime(2026, 10, 25, 0, 0, 0, DateTimeKind.Utc),
                     TournamentType = "ATP 250",
                     CourtSurface = CourtSurface.Hard,
                     CourtEnvironment = CourtEnvironment.Indoor,
                 },
                 new Tournament
                 {
                     Id = 5,
                     TournamentName = "Australian Open",
                     Location = "Melbourne, Australia",
                     StartDate = new DateTime(2026, 1, 18, 0, 0, 0, DateTimeKind.Utc),
                     EndDate = new DateTime(2026, 1, 31, 0, 0, 0, DateTimeKind.Utc),
                     TournamentType = "Grand Slam Mens",
                     CourtSurface = CourtSurface.Hard,
                     CourtEnvironment = CourtEnvironment.Outdoor,
                 },
                 new Tournament
                 {
                     Id = 6,
                     TournamentName = "Monte-Carlo Masters",
                     Location = "Roquebrune-Cap-Martin, France",
                     StartDate = new DateTime(2026, 4, 12, 0, 0, 0, DateTimeKind.Utc),
                     EndDate = new DateTime(2026, 4, 19, 0, 0, 0, DateTimeKind.Utc),
                     TournamentType = "ATP 1000",
                     CourtSurface = CourtSurface.Clay,
                     CourtEnvironment = CourtEnvironment.Outdoor,
                 },
                 new Tournament
                 {
                     Id = 7,
                     TournamentName = "Mutua Madrid Open",
                     Location = "Madrid, Spain",
                     StartDate = new DateTime(2026, 5, 4, 0, 0, 0, DateTimeKind.Utc),
                     EndDate = new DateTime(2026, 5, 17, 0, 0, 0, DateTimeKind.Utc),
                     TournamentType = "ATP 1000",
                     CourtSurface = CourtSurface.Clay,
                     CourtEnvironment = CourtEnvironment.Outdoor,
                 },
                 new Tournament
                 {
                     Id = 8,
                     TournamentName = "Italian Open",
                     Location = "Rome, Italy",
                     StartDate = new DateTime(2026, 5, 11, 0, 0, 0, DateTimeKind.Utc),
                     EndDate = new DateTime(2026, 5, 24, 0, 0, 0, DateTimeKind.Utc),
                     TournamentType = "ATP 1000",
                     CourtSurface = CourtSurface.Clay,
                     CourtEnvironment = CourtEnvironment.Outdoor,
                 },
                 new Tournament
                 {
                     Id = 9,
                     TournamentName = "Cinch Championships",
                     Location = "London, United Kingdom",
                     StartDate = new DateTime(2026, 6, 15, 0, 0, 0, DateTimeKind.Utc),
                     EndDate = new DateTime(2026, 6, 21, 0, 0, 0, DateTimeKind.Utc),
                     TournamentType = "ATP 500",
                     CourtSurface = CourtSurface.Grass,
                     CourtEnvironment = CourtEnvironment.Outdoor,
                 },
                 new Tournament
                 {
                     Id = 10,
                     TournamentName = "Swiss Indoors Basel",
                     Location = "Basel, Switzerland",
                     StartDate = new DateTime(2026, 10, 24, 0, 0, 0, DateTimeKind.Utc),
                     EndDate = new DateTime(2026, 11, 1, 0, 0, 0, DateTimeKind.Utc),
                     TournamentType = "ATP 500",
                     CourtSurface = CourtSurface.Hard,
                     CourtEnvironment = CourtEnvironment.Indoor,
                 },
                 new Tournament
                 {
                     Id = 11,
                     TournamentName = "Shanghai Masters",
                     Location = "Shanghai, China",
                     StartDate = new DateTime(2026, 10, 7, 0, 0, 0, DateTimeKind.Utc),
                     EndDate = new DateTime(2026, 10, 18, 0, 0, 0, DateTimeKind.Utc),
                     TournamentType = "ATP 1000",
                     CourtSurface = CourtSurface.Hard,
                     CourtEnvironment = CourtEnvironment.Outdoor,
                 },
                 new Tournament
                 {
                     Id = 12,
                     TournamentName = "European Open",
                     Location = "Brussels, Belgium",
                     StartDate = new DateTime(2026, 10, 17, 0, 0, 0, DateTimeKind.Utc),
                     EndDate = new DateTime(2026, 10, 25, 0, 0, 0, DateTimeKind.Utc),
                     TournamentType = "ATP 250",
                     CourtSurface = CourtSurface.Hard,
                     CourtEnvironment = CourtEnvironment.Indoor,
                 },
                 new Tournament
                 {
                     Id = 13,
                     TournamentName = "Bybit Stockholm Open",
                     Location = "Stockholm, Sweden",
                     StartDate = new DateTime(2026,  11,      8,       0, 0, 0,  DateTimeKind.Utc),
                     EndDate = new DateTime(2026, 11,     14,        0,     0, 0,  DateTimeKind.Utc),
                     TournamentType = "ATP 250",
                     CourtSurface = CourtSurface.Hard,
                     CourtEnvironment = CourtEnvironment.Indoor,
                 },
                 new Tournament
                 {
                     Id = 14,
                     TournamentName = "Nitto Finals",
                     Location = "Turin, Italy",
                     StartDate = new DateTime(2026,  11,      15,      0, 0, 0,  DateTimeKind.Utc),
                     EndDate = new DateTime(2026, 11,     22,        0,     0, 0,  DateTimeKind.Utc),
                     TournamentType = "ATP",
                     CourtSurface = CourtSurface.Hard,
                     CourtEnvironment = CourtEnvironment.Indoor,
                 },
                 new Tournament
                 {
                     Id = 15,
                     TournamentName = "Davis Cup Finals",
                     Location = "Bologna, Italy",
                     StartDate = new DateTime(2026,  11,      23,      0, 0, 0,  DateTimeKind.Utc),
                     EndDate = new DateTime(2026, 11,     29,        0,     0, 0,     DateTimeKind.Utc),
                     TournamentType = "ITF Mens",
                     CourtSurface = CourtSurface.Hard,
                     CourtEnvironment = CourtEnvironment.Indoor,
                 },
                 new Tournament
                 {
                     Id = 16,
                     TournamentName = "Next Gen Finals",
                     Location = "Reggio Calabria, Italy",
                     StartDate = new DateTime(2026,  12,      9,       0, 0, 0,  DateTimeKind.Utc),
                     EndDate = new DateTime(2026, 12,     13,        0,     0, 0,     DateTimeKind.Utc),
                     TournamentType = "ATP",
                     CourtSurface = CourtSurface.Hard,
                     CourtEnvironment = CourtEnvironment.Indoor,
                 }
             };

             public static IEnumerable<Tournament> DefaultWomensTournaments =>
                      new List<Tournament>
             {
                 new Tournament
                 {
                     Id = 101,
                     TournamentName = "Open 6ème Sens Métropole de  Lyon",
                     Location = "Lyon, France",
                     StartDate = new DateTime(2026, 3,    1,    0, 0, 0,  DateTimeKind.Utc),
                     EndDate = new DateTime(2026, 3,  7,      0, 0, 0,  DateTimeKind.Utc),
                     TournamentType = "WTA 250",
                     CourtSurface = CourtSurface.Hard,
                     CourtEnvironment = CourtEnvironment.Indoor,
                 },
                 new Tournament
                 {
                     Id = 102,
                     TournamentName = "Mutua Madrid Open",
                     Location = "Madrid, Spain",
                     StartDate = new DateTime(2026, 4,    27,   0, 0, 0,  DateTimeKind.Utc),
                     EndDate = new DateTime(2026, 5,  9,      0, 0, 0,  DateTimeKind.Utc),
                     TournamentType = "WTA 1000",
                     CourtSurface = CourtSurface.Clay,
                     CourtEnvironment = CourtEnvironment.Outdoor,
                 },
                 new Tournament
                 {
                     Id = 103,
                     TournamentName = "Internazionali BNL d'Italia",
                     Location = "Rome, Italy",
                     StartDate = new DateTime(2026, 5,    11,   0, 0, 0,  DateTimeKind.Utc),
                     EndDate = new DateTime(2026, 5,      17,     0, 0, 0,  DateTimeKind.Utc),
                     TournamentType = "WTA 1000",
                     CourtSurface = CourtSurface.Clay,
                     CourtEnvironment = CourtEnvironment.Outdoor,
                 },
                 new Tournament
                 {
                     Id = 104,
                     TournamentName = "US Open",
                     Location = "New York, USA",
                     StartDate = new DateTime(2026, 8,    31,   0, 0, 0,  DateTimeKind.Utc),
                     EndDate = new DateTime(2026, 9,      13,     0, 0, 0,  DateTimeKind.Utc),
                     TournamentType = "Grand Slam",
                     CourtSurface = CourtSurface.Hard,
                     CourtEnvironment = CourtEnvironment.Outdoor,
                 },
                 new Tournament
                 {
                     Id = 105,
                     TournamentName = "Billie Jean King Cup Finals",
                     Location = "Seville, Spain",
                     StartDate = new DateTime(2026,  11,      12,      0, 0, 0,  DateTimeKind.Utc),
                     EndDate = new DateTime(2026, 11,     20,        0,     0, 0,  DateTimeKind.Utc),
                     TournamentType = "ITF Women",
                     CourtSurface = CourtSurface.Hard,
                     CourtEnvironment = CourtEnvironment.Indoor,
                 }
             };           
    }
}
