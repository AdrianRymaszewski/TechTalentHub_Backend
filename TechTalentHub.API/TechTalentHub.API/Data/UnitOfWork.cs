using TechTalentHub.API.Models;
using TechTalentHub.API.Models.CurriculumVitae;

namespace TechTalentHub.API.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TechTalentHubDbContext _ctx;

        public UnitOfWork(TechTalentHubDbContext ctx, IRepo<JobOffer> jobOfferRepo,IRepo<CurriculumVitae> curriculumVitaeRepo)
        {
            _ctx = ctx;
            JobOfferRepo = jobOfferRepo;
            CurriculumVitaeRepo = curriculumVitaeRepo;
        }


        public IRepo<JobOffer> JobOfferRepo { get; }
        public IRepo<CurriculumVitae> CurriculumVitaeRepo { get; }

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
