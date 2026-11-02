namespace CourtSide.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using CourtSide.Data.Models;

    public class VenueConfiguration : IEntityTypeConfiguration<Venue>
    {
        public static IEnumerable<Venue> DefaultVenues =>
             new List<Venue>
             {
                 new Venue
{
    Id = 1,
    Name = "Palais des Sports de Gerland (Lyon Open)"
},
new Venue
{
    Id = 2,
    Name = "Accor Arena / Paris La Défense Arena (Rolex Paris Masters)"
},
new Venue
{
    Id = 3,
    Name = "USTA Billie Jean King National Tennis Center (US Open)"
},
new Venue
{
    Id = 4,
    Name = "Almaty Arena (Almaty Open)"
},
new Venue
{
    Id = 5,
    Name = "Melbourne Park (Australian Open)"
},
new Venue
{
    Id = 6,
    Name = "Monte-Carlo Country Club (Monte-Carlo Masters)"
},
new Venue
{
    Id = 7,
    Name = "Caja Mágica (Mutua Madrid Open)"
},
new Venue
{
    Id = 8,
    Name = "Foro Italico (Italian Open)"
},
new Venue
{
    Id = 9,
    Name = "Queen's Club (Cinch Championships)"
},
new Venue
{
    Id = 10,
    Name = "St. Jakobshalle (Swiss Indoors Basel)"
},
new Venue
{
    Id = 11,
    Name = "Qizhong Forest Sports City Arena (Shanghai Masters)"
},
new Venue
{
    Id = 12,
    Name = "Sportpaleis Antwerp / Lotto Arena (European Open)"
},
new Venue
{
    Id = 13,
    Name = "Kungliga Tennishallen (Bybit Stockholm Open)"
},
new Venue
{
    Id = 14,
    Name = "Inalpi Arena (Nitto Finals)"
},
new Venue
{
    Id = 15,
    Name = "Unipol Arena (Davis Cup Finals)"
},
new Venue
{
    Id = 16,
    Name = "PalaTennis 'Corrado Barazzutti' (Next Gen Finals)"
}
             };

        public void Configure(EntityTypeBuilder<Venue> builder)
        {
            builder.HasMany(v => v.TournamentVenues)
               .WithOne(tv => tv.Venue)
               .HasForeignKey(tv => tv.VenueId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(DefaultVenues);
        }
    }
}
