namespace CourtSide.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using CourtSide.Common.MatchEnumerations;
    using static CourtSide.Common.ValidationConstants.Tournament;
    public class Tournament
    {
        [Key]
        public int Id { get; set; }

        //example value Almaty Open
        [Required]
        [MaxLength(TournamentNameMaxLength)]
        public required string TournamentName { get; set; }

        //example value ATP 250
        [Required]
        [MaxLength(TournamentTypeMaxLength)]
        public required string TournamentType { get; set; }

        //example value Almaty, Kazakhstan
        [Required]
        [MaxLength(LocationMaxLength)]
        public required string Location { get; set; }

        //example value 19 October 2026
        [Required]
        [Column(TypeName = "datetime2")]
        public required DateTime StartDate { get; set; }

        //example value 25 October 2026
        [Required]
        [Column(TypeName = "datetime2")]
        public required DateTime EndDate { get; set; }

        //the variants are Grass, Clay, Hard, Carpet 
        [MaxLength(CourtSurfaceMaxLength)]
        public required CourtSurface CourtSurface { get; set; }

        //the variants are Indoor, Outdoor
        [MaxLength(CourtEnvironmentMaxLength)]
        public required CourtEnvironment CourtEnvironment { get; set; }

        [NotMapped]
        public bool IsActive =>
            DateTime.Now >= this.StartDate && DateTime.Now <= this.EndDate;

        public virtual  ICollection<TournamentVenue> TournamentVenues { get; set; } =
            new HashSet<TournamentVenue>();
    }
}
