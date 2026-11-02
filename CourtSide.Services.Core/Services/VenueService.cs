namespace CourtSide.Services.Core.Services
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using CourtSide.Data.Models;
    using CourtSide.Data.Persistance;
    using CourtSide.Services.Core.Contracts;
    using CourtSide.ViewModels.Players;
    using CourtSide.ViewModels.Venues;
    using Microsoft.EntityFrameworkCore;

    public class VenueService : IVenueService
    {
        private readonly CourtSideDbContext context;
        private readonly IMapper mapper;

        public VenueService(CourtSideDbContext context,
            IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<VenueSelectViewModel>> GetAllVenuesAsync()
        {
            return await this.context.Venues
                .AsNoTracking()
                .ProjectTo<VenueSelectViewModel>
                (this.mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
    
}
