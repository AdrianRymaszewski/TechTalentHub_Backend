using TechTalentHub.API.Models;
using TechTalentHub.API.Models.CurriculumVitae;

namespace TechTalentHub.API.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IRepo<JobOffer> JobOfferRepo { get; }
        IRepo<CurriculumVitae> CurriculumVitaeRepo { get; }
        Task SaveChangesAsync();
    }
}
