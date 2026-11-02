namespace CourtSide.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using CourtSide.Common.MatchEnumerations;
    using static CourtSide.Common.ValidationConstants.Match;
    public class Match
    {
        [Key]
        public int Id { get; set; }

        public required int FirstPlayerId { get; set; }
        [ForeignKey(nameof(FirstPlayerId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Player FirstPlayer { get; set; } = null!;

        public required int SecondPlayerId { get; set; }
        [ForeignKey(nameof(SecondPlayerId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Player SecondPlayer { get; set; } = null!;

        [Required]
        [Column(TypeName = "datetime2")]
        public required DateTime DateTime { get; set; }

        //The variants are Sheduled, In Progress, Completed, Cancelled 
        [MaxLength(MatchStatusMaxLength)]
        public required MatchStatus MatchStatus { get; set; }

        [MaxLength(MatchRoundMaxLength)]
        public required MatchRound MatchRound { get; set; }

        //example value 1h 31m
        //public required string MatchDuration { get; set; }

        //The variants are Grass, Clay, Hard and Carpet
        [MaxLength(CourtSurfaceMaxLength)]
        public required CourtSurface CourtSurface { get; set; }

        [Required]
        [MaxLength(CourtNameMaxLength)]
        public required string CourtName { get; set; }

        //The variants are Indoor and Outdoor
        [MaxLength(CourtEnvironmentMaxLength)]
        public required CourtEnvironment? CourtEnvironment { get; set; }

        //The venue(tennis club or a stadium)
        //where the match will be played or was played
        public required int VenueId { get; set; }
        [ForeignKey(nameof(VenueId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Venue Venue { get; set; } = null!;

        public required int TournamentId { get; set; }
        [ForeignKey(nameof(TournamentId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Tournament Tournament { get; set; } = null!;

        [MaxLength(ScoreResultMaxLength)]
        public string? ScoreResult { get; set; }

        public int? WinnerId { get; set; }
        [ForeignKey(nameof(WinnerId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Player? Winner { get; set; }
    }
}
