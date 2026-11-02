namespace CourtSide.ViewModels.Tournaments
{
    using CourtSide.Common.MatchEnumerations;

    public class TournamentDetailsViewModel
    {
        public int Id { get; set; }

        public string TournamentName { get; set; } = string.Empty;

        public string Location { get; set; } = string.Empty;

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public string TournamentType { get; set; } = string.Empty;

        public CourtSurface CourtSurface { get; set; }

        public CourtEnvironment CourtEnvironment { get; set; }

        public bool IsActive { get; set; }
    }
}
