namespace CourtSide.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using CourtSide.Data.Models;
    using CourtSide.Data.Seeding;

    public class VenueConfiguration : IEntityTypeConfiguration<Venue>
    {
        public void Configure(EntityTypeBuilder<Venue> builder)
        {
            builder.HasMany(v => v.TournamentVenues)
               .WithOne(tv => tv.Venue)
               .HasForeignKey(tv => tv.VenueId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasQueryFilter(v => v.IsDeleted == false);

            builder.HasData(DefaultVenues);
        }

        public static IEnumerable<Venue> DefaultVenues =>
             new List<Venue>
             {
                new Venue
                {
                    // Tournament name - Lyon Open
                    // men's and women's venue
                     Id = DeterministicGuid.Create("Venue_LDLC Arena"),
                     Name = "LDLC Arena"
                },
                new Venue
                {
                    // Tournament name - Rolex Paris Masters
                    // men's venue
                    Id = DeterministicGuid.Create("Venue_Paris La Défense Arena"),
                    Name = "Paris La Défense Arena"
                },
                new Venue
                {
                    // Tournament name - US Open
                    // men's and women's venue
                    Id = DeterministicGuid.Create("Venue_USTA Billie Jean King National Tennis Center"),
                    Name = "USTA Billie Jean King National Tennis Center"
                },
                new Venue
                {
                    // Tournament name - Almaty Open
                    // men's venue
                    Id = DeterministicGuid.Create("Venue_Almaty Arena"),
                    Name = "Almaty Arena"
                },
                new Venue
                {
                    // Tournament name - Australian Open
                    // men's and women's venue
                    Id = DeterministicGuid.Create("Venue_Melbourne Park"),
                    Name = "Melbourne Park"
                },
                new Venue
                {
                    // Tournament name - Monte-Carlo Masters
                    // men's venue
                    Id = DeterministicGuid.Create("Venue_Monte-Carlo Country Club"),
                    Name = "Monte-Carlo Country Club"
                },
                new Venue
                {
                    // Tournament name - Mutua Madrid Open
                    // men's and women's venue
                    Id = DeterministicGuid.Create("Venue_Caja Mágica"),
                    Name = "Caja Mágica"
                },
                new Venue
                {
                    // Tournament name - Italian Open
                    // men's and women's venue
                    Id = DeterministicGuid.Create("Venue_Foro Italico"),
                    Name = "Foro Italico"
                },
                new Venue
                {
                    // Tournament name - Cinch Championships
                    // men's venue
                    Id = DeterministicGuid.Create("Venue_Queen's Club"),
                    Name = "Queen's Club"
                },
                new Venue
                {
                    // Tournament name - Swiss Indoors Basel
                    // men's venue
                    Id = DeterministicGuid.Create("Venue_St. Jakobshalle"),
                    Name = "St. Jakobshalle"
                },
                new Venue
                {
                    // Tournament name - Shanghai Masters
                    // men's venue
                    Id = DeterministicGuid.Create("Venue_Qizhong Forest Sports City Arena"),
                    Name = "Qizhong Forest Sports City Arena"
                },
                new Venue
                {
                    // Tournament name - European Open
                    // men's venue
                    Id = DeterministicGuid.Create("Venue_Lotto Arena"),
                    Name = "Lotto Arena"
                },
                new Venue
                {
                    // Tournament name - Bybit Stockholm Open
                    // men's venue
                    Id = DeterministicGuid.Create("Venue_Kungliga Tennishallen"),
                    Name = "Kungliga Tennishallen"
                },
                new Venue
                {
                    // Tournament name - Nitto Finals
                    // men's venue
                    Id = DeterministicGuid.Create("Venue_Inalpi Arena"),
                    Name = "Inalpi Arena"
                },
                new Venue
                {
                    // Tournament name - Davis Cup Finals
                    // men's venue
                    Id = DeterministicGuid.Create("Venue_Unipol Arena"),
                    Name = "Unipol Arena"
                },
                new Venue
                {
                    // Tournament name - Next Gen Finals
                    // men's venue
                    Id = DeterministicGuid.Create("Venue_PalaTennis 'Corrado Barazzutti'"),
                    Name = "PalaTennis 'Corrado Barazzutti'"
                },
                new Venue
                {
                    // Tournament name - Billie Jean King Cup Finals
                    Id = DeterministicGuid.Create("Venue_Estadio La Cartuja"),
                    Name = "Estadio La Cartuja"
                },
                new Venue
                {
                    //Tournament name - "Open 6ème Sens Métropole de Lyon"
                    Id = DeterministicGuid.Create("Venue_Palais des Sports de Gerland"),
                    Name = "Palais des Sports de Gerland"
                },
                new Venue
                {
                    // Tournament name - Qatar TotalEnergies Open
                    // women's venue
                    Id = DeterministicGuid.Create("Venue_Khalifa International Tennis & Squash Complex"),
                    Name = "Khalifa International Tennis & Squash Complex"
                },
                new Venue
                {
                    // Tournament name - BNP Paribas Open
                    // men's and women's venue
                    Id = DeterministicGuid.Create("Venue_Indian Wells Tennis Garden"),
                    Name = "Indian Wells Tennis Garden"
                },
                new Venue
                {
                    // Tournament name - Miami Open
                    // men's and women's venue
                    Id = DeterministicGuid.Create("Venue_Hard Rock Stadium"),
                    Name = "Hard Rock Stadium"
                },
                new Venue
                {
                    // Tournament name - Porsche Tennis Grand Prix
                    // women's venue
                    Id = DeterministicGuid.Create("Venue_Porsche-Arena"),
                    Name = "Porsche-Arena"
                },
                new Venue
                {
                    // Tournament name - Roland Garros
                    // men's and women's venue
                    Id = DeterministicGuid.Create("Venue_Stade Roland Garros"),
                    Name = "Stade Roland Garros"
                },
                new Venue
                {
                    // Tournament name - Rothesay International Eastbourne
                    // women's venue
                    Id = DeterministicGuid.Create("Venue_Devonshire Park Lawn Tennis Club"),
                    Name = "Devonshire Park Lawn Tennis Club"
                },
                new Venue
                {
                    // Tournament name - Wimbledon
                    // men's and women's venue
                    Id = DeterministicGuid.Create("Venue_All England Lawn Tennis and Croquet Club"),
                    Name = "All England Lawn Tennis and Croquet Club"
                },
                new Venue
                {
                    // Tournament name - National Bank Open
                    // men's and women's venue
                    Id = DeterministicGuid.Create("Venue_IGA Stadium"),
                    Name = "IGA Stadium / Stade IGA"
                },
                new Venue
                {
                    // Tournament name - China Open
                    // men's and women's venue
                    Id = DeterministicGuid.Create("Venue_National Tennis Center"),
                    Name = "National Tennis Center"
                },
                new Venue
                {
                    // Tournament name - WTA Finals Riyadh
                    // women's venue
                    Id = DeterministicGuid.Create("Venue_King Saud University Indoor Arena"),
                    Name = "King Saud University Indoor Arena"
                }
             };
    }
}