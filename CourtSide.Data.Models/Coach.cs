namespace CourtSide.Data.Models
{
    using Microsoft.EntityFrameworkCore;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using static CourtSide.Common.ValidationConstants.Coach;

    public class Coach
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(FirstNameMaxLength)]
        public required string FirstName { get; set; }

        [Required]
        [MaxLength(LastNameMaxLength)]
        public required string LastName { get; set; }

        public required int PlayerId { get; set; }

        [ForeignKey(nameof(PlayerId))]
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public virtual Player Player { get; set; } = null!;
    }
}
