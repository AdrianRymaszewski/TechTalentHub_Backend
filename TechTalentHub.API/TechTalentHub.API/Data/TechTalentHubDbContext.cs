﻿using Microsoft.EntityFrameworkCore;
using TechTalentHub.API.Models;

namespace TechTalentHub.API.Data
{
    public class TechTalentHubDbContext : DbContext
    {
        public TechTalentHubDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<JobOffer> JobOffer { get; set; } = null;
    }
}
