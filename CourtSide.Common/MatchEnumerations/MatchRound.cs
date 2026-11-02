namespace CourtSide.Common.MatchEnumerations
{
    using System.ComponentModel.DataAnnotations;

    public enum MatchRound
    {
        [Display(Name = "First Round")]
        FirstRound = 0,

        [Display(Name = "Second Round")]
        SecondRound = 1,

        [Display(Name = "Third Round")]
        ThirdRound = 2,

        [Display(Name = "Fourth Round")]
        FourthRound = 3,

        Quarterfinal = 4,

        Semifinal = 5,

        Final = 6
    }
}
