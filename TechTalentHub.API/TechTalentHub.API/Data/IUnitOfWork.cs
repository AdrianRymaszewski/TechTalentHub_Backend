using TechTalentHub.API.Models;

namespace TechTalentHub.API.Data
{
    public interface IUnitOfWork : IDisposable
    {
        IRepo<JobOffer> JobOfferRepo { get; }
        Task SaveChangesAsync();
    }
}
