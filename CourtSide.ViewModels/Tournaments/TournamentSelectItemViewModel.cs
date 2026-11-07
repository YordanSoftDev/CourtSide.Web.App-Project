namespace CourtSide.ViewModels.Tournaments
{
    public class TournamentSelectItemViewModel
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required int VenueId { get; set; }
    }
}
