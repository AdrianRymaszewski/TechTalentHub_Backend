using Microsoft.EntityFrameworkCore;

namespace TechTalentHub.API.Data
{
    public class TechTalentHubDbContext : DbContext
    {
        public TechTalentHubDbContext(DbContextOptions options) : base(options)
        {
            
        }
    }
}
