namespace CourtSide.ViewModels.Tournaments
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.ComponentModel.DataAnnotations;
    using CourtSide.Common.MatchEnumerations;
    using static CourtSide.Common.ValidationConstants.Tournament;

    public class TournamentFormViewModel
    {
        [Required(ErrorMessage = "Please select or enter a " +
                                 "tournament name.")]
        [StringLength(TournamentNameMaxLength, MinimumLength = TournamentNameMinLength,
            ErrorMessage = "Tournament name must be between 2 and " + "100 characters.")]
        [Display(Name = "Tournament Name")]
        public string? TournamentName { get; set; }

        public IEnumerable<SelectListItem> TournamentNames { get; set; }
                        = new List<SelectListItem>();

        [Required(ErrorMessage = "Location is required.")]
        [StringLength(LocationMaxLength, MinimumLength = LocationMinLength,
            ErrorMessage = "Location must be between 6 " +
                           "and 100 characters.")]
        public string? Location { get; set; }

        [Required(ErrorMessage = "Start date is required.")]
        [DataType(DataType.Date)]
        [Display(Name = "Start Date")]
        public DateTime? StartDate { get; set; }

        [Required(ErrorMessage = "End date is required.")]
        [DataType(DataType.Date)]
        [Display(Name = "End Date")]
        public DateTime? EndDate { get; set; }

        [Required(ErrorMessage = "Tournament type is required.")]
        [StringLength(TournamentTypeMaxLength, MinimumLength = TournamentTypeMinLength,
            ErrorMessage = "Tournament type must be between 3 and " + "50 characters.")]

        [Display(Name = "Tournament Type")]
        public string? TournamentType { get; set; }

        public IEnumerable<SelectListItem> TournamentTypes { get; set; }
                        = new List<SelectListItem>();

        [Required(ErrorMessage = "Please select a court surface.")]
        [Display(Name = "Court Surface")]
        public CourtSurface? CourtSurface { get; set; }

        [Required(ErrorMessage = "Please select a court environment.")]
        [Display(Name = "Court Environment")]
        public CourtEnvironment? CourtEnvironment { get; set; }
    }
}
