using System;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options) : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql("Host=localhost:5432;Database=Sport-Buddy;Username=postgres;Password=");
        }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            // 1 Activity = 2 Customers

            modelBuilder.Entity<Activity>()
                .HasOne(m => m.user1)
                .WithMany(t => t.Main_Activity)
                .HasForeignKey(m => m.user1_id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Activity>()
                .HasOne(m => m.user2)
                .WithMany(t => t.Buddy_Activity)
                .HasForeignKey(m => m.user2_id)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Activity>()
                .HasOne(m => m.Location)
                .WithMany(t => t.Activity)
                .HasForeignKey(m => m.location_id)
                .OnDelete(DeleteBehavior.Cascade);


            /*
            modelBuilder.Entity<Activity>(entity =>
            {
                entity.HasOne(d => d.user1)
                .WithMany(p => p.Activity)
                .HasForeignKey(d => d.user1_id)
                .HasConstraintName("fk_user1_activity");

                entity.HasOne(d => d.Location)
                .WithMany(p => p.Activity)
                .HasForeignKey(d => d.location_id)
                .HasConstraintName("fk_location_activity");

            });

            
            modelBuilder.Entity<Activity>(entity =>
            {
                entity.HasOne(d => d.user2)
                .WithMany(p => p.Activity)
                .HasForeignKey(d => d.user2_id)
                .HasConstraintName("fk_user2_activity");
            });
            */


            modelBuilder.Entity<Customer>()
            .Property(f => f.id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

            modelBuilder.Entity<Location>()
            .Property(f => f.location_id)
            .ValueGeneratedOnAdd();

            modelBuilder.Entity<Activity>()
            .Property(f => f.activity_id)
            .ValueGeneratedOnAdd();

            modelBuilder.Entity<Activity>()
                .Property(f => f.status)
                .HasDefaultValue("Pending");
        }
        

        public DbSet<Customer> customer{ get; set; }
        public DbSet<Admin> admin{ get; set; }
        public DbSet<Location> location { get; set; }
        public DbSet<Activity> activity { get; set; }

        
    }
}

