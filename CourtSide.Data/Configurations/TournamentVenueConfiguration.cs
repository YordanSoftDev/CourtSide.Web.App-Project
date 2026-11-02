namespace CourtSide.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using CourtSide.Data.Models;

    public class TournamentVenueConfiguration : IEntityTypeConfiguration<TournamentVenue>
    {
        public void Configure(EntityTypeBuilder<TournamentVenue> builder)
        {
        }
    }
}
