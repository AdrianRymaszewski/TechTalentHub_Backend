using Microsoft.EntityFrameworkCore;

namespace TechTalentHub.API.Data
{
    public class DataRepository<TEntity>: IRepo<TEntity> where TEntity : class
    {
        private readonly TechTalentHubDbContext _ctx;
        private readonly DbSet<TEntity> _dbSet;

        public DataRepository(TechTalentHubDbContext ctx)
        {
            _ctx = ctx;
            _dbSet = ctx.Set<TEntity>();
        }


        public async Task<IEnumerable<TEntity>> GetAsync()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id) ?? throw new Exception($"Entity with ID {id} not found.");
        }

        public async Task InsertAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Entry(entity).State = EntityState.Modified;
        }

        public async Task DeleteAsync(int id)
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null) _dbSet.Remove(entity);
            }

        public async Task SaveChangesAsync()
        {
            await _ctx.SaveChangesAsync();
        }
    }
}
