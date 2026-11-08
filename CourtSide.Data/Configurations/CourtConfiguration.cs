namespace CourtSide.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;

    using CourtSide.Data.Models;

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
                new Court { Id = 1, Name = "Centre Court", VenueId = 1 },
                new Court { Id = 2, Name = "Court 1", VenueId = 1 },

                // 2. Accor Arena / Paris La Défense Arena (Rolex Paris Masters)
                new Court { Id = 3, Name = "Court Central", VenueId = 2 },
                new Court { Id = 4, Name = "Court 1", VenueId = 2 },

                // 3. USTA Billie Jean King National Tennis Center (US Open)
                new Court { Id = 5, Name = "Arthur Ashe Stadium", VenueId = 3 },
                new Court { Id = 6, Name = "Louis Armstrong Stadium", VenueId = 3 },
                new Court { Id = 7, Name = "Grandstand", VenueId = 3 },
                new Court { Id = 8, Name = "Court 17", VenueId = 3 },

                // 4. Almaty Arena (Almaty Open)
                new Court { Id = 9, Name = "Center Court", VenueId = 4 },
                new Court { Id = 10, Name = "Court 1", VenueId = 4 },

                // 5. Melbourne Park (Australian Open)
                new Court { Id = 11, Name = "Rod Laver Arena", VenueId = 5 },
                new Court { Id = 12, Name = "John Cain Arena", VenueId = 5 },
                new Court { Id = 13, Name = "Margaret Court Arena", VenueId = 5 },
                new Court { Id = 14, Name = "Kia Arena", VenueId = 5 },

                // 6. Monte-Carlo Country Club (Monte-Carlo Masters)
                new Court { Id = 15, Name = "Court Rainier III", VenueId = 6 },
                new Court { Id = 16, Name = "Court Des Princes", VenueId = 6 },

                // 7. Caja Mágica (Mutua Madrid Open)
                new Court { Id = 17, Name = "Manolo Santana Stadium", VenueId = 7 },
                new Court { Id = 18, Name = "Arantxa Sánchez Vicario Stadium", VenueId = 7 },
                new Court { Id = 19, Name = "Stadium 3", VenueId = 7 },

                // 8. Foro Italico (Italian Open)
                new Court { Id = 20, Name = "Campo Centrale", VenueId = 8 },
                new Court { Id = 21, Name = "Grandstand Arena", VenueId = 8 },
                new Court { Id = 22, Name = "Pietrangeli", VenueId = 8 },

                // 9. Queen's Club (Cinch Championships)
                new Court { Id = 23, Name = "Centre Court", VenueId = 9 },
                new Court { Id = 24, Name = "Court 1", VenueId = 9 },

                // 10. St. Jakobshalle (Swiss Indoors Basel)
                new Court { Id = 25, Name = "Centre Court", VenueId = 10 },
                new Court { Id = 26, Name = "Court 1", VenueId = 10 },

                // 11. Qizhong Forest Sports City Arena (Shanghai Masters)
                new Court { Id = 27, Name = "Center Court", VenueId = 11 },
                new Court { Id = 28, Name = "Grandstand", VenueId = 11 },

                // 12. Sportpaleis Antwerp / Lotto Arena (European Open)
                new Court { Id = 29, Name = "Center Court", VenueId = 12 },

                // 13. Kungliga Tennishallen (Bybit Stockholm Open)
                new Court { Id = 30, Name = "Centre Court", VenueId = 13 },

                // 14. Inalpi Arena (Nitto Finals)
                new Court { Id = 31, Name = "Centre Court", VenueId = 14 },

                // 15. Unipol Arena (Davis Cup Finals)
                new Court { Id = 32, Name = "Centre Court", VenueId = 15 },

                // 16. PalaTennis 'Corrado Barazzutti' (Next Gen Finals)
                new Court { Id = 33, Name = "Centre Court", VenueId = 16 },

                // 17. Estadio La Cartuja (Billie Jean King Cup Finals)
                new Court { Id = 34, Name = "Centre Court", VenueId = 17 },

                // 18. Khalifa International Tennis & Squash Complex (Qatar TotalEnergies Open)
                new Court { Id = 35, Name = "Centre Court", VenueId = 18 },
                new Court { Id = 36, Name = "Grandstand 1", VenueId = 18 },

                // 19. Indian Wells Tennis Garden (BNP Paribas Open)
                new Court { Id = 37, Name = "Stadium 1", VenueId = 19 },
                new Court { Id = 38, Name = "Stadium 2", VenueId = 19 },
                new Court { Id = 39, Name = "Stadium 3", VenueId = 19 },

                // 20. Hard Rock Stadium (Miami Open)
                new Court { Id = 40, Name = "Stadium Court", VenueId = 20 },
                new Court { Id = 41, Name = "Grandstand", VenueId = 20 },

                // 21. Porsche-Arena (Porsche Tennis Grand Prix)
                new Court { Id = 42, Name = "Centre Court", VenueId = 21 },

                // 22. Stade Roland Garros (Roland Garros)
                new Court { Id = 43, Name = "Court Philippe-Chatrier", VenueId = 22 },
                new Court { Id = 44, Name = "Court Suzanne-Lenglen", VenueId = 22 },
                new Court { Id = 45, Name = "Court Simonne-Mathieu", VenueId = 22 },

                // 23. Devonshire Park Lawn Tennis Club (Rothesay International Eastbourne)
                new Court { Id = 46, Name = "Centre Court", VenueId = 23 },
                new Court { Id = 47, Name = "Court 1", VenueId = 23 },

                // 24. All England Lawn Tennis and Croquet Club (Wimbledon)
                new Court { Id = 48, Name = "Centre Court", VenueId = 24 },
                new Court { Id = 49, Name = "No. 1 Court", VenueId = 24 },
                new Court { Id = 50, Name = "No. 2 Court", VenueId = 24 },
                new Court { Id = 51, Name = "No. 3 Court", VenueId = 24 },

                // 25. IGA Stadium / Stade IGA (National Bank Open)
                new Court { Id = 52, Name = "Court Central", VenueId = 25 },
                new Court { Id = 53, Name = "National Bank Court", VenueId = 25 },

                // 26. National Tennis Center (China Open)
                new Court { Id = 54, Name = "Diamond Court", VenueId = 26 },
                new Court { Id = 55, Name = "Lotus Court", VenueId = 26 },
                new Court { Id = 56, Name = "Moon Court", VenueId = 26 },

                // 27. King Saud University Indoor Arena (WTA Finals Riyadh)
                new Court { Id = 57, Name = "Center Court", VenueId = 27 }
                };
    }
}



