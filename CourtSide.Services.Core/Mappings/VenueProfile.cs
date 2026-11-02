namespace CourtSide.Services.Core.Mappings
{
    using AutoMapper;
    using CourtSide.ViewModels.Venues;
    using CourtSide.Data.Models;
    public class VenueProfile : Profile
    {
        public VenueProfile()
        {
            this.CreateMap<Venue, VenueSelectViewModel>();
        }
    }
}
