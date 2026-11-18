namespace CourtSide.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using CourtSide.Data.Models;
    using CourtSide.Data.Seeding;

    public class TournamentVenueConfiguration : IEntityTypeConfiguration<TournamentVenue>
    {
        public void Configure(EntityTypeBuilder<TournamentVenue> builder)
        {
            builder.HasKey(tv => new { tv.TournamentId, tv.VenueId });

            builder.HasData(DefaultMensTournamentVenues.Concat(DefaultWomensTournamentVenues));
        }

        public static IEnumerable<TournamentVenue> DefaultMensTournamentVenues => new List<TournamentVenue>
        {
                new TournamentVenue
                {
                    TournamentId = DeterministicGuid.Create("Tournament_Lyon Open"),
                    VenueId = DeterministicGuid.Create("Venue_LDLC Arena")
                },
                new TournamentVenue
                {
                    TournamentId = DeterministicGuid.Create("Tournament_Rolex Paris Masters"),
                    VenueId = DeterministicGuid.Create("Venue_Paris La Défense Arena")
                },
                new TournamentVenue
                {
                    TournamentId = DeterministicGuid.Create("Tournament_US Open"),
                    VenueId = DeterministicGuid.Create("Venue_USTA Billie Jean King National Tennis Center")
                },
                new TournamentVenue
                {
                    TournamentId = DeterministicGuid.Create("Tournament_Almaty Open"),
                    VenueId = DeterministicGuid.Create("Venue_Almaty Arena")
                },
                new TournamentVenue
                {
                    TournamentId = DeterministicGuid.Create("Tournament_Australian Open"),
                    VenueId = DeterministicGuid.Create("Venue_Melbourne Park")
                },
                new TournamentVenue
                {
                    TournamentId = DeterministicGuid.Create("Tournament_Monte-Carlo Masters"),
                    VenueId = DeterministicGuid.Create("Venue_Monte-Carlo Country Club")
                },
                new TournamentVenue
                {
                    TournamentId = DeterministicGuid.Create("Tournament_Mutua Madrid Open"),
                    VenueId = DeterministicGuid.Create("Venue_Caja Mágica")
                },
                new TournamentVenue
                {
                    TournamentId = DeterministicGuid.Create("Tournament_Italian Open"),
                    VenueId = DeterministicGuid.Create("Venue_Foro Italico")
                },
                new TournamentVenue
                {
                    TournamentId = DeterministicGuid.Create("Tournament_Cinch Championships"),
                    VenueId = DeterministicGuid.Create("Venue_Queen's Club")
                },
                new TournamentVenue
                {
                    TournamentId = DeterministicGuid.Create("Tournament_Swiss Indoors Basel"),
                    VenueId = DeterministicGuid.Create("Venue_St. Jakobshalle")
                },
                new TournamentVenue
                {
                    TournamentId = DeterministicGuid.Create("Tournament_Shanghai Masters"),
                    VenueId = DeterministicGuid.Create("Venue_Qizhong Forest Sports City Arena")
                },
                new TournamentVenue
                {
                    TournamentId = DeterministicGuid.Create("Tournament_European Open"),
                    VenueId = DeterministicGuid.Create("Venue_Lotto Arena")
                },
                new TournamentVenue
                {
                    TournamentId = DeterministicGuid.Create("Tournament_Bybit Stockholm Open"),
                    VenueId = DeterministicGuid.Create("Venue_Kungliga Tennishallen")
                },
                new TournamentVenue
                {
                    TournamentId = DeterministicGuid.Create("Tournament_Nitto Finals"),
                    VenueId = DeterministicGuid.Create("Venue_Inalpi Arena")
                },
                new TournamentVenue
                {
                    TournamentId = DeterministicGuid.Create("Tournament_Davis Cup Finals"),
                    VenueId = DeterministicGuid.Create("Venue_Unipol Arena")
                },
                new TournamentVenue
                {
                    TournamentId = DeterministicGuid.Create("Tournament_Next Gen Finals"),
                    VenueId = DeterministicGuid.Create("Venue_PalaTennis 'Corrado Barazzutti'")
                }
        };

        public static IEnumerable<TournamentVenue> DefaultWomensTournamentVenues => new List<TournamentVenue>
        {
                new TournamentVenue
                {
                    TournamentId = DeterministicGuid.Create("Tournament_Open 6eme Sens Metropole de Lyon"),
                    VenueId = DeterministicGuid.Create("Venue_Palais des Sports de Gerland")
                },
                new TournamentVenue
                {
                    TournamentId = DeterministicGuid.Create("Tournament_Womens US Open"),
                    VenueId = DeterministicGuid.Create("Venue_USTA Billie Jean King National Tennis Center")
                },
                new TournamentVenue
                {
                    TournamentId = DeterministicGuid.Create("Tournament_Qatar TotalEnergies Open"),
                    VenueId = DeterministicGuid.Create("Venue_Khalifa International Tennis & Squash Complex")
                },
                new TournamentVenue
                {
                    TournamentId = DeterministicGuid.Create("Tournament_BNP Paribas Open"),
                    VenueId = DeterministicGuid.Create("Venue_Indian Wells Tennis Garden")
                },
                new TournamentVenue
                {
                    TournamentId = DeterministicGuid.Create("Tournament_Miami Open"),
                    VenueId = DeterministicGuid.Create("Venue_Hard Rock Stadium")
                },
                new TournamentVenue
                {
                    TournamentId = DeterministicGuid.Create("Tournament_Porsche Tennis Grand Prix"),
                    VenueId = DeterministicGuid.Create("Venue_Porsche-Arena")
                },
                new TournamentVenue
                {
                    TournamentId = DeterministicGuid.Create("Tournament_Roland Garros"),
                    VenueId = DeterministicGuid.Create("Venue_Stade Roland Garros")
                },
                new TournamentVenue
                {
                    TournamentId = DeterministicGuid.Create("Tournament_Rothesay International Eastbourne"),
                    VenueId = DeterministicGuid.Create("Venue_Devonshire Park Lawn Tennis Club")
                },
                new TournamentVenue
                {
                    TournamentId = DeterministicGuid.Create("Tournament_Wimbledon"),
                    VenueId = DeterministicGuid.Create("Venue_All England Lawn Tennis and Croquet Club")
                },
                new TournamentVenue
                {
                    TournamentId = DeterministicGuid.Create("Tournament_National Bank Open"),
                    VenueId = DeterministicGuid.Create("Venue_IGA Stadium")
                },
                new TournamentVenue
                {
                    TournamentId = DeterministicGuid.Create("Tournament_China Open"),
                    VenueId = DeterministicGuid.Create("Venue_National Tennis Center")
                },
                 new TournamentVenue
                {
                    TournamentId = DeterministicGuid.Create("Tournament_WTA Finals"),
                    VenueId = DeterministicGuid.Create("Venue_King Saud University Indoor Arena")
                },
                 


                //new TournamentVenue
                //{
                //    TournamentId = DeterministicGuid.Create("Tournament_Womens Australian Open"),
                //    VenueId = DeterministicGuid.Create("Venue_Australian Open_Venue")
                //},
                //new TournamentVenue
                //{
                //    TournamentId = DeterministicGuid.Create("Tournament_Womens Mutua Madrid Open"),
                //    VenueId = DeterministicGuid.Create("Venue_Mutua Madrid Open_Venue")
                //},
                //new TournamentVenue
                //{
                //    TournamentId = DeterministicGuid.Create("Tournament_Internazionali BNL d'Italia"),
                //    VenueId = DeterministicGuid.Create("Venue_Italian Open_Venue")
                //},
                //new TournamentVenue
                //{
                //    TournamentId = DeterministicGuid.Create("Tournament_Billie Jean King Cup Finals"),
                //    VenueId = DeterministicGuid.Create("Venue_Billie Jean King Cup Finals_Venue")
                //},          
        };
    }
}