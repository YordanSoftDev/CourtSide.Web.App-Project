namespace CourtSide.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using CourtSide.Data.Models;

    public class TournamentVenueConfiguration : IEntityTypeConfiguration<TournamentVenue>
    {
        public void Configure(EntityTypeBuilder<TournamentVenue> builder)
        {
            builder.HasKey(tv => new { tv.TournamentId, tv.VenueId });

            builder.HasData(DefaultMensTournamentVenues.Concat
                (DefaultWomensTournamentVenues));
        }

        public static IEnumerable<TournamentVenue> DefaultMensTournamentVenues => new List<TournamentVenue>
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

        public static IEnumerable<TournamentVenue> DefaultWomensTournamentVenues => new List<TournamentVenue>
        {
                new TournamentVenue
                {
                    TournamentId = 101,
                    VenueId =  1
                },
                new TournamentVenue
                {
                    TournamentId = 102,
                    VenueId =  3
                },
                new TournamentVenue
                {
                    TournamentId = 103,
                    VenueId= 5
                },
                new TournamentVenue
                {
                    TournamentId = 104,
                    VenueId =  7
                },
                new TournamentVenue
                {
                    TournamentId = 105,
                    VenueId = 8
                },
                new TournamentVenue
                {
                    TournamentId = 106,
                    VenueId = 17
                },
                new TournamentVenue
                {
                    TournamentId = 107,
                    VenueId = 18
                },
                new TournamentVenue
                {
                    TournamentId = 108,
                    VenueId = 19
                },
                new TournamentVenue
                {
                    TournamentId = 109,
                    VenueId = 20
                },
                new TournamentVenue
                {
                    TournamentId = 110,
                    VenueId = 21
                },
                new TournamentVenue
                {
                    TournamentId = 111,
                    VenueId = 22
                },
                new TournamentVenue
                {
                    TournamentId = 112,
                    VenueId = 23
                },
                new TournamentVenue
                {
                    TournamentId = 113,
                    VenueId = 24
                },
                new TournamentVenue
                {
                    TournamentId = 114,
                    VenueId = 25
                },
                new TournamentVenue
                {
                    TournamentId = 115,
                    VenueId = 26
                },
                new TournamentVenue
                {
                    TournamentId = 116,
                    VenueId = 27
                }
        };
    }

}



