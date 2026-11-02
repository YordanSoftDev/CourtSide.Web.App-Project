namespace CourtSide.ViewModels.Players
{
    public class PlayerDetailsViewModel
    {
        public int Id { get; set; }

        public string FullName { get; set; } = string.Empty;

        public int Age { get; set; }

        public string Weight { get; set; } = string.Empty;

        public string Height { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;

        public string Birthplace { get; set; } = string.Empty;

        public required int Rank { get; set; }
    }
}
