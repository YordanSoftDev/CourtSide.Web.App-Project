namespace CourtSide.Services.Core.Contracts
{
    using CourtSide.ViewModels.Venues;

    public interface IVenueService
    {
        public Task<IEnumerable<VenueSelectViewModel>> GetAllVenuesAsync();
    }
}
