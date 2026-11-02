namespace CourtSide.Data.Models
{
    using System.ComponentModel.DataAnnotations;
    using static CourtSide.Common.ValidationConstants.Country;
    public class Country
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public required string Name { get; set; }
    }
}
