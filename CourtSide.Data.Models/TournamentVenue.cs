namespace CourtSide.Data.Models
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Microsoft.EntityFrameworkCore;

    [Table("TournamentVenues")]
    [PrimaryKey(nameof(TournamentId), nameof(VenueId))]
    public class TournamentVenue
    {
        public int TournamentId { get; set; }

        [ForeignKey(nameof(TournamentId))]
        public virtual Tournament Tournament { get; set; } = null!;

        public int VenueId { get; set; }

        [ForeignKey(nameof(VenueId))]
        public virtual Venue Venue { get; set; } = null!;
    }
}
