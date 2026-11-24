namespace CourtSide.Data.Repository.Common
{
    using Microsoft.EntityFrameworkCore;

    using CourtSide.Data.Persistance;
    using CourtSide.Data.Repository.Contracts.Common;
    public abstract class BaseRepository<TEntity> : IRepository<TEntity>, IDisposable
        where TEntity : class
    {
        protected BaseRepository(CourtSideDbContext dbContext)
        {
            this.DbContext = dbContext;
            this.DbSet = dbContext.Set<TEntity>();
        }

        protected CourtSideDbContext DbContext { get; }

        protected DbSet<TEntity> DbSet { get; }

        public IQueryable<TEntity> All()
        {
            return this.DbSet.AsQueryable();
        }

        public IQueryable<TEntity> AllAsNoTracking()
        {
            return this.DbSet
                .AsNoTracking()
                .AsQueryable();
        }

        public void Add(TEntity entity)
        {
            this.DbSet.Add(entity);
        }

        public async Task AddAsync(TEntity entity)
        {
            await this.DbSet.AddAsync(entity);
        }

        public void AddRange(IEnumerable<TEntity> entityCollection)
        {
            this.DbSet.AddRange(entityCollection);
        }

        public async Task AddRangeAsync(IEnumerable<TEntity> entityCollection)
        {
            await this.DbSet.AddRangeAsync(entityCollection);
        }

        public void Update(TEntity entity)
        {
            this.DbSet.Update(entity);
        }

        public void UpdateRange(IEnumerable<TEntity> entityCollection)
        {
            this.DbSet.UpdateRange(entityCollection);
        }

        public void Remove(TEntity entity)
        {
            this.DbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entityCollection)
        {
            this.DbSet.RemoveRange(entityCollection);
        }

        public int SaveChanges()
        {
            return this.DbContext.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await this.DbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            this.DbContext.Dispose();
        }
    }
}
