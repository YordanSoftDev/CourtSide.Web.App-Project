namespace CourtSide.Services.Core.Mappings
{
    using AutoMapper;

    using CourtSide.Data.Models;
    using CourtSide.ViewModels.Matches;

    public class MatchProfile : Profile
    {
        public MatchProfile()
        {
            this.CreateMap<MatchFormViewModel, Match>()
                .ForMember(dest => dest.Id, opt => opt.Ignore())
                .ForMember(dest => dest.Tournament, opt => opt.Ignore())
                .ForMember(dest => dest.Venue, opt => opt.Ignore())
                .ForMember(dest => dest.FirstPlayer, opt => opt.Ignore())
                .ForMember(dest => dest.SecondPlayer, opt => opt.Ignore())
                .ForMember(dest => dest.Winner, opt => opt.Ignore());

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
                .ForMember(dest => dest.VenueName, opt => opt.MapFrom(src =>
                    src.Tournament.TournamentVenues.Select(tv => tv.Venue.Name).FirstOrDefault()
                    ?? src.Venue.Name))
                .ForMember(dest => dest.TournamentType,
                opt => opt
                .MapFrom(src => src.Tournament.TournamentType))
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