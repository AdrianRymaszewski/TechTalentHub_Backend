using TechTalentHub.API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TechTalentHub.API.Data.Configurations;

namespace TechTalentHub.API.Data
{
    public class TechTalentHubDbContext : IdentityDbContext<TechTalentHubUser>
    {
        public TechTalentHubDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<JobOffer> JobOffer { get; set; } = null;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }
    }
}
