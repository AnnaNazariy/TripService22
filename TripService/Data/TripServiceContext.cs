namespace TripService.Data
{
    using Microsoft.EntityFrameworkCore;
    using TripService.Models;

    public class TripServiceContext : DbContext
    {
        public TripServiceContext(DbContextOptions<TripServiceContext> options)
            : base(options)
        {
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AccountsTrips> AccountsTrips { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountsTrips>()
                .HasKey(at => new { at.AccountId, at.TripId });

            modelBuilder.Entity<AccountsTrips>()
                .HasOne(at => at.Account)
                .WithMany(a => a.AccountsTrips)
                .HasForeignKey(at => at.AccountId);

            modelBuilder.Entity<AccountsTrips>()
                .HasOne(at => at.Trip)
                .WithMany(t => t.AccountsTrips)
                .HasForeignKey(at => at.TripId);
        }
    }

}
