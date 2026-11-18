namespace CourtSide.ViewModels.Matches
{
    using CourtSide.Common.MatchEnumerations;
    using CourtSide.Common.TournamentEnumerations;

    public class MatchDetailsViewModel
    {
        public Guid Id { get; set; }

        public Guid FirstPlayerId { get; set; }

        public string FirstPlayerFullName { get; set; } = string.Empty;

        public Guid SecondPlayerId { get; set; }

        public string SecondPlayerFullName { get; set; } = string.Empty;

        public string Tour { get; set; } = string.Empty;

        public string Discipline { get; set; } = string.Empty;

        public DateTime DateTime { get; set; }

        public MatchStatus MatchStatus { get; set; }

        public MatchRound MatchRound { get; set; }

        public string MatchDuration { get; set; } = string.Empty;

        public CourtSurface CourtSurface { get; set; }

        public CourtEnvironment CourtEnvironment { get; set; }

        public string CourtName { get; set; } = string.Empty;

        public MatchFormat MatchFormat { get; set; }

        public TieBreakRule TieBreakRule { get; set; }

        public Guid VenueId { get; set; }

        public string VenueName { get; set; } = string.Empty;

        public Guid TournamentId { get; set; }

        public string TournamentName { get; set; } = string.Empty;

        public string? ScoreResult { get; set; }

        public Guid? WinnerId { get; set; }

        public string? WinnerFullName { get; set; }

        public bool IsCompleted => this.MatchStatus == MatchStatus.Completed;
    }
}
