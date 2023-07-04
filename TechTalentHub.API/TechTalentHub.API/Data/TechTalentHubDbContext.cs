using TechTalentHub.API.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TechTalentHub.API.Data.Configurations;
using System.Reflection.Emit;
using TechTalentHub.API.Models.CurriculumVitae;

namespace TechTalentHub.API.Data
{
    public class TechTalentHubDbContext : IdentityDbContext<TechTalentHubUser>
    {
        public TechTalentHubDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<JobOffer> JobOffer { get; set; } = null;
        public DbSet<CurriculumVitae> CurriculumVitae { get; set; }
        public DbSet<Education> Educations { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Network> Networks { get; set; }
        public DbSet<PersonalData> PersonalDates { get; set; }
        public DbSet<Skill> Skills { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
        }
    }
}
