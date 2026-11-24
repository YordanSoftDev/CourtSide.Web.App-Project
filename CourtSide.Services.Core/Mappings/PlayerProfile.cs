namespace CourtSide.Services.Core.Mappings
{
    using AutoMapper;
    using CourtSide.Data.Models;
    using CourtSide.ViewModels.Players;
    using Microsoft.AspNetCore.Mvc.Rendering;

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


            this.CreateMap<Player, PlayerSelectItemViewModel>()
                .ForMember(dest => dest.FullName,
               opt =>   opt
                .MapFrom(src => $"{src.FirstName} {src.LastName}"));


            this.CreateMap<PlayerSelectItemViewModel, SelectListItem>()
                .ForMember(dest => dest.Value, opt => opt.MapFrom(src => src.Id.ToString()))
                .ForMember(dest => dest.Text, opt => opt.MapFrom(src => src.FullName))
                .ForMember(dest => dest.Selected, opt => opt.Ignore())
                .ForMember(dest => dest.Disabled, opt => opt.Ignore())
                .ForMember(dest => dest.Group, opt => opt.Ignore());
        }
    }
}
