using Microsoft.EntityFrameworkCore;
using SwgohParticipation.Models;

namespace SwgohParticipation.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<RaidParticipation> RaidParticipations { get; set; }
        public DbSet<PlayerOverview> PlayerOverviews { get; set; }
        public DbSet<RoteParticipation> RoteParticipations { get; set; }
        public DbSet<TwParticipation> TwParticipations { get; set; }
        public DbSet<TicketParticipation> TicketParticipations { get; set; }
        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<RaidParticipation>()
                .HasKey(raid => new { raid.StartDate, raid.Name }); // Composite PK

            modelBuilder.Entity<RaidParticipation>()
                .Property(raid => raid.Raid)
                .HasColumnName("raid")
                .HasMaxLength(32)
                .HasDefaultValue("order66");

            // Keeping composite keys consistent with the rest of the entities
            modelBuilder.Entity<PlayerOverview>()
                .HasKey(po => new { po.ReportDate, po.Name }); // Composite PK

            modelBuilder.Entity<RoteParticipation>()
                .HasKey(rp => new { rp.StartDate, rp.Name }); // Composite PK

            modelBuilder.Entity<TwParticipation>()
                .HasKey(twp => new { twp.StartDate, twp.Name }); // Composite PK

            modelBuilder.Entity<TicketParticipation>()
                .HasKey(tp => new { tp.WeekEndDate, tp.Name }); // Composite PK
        }
    }
}