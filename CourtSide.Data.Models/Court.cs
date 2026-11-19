namespace CourtSide.Data.Models
{
    using CourtSide.Common.Models;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static CourtSide.Common.ValidationConstants.Court;

    public class Court : ISoftDeleteableEntity
    {
        [Key]
        public Guid Id { get; set; }

        // example value "Centre Court", "Court 1"
        [Required]
        [MaxLength(NameMaxLength)]
        public required string Name { get; set; } 

        public bool IsDeleted { get ; set; }

        public Guid VenueId { get; set; }

        [ForeignKey(nameof(VenueId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]

        public Venue Venue { get; set; } = null!;

        public ICollection<Match> Matches { get; set; } = new List<Match>();
    }
}