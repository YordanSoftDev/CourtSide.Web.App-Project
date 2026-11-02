namespace CourtSide.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using CourtSide.Data.Models;

    public class TournamentVenueConfiguration : IEntityTypeConfiguration<TournamentVenue>
    {
        public void Configure(EntityTypeBuilder<TournamentVenue> builder)
        {
            builder.HasData(DefaultTournamentVenues);
        }

        public static IEnumerable<TournamentVenue>  DefaultTournamentVenues => new List<TournamentVenue>
        {
                new TournamentVenue
                {
                    TournamentId = 1,
                    VenueId = 1
                },
                new TournamentVenue
                {
                    TournamentId = 2,
                    VenueId = 2
                },
                new TournamentVenue
                {
                    TournamentId = 3,
                    VenueId = 3
                },
                new TournamentVenue
                {
                    TournamentId = 4,
                    VenueId = 4
                },
                new TournamentVenue
                {
                    TournamentId = 5,
                    VenueId = 5
                },
                new TournamentVenue
                {
                    TournamentId = 6,
                    VenueId = 6
                },
                new TournamentVenue
                {
                    TournamentId = 7,
                    VenueId = 7
                },
                new TournamentVenue
                {
                    TournamentId = 8,
                    VenueId = 8
                },
                new TournamentVenue
                {
                    TournamentId = 9,
                    VenueId = 9
                },
                new TournamentVenue
                {
                    TournamentId = 10,
                    VenueId = 10
                },
                new TournamentVenue
                {
                    TournamentId = 11,
                    VenueId = 11
                },
                new TournamentVenue
                {
                    TournamentId = 12,
                    VenueId = 12
                },
                new TournamentVenue
                {
                    TournamentId = 13,
                    VenueId = 13
                },
                new TournamentVenue
                {
                    TournamentId = 14,
                    VenueId = 14
                },
                new TournamentVenue
                {
                    TournamentId = 15,
                    VenueId = 15
                },
                new TournamentVenue
                {
                    TournamentId = 16,
                    VenueId = 16
                }
        };
    }
}


