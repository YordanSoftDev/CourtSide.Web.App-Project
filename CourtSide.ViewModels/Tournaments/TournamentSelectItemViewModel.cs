using CourtSide.Common.MatchEnumerations;

namespace CourtSide.ViewModels.Tournaments
{
    public class TournamentSelectItemViewModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required int VenueId { get; set; }
        public CourtSurface CourtSurface { get; set; }
        public CourtEnvironment CourtEnvironment { get; set; }
    }
}
