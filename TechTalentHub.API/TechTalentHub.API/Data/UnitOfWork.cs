using TechTalentHub.API.Models;

namespace TechTalentHub.API.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TechTalentHubDbContext _ctx;

        public UnitOfWork(TechTalentHubDbContext ctx, IRepo<JobOffer> jobOfferRepo)
        {
            _ctx = ctx;
            JobOfferRepo = jobOfferRepo;
        }


        public IRepo<JobOffer> JobOfferRepo { get; }

        public async Task SaveChangesAsync()
        {
            await _ctx.SaveChangesAsync();
        }

        public virtual void Dispose(bool disposing)
        {
            if (disposing) _ctx.Dispose();
        }

        public void Dispose()
        {
            Dispose(false);
            GC.SuppressFinalize(this);
        }
    }
}
