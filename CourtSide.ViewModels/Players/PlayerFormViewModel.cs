namespace CourtSide.ViewModels.Players
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.ComponentModel.DataAnnotations;
    using static CourtSide.Common.ValidationConstants.Player;
    public class PlayerFormViewModel
    {

        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(FirstNameMaxLength, MinimumLength = FirstNameMinLength)]
        [RegularExpression(@"^[A-Z][a-z]+$",
         ErrorMessage = "First name must start with an uppercase letter " +
                        "followed by one or more lowercase letters.")]
        public string? FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [StringLength(LastNameMaxLength, MinimumLength = LastNameMinLength)]
        [RegularExpression(@"^[A-Z][a-z]+$",
         ErrorMessage = "Last name must start with an uppercase letter " +
                        "followed by one or more lowercase letters.")]
        public string? LastName { get; set; }

        [Required(ErrorMessage = "Age is required.")]
        [Range(13, 45, ErrorMessage = "Age must be " +
                                              "between 13 and 45.")]
        public int? Age { get; set; }

        [Required(ErrorMessage = "Weight is required.")]
        [StringLength(WeightMaxLength, MinimumLength = WeightMinLength)]
        [RegularExpression(@"^\d{2,3} lbs/\(\d{2,3}kg\)$",
            ErrorMessage = "Weight value must be in the format " +
                           "170 lbs/(77kg)")]
        public string? Weight { get; set; }

        [Required(ErrorMessage = "Height is required.")]
        [StringLength(HeightMaxLength, MinimumLength = HeightMinLength)]
        [RegularExpression(@"^\d{1}'\d{1,2}""/\(\d{3}cm\)$",
            ErrorMessage = "Height value must be in the format " +
                           "6'3/(191cm)")]
        public string? Height { get; set; }


        [Required(ErrorMessage = "Country is required.")]
        [Display(Name = "Country")]
        public int? CountryId { get; set; }


        [Required(ErrorMessage = "Birthplace is required.")]
        [StringLength(BirthplaceMaxLength, MinimumLength = BirthplaceMinLength,
            ErrorMessage = "Birthplace's length must be between " +
                                       "6 and 100 symbols.")]
        public string? Birthplace { get; set; }

        [Required(ErrorMessage = "Rank is required.")]
        [Range(1, 80)]
        public int? Rank { get; set; }

        public IEnumerable<SelectListItem> Countries { get; set; } = Enumerable.Empty<SelectListItem>();
    }
}
