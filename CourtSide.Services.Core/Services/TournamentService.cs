namespace CourtSide.Services.Core.Services
{
    using AutoMapper;
    using Microsoft.EntityFrameworkCore;
    using AutoMapper.QueryableExtensions;
    using System.Linq;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    using CourtSide.Data.Models;
    using CourtSide.Data.Repository.Contracts;
    using CourtSide.Services.Core.Contracts;
    using CourtSide.ViewModels.Tournaments;

    public class TournamentService : ITournamentService
    {
        private readonly ITournamentRepository tournamentRepository;
        private readonly IMapper mapper;

        public TournamentService(ITournamentRepository tournamentRepository,
            IMapper mapper)
        {
            this.tournamentRepository = tournamentRepository;
            this.mapper = mapper;
        }

        public async Task<Guid> CreateTournamentAsync(TournamentFormViewModel tournamentForm)
        {
            Tournament newTournament = this.mapper.Map<Tournament>(tournamentForm);

            await this.tournamentRepository.AddAsync(newTournament);
            await this.tournamentRepository.SaveChangesAsync();

            return newTournament.Id;
        }

        public async Task<bool> UpdateTournamentAsync(Guid id, TournamentFormViewModel tournamentForm)
        {
            var tournamentToUpdate = await this.tournamentRepository.All().FirstOrDefaultAsync(m => m.Id == id);

            if (tournamentToUpdate == null)
            {
                return false;
            }

            this.mapper.Map(tournamentForm, tournamentToUpdate);

            await this.tournamentRepository.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteTournamentAsync(Guid id)
        {
            Tournament? tournamentToDelete = await this.tournamentRepository.All()
                .Where(m => m.Id == id)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (tournamentToDelete == null)
            {
                throw new ArgumentException("The tournament does not exist");
            }

            if (tournamentToDelete.IsActive == true)
            {
                throw new ArgumentException("The tournament cannot be deleted because is active");
            }

            try
            {
                this.tournamentRepository.Remove(tournamentToDelete);
                await this.tournamentRepository.SaveChangesAsync();
                return true;
            }
            catch (DbUpdateException ex)
            {
                throw new InvalidOperationException("This tournament cannot be deleted because it has associated venues or match records.", ex);
            }
        }

        public async Task<TournamentDetailsViewModel?> GetTournamentDetailsByIdAsync(Guid id)
        {
            return await this.tournamentRepository
                .AllAsNoTracking()
                .Where(t => t.Id == id)
                .ProjectTo<TournamentDetailsViewModel>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
        }

        public async Task<TournamentFormViewModel?> GetTournamentForEditByIdAsync(Guid id)
        {
            return await this.tournamentRepository
                .AllAsNoTracking()
                .Where(t => t.Id == id)
                .ProjectTo<TournamentFormViewModel>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<TournamentInfoViewModel>> GetAllTournamentsForIndexAsync()
        {
            return await this.tournamentRepository
                .AllAsNoTracking()
                .OrderByDescending(t => t.StartDate)
                .ProjectTo<TournamentInfoViewModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<IEnumerable<TournamentSelectItemViewModel>> GetTournamentsByTourWithVenueAsync(string tour)
        {
            return await this.tournamentRepository
             .AllAsNoTracking()
             .Where(t => tour == "ATP"
             ? (t.TournamentType.StartsWith("ATP") ||
               t.TournamentType.EndsWith(" Men"))
             : (t.TournamentType.StartsWith("WTA") ||
               t.TournamentType.Contains("Women")))
                .Select(t => new TournamentSelectItemViewModel
                {
                    Id = t.Id,
                    Name = t.TournamentName,
                    VenueId = t.TournamentVenues.Select(tv => tv.VenueId).FirstOrDefault(),
                    CourtSurface = t.CourtSurface,
                    CourtEnvironment = t.CourtEnvironment
                })
                .OrderBy(t => t.Name)
                .ToListAsync();
        }
    }
}