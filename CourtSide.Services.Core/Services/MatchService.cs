namespace CourtSide.Services.Core.Services
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using CourtSide.Data.Models;
    using CourtSide.Data.Persistance;
    using CourtSide.Services.Core.Contracts;
    using CourtSide.ViewModels.Matches;
    using Microsoft.EntityFrameworkCore;

    public class MatchService : IMatchService
    {
        private readonly CourtSideDbContext context;
        private readonly IMapper mapper;

        public MatchService(CourtSideDbContext context,
        IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<int> CreateMatchAsync(MatchFormViewModel matchForm)
        {
            Match newMatch = this.mapper.Map<Match>(matchForm);

            this.context.Matches.Add(newMatch);
            await this.context.SaveChangesAsync();

            return newMatch.Id;
        }

        public async Task<bool> UpdateMatchAsync(int id, MatchFormViewModel matchForm)
        {
            Match? matchToUpdate = await this.context.Matches.FindAsync(id);

            if (matchToUpdate == null)
            {
                return false;
            }

            this.mapper.Map(matchForm, matchToUpdate);

            var entry = this.context.Entry(matchToUpdate);

            await this.context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteMatchAsync(int id)
        {
            int rowsAffected = await this.context.Matches
                .Where(m => m.Id == id)
                .ExecuteDeleteAsync();

            return rowsAffected > 0;
        }

        public async Task<MatchDetailsViewModel?> GetMatchDetailsByIdAsync(int id)
        {
            return await this.context.Matches
                .AsNoTracking()
                .Where(m => m.Id == id)
                .ProjectTo<MatchDetailsViewModel>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
        }
        public async Task<MatchFormViewModel?> GetMatchForEditByIdAsync(int id)
        {
            return await this.context.Matches
                .AsNoTracking()
                .Where(m => m.Id == id)
                .ProjectTo<MatchFormViewModel>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<MatchInfoViewModel>> GetAllMatchesForIndexAsync()
        {
            return await this.context.Matches
                .AsNoTracking()
               .OrderByDescending(m => m.DateTime)
               .ThenByDescending(m => m.Id)
               .ProjectTo<MatchInfoViewModel>(this.mapper.ConfigurationProvider)
               .ToListAsync();
        }     
    }
}
