namespace CourtSide.Services.Core.Services
{
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;

    using CourtSide.Data.Persistance;
    using CourtSide.ViewModels.Courts;
    using CourtSide.Services.Core.Contracts;

    public class CourtService : ICourtService
    {
        private readonly CourtSideDbContext context;
        private readonly IMapper mapper;

        public CourtService(CourtSideDbContext context,
            IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public async Task<IEnumerable<CourtSelectViewModel>> GetCourtsByVenueIdAsync(int venueId)
        {
            return await this.context.Courts
                .AsNoTracking()
                .Where(c => c.VenueId == venueId)
                .Select(c => new CourtSelectViewModel
                {
                    Id = c.Id,
                    Name = c.Name
                })
                .OrderBy(c => c.Name)
                .ToListAsync();
        }
    }
}
