namespace CourtSide.Services.Core.Mappings
{
    using AutoMapper;
    using CourtSide.Data.Models;
    using CourtSide.ViewModels.Courts;
    public class CourtProfile : Profile
    {
        public CourtProfile()
        {
            this.CreateMap<Court, CourtSelectViewModel>();
        }
    }
}
