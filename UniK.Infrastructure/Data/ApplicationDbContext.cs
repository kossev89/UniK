using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UniK.Infrastructure.Data.Models;
using UniK.Infrastructure.Data.Models.Bases;
using UniK.Infrastructure.Data.Models.Dosers;

namespace UniK.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<FeedingConveyor> FeedingConveyors { get; set; } = null!;
        public DbSet<CompleteSolution> CompleteSolutions { get; set; } = null!;
        public DbSet<Bag> Bags { get; set; } = null!;
        public DbSet<Feature> Features { get; set; } = null!;
        public DbSet<FeatureGroup> FeatureGroups { get; set; } = null!;
        public DbSet<AugerFiller> AugerFillers { get; set; } = null!;
        public DbSet<BeltMetalDetector> BeltMetalDetectors { get; set; } = null!;
        public DbSet<CheckWeigher> Checkweighers { get; set; } = null!;
        public DbSet<ExtraBag> ExtraBags { get; set; } = null!;



    }
}
