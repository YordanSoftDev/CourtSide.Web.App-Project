namespace CourtSide.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using CourtSide.Common.MatchEnumerations;
    using CourtSide.Data.Models;
    using CourtSide.Common.TournamentEnumerations;

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
                        TournamentType = "ATP 250",
                        Discipline = "Men's singles",
                        Location = "Lyon, France",
                        StartDate = new DateTime(2026, 10,  19,      0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2026, 10, 25,        0, 0, 0, DateTimeKind.Utc),
                        CourtSurface = CourtSurface.Hard,
                        CourtEnvironment = CourtEnvironment.Indoor,
                        MatchFormat = MatchFormat.BestOfThree,
                        TieBreakRule = TieBreakRule.StandardAllSets
                    },
                    new Tournament
                    {
                        Id = 2,
                        TournamentName = "Rolex Paris Masters",
                        TournamentType = "ATP 1000",
                        Discipline = "Men's singles",
                        Location = "Paris, France",
                        StartDate = new DateTime(2026, 11, 2,       0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2026, 11, 8,         0,     0, 0, DateTimeKind.Utc),
                        CourtSurface = CourtSurface.Hard,
                        CourtEnvironment = CourtEnvironment.Indoor,
                        MatchFormat = MatchFormat.BestOfThree,
                        TieBreakRule = TieBreakRule.StandardAllSets
                    },
                    new Tournament
                    {
                        Id = 3,
                        TournamentName = "US Open",
                        TournamentType = "Grand Slam Men",
                        Discipline = "Men's singles",
                        Location = "New York, USA",
                        StartDate = new DateTime(2026, 8, 31,       0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2026, 9, 13,         0,     0, 0, DateTimeKind.Utc),
                        CourtSurface = CourtSurface.Hard,
                        CourtEnvironment = CourtEnvironment.Outdoor,
                        MatchFormat = MatchFormat.BestOfFive,
                        TieBreakRule = TieBreakRule.GrandSlamFinalSet
                    },
                    new Tournament
                    {
                        Id = 4,
                        TournamentName = "Almaty Open",
                        TournamentType = "ATP 250",
                        Discipline = "Men's singles",
                        Location = "Almaty, Kazakhstan",
                        StartDate = new DateTime(2026, 10,  19,      0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2026, 10, 25,        0, 0, 0, DateTimeKind.Utc),
                        CourtSurface = CourtSurface.Hard,
                        CourtEnvironment = CourtEnvironment.Indoor,
                        MatchFormat = MatchFormat.BestOfThree,
                        TieBreakRule = TieBreakRule.StandardAllSets
                    },
                    new Tournament
                    {
                        Id = 5,
                        TournamentName = "Australian Open",
                        TournamentType = "Grand Slam Men",
                        Discipline = "Men's singles",
                        Location = "Melbourne, Australia",
                        StartDate = new DateTime(2026, 1, 18,       0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2026, 1, 31,         0,     0, 0, DateTimeKind.Utc),
                        CourtSurface = CourtSurface.Hard,
                        CourtEnvironment = CourtEnvironment.Outdoor,
                        MatchFormat = MatchFormat.BestOfFive,
                        TieBreakRule = TieBreakRule.GrandSlamFinalSet
                    },
                    new Tournament
                    {
                        Id = 6,
                        TournamentName = "Monte-Carlo Masters",
                        TournamentType = "ATP 1000",
                        Discipline = "Men's singles",
                        Location = "Roquebrune-Cap-Martin, France",
                        StartDate = new DateTime(2026, 4, 12,       0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2026, 4, 19,         0,     0, 0, DateTimeKind.Utc),
                        CourtSurface = CourtSurface.Clay,
                        CourtEnvironment = CourtEnvironment.Outdoor,
                        MatchFormat = MatchFormat.BestOfThree,
                        TieBreakRule = TieBreakRule.StandardAllSets
                    },
                    new Tournament
                    {
                        Id = 7,
                        TournamentName = "Mutua Madrid Open",
                        TournamentType = "ATP 1000",
                        Discipline = "Men's singles",
                        Location = "Madrid, Spain",
                        StartDate = new DateTime(2026, 5, 4,        0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2026, 5, 17,         0,     0, 0, DateTimeKind.Utc),
                        CourtSurface = CourtSurface.Clay,
                        CourtEnvironment = CourtEnvironment.Outdoor,
                        MatchFormat = MatchFormat.BestOfThree,
                        TieBreakRule = TieBreakRule.StandardAllSets
                    },
                    new Tournament
                    {
                        Id = 8,
                        TournamentName = "Italian Open",
                        TournamentType = "ATP 1000",
                        Discipline = "Men's singles",
                        Location = "Rome, Italy",
                        StartDate = new DateTime(2026, 5, 11,       0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2026, 5, 24,         0,     0, 0, DateTimeKind.Utc),
                        CourtSurface = CourtSurface.Clay,
                        CourtEnvironment = CourtEnvironment.Outdoor,
                        MatchFormat = MatchFormat.BestOfThree,
                        TieBreakRule = TieBreakRule.StandardAllSets
                    },
                    new Tournament
                    {
                        Id = 9,
                        TournamentName = "Cinch Championships",
                        TournamentType = "ATP 500",
                        Discipline = "Men's singles",
                        Location = "London, United Kingdom",
                        StartDate = new DateTime(2026, 6, 15,       0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2026, 6, 21,         0,     0, 0, DateTimeKind.Utc),
                        CourtSurface = CourtSurface.Grass,
                        CourtEnvironment = CourtEnvironment.Outdoor,
                        MatchFormat = MatchFormat.BestOfThree,
                        TieBreakRule = TieBreakRule.StandardAllSets
                    },
                    new Tournament
                    {
                        Id = 10,
                        TournamentName = "Swiss Indoors Basel",
                        TournamentType = "ATP 500",
                        Discipline = "Men's singles",
                        Location = "Basel, Switzerland",
                        StartDate = new DateTime(2026, 10,  24,      0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2026, 11, 1,         0,     0, 0, DateTimeKind.Utc),
                        CourtSurface = CourtSurface.Hard,
                        CourtEnvironment = CourtEnvironment.Indoor,
                        MatchFormat = MatchFormat.BestOfThree,
                        TieBreakRule = TieBreakRule.StandardAllSets
                    },
                    new Tournament
                    {
                        Id = 11,
                        TournamentName = "Shanghai Masters",
                        TournamentType = "ATP 1000",
                        Discipline = "Men's singles",
                        Location = "Shanghai, China",
                        StartDate = new DateTime(2026, 10, 7,       0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2026, 10, 18,        0, 0, 0, DateTimeKind.Utc),
                        CourtSurface = CourtSurface.Hard,
                        CourtEnvironment = CourtEnvironment.Outdoor,
                        MatchFormat = MatchFormat.BestOfThree,
                        TieBreakRule = TieBreakRule.StandardAllSets
                    },
                    new Tournament
                    {
                        Id = 12,
                        TournamentName = "European Open",
                        TournamentType = "ATP 250",
                        Discipline = "Men's singles",
                        Location = "Brussels, Belgium",
                        StartDate = new DateTime(2026, 10,  17,      0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2026, 10, 25,        0, 0, 0, DateTimeKind.Utc),
                        CourtSurface = CourtSurface.Hard,
                        CourtEnvironment = CourtEnvironment.Indoor,
                        MatchFormat = MatchFormat.BestOfThree,
                        TieBreakRule = TieBreakRule.StandardAllSets
                    },
                    new Tournament
                    {
                        Id = 13,
                        TournamentName = "Bybit Stockholm Open",
                        TournamentType = "ATP 250",
                        Discipline = "Men's singles",
                        Location = "Stockholm, Sweden",
                        StartDate = new DateTime(2026, 11, 8,       0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2026, 11, 14,        0, 0, 0, DateTimeKind.Utc),
                        CourtSurface = CourtSurface.Hard,
                        CourtEnvironment = CourtEnvironment.Indoor,
                        MatchFormat = MatchFormat.BestOfThree,
                        TieBreakRule = TieBreakRule.StandardAllSets
                    },
                    new Tournament
                    {
                        Id = 14,
                        TournamentName = "Nitto Finals",
                        TournamentType = "ATP Finals",
                        Discipline = "Men's singles",
                        Location = "Turin, Italy",
                        StartDate = new DateTime(2026, 11,  15,      0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2026, 11, 22,        0, 0, 0, DateTimeKind.Utc),
                        CourtSurface = CourtSurface.Hard,
                        CourtEnvironment = CourtEnvironment.Indoor,
                        MatchFormat = MatchFormat.BestOfThree,
                        TieBreakRule = TieBreakRule.StandardAllSets
                    },
                    new Tournament
                    {
                        Id = 15,
                        TournamentName = "Davis Cup Finals",
                        TournamentType = "ITF Men",
                        Discipline = "Men's singles",
                        Location = "Bologna, Italy",
                        StartDate = new DateTime(2026, 11,  23,      0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2026, 11, 29,        0, 0, 0, DateTimeKind.Utc),
                        CourtSurface = CourtSurface.Hard,
                        CourtEnvironment = CourtEnvironment.Indoor,
                        MatchFormat = MatchFormat.BestOfThree,
                        TieBreakRule = TieBreakRule.StandardAllSets
                    },
                    new Tournament
                    {
                        Id = 16,
                        TournamentName = "Next Gen Finals",
                        TournamentType = "ATP Finals",
                        Discipline = "Men's singles",
                        Location = "Reggio Calabria, Italy",
                        StartDate = new DateTime(2026, 12, 9,       0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2026, 12, 13,        0, 0, 0, DateTimeKind.Utc),
                        CourtSurface = CourtSurface.Hard,
                        CourtEnvironment = CourtEnvironment.Indoor,
                        MatchFormat = MatchFormat.BestOfThree,
                        TieBreakRule = TieBreakRule.StandardAllSets
                    }
                };

        public static IEnumerable<Tournament> DefaultWomensTournaments =>
                new List<Tournament>
                {
                    new Tournament
                    {
                        Id = 101,
                        TournamentName = "Open 6ème Sens Métropole de Lyon",
                        TournamentType = "WTA 250",
                        Discipline = "Women's singles",
                        Location = "Lyon, France",
                        StartDate = new DateTime(2026, 3, 1,        0,     0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2026, 3, 7,  0,       0, 0, DateTimeKind.Utc),
                        CourtSurface = CourtSurface.Hard,
                        CourtEnvironment = CourtEnvironment.Indoor,
                        MatchFormat = MatchFormat.BestOfThree,
                        TieBreakRule = TieBreakRule.StandardAllSets
                    },
                    new Tournament
                    {
                        Id = 102,
                        TournamentName = "US Open",
                        TournamentType = "Grand Slam Women",
                        Discipline = "Women's singles",
                        Location = "New York, USA",
                        StartDate = new DateTime(2026, 8,   31,       0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2026, 9, 13,     0,      0, 0, DateTimeKind.Utc),
                        CourtSurface = CourtSurface.Hard,
                        CourtEnvironment = CourtEnvironment.Outdoor,
                        MatchFormat = MatchFormat.BestOfThree,
                        TieBreakRule = TieBreakRule.GrandSlamFinalSet
                    },
                    new Tournament
                    {
                        Id = 103,
                        TournamentName = "Australian Open",
                        TournamentType = "Grand Slam Women",
                        Discipline = "Women's singles",
                        Location = "Melbourne, Australia",
                        StartDate = new DateTime(2026, 1,   18,       0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2026, 1, 31,     0,      0, 0, DateTimeKind.Utc),
                        CourtSurface = CourtSurface.Hard,
                        CourtEnvironment = CourtEnvironment.Outdoor,
                        MatchFormat = MatchFormat.BestOfThree,
                        TieBreakRule = TieBreakRule.GrandSlamFinalSet
                    },
                    new Tournament
                    {
                        Id = 104,
                        TournamentName = "Mutua Madrid Open",
                        TournamentType = "WTA 1000",
                        Discipline = "Women's singles",
                        Location = "Madrid, Spain",
                        StartDate = new DateTime(2026, 4,   27,       0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2026, 5, 9,  0,       0, 0, DateTimeKind.Utc),
                        CourtSurface = CourtSurface.Clay,
                        CourtEnvironment = CourtEnvironment.Outdoor,
                        MatchFormat = MatchFormat.BestOfThree,
                        TieBreakRule = TieBreakRule.StandardAllSets
                    },
                    new Tournament
                    {
                        Id = 105,
                        TournamentName = "Internazionali BNL d'Italia",
                        TournamentType = "WTA 1000",
                        Discipline = "Women's singles",
                        Location = "Rome, Italy",
                        StartDate = new DateTime(2026, 5,   11,       0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2026, 5, 17,     0,      0, 0, DateTimeKind.Utc),
                        CourtSurface = CourtSurface.Clay,
                        CourtEnvironment = CourtEnvironment.Outdoor,
                        MatchFormat = MatchFormat.BestOfThree,
                        TieBreakRule = TieBreakRule.StandardAllSets
                    },
                    new Tournament
                    {
                        Id = 106,
                        TournamentName = "Billie Jean King Cup Finals",
                        TournamentType = "ITF Women",
                        Discipline = "Women's singles",
                        Location = "Seville, Spain",
                        StartDate = new DateTime(2026, 11,  12,      0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2026, 11, 20,        0,     0, 0, DateTimeKind.Utc),
                        CourtSurface = CourtSurface.Hard,
                        CourtEnvironment = CourtEnvironment.Indoor,
                        MatchFormat = MatchFormat.BestOfThree,
                        TieBreakRule = TieBreakRule.StandardAllSets
                    },
                    new Tournament
                    {
                        Id = 107,
                        TournamentName = "Qatar TotalEnergies Open",
                        TournamentType = "WTA 1000",
                        Discipline = "Women's singles",
                        Location = "Doha, Qatar",
                        StartDate = new DateTime(2026, 2, 8,        0,     0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2026, 2, 14,     0,      0, 0, DateTimeKind.Utc),
                        CourtSurface = CourtSurface.Hard,
                        CourtEnvironment = CourtEnvironment.Outdoor,
                        MatchFormat = MatchFormat.BestOfThree,
                        TieBreakRule = TieBreakRule.StandardAllSets
                    },
                    new Tournament
                    {
                        Id = 108,
                        TournamentName = "BNP Paribas Open",
                        TournamentType = "WTA 1000",
                        Discipline = "Women's singles",
                        Location = "Indian Wells, USA",
                        StartDate = new DateTime(2026, 3, 4,        0,     0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2026, 3, 15,     0,      0, 0, DateTimeKind.Utc),
                        CourtSurface = CourtSurface.Hard,
                        CourtEnvironment = CourtEnvironment.Outdoor,
                        MatchFormat = MatchFormat.BestOfThree,
                        TieBreakRule = TieBreakRule.StandardAllSets
                    },
                    new Tournament
                    {
                        Id = 109,
                        TournamentName = "Miami Open",
                        TournamentType = "WTA 1000",
                        Discipline = "Women's singles",
                        Location = "Miami, USA",
                        StartDate = new DateTime(2026, 3,   17,       0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2026, 3, 29,     0,      0, 0, DateTimeKind.Utc),
                        CourtSurface = CourtSurface.Hard,
                        CourtEnvironment = CourtEnvironment.Outdoor,
                        MatchFormat = MatchFormat.BestOfThree,
                        TieBreakRule = TieBreakRule.StandardAllSets
                    },
                    new Tournament
                    {
                        Id = 110,
                        TournamentName = "Porsche Tennis Grand Prix",
                        TournamentType = "WTA 500",
                        Discipline = "Women's singles",
                        Location = "Stuttgart, Germany",
                        StartDate = new DateTime(2026, 4,   13,       0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2026, 4, 19,     0,      0, 0, DateTimeKind.Utc),
                        CourtSurface = CourtSurface.Clay,
                        CourtEnvironment = CourtEnvironment.Indoor,
                        MatchFormat = MatchFormat.BestOfThree,
                        TieBreakRule = TieBreakRule.StandardAllSets
                    },
                    new Tournament
                    {
                        Id = 111,
                        TournamentName = "Roland Garros",
                        TournamentType = "Grand Slam Women",
                        Discipline = "Women's singles",
                        Location = "Paris, France",
                        StartDate = new DateTime(2026, 5,   24,       0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2026, 6, 7,  0,       0, 0, DateTimeKind.Utc),
                        CourtSurface = CourtSurface.Clay,
                        CourtEnvironment = CourtEnvironment.Outdoor,
                        MatchFormat = MatchFormat.BestOfThree,
                        TieBreakRule = TieBreakRule.GrandSlamFinalSet
                    },
                    new Tournament
                    {
                        Id = 112,
                        TournamentName = "Rothesay International Eastbourne",
                        TournamentType = "WTA 500",
                        Discipline = "Women's singles",
                        Location = "Eastbourne, United Kingdom",
                        StartDate = new DateTime(2026, 6,   22,       0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2026, 6, 27,     0,      0, 0, DateTimeKind.Utc),
                        CourtSurface = CourtSurface.Grass,
                        CourtEnvironment = CourtEnvironment.Outdoor,
                        MatchFormat = MatchFormat.BestOfThree,
                        TieBreakRule = TieBreakRule.StandardAllSets
                    },
                    new Tournament
                    {
                        Id = 113,
                        TournamentName = "Wimbledon",
                        TournamentType = "Grand Slam Women",
                        Discipline = "Women's singles",
                        Location = "London, United Kingdom",
                        StartDate = new DateTime(2026, 6,   29,       0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2026, 7, 12,     0,      0, 0, DateTimeKind.Utc),
                        CourtSurface = CourtSurface.Grass,
                        CourtEnvironment = CourtEnvironment.Outdoor,
                        MatchFormat = MatchFormat.BestOfThree,
                        TieBreakRule = TieBreakRule.GrandSlamFinalSet
                    },
                    new Tournament
                    {
                        Id = 114,
                        TournamentName = "National Bank Open",
                        TournamentType = "WTA 1000",
                        Discipline = "Women's singles",
                        Location = "Montreal, Canada",
                        StartDate = new DateTime(2026, 8,   10,       0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2026, 8, 16,     0,      0, 0, DateTimeKind.Utc),
                        CourtSurface = CourtSurface.Hard,
                        CourtEnvironment = CourtEnvironment.Outdoor,
                        MatchFormat = MatchFormat.BestOfThree,
                        TieBreakRule = TieBreakRule.StandardAllSets
                    },
                    new Tournament
                    {
                        Id = 115,
                        TournamentName = "China Open",
                        TournamentType = "WTA 1000",
                        Discipline = "Women's singles",
                        Location = "Beijing, China",
                        StartDate = new DateTime(2026, 9,   28,       0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2026, 10, 11,        0,     0, 0, DateTimeKind.Utc),
                        CourtSurface = CourtSurface.Hard,
                        CourtEnvironment = CourtEnvironment.Outdoor,
                        MatchFormat = MatchFormat.BestOfThree,
                        TieBreakRule = TieBreakRule.StandardAllSets
                    },
                    new Tournament
                    {
                        Id = 116,
                        TournamentName = "WTA Finals",
                        TournamentType = "WTA Finals",
                        Discipline = "Women's singles",
                        Location = "Riyadh, Saudi Arabia",
                        StartDate = new DateTime(2026, 11,  1,       0, 0, 0, DateTimeKind.Utc),
                        EndDate = new DateTime(2026, 11, 8,     0,      0, 0, DateTimeKind.Utc),
                        CourtSurface = CourtSurface.Hard,
                        CourtEnvironment = CourtEnvironment.Indoor,
                        MatchFormat = MatchFormat.BestOfThree,
                        TieBreakRule = TieBreakRule.StandardAllSets
                    }
                };
    }
}
