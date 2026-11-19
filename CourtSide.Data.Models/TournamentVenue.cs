namespace CourtSide.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;
    using CourtSide.Common.Models;
    using Microsoft.EntityFrameworkCore;

    [Table("TournamentVenues")]
    [PrimaryKey(nameof(TournamentId), nameof(VenueId))]
    public class TournamentVenue : ISoftDeleteableEntity
    {
        public required Guid TournamentId { get; set; }

        [ForeignKey(nameof(TournamentId))]
        public virtual Tournament Tournament { get; set; } = null!;

        public required Guid VenueId { get; set; }

        [ForeignKey(nameof(VenueId))]
        public virtual Venue Venue { get; set; } = null!;

        public bool IsDeleted { get; set; }
    }
}
