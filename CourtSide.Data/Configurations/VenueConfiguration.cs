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
                    // men's and women's venue
                    Id = 1,
                    Name = "Palais des Sports de Gerland (Lyon Open)"
                },
                new Venue
                {
                    // men's venue
                    Id = 2,
                    Name = "Accor Arena / Paris La Défense Arena (Rolex Paris Masters)"
                },
                new Venue
                {
                    // men's and women's venue
                    Id = 3,
                    Name = "USTA Billie Jean King National Tennis Center (US Open)"
                },
                new Venue
                {
                    // men's venue
                    Id = 4,
                    Name = "Almaty Arena (Almaty Open)"
                },
                new Venue
                {
                    // men's and women's venue
                    Id = 5,
                    Name = "Melbourne Park (Australian Open)"
                },
                new Venue
                {
                    // men's venue
                    Id = 6,
                    Name = "Monte-Carlo Country Club (Monte-Carlo Masters)"
                },
                new Venue
                {
                    // men's and women's venue
                    Id = 7,
                    Name = "Caja Mágica (Mutua Madrid Open)"
                },
                new Venue
                {
                    // men's and women's venue
                    Id = 8,
                    Name = "Foro Italico (Italian Open)"
                },
                new Venue
                {
                    // men's venue
                    Id = 9,
                    Name = "Queen's Club (Cinch Championships)"
                },
                new Venue
                {
                    // men's venue
                    Id = 10,
                    Name = "St. Jakobshalle (Swiss Indoors Basel)"
                },
                new Venue
                {
                    // men's venue
                    Id = 11,
                    Name = "Qizhong Forest Sports City Arena (Shanghai Masters)"
                },
                new Venue
                {
                    // men's venue
                    Id = 12,
                    Name = "Sportpaleis Antwerp / Lotto Arena (European Open)"
                },
                new Venue
                {
                    // men's venue
                    Id = 13,
                    Name = "Kungliga Tennishallen (Bybit Stockholm Open)"
                },
                new Venue
                {
                    // men's venue
                    Id = 14,
                    Name = "Inalpi Arena (Nitto Finals)"
                },
                new Venue
                {
                    // men's venue
                    Id = 15,
                    Name = "Unipol Arena (Davis Cup Finals)"
                },
                new Venue
                {
                    // men's venue
                    Id = 16,
                    Name = "PalaTennis 'Corrado Barazzutti' (Next Gen Finals)"
                },
                new Venue
                {
                    // women's venue
                    Id = 17,
                    Name = "Estadio La Cartuja (Billie Jean King Cup Finals)"
                },
                new Venue
                {
                    // women's venue
                    Id = 18,
                    Name = "Khalifa International Tennis & Squash Complex (Qatar TotalEnergies Open)"
                },
                new Venue
                {
                    // men's and women's venue
                    Id = 19,
                    Name = "Indian Wells Tennis Garden (BNP Paribas Open)"
                },
                new Venue
                {
                    // men's and women's venue
                    Id = 20,
                    Name = "Hard Rock Stadium (Miami Open)"
                },
                new Venue
                {
                    // women's venue
                    Id = 21,
                    Name = "Porsche-Arena (Porsche Tennis Grand Prix)"
                },
                new Venue
                {
                    // men's and women's venue
                    Id = 22,
                    Name = "Stade Roland Garros (Roland Garros)"
                },
                new Venue
                {
                    // women's venue
                    Id = 23,
                    Name = "Devonshire Park Lawn Tennis Club (Rothesay International Eastbourne)"
                },
                new Venue
                {
                    // men's and women's venue
                    Id = 24,
                    Name = "All England Lawn Tennis and Croquet Club (Wimbledon)"
                },
                new Venue
                {
                    // men's and women's venue
                    Id = 25,
                    Name = "IGA Stadium / Stade IGA (National Bank Open)"
                },
                new Venue
                {
                    // men's and women's venue
                    Id = 26,
                    Name = "National Tennis Center (China Open)"
                },
                new Venue
                {
                    // women's venue
                    Id = 27,
                    Name = "King Saud University Indoor Arena (WTA Finals Riyadh)"
                }
             };
    }
}