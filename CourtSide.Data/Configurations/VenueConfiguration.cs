namespace CourtSide.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using CourtSide.Data.Models;

    public class VenueConfiguration : IEntityTypeConfiguration<Venue>
    {
        public void Configure(EntityTypeBuilder<Venue> builder)
        {
            builder.HasMany(v => v.TournamentVenues)
               .WithOne(tv => tv.Venue)
               .HasForeignKey(tv => tv.VenueId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(DefaultVenues);
        }

        public static IEnumerable<Venue> DefaultVenues =>
             new List<Venue>
             {
                new Venue
                {
                    // Tournament name - Lyon Open
                    // men's and women's venue
                    Id = 1,
                    Name = "Palais des Sports de Gerland"
                },
                new Venue
                {
                    // Tournament name - Rolex Paris Masters
                    // men's venue
                    Id = 2,
                    Name = "Accor Arena / Paris La Défense Arena"
                },
                new Venue
                {
                    // Tournament name - US Open
                    // men's and women's venue
                    Id = 3,
                    Name = "USTA Billie Jean King National Tennis Center"
                },
                new Venue
                {
                    // Tournament name - Almaty Open
                    // men's venue
                    Id = 4,
                    Name = "Almaty Arena"
                },
                new Venue
                {
                    // Tournament name - Australian Open
                    // men's and women's venue
                    Id = 5,
                    Name = "Melbourne Park"
                },
                new Venue
                {
                    // Tournament name - Monte-Carlo Masters
                    // men's venue
                    Id = 6,
                    Name = "Monte-Carlo Country Club"
                },
                new Venue
                {
                    // Tournament name - Mutua Madrid Open
                    // men's and women's venue
                    Id = 7,
                    Name = "Caja Mágica"
                },
                new Venue
                {
                    // Tournament name - Italian Open
                    // men's and women's venue
                    Id = 8,
                    Name = "Foro Italico"
                },
                new Venue
                {
                    // Tournament name - Cinch Championships
                    // men's venue
                    Id = 9,
                    Name = "Queen's Club"
                },
                new Venue
                {
                    // Tournament name - Swiss Indoors Basel
                    // men's venue
                    Id = 10,
                    Name = "St. Jakobshalle"
                },
                new Venue
                {
                    // Tournament name - Shanghai Masters
                    // men's venue
                    Id = 11,
                    Name = "Qizhong Forest Sports City Arena"
                },
                new Venue
                {
                    // Tournament name - European Open
                    // men's venue
                    Id = 12,
                    Name = "Sportpaleis Antwerp / Lotto Arena"
                },
                new Venue
                {
                    // Tournament name - Bybit Stockholm Open
                    // men's venue
                    Id = 13,
                    Name = "Kungliga Tennishallen"
                },
                new Venue
                {
                    // Tournament name - Nitto Finals
                    // men's venue
                    Id = 14,
                    Name = "Inalpi Arena"
                },
                new Venue
                {
                    // Tournament name - Davis Cup Finals
                    // men's venue
                    Id = 15,
                    Name = "Unipol Arena"
                },
                new Venue
                {
                    // Tournament name - Next Gen Finals
                    // men's venue
                    Id = 16,
                    Name = "PalaTennis 'Corrado Barazzutti'"
                },
                new Venue
                {
                    // Tournament name - Billie Jean King Cup Finals
                    // women's venue
                    Id = 17,
                    Name = "Estadio La Cartuja"
                },
                new Venue
                {
                    // Tournament name - Qatar TotalEnergies Open
                    // women's venue
                    Id = 18,
                    Name = "Khalifa International Tennis & Squash Complex"
                },
                new Venue
                {
                    // Tournament name - BNP Paribas Open
                    // men's and women's venue
                    Id = 19,
                    Name = "Indian Wells Tennis Garden"
                },
                new Venue
                {
                    // Tournament name - Miami Open
                    // men's and women's venue
                    Id = 20,
                    Name = "Hard Rock Stadium"
                },
                new Venue
                {
                    // Tournament name - Porsche Tennis Grand Prix
                    // women's venue
                    Id = 21,
                    Name = "Porsche-Arena"
                },
                new Venue
                {
                    // Tournament name - Roland Garros
                    // men's and women's venue
                    Id = 22,
                    Name = "Stade Roland Garros"
                },
                new Venue
                {
                    // Tournament name - Rothesay International Eastbourne
                    // women's venue
                    Id = 23,
                    Name = "Devonshire Park Lawn Tennis Club"
                },
                new Venue
                {
                    // Tournament name - Wimbledon
                    // men's and women's venue
                    Id = 24,
                    Name = "All England Lawn Tennis and Croquet Club"
                },
                new Venue
                {
                    // Tournament name - National Bank Open
                    // men's and women's venue
                    Id = 25,
                    Name = "IGA Stadium / Stade IGA"
                },
                new Venue
                {
                    // Tournament name - China Open
                    // men's and women's venue
                    Id = 26,
                    Name = "National Tennis Center"
                },
                new Venue
                {
                    // Tournament name - WTA Finals Riyadh
                    // women's venue
                    Id = 27,
                    Name = "King Saud University Indoor Arena"
                }
             };
    }
}