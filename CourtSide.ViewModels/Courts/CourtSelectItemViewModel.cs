namespace CourtSide.ViewModels.Courts
{
    public class CourtSelectItemViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public Guid VenueId { get; set; }
    }
}
