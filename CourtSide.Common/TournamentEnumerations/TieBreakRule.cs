namespace CourtSide.Common.TournamentEnumerations
{
    using System.ComponentModel.DataAnnotations;

    public enum TieBreakRule
    {
        [Display(Name = "7 points at 6–6, all sets")]
        StandardAllSets = 0,

        [Display(Name = "7 points at 6–6; 10 points at 6–6, final set")]
        GrandSlamFinalSet = 1,

        [Display(Name = "7 points at 6–6; 10-point tie-break for 3rd set")]
        DoublesMatchTieBreak = 2
    }
}
