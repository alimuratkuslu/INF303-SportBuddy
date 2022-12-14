using System;
using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concrete
{
    public class Context : DbContext
    {

        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseNpgsql("Host=localhost:5432;Database=Sport-Buddy;Username=postgres;Password=");
        }

        public DbSet<Customer> customer{ get; set; }
        public DbSet<Admin> admin{ get; set; }
        public DbSet<Location> location { get; set; }
        public DbSet<Activity> activity { get; set; }
    }
}

