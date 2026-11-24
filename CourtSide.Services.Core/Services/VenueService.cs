namespace CourtSide.Services.Core.Services
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Microsoft.EntityFrameworkCore;

    using CourtSide.Data.Repository.Contracts;
    using CourtSide.Services.Core.Contracts;
    using CourtSide.ViewModels.Venues;

    public class VenueService : IVenueService
    {
        private readonly IVenueRepository venueRepository;
        private readonly IMapper mapper;

        public VenueService(IVenueRepository venueRepository,
            IMapper mapper)
        {
            this.venueRepository = venueRepository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<VenueSelectViewModel>> GetAllVenuesAsync()
        {
            return await this.venueRepository
                .AllAsNoTracking()
                .ProjectTo<VenueSelectViewModel>
                (this.mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }  
}
