namespace CourtSide.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using CourtSide.Common.MatchEnumerations;
    using CourtSide.Data.Models;
    using CourtSide.Data.Seeding;

    public class MatchConfiguration : IEntityTypeConfiguration<Match>
    {
        public void Configure(EntityTypeBuilder<Match> builder)
        {
            builder.Property(m => m.MatchStatus)
                .HasConversion<string>();

            builder.Property(m => m.MatchRound)
                .HasConversion<string>();

            builder.Property(m => m.CourtSurface)
                .HasConversion<string>();

            builder.HasData(DefaultMatches);
        }

        public static IEnumerable<Match> DefaultMatches =>
            new List<Match>
            {
                new Match
                {
                    Id = DeterministicGuid.Create("Match_2026_10_15_Zverev_Rublev"),
                    FirstPlayerId = DeterministicGuid.Create("Player_Alexander_Zverev"),
                    SecondPlayerId = DeterministicGuid.Create("Player_Andrey_Rublev"),
                    TournamentId = DeterministicGuid.Create("Tournament_European Open"),
                    VenueId = DeterministicGuid.Create("Venue_Lotto Arena"),
                    DateTime = new DateTime(2026, 10, 15, 13, 10, 0, DateTimeKind.Utc),
                    CourtSurface = CourtSurface.Hard,
                    CourtEnvironment = CourtEnvironment.Outdoor,
                    CourtId = DeterministicGuid.Create("Court_Lotto Arena_Center Court"),
                    MatchRound = MatchRound.Quarterfinal,
                    MatchStatus = MatchStatus.Completed,
                    ScoreResult = "6-4 5-4",
                    WinnerId = DeterministicGuid.Create("Player_Alexander_Zverev")
                },
                new Match
                {
                    Id = DeterministicGuid.Create("Match_2026_10_15_Match2"),
                    FirstPlayerId = DeterministicGuid.Create("Player_Corentin_Moutet"),
                    SecondPlayerId = DeterministicGuid.Create("Player_Matteo_Berrettini"),
                    TournamentId = DeterministicGuid.Create("Tournament_European Open"),
                    VenueId = DeterministicGuid.Create("Venue_Lotto Arena"),
                    DateTime = new DateTime(2026, 10, 15, 09, 40, 0, DateTimeKind.Utc),
                    CourtSurface = CourtSurface.Hard,
                    CourtEnvironment = CourtEnvironment.Outdoor,
                    CourtId = DeterministicGuid.Create("Court_Lotto Arena_Center Court"),
                    MatchRound = MatchRound.Quarterfinal,
                    MatchStatus = MatchStatus.Completed,
                    ScoreResult = "1-4",
                    WinnerId = DeterministicGuid.Create("Player_Matteo_Berrettini")
                },
                new Match
                {
                    Id = DeterministicGuid.Create("Match_2026_10_16_Medvedev_Norrie"),
                    FirstPlayerId = DeterministicGuid.Create("Player_Daniil_Medvedev"),
                    SecondPlayerId = DeterministicGuid.Create("Player_Cameron_Norrie"),
                    TournamentId = DeterministicGuid.Create("Tournament_European Open"),
                    VenueId = DeterministicGuid.Create("Venue_Lotto Arena"),
                    DateTime = new DateTime(2026, 10, 16, 13, 10, 0, DateTimeKind.Utc),
                    CourtSurface = CourtSurface.Hard,
                    CourtEnvironment = CourtEnvironment.Outdoor,
                    CourtId = DeterministicGuid.Create("Court_Lotto Arena_Center Court"),
                    MatchRound = MatchRound.Quarterfinal,
                    MatchStatus = MatchStatus.Completed,
                    ScoreResult = "6-3 1-6 6-3",
                    WinnerId = DeterministicGuid.Create("Player_Daniil_Medvedev")
                },
                new Match
                {
                    Id = DeterministicGuid.Create("Match_2026_10_16_Match4"),
                    FirstPlayerId = DeterministicGuid.Create("Player_Antonia_Ruzic"),
                    SecondPlayerId = DeterministicGuid.Create("Player_Casper_Ruud"),
                    TournamentId = DeterministicGuid.Create("Tournament_European Open"),
                    VenueId = DeterministicGuid.Create("Venue_Lotto Arena"),
                    DateTime = new DateTime(2026, 10, 16, 09, 40, 0, DateTimeKind.Utc),
                    CourtSurface = CourtSurface.Hard,
                    CourtEnvironment = CourtEnvironment.Outdoor,
                    CourtId = DeterministicGuid.Create("Court_Lotto Arena_Center Court"),
                    MatchRound = MatchRound.Quarterfinal,
                    MatchStatus = MatchStatus.Completed,
                    ScoreResult = "4-6 6-4 6-3",
                    WinnerId = DeterministicGuid.Create("Player_Antonia_Ruzic")
                },
                new Match
                {
                    Id = DeterministicGuid.Create("Match_2026_10_17_Semifinal_1"),
                    FirstPlayerId = DeterministicGuid.Create("Player_Alexander_Zverev"),
                    SecondPlayerId = DeterministicGuid.Create("Player_Matteo_Berrettini"),
                    TournamentId = DeterministicGuid.Create("Tournament_European Open"),
                    VenueId = DeterministicGuid.Create("Venue_Lotto Arena"),
                    DateTime = new DateTime(2026, 10, 17, 11, 40, 0, DateTimeKind.Utc),
                    CourtSurface = CourtSurface.Hard,
                    CourtEnvironment = CourtEnvironment.Outdoor,
                    CourtId = DeterministicGuid.Create("Court_Lotto Arena_Center Court"),
                    MatchRound = MatchRound.Semifinal,
                    MatchStatus = MatchStatus.Completed,
                    ScoreResult = "7-5 4-6 3-6",
                    WinnerId = DeterministicGuid.Create("Player_Matteo_Berrettini")
                },
                new Match
                {
                    Id = DeterministicGuid.Create("Match_2026_10_17_Semifinal_2"),
                    FirstPlayerId = DeterministicGuid.Create("Player_Antonia_Ruzic"),
                    SecondPlayerId = DeterministicGuid.Create("Player_Daniil_Medvedev"),
                    TournamentId = DeterministicGuid.Create("Tournament_European Open"),
                    VenueId = DeterministicGuid.Create("Venue_Lotto Arena"),
                    DateTime = new DateTime(2026, 10, 17, 14, 10, 0, DateTimeKind.Utc),
                    CourtSurface = CourtSurface.Hard,
                    CourtEnvironment = CourtEnvironment.Outdoor,
                    CourtId = DeterministicGuid.Create("Court_Lotto Arena_Center Court"),
                    MatchRound = MatchRound.Semifinal,
                    MatchStatus = MatchStatus.Completed,
                    ScoreResult = "6-3 6-4",
                    WinnerId = DeterministicGuid.Create("Player_Antonia_Ruzic")
                }
            };
    }
}