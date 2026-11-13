namespace CourtSide.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using static CourtSide.Common.ValidationConstants.Court;

    public class Court
    {
        [Key]
        public int Id { get; set; }

        // example value "Centre Court", "Court 1"
        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = string.Empty;

        [Required]
        public int VenueId { get; set; }

        [ForeignKey(nameof(VenueId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]

        public Venue Venue { get; set; } = null!;
    }
}