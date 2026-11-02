namespace CourtSide.Services.Core.Mappings
{
    using AutoMapper;
    using CourtSide.ViewModels.Players;
    using CourtSide.Data.Models;

    public class PlayerProfile : Profile
    {
        public PlayerProfile()
        {
            this.CreateMap<PlayerFormViewModel, Player>();
            this.CreateMap<Player, PlayerFormViewModel>();

            this.CreateMap<Player, PlayerDetailsViewModel>()
                .ForMember(dest => dest.FullName, opt => opt
                .MapFrom(src => $"{src.FirstName} {src.LastName}"))
                .ForMember(dest => dest.Country, opt => opt
                .MapFrom(src => src.Country.Name));

            this.CreateMap<Player, PlayerInfoViewModel>()
                .ForMember(dest => dest.FullName, opt => opt
                .MapFrom(src => $"{src.FirstName} {src.LastName}"))
                .ForMember(dest => dest.Country, 
   opt => opt
                .MapFrom(src => src.Country.Name));


            this.CreateMap<Player, PlayerSelectViewModel>()
                .ForMember(dest => dest.FullName,
               opt =>   opt
                .MapFrom(src => $"{src.FirstName} {src.LastName}"));
        }
    }
}
