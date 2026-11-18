namespace CourtSide.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using CourtSide.Data.Models;
    using CourtSide.Data.Seeding;

    public class CourtConfiguration : IEntityTypeConfiguration<Court>
    {
        public void Configure(EntityTypeBuilder<Court> builder)
        {
            builder.HasOne(c => c.Venue)
                .WithMany(v => v.Courts)
                .HasForeignKey(c => c.VenueId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(DefaultCourts);
        }

        public static IEnumerable<Court> DefaultCourts =>
        new List<Court>
        {     
                // 1. Palais des Sports de Gerland (Lyon Open)
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Palais des Sports de Gerland_Centre Court"),
                    Name = "Centre Court",
                    VenueId = DeterministicGuid.Create("Venue_Palais des Sports de Gerland")
                },
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Palais des Sports de Gerland_Court 1"),
                    Name = "Court 1",
                    VenueId = DeterministicGuid.Create("Venue_Palais des Sports de Gerland")
                },

                // 2. Accor Arena / Paris La Défense Arena (Rolex Paris Masters)
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Paris La Défense Arena_Court Central"),
                    Name = "Court Central",
                    VenueId = DeterministicGuid.Create("Venue_Paris La Défense Arena")
                },
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Paris La Défense Arena_Court 1"),
                    Name = "Court 1",
                    VenueId = DeterministicGuid.Create("Venue_Paris La Défense Arena")
                },

                // 3. USTA Billie Jean King National Tennis Center (US Open)
                new Court
                {
                    Id = DeterministicGuid.Create("Court_USTA Billie Jean King National Tennis Center_Arthur Ashe Stadium"),
                    Name = "Arthur Ashe Stadium",
                    VenueId = DeterministicGuid.Create("Venue_USTA Billie Jean King National Tennis Center")
                },
                new Court
                {
                    Id = DeterministicGuid.Create("Court_USTA Billie Jean King National Tennis Center_Louis Armstrong Stadium"),
                    Name = "Louis Armstrong Stadium",
                    VenueId = DeterministicGuid.Create("Venue_USTA Billie Jean King National Tennis Center")
                },
                new Court
                {
                    Id = DeterministicGuid.Create("Court_USTA Billie Jean King National Tennis Center_Grandstand"),
                    Name = "Grandstand",
                    VenueId = DeterministicGuid.Create("Venue_USTA Billie Jean King National Tennis Center")
                },
                new Court
                {
                    Id = DeterministicGuid.Create("Court_USTA Billie Jean King National Tennis Center_Court 17"),
                    Name = "Court 17",
                    VenueId = DeterministicGuid.Create("Venue_USTA Billie Jean King National Tennis Center")
                },

                // 4. Almaty Arena (Almaty Open)
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Almaty Arena_Center Court"),
                    Name = "Center Court",
                    VenueId = DeterministicGuid.Create("Venue_Almaty Arena")
                },
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Almaty Arena_Court 1"),
                    Name = "Court 1",
                    VenueId = DeterministicGuid.Create("Venue_Almaty Arena")
                },

                // 5. Melbourne Park (Australian Open)
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Melbourne Park_Rod Laver Arena"),
                    Name = "Rod Laver Arena",
                    VenueId = DeterministicGuid.Create("Venue_Melbourne Park")
                },
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Melbourne Park_John Cain Arena"),
                    Name = "John Cain Arena",
                    VenueId = DeterministicGuid.Create("Venue_Melbourne Park")
                },
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Melbourne Park_Margaret Court Arena"),
                    Name = "Margaret Court Arena",
                    VenueId = DeterministicGuid.Create("Venue_Melbourne Park")
                },
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Melbourne Park_Kia Arena"),
                    Name = "Kia Arena",
                    VenueId = DeterministicGuid.Create("Venue_Melbourne Park")
                },

                // 6. Monte-Carlo Country Club (Monte-Carlo Masters)
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Monte-Carlo Country Club_Court Rainier III"),
                    Name = "Court Rainier III",
                    VenueId = DeterministicGuid.Create("Venue_Monte-Carlo Country Club")
                },
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Monte-Carlo Country Club_Court Des Princes"),
                    Name = "Court Des Princes",
                    VenueId = DeterministicGuid.Create("Venue_Monte-Carlo Country Club")
                },

                // 7. Caja Mágica (Mutua Madrid Open)
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Caja Mágica_Manolo Santana Stadium"),
                    Name = "Manolo Santana Stadium",
                    VenueId = DeterministicGuid.Create("Venue_Caja Mágica")
                },
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Caja Mágica_Arantxa Sánchez Vicario Stadium"),
                    Name = "Arantxa Sánchez Vicario Stadium",
                    VenueId = DeterministicGuid.Create("Venue_Caja Mágica")
                },
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Caja Mágica_Stadium 3"),
                    Name = "Stadium 3",
                    VenueId = DeterministicGuid.Create("Venue_Caja Mágica")
                },

                // 8. Foro Italico (Italian Open)
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Foro Italico_Campo Centrale"),
                    Name = "Campo Centrale",
                    VenueId = DeterministicGuid.Create("Venue_Foro Italico")
                },
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Foro Italico_Grandstand Arena"),
                    Name = "Grandstand Arena",
                    VenueId = DeterministicGuid.Create("Venue_Foro Italico")
                },
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Foro Italico_Pietrangeli"),
                    Name = "Pietrangeli",
                    VenueId = DeterministicGuid.Create("Venue_Foro Italico")
                },

                // 9. Queen's Club (Cinch Championships)
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Queen's Club_Centre Court"),
                    Name = "Centre Court",
                    VenueId = DeterministicGuid.Create("Venue_Queen's Club")
                },
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Queen's Club_Court 1"),
                    Name = "Court 1",
                    VenueId = DeterministicGuid.Create("Venue_Queen's Club")
                },

                // 10. St. Jakobshalle (Swiss Indoors Basel)
                new Court
                {
                    Id = DeterministicGuid.Create("Court_St. Jakobshalle_Centre Court"),
                    Name = "Centre Court",
                    VenueId = DeterministicGuid.Create("Venue_St. Jakobshalle")
                },
                new Court
                {
                    Id = DeterministicGuid.Create("Court_St. Jakobshalle_Court 1"),
                    Name = "Court 1",
                    VenueId = DeterministicGuid.Create("Venue_St. Jakobshalle")
                },

                // 11. Qizhong Forest Sports City Arena (Shanghai Masters)
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Qizhong Forest Sports City Arena_Center Court"),
                    Name = "Center Court",
                    VenueId = DeterministicGuid.Create("Venue_Qizhong Forest Sports City Arena")
                },
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Qizhong Forest Sports City Arena_Grandstand"),
                    Name = "Grandstand",
                    VenueId = DeterministicGuid.Create("Venue_Qizhong Forest Sports City Arena")
                },

                // 12. Sportpaleis Antwerp / Lotto Arena (European Open)
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Lotto Arena_Center Court"),
                    Name = "Center Court",
                    VenueId = DeterministicGuid.Create("Venue_Lotto Arena")
                },

                // 13. Kungliga Tennishallen (Bybit Stockholm Open)
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Kungliga Tennishallen_Centre Court"),
                    Name = "Centre Court",
                    VenueId = DeterministicGuid.Create("Venue_Kungliga Tennishallen")
                },

                // 14. Inalpi Arena (Nitto Finals)
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Inalpi Arena_Centre Court"),
                    Name = "Centre Court",
                    VenueId = DeterministicGuid.Create("Venue_Inalpi Arena")
                },

                // 15. Unipol Arena (Davis Cup Finals)
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Unipol Arena_Centre Court"),
                    Name = "Centre Court",
                    VenueId = DeterministicGuid.Create("Venue_Unipol Arena")
                },

                // 16. PalaTennis 'Corrado Barazzutti' (Next Gen Finals)
                new Court
                {
                    Id = DeterministicGuid.Create("Court_PalaTennis 'Corrado Barazzutti'_Centre Court"),
                    Name = "Centre Court",
                    VenueId = DeterministicGuid.Create("Venue_PalaTennis 'Corrado Barazzutti'")
                },

                // 17. Estadio La Cartuja (Billie Jean King Cup Finals)
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Estadio La Cartuja_Centre Court"),
                    Name = "Centre Court",
                    VenueId = DeterministicGuid.Create("Venue_Estadio La Cartuja")
                },

                // 18. Khalifa International Tennis & Squash Complex (Qatar TotalEnergies Open)
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Khalifa International Tennis & Squash Complex_Centre Court"),
                    Name = "Centre Court",
                    VenueId = DeterministicGuid.Create("Venue_Khalifa International Tennis & Squash Complex")
                },
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Khalifa International Tennis & Squash Complex_Grandstand 1"),
                    Name = "Grandstand 1",
                    VenueId = DeterministicGuid.Create("Venue_Khalifa International Tennis & Squash Complex")
                },

                // 19. Indian Wells Tennis Garden (BNP Paribas Open)
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Indian Wells Tennis Garden_Stadium 1"),
                    Name = "Stadium 1",
                    VenueId = DeterministicGuid.Create("Venue_Indian Wells Tennis Garden")
                },
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Indian Wells Tennis Garden_Stadium 2"),
                    Name = "Stadium 2",
                    VenueId = DeterministicGuid.Create("Venue_Indian Wells Tennis Garden")
                },
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Indian Wells Tennis Garden_Stadium 3"),
                    Name = "Stadium 3",
                    VenueId = DeterministicGuid.Create("Venue_Indian Wells Tennis Garden")
                },

                // 20. Hard Rock Stadium (Miami Open)
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Hard Rock Stadium_Stadium Court"),
                    Name = "Stadium Court",
                    VenueId = DeterministicGuid.Create("Venue_Hard Rock Stadium")
                },
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Hard Rock Stadium_Grandstand"),
                    Name = "Grandstand",
                    VenueId = DeterministicGuid.Create("Venue_Hard Rock Stadium")
                },

                // 21. Porsche-Arena (Porsche Tennis Grand Prix)
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Porsche-Arena_Centre Court"),
                    Name = "Centre Court",
                    VenueId = DeterministicGuid.Create("Venue_Porsche-Arena")
                },

                // 22. Stade Roland Garros (Roland Garros)
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Stade Roland Garros_Court Philippe-Chatrier"),
                    Name = "Court Philippe-Chatrier",
                    VenueId = DeterministicGuid.Create("Venue_Stade Roland Garros")
                },
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Stade Roland Garros_Court Suzanne-Lenglen"),
                    Name = "Court Suzanne-Lenglen",
                    VenueId = DeterministicGuid.Create("Venue_Stade Roland Garros")
                },
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Stade Roland Garros_Court Simonne-Mathieu"),
                    Name = "Court Simonne-Mathieu",
                    VenueId = DeterministicGuid.Create("Venue_Stade Roland Garros")
                },

                // 23. Devonshire Park Lawn Tennis Club (Rothesay International Eastbourne)
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Devonshire Park Lawn Tennis Club_Centre Court"),
                    Name = "Centre Court",
                    VenueId = DeterministicGuid.Create("Venue_Devonshire Park Lawn Tennis Club")
                },
                new Court
                {
                    Id = DeterministicGuid.Create("Court_Devonshire Park Lawn Tennis Club_Court 1"),
                    Name = "Court 1",
                    VenueId = DeterministicGuid.Create("Venue_Devonshire Park Lawn Tennis Club")
                },

                // 24. All England Lawn Tennis and Croquet Club (Wimbledon)
                new Court
                {
                    Id = DeterministicGuid.Create("Court_All England Lawn Tennis and Croquet Club_Centre Court"),
                    Name = "Centre Court",
                    VenueId = DeterministicGuid.Create("Venue_All England Lawn Tennis and Croquet Club")
                },
                new Court
                {
                    Id = DeterministicGuid.Create("Court_All England Lawn Tennis and Croquet Club_No. 1 Court"),
                    Name = "No. 1 Court",
                    VenueId = DeterministicGuid.Create("Venue_All England Lawn Tennis and Croquet Club")
                },
                new Court
                {
                    Id = DeterministicGuid.Create("Court_All England Lawn Tennis and Croquet Club_No. 2 Court"),
                    Name = "No. 2 Court",
                    VenueId = DeterministicGuid.Create("Venue_All England Lawn Tennis and Croquet Club")
                },
                new Court
                {
                    Id = DeterministicGuid.Create("Court_All England Lawn Tennis and Croquet Club_No. 3 Court"),
                    Name = "No. 3 Court",
                    VenueId = DeterministicGuid.Create("Venue_All England Lawn Tennis and Croquet Club")
                },

                // 25. IGA Stadium / Stade IGA (National Bank Open)
                new Court
                {
                    Id = DeterministicGuid.Create("Court_IGA Stadium_Court Central"),
                    Name = "Court Central",
                    VenueId = DeterministicGuid.Create("Venue_IGA Stadium")
                },
                new Court
                {
                    Id = DeterministicGuid.Create("Court_IGA Stadium_National Bank Court"),
                    Name = "National Bank Court",
                    VenueId = DeterministicGuid.Create("Venue_IGA Stadium")
                },

                // 26. National Tennis Center (China Open)
                new Court
                {
                    Id = DeterministicGuid.Create("Court_National Tennis Center_Diamond Court"),
                    Name = "Diamond Court",
                    VenueId = DeterministicGuid.Create("Venue_National Tennis Center")
                },
                new Court
                {
                    Id = DeterministicGuid.Create("Court_National Tennis Center_Lotus Court"),
                    Name = "Lotus Court",
                    VenueId = DeterministicGuid.Create("Venue_National Tennis Center")
                },
                new Court
                {
                    Id = DeterministicGuid.Create("Court_National Tennis Center_Moon Court"),
                    Name = "Moon Court",
                    VenueId = DeterministicGuid.Create("Venue_National Tennis Center")
                },

                // 27. King Saud University Indoor Arena (WTA Finals Riyadh)
                new Court
                {
                    Id = DeterministicGuid.Create("Court_King Saud University Indoor Arena_Center Court"),
                    Name = "Center Court",
                    VenueId = DeterministicGuid.Create("Venue_King Saud University Indoor Arena")
                }
        };
    }
}