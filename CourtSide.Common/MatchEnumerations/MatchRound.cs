namespace CourtSide.Common.MatchEnumerations
{
    using System.ComponentModel.DataAnnotations;

    public enum MatchRound
    {
        [Display(Name = "First-Round")]
        FirstRound = 0,

        [Display(Name = "Second-Round")]
        SecondRound = 1,

        [Display(Name = "Third-Round")]
        ThirdRound = 2,

        [Display(Name = "Fourth-Round")]
        FourthRound = 3,

        [Display(Name = "Quarter-final")]
        Quarterfinal = 4,

        [Display(Name = "Semi-final")]
        Semifinal = 5,

        [Display(Name = "Final")]
        Final = 6
    }
}
