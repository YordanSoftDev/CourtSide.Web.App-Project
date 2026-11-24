namespace CourtSide.Data.Repository.Common
{
    using Microsoft.EntityFrameworkCore;

    using CourtSide.Common.Models;
    using CourtSide.Data.Persistance;
    using CourtSide.Data.Repository.Contracts.Common;
    public abstract class BaseSoftDeleteableRepository<TEntity>
        : BaseRepository<TEntity>, ISoftDeleteableRepository<TEntity>
        where TEntity : class, ISoftDeleteableEntity
    {
        protected BaseSoftDeleteableRepository(CourtSideDbContext dbContext)
            : base(dbContext)
        {

        }

        public IQueryable<TEntity> AllWithDeleted()
        {
            return this.DbSet.IgnoreQueryFilters()
                .AsQueryable();
        }

        public IQueryable<TEntity> AllWithDeletedAsNoTracking()
        {
            return this.DbSet.IgnoreQueryFilters()
                .AsNoTracking()
                .AsQueryable();
        }

        public void SoftDelete(TEntity entity)
        {
            entity.IsDeleted = true;
        }

        public void Recover(TEntity entity)
        {
            entity.IsDeleted = false;
        }
    }
}
