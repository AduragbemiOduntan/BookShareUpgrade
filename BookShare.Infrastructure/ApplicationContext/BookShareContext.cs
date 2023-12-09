using BookShare.Domain.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BookShare.Infrastructure.ApplicationContext
{
    public class BookShareContext : IdentityDbContext<User>
    {
        public BookShareContext(DbContextOptions options) :base(options)
        {
        }
        public DbSet<User> Users { get; set; }
        public DbSet<BookForSale> BooksForSale { get; set; }
        public DbSet<Delivery> Deliveries  { get; set; }
        public DbSet<KYC> KYCs { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Transporter> Transporters { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            builder.Entity<Delivery>().HasOne(d => d.BookForSale)
                .WithOne().OnDelete(DeleteBehavior.Restrict);
            builder.Entity<Delivery>().HasOne(d => d.Request)
                .WithOne().OnDelete(DeleteBehavior.Restrict);
            builder.Entity<Delivery>().HasOne(d => d.Transporter)
                .WithOne().OnDelete(DeleteBehavior.Restrict);
            builder.Entity<Delivery>().HasOne(d => d.Location)
                .WithOne().OnDelete(DeleteBehavior.Restrict);
            builder.Entity<Delivery>().HasOne(d => d.User)
                .WithOne().OnDelete(DeleteBehavior.Restrict);
        }
        protected virtual void ConfigureConventions(ModelConfigurationBuilder modelConfigurationBuilder)
        {
            modelConfigurationBuilder.Properties<string>().HaveMaxLength(200);
            modelConfigurationBuilder.Properties<DateTime>().HaveColumnType("date");
            modelConfigurationBuilder.Properties<decimal>().HaveColumnType("money");
        }
    }
}
