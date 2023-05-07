using Microsoft.EntityFrameworkCore;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Locker> Lockers { get; set; }
        public DbSet<Parcel> Parcels { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public DbSet<Worker> Workers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Parcel>()
            .HasOne(x => x.Sender)
            .WithMany(x => x.SentShipments)
            .HasForeignKey(x => x.SenderId)
            .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Parcel>()
            .HasOne(x => x.Receiver)
            .WithMany(x => x.ReceivedShipments)
            .HasForeignKey(x => x.ReceiverId)
            .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Parcel>()
            .HasOne(x => x.FromLocker)
            .WithMany(x => x.FromLockerDelivery)
            .HasForeignKey(x => x.FromLockerId)
            .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Parcel>()
            .HasOne(x => x.ToLocker)
            .WithMany(x => x.ToLockerDelivery)
            .HasForeignKey(x => x.ToLockerId)
            .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Parcel>()
            .HasOne(x => x.Payment)
            .WithOne(x => x.Parcel)
            .HasForeignKey<Payment>(x => x.ParcelId);
        }
    }
}
