namespace CourtSide.Services.Core.Mappings
{
    using AutoMapper;
    using CourtSide.Common.MatchEnumerations;
    using CourtSide.Data.Models;
    using CourtSide.ViewModels.Matches;
    using CourtSide.ViewModels.Players;

    public class MatchProfile : Profile
    {
        public MatchProfile()
        {
            this.CreateMap<MatchFormViewModel, Match>()
                .ForMember(dest => dest.Id, opt => opt.Ignore());
            this.CreateMap<Match, MatchFormViewModel>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id));


            this.CreateMap<Match, MatchDetailsViewModel>()  
                .ForMember(dest => dest.VenueName,
                opt => opt
                .MapFrom(src => src.Venue.Name))
                .ForMember(dest => dest.TournamentName,
                opt => opt
                .MapFrom(src => src.Tournament.TournamentName))
                .ForMember(dest => dest.FirstPlayerFullName,
                opt => opt
                .MapFrom(src => $"{src.FirstPlayer.FirstName} " +
                $"{src.FirstPlayer.LastName}"))
                .ForMember(dest => dest.SecondPlayerFullName,
                opt => opt
                .MapFrom(src => $"{src.SecondPlayer.FirstName} " +
                $"{src.SecondPlayer.LastName}"))
                .ForMember(dest => dest.WinnerFullName,
                opt => opt
                .MapFrom(src => src.Winner != null ? $"{src.Winner.FirstName} " +
                $"{src.Winner.LastName}" : null));


            this.CreateMap<Match, MatchInfoViewModel>()       
                .ForMember(dest => dest.VenueName,
                opt => opt
                .MapFrom(src => src.Venue.Name))
                .ForMember(dest => dest.TournamentType,
                opt => opt
                .MapFrom(src => src.Tournament.TournamentType
                .StartsWith("WTA") || src.FirstPlayer.Gender == Gender.Female ? "WTA"
                : "ATP"))

                .ForMember(dest => dest.FirstPlayerFullName,
                opt => opt
                .MapFrom(src => $"{src.FirstPlayer.FirstName} " +
                $"{src.FirstPlayer.LastName}"))
                .ForMember(dest => dest.SecondPlayerFullName,
                opt => opt
                .MapFrom(src => $"{src.SecondPlayer.FirstName} " +
                $"{src.SecondPlayer.LastName}"))
                .ForMember(dest => dest.WinnerFullName,
                opt => opt
                .MapFrom(src => src.Winner != null ? $"{src.Winner.FirstName} " +
                $"{src.Winner.LastName}" : null));
        }
    }
}
