namespace CourtSide.Common.TournamentEnumerations
{
    using System.ComponentModel.DataAnnotations;

    public enum MatchFormat
    {
        [Display(Name = "Best of 3 sets")]
        BestOfThree = 0,

        [Display(Name = "Best of 5 sets")]
        BestOfFive = 1,

        [Display(Name = "Best of 3 sets (10-pt match tie-break)")]
        BestOfThreeMatchTieBreak = 2
    }
}
