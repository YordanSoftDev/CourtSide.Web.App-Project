namespace CourtSide.Services.Core.Services
{
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using AutoMapper.QueryableExtensions;

    using CourtSide.ViewModels.Courts;
    using CourtSide.Services.Core.Contracts;
    using CourtSide.Data.Repository.Contracts;

    public class CourtService : ICourtService
    {
        private readonly ICourtRepository courtRepository;
        private readonly IMapper mapper;

        public CourtService(ICourtRepository courtRepository, 
            IMapper mapper)
        {
            this.mapper = mapper;
            this.courtRepository = courtRepository;
        }
        public async Task<IEnumerable<CourtSelectViewModel>> GetCourtsByVenueIdAsync(Guid venueId)
        {
            return await this.courtRepository
                .AllAsNoTracking()
                
                .Where(c => c.VenueId == venueId)
                .OrderBy(c => c.Name)
                .ProjectTo<CourtSelectViewModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
