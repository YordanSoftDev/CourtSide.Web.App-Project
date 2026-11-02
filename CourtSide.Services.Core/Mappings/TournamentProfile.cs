namespace CourtSide.Services.Core.Mappings
{
    using AutoMapper;
    using CourtSide.Data.Models;
    using CourtSide.ViewModels.Tournaments;

    public class TournamentProfile : Profile
    {
        public TournamentProfile()
        {
            this.CreateMap<TournamentFormViewModel, Tournament>();
            this.CreateMap<Tournament, TournamentFormViewModel>();

            this.CreateMap<Tournament, TournamentDetailsViewModel>()
                .ForMember(d => d.Location, opt => opt.MapFrom(src =>
                    src.TournamentVenues.Select(tv => tv.Venue.Name).FirstOrDefault())); ;

            this.CreateMap<Tournament, TournamentInfoViewModel>()
                .ForMember(d => d.Location, opt => opt.MapFrom(src =>
                    src.TournamentVenues.Select(tv => tv.Venue.Name).FirstOrDefault())); ;
        }
    }
}
