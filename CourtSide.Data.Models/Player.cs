namespace CourtSide.Data.Models
{
    using CourtSide.Common.MatchEnumerations;
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static CourtSide.Common.ValidationConstants.Player;

    public class Player
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(FirstNameMaxLength)]
        public required string FirstName { get; set; }

        [Required]
        [MaxLength(LastNameMaxLength)]
        public required string LastName { get; set; }

        [MaxLength(GenderMaxLength)]
        public required Gender Gender { get; set; }

        public required int Age { get; set; }

        //example value 170 lbs/(77kg)
        [Required]
        [MaxLength(WeightMaxLength)]
        public required string Weight { get; set; }

        //example value 6'3"/(191cm)
        [Required]
        [MaxLength(HeightMaxLength)]
        public required string Height { get; set; }

        public required int CountryId { get; set; }

        [ForeignKey(nameof(CountryId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Country Country { get; set; } = null!;

        //example value Palma de Mallorca, Spain
        [Required]
        [MaxLength(BirthplaceMaxLength)]
        public required string Birthplace { get; set; }

        public required int Rank { get; set; }

        public required int? Points { get; set; }

        public required int? TournamentsPlayed { get; set; }

        public virtual ICollection<Coach> Coaches { get; set; } = new List<Coach>();
    }
}
