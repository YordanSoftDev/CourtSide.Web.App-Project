namespace CourtSide.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using CourtSide.Common.MatchEnumerations;
    using CourtSide.Common.Models;
    using CourtSide.Common.TournamentEnumerations;
    using static CourtSide.Common.ValidationConstants.Tournament;
    public class Tournament : ISoftDeleteableEntity
    {
        [Key]
        public Guid Id { get; set; }

        //example value Almaty Open
        [Required]
        [MaxLength(TournamentNameMaxLength)]
        public required string TournamentName { get; set; }

        //example value ATP 250
        [Required]
        [MaxLength(TournamentTypeMaxLength)]
        public required string TournamentType { get; set; }

        //example value Singles
        [Required]
        [MaxLength(DisciplineMaxLength)]
        public required string Discipline { get; set; }

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
        [Required]
        [MaxLength(CourtSurfaceMaxLength)]
        public required CourtSurface CourtSurface { get; set; }

        //the variants are Indoor, Outdoor
        [Required]
        [MaxLength(CourtEnvironmentMaxLength)]
        public required CourtEnvironment CourtEnvironment { get; set; }

        [Required]
        [MaxLength(MatchFormatMaxLength)]
        public required MatchFormat MatchFormat { get; set; }

        [Required]
        [MaxLength(TieBreakRuleMaxLength)]
        public required TieBreakRule TieBreakRule { get; set; }

        [NotMapped]
        public bool IsActive =>
            DateTime.Now >= this.StartDate && DateTime.Now <= this.EndDate;

        public bool IsDeleted { get; set; }

        public virtual ICollection<TournamentVenue> TournamentVenues { get; set; } =
            new HashSet<TournamentVenue>();
    }
}
