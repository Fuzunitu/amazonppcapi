using amazonppcapi.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace amazonppcapi.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {
        }
        public DbSet<AdvertisedProductReport> AdvertisedProductsReports { get; set; }
        public DbSet<BudgetReport> BudgetReport { get; set; }
        public DbSet<CampaignReport> CampaignReport { get; set; }
        public DbSet<GrossInvalidTrafficReport> GrossInvalidTrafficReport { get; set; }
        public DbSet<PerformanceOverTimeReport> PerformanceOverTimeReport { get; set; }
        public DbSet<PlacementReport> PlacementReport { get; set; }
        public DbSet<PurchasedProductReport> PurchasedProductReport { get; set; }
        public DbSet<SearchTermImpressionShareReport> SearchTermImpressionShareReport { get; set; }
        public DbSet<SearchTermReport> SearchTermsReport { get; set; }
        public DbSet<TargetingReport> TargetingReport { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdvertisedProductReport>()
                .Property(e => e.AprDate)
                .HasColumnType("timestamptz");

            // Call base method last.
            base.OnModelCreating(modelBuilder);
        }
    }
}
