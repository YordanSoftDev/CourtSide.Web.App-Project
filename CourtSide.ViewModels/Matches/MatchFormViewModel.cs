namespace CourtSide.ViewModels.Matches
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using System.ComponentModel.DataAnnotations;

    using CourtSide.Common.MatchEnumerations;
    using CourtSide.ViewModels.Tournaments;
    using static CourtSide.Common.ValidationConstants.Match;

    public class MatchFormViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Please select a First Player.")]
        [Display(Name = "First Player")]
        public Guid? FirstPlayerId { get; set; }

        [Required(ErrorMessage = "Please select a Second Player.")]
        [Display(Name = "Second Player")]
        public Guid? SecondPlayerId { get; set; }
        //When the user selects First Player from the dropdown menu, 
        //the player's name is removed automatically so that the Second Player
        //list does not already contain the name. The same applies
        //in the opposite direction (Second Player => First Player)
        public IEnumerable<SelectListItem> Players { get; set; } =
                    new List<SelectListItem>();

        [Required(ErrorMessage = "Please select a tour.")]
        public string Tour { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please select a Date and Time.")]
        [Display(Name = "Date Time")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-ddTHH:mm}", ApplyFormatInEditMode = true)]
        public DateTime? DateTime { get; set; }

        [Required(ErrorMessage = "Please select a Match Status.")]
        [EnumDataType(typeof(MatchStatus),
            ErrorMessage = "Please select a valid option.")]
        [Display(Name = "Match Status")]
        public MatchStatus? MatchStatus { get; set; }

        [Required(ErrorMessage = "Please select a Match Round.")]
        [EnumDataType(typeof(MatchRound),
            ErrorMessage = "Please select a valid option.")]
        [Display(Name = "Match Round")]
        public MatchRound? MatchRound { get; set; }

        //[Required(ErrorMessage = "Please enter a Match Duration.")]
        //[RegularExpression(@"^(?:(\d{1,2})h\s*)?(?:(\d{1,2})m)?$",
        // ErrorMessage = "Duration must be in the format '1h 45m', '2h 00m', or '31m'.")]
        //[Display(Name = "Match Duration")]
        //public string? MatchDuration { get; set; }


        // the field is set automatically in the form when the tournament is chosen
        [Required(ErrorMessage = "Please select a Court Name.")]
        [Display(Name = "Court Name")]
        public Guid CourtId { get; set; }

        [Required(ErrorMessage = "Please select a Venue.")]
        [Display(Name = "Venue")]
        public Guid? VenueId { get; set; }
        public IEnumerable<SelectListItem> Venues { get; set; } =
            new List<SelectListItem>();

        [Required(ErrorMessage = "Please select a Tournament.")]
        [Display(Name = "Tournament")]
        public Guid? TournamentId { get; set; }

        public IEnumerable<TournamentSelectItemViewModel> Tournaments { get; set; } =
            new List<TournamentSelectItemViewModel>();

        // the field is set automatically in the form when the tournament is chosen
        public CourtSurface CourtSurface { get; set; }

        // the field is set automatically in the form when the tournament is chosen
        public CourtEnvironment CourtEnvironment { get; set; }

        [Display(Name = "Score Result")]
        [MaxLength(ScoreResultMaxLength, ErrorMessage = "Score Result cannot exceed 100 characters.")]
        public string? ScoreResult { get; set; }

        //The user can select an option from the dropdown menu 
        //only if Match Status is Completed
        [Display(Name = "Winner")]
        public Guid? WinnerId { get; set; }
        public IEnumerable<SelectListItem> Winners { get; set; } =
            new List<SelectListItem>();
    }
}
