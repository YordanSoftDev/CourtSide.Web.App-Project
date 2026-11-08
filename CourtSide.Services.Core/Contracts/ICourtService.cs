namespace CourtSide.Services.Core.Contracts
{
    using CourtSide.ViewModels.Courts;
    public interface ICourtService
    {
        Task<IEnumerable<CourtSelectViewModel>> GetCourtsByVenueIdAsync(int venueId);
    }
}
