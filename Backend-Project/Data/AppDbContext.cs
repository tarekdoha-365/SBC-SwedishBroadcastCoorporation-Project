using Backend_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend_Project.Data 
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }
        public DbSet<Report> Reports { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Report>()
                .HasDiscriminator<string>("Report-Type")
                .HasValue<ReportBusiness>("Business")
                .HasValue<ReportClimate>("Climate")
                .HasValue<ReportEntertainmentAndArt>("EntertainmentAndArt")
                .HasValue<ReportHealth>("Health")
                .HasValue<ReportPolitics>("Politics")
                .HasValue<ReportScience>("Science")
                .HasValue<ReportStories>("Stories")
                .HasValue<ReportTechnology>("Technology");
        }
    }
}