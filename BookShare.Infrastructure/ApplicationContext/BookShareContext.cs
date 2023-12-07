using BookShare.Domain.Model;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShare.Infrastructure.ApplicationContext
{
    public class BookShareContext : IdentityDbContext<User>
    {
        public BookShareContext(DbContextOptions options) :base(options)
        {
        }
        public DbSet<Book> Books { get; set; }
        public DbSet<Delivery> Deliveries  { get; set; }
        public DbSet<Donation> Donations { get; set; }
        public DbSet<KYC> KYCs { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Request> Requests { get; set; }
        public DbSet<Transporter> Transporters { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}
