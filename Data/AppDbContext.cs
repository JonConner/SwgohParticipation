using Microsoft.EntityFrameworkCore;
using SwgohParticipation.Models;

namespace SwgohParticipation.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Order66Participation> Order66Participations { get; set; }
        public DbSet<RoteParticipation> RoteParticipations { get; set; }
        public DbSet<TwParticipation> TwParticipations { get; set; }
        public DbSet<TicketParticipation> TicketParticipations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order66Participation>()
                .HasKey(o66p => new { o66p.StartDate, o66p.Name }); // Composite PK

            modelBuilder.Entity<RoteParticipation>()
                .HasKey(rp => new { rp.StartDate, rp.Name }); // Composite PK

            modelBuilder.Entity<TwParticipation>()
                .HasKey(twp => new { twp.StartDate, twp.Name }); // Composite PK

            modelBuilder.Entity<TicketParticipation>()
                .HasKey(tp => new { tp.WeekEndDate, tp.Name }); // Composite PK
        }
    }
}