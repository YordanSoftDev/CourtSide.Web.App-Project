namespace CourtSide.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using CourtSide.Common.MatchEnumerations;
    using CourtSide.Data.Models;

    public class MatchConfiguration : IEntityTypeConfiguration<Match>
    {
        public static IEnumerable<Match> DefaultMatches =>
            new List<Match>
            { 
                new Match
                {
                    Id = 1,
                    FirstPlayerId = 5,
                    SecondPlayerId = 11,
                    TournamentId = 11,
                    VenueId = 12,
                    DateTime = new DateTime(2026, 10, 15, 13, 10, 0, DateTimeKind.Utc),
                    CourtSurface = CourtSurface.Hard,
                    CourtEnvironment = CourtEnvironment.Outdoor,
                    CourtName = "Court 1",
                    MatchRound = MatchRound.Quarterfinal,
                    MatchStatus = MatchStatus.Completed,
                    //MatchDuration = "1h 40m",
                    ScoreResult = "6-4 5-4",
                    WinnerId = 5
                },
                new Match
                {
                    Id = 2,
                    FirstPlayerId = 92,
                    SecondPlayerId = 44,
                    TournamentId = 11,
                    VenueId = 12,
                    DateTime = new DateTime(2026, 10, 15, 09, 40, 0, DateTimeKind.Utc),
                    CourtSurface = CourtSurface.Hard,
                    CourtEnvironment = CourtEnvironment.Outdoor,
                    CourtName = "Court 2",
                    MatchRound = MatchRound.Quarterfinal,
                    MatchStatus = MatchStatus.Completed,
                    //MatchDuration = "1h 01m",
                    ScoreResult = "1-4",
                    WinnerId = 44
                },
                new Match
                {
                    Id = 3,
                    FirstPlayerId = 4,
                    SecondPlayerId = 41,
                    TournamentId = 11,
                    VenueId = 12,
                    DateTime = new DateTime(2026, 10, 16, 13, 10, 0, DateTimeKind.Utc),
                    CourtSurface = CourtSurface.Hard,
                    CourtEnvironment = CourtEnvironment.Outdoor,
                    CourtName = "Centre Court",
                    MatchRound = MatchRound.Quarterfinal,
                    MatchStatus = MatchStatus.Completed,
                    //MatchDuration = "2h 05m",
                    ScoreResult = "6-3 1-6 6-3",
                    WinnerId = 4
                },
                new Match
                {
                    Id = 4,
                    FirstPlayerId = 91,
                    SecondPlayerId = 8,
                    TournamentId = 11,
                    VenueId = 12,
                    DateTime = new DateTime(2026, 10, 16, 09, 40, 0, DateTimeKind.Utc),
                    CourtSurface = CourtSurface.Hard,
                    CourtEnvironment = CourtEnvironment.Outdoor,
                    CourtName = "Court 1",
                    MatchRound = MatchRound.Quarterfinal,
                    MatchStatus = MatchStatus.Completed,
                    //MatchDuration = "2h 30m",
                    ScoreResult = "4-6 6-4 6-3",
                    WinnerId = 91
                },
                new Match
                {
                    Id = 5,
                    FirstPlayerId = 5,
                    SecondPlayerId = 44,
                    TournamentId = 11,
                    VenueId = 12,
                    DateTime = new DateTime(2026, 10, 17, 11, 40, 0, DateTimeKind.Utc),
                    CourtSurface = CourtSurface.Hard,
                    CourtEnvironment = CourtEnvironment.Outdoor,
                    CourtName = "Centre Court",
                    MatchRound = MatchRound.Semifinal,
                    MatchStatus = MatchStatus.Completed,
                    //MatchDuration = "2h 20m",
                    ScoreResult = "7-5 4-6 3-6",
                    WinnerId = 44
                },
                new Match
                {
                    Id = 6,
                    FirstPlayerId = 91,
                    SecondPlayerId = 4,
                    TournamentId = 11,
                    VenueId = 12,
                    DateTime = new DateTime(2026, 10, 17, 14, 10, 0, DateTimeKind.Utc),
                    CourtSurface = CourtSurface.Hard,
                    CourtEnvironment = CourtEnvironment.Outdoor,
                    CourtName = "Court 2",
                    MatchRound = MatchRound.Semifinal,
                    MatchStatus = MatchStatus.Completed,
                    //MatchDuration = "1h 25m",
                    ScoreResult = "6-3 6-4",
                    WinnerId = 91
                },
            };

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
    }
}
