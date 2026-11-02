namespace CourtSide.Services.Core.Services
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using CourtSide.Data.Models;
    using CourtSide.Data.Persistance;
    using CourtSide.Services.Core.Contracts;
    using CourtSide.ViewModels.Tournaments;

    public class TournamentService : ITournamentService
    {
        private readonly CourtSideDbContext context;
        private readonly IMapper mapper;

        public TournamentService(CourtSideDbContext context,
            IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<int> CreateTournamentAsync(TournamentFormViewModel tournamentForm)
        {
            Tournament newTournament = this.mapper.Map<Tournament>(tournamentForm);

            await this.context.Tournaments.AddAsync(newTournament);
            await this.context.SaveChangesAsync();

            return newTournament.Id;
        }

        public async Task<bool> UpdateTournamentAsync(int id, TournamentFormViewModel tournamentForm)
        {
            var tournamentToUpdate = await this.context.Tournaments.FindAsync(id);

            if (tournamentToUpdate == null)
            {
                return false;
            }

            this.mapper.Map(tournamentForm, tournamentToUpdate);

            await this.context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteTournamentAsync(int id)
        {
            Tournament? tournamentToDelete = await this.context.Tournaments
                .FirstOrDefaultAsync(t => t.Id == id);

            if (tournamentToDelete == null)
            {
                return false;
            }

            if (tournamentToDelete.IsActive == true)
            {
                throw new ArgumentException("The tournament cannot be deleted because is active");
            }

            try
            {
                this.context.Tournaments.Remove(tournamentToDelete);
                await this.context.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateException ex)
            {
                throw new InvalidOperationException("This tournament cannot be deleted because it has associated venues or match records.", ex);
            }
        }

        public async Task<TournamentDetailsViewModel?> GetTournamentDetailsByIdAsync(int id)
        {
            return await this.context.Tournaments
                .AsNoTracking()
                .Where(t => t.Id == id)
                .ProjectTo<TournamentDetailsViewModel>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
        }

        public async Task<TournamentFormViewModel?> GetTournamentForEditByIdAsync(int id)
        {
            return await this.context.Tournaments
                .AsNoTracking()
                .Where(t => t.Id == id)
                .ProjectTo<TournamentFormViewModel>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<TournamentInfoViewModel>> GetAllTournamentsForIndexAsync()
        {
            return await this.context.Tournaments
                .AsNoTracking()
                .OrderByDescending(t => t.StartDate)
                .ProjectTo<TournamentInfoViewModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}