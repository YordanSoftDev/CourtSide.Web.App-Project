using CourtSide.Common.MatchEnumerations;

namespace CourtSide.ViewModels.Tournaments
{
    public class TournamentSelectItemViewModel
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }
        public required Guid VenueId { get; set; }
        public CourtSurface CourtSurface { get; set; }
        public CourtEnvironment CourtEnvironment { get; set; }
    }
}
