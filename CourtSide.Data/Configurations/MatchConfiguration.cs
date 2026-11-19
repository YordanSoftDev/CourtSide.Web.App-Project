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

            builder.HasQueryFilter(m => m.IsDeleted == false);

            builder.HasData(DefaultMatches);
        }

        public static IEnumerable<Match> DefaultMatches =>
            new List<Match>
            {
                new Match
                {
                    Id = DeterministicGuid.Create("Match_2026_10_15_Zverev_de Minaur"),
                    FirstPlayerId = DeterministicGuid.Create("Player_Alexander_Zverev"),
                    SecondPlayerId = DeterministicGuid.Create("Player_Alex_DeMinaur"),
                    TournamentId = DeterministicGuid.Create("Tournament_Shanghai Masters"),
                    VenueId = DeterministicGuid.Create("Venue_Qizhong Forest Sports City Arena"),
                    DateTime = new DateTime(2026, 10, 15, 13, 30, 0, DateTimeKind.Utc),
                    CourtSurface = CourtSurface.Hard,
                    CourtEnvironment = CourtEnvironment.Outdoor,
                    CourtId = DeterministicGuid.Create("Court_Qizhong Forest Sports City Stadium Court"),
                    MatchRound = MatchRound.Quarterfinal,
                    MatchStatus = MatchStatus.Completed,
                    ScoreResult = "6-4 6-4",
                    WinnerId = DeterministicGuid.Create("Player_Alexander_Zverev")
                },
                new Match
                {
                    Id = DeterministicGuid.Create("Match_2026_10_15_Gea_Davidovich Fokina"),
                    FirstPlayerId = DeterministicGuid.Create("Player_Arthur_Gea"),
                    SecondPlayerId = DeterministicGuid.Create("Player_Alejandro_Davidovich Fokina"),
                    TournamentId = DeterministicGuid.Create("Tournament_Shanghai Masters"),
                    VenueId = DeterministicGuid.Create("Venue_Qizhong Forest Sports City Arena"),
                    DateTime = new DateTime(2026, 10, 15, 10, 00, 0, DateTimeKind.Utc),
                    CourtSurface = CourtSurface.Hard,
                    CourtEnvironment = CourtEnvironment.Outdoor,
                    CourtId = DeterministicGuid.Create("Court_Qizhong Forest Sports City Stadium Court"),
                    MatchRound = MatchRound.Quarterfinal,
                    MatchStatus = MatchStatus.Completed,
                    ScoreResult = "1-4",
                    WinnerId = DeterministicGuid.Create("Player_Alejandro_Davidovich Fokina")
                },
                new Match
                {
                    Id = DeterministicGuid.Create("Match_2026_10_16_Medvedev_Paul"),
                    FirstPlayerId = DeterministicGuid.Create("Player_Daniil_Medvedev"),
                    SecondPlayerId = DeterministicGuid.Create("Player_Tommy_Paul"),
                    TournamentId = DeterministicGuid.Create("Tournament_Shanghai Masters"),
                    VenueId = DeterministicGuid.Create("Venue_Qizhong Forest Sports City Arena"),
                    DateTime = new DateTime(2026, 10, 16, 13, 00, 0, DateTimeKind.Utc),
                    CourtSurface = CourtSurface.Hard,
                    CourtEnvironment = CourtEnvironment.Outdoor,
                    CourtId = DeterministicGuid.Create("Court_Qizhong Forest Sports City Stadium Court"),
                    MatchRound = MatchRound.Quarterfinal,
                    MatchStatus = MatchStatus.Completed,
                    ScoreResult = "6-3 1-6 6-3",
                    WinnerId = DeterministicGuid.Create("Player_Daniil_Medvedev")
                },
                new Match
                {
                    Id = DeterministicGuid.Create("Match_2026_10_16_Jodar_Ruud"),
                    FirstPlayerId = DeterministicGuid.Create("Player_Rafael_Jodar"),
                    SecondPlayerId = DeterministicGuid.Create("Player_Casper_Ruud"),
                    TournamentId = DeterministicGuid.Create("Tournament_Shanghai Masters"),
                    VenueId = DeterministicGuid.Create("Venue_Qizhong Forest Sports City Arena"),
                    DateTime = new DateTime(2026, 10, 16, 11, 00, 0, DateTimeKind.Utc),
                    CourtSurface = CourtSurface.Hard,
                    CourtEnvironment = CourtEnvironment.Outdoor,
                    CourtId = DeterministicGuid.Create("Court_Qizhong Forest Sports City Stadium Court"),
                    MatchRound = MatchRound.Quarterfinal,
                    MatchStatus = MatchStatus.Completed,
                    ScoreResult = "4-6 6-4 6-3",
                    WinnerId = DeterministicGuid.Create("Player_Rafael_Jodar")
                },
                new Match
                {
                    Id = DeterministicGuid.Create("Match_2026_10_17_Zverev_Davidovich Fokina"),
                    FirstPlayerId = DeterministicGuid.Create("Player_Alexander_Zverev"),
                    SecondPlayerId = DeterministicGuid.Create("Player_Alejandro_Davidovich Fokina"),
                    TournamentId = DeterministicGuid.Create("Tournament_Shanghai Masters"),
                    VenueId = DeterministicGuid.Create("Venue_Qizhong Forest Sports City Arena"),
                    DateTime = new DateTime(2026, 10, 17, 11, 40, 0, DateTimeKind.Utc),
                    CourtSurface = CourtSurface.Hard,
                    CourtEnvironment = CourtEnvironment.Outdoor,
                    CourtId = DeterministicGuid.Create("Court_Qizhong Forest Sports City Stadium Court"),
                    MatchRound = MatchRound.Semifinal,
                    MatchStatus = MatchStatus.Completed,
                    ScoreResult = "7-5 4-6 3-6",
                    WinnerId = DeterministicGuid.Create("Player_Alejandro_Davidovich Fokina")
                },
                new Match
                {
                    Id = DeterministicGuid.Create("Match_2026_10_17_Jodar_Medvedev"),
                    FirstPlayerId = DeterministicGuid.Create("Player_Rafael_Jodar"),
                    SecondPlayerId = DeterministicGuid.Create("Player_Daniil_Medvedev"),
                    TournamentId = DeterministicGuid.Create("Tournament_Shanghai Masters"),
                    VenueId = DeterministicGuid.Create("Venue_Qizhong Forest Sports City Arena"),
                    DateTime = new DateTime(2026, 10, 17, 14, 10, 0, DateTimeKind.Utc),
                    CourtSurface = CourtSurface.Hard,
                    CourtEnvironment = CourtEnvironment.Outdoor,
                    CourtId = DeterministicGuid.Create("Court_Qizhong Forest Sports City Stadium Court"),
                    MatchRound = MatchRound.Semifinal,
                    MatchStatus = MatchStatus.Completed,
                    ScoreResult = "6-3 6-4",
                    WinnerId = DeterministicGuid.Create("Player_Rafael_Jodar")
                }
            };
    }
}