namespace CourtSide.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static CourtSide.Common.ValidationConstants.Venue;
    public class Venue
    {
        [Key]
        public Guid Id { get; set; }

        //example value Melbourne Park
        [Required]
        [MaxLength(NameMaxLength)]                          
        public required string Name { get; set; }

        public virtual ICollection<TournamentVenue> TournamentVenues { get; set; } =
            new HashSet<TournamentVenue>();

        public virtual ICollection<Court> Courts { get; set; } =
            new HashSet<Court>();
    }
}
