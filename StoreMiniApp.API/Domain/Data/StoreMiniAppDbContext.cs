using Microsoft.EntityFrameworkCore;
using StoreMiniApp.API.Domain.Data.SeedTestData;
using StoreMiniApp.API.Domain.Entities.Model;

namespace StoreMiniApp.API.Domain.Data
{
    public class StoreMiniAppDbContext : DbContext
    {
        //public StoreMiniAppDbContext(DbContextOptions<StoreMiniAppDbContext> options) : base(options) { }
        protected readonly IConfiguration Configuration;

        public StoreMiniAppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("Default"));
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //foreach (var property in modelBuilder.Model.GetEntityTypes()
            //     .SelectMany(t => t.GetProperties())
            //     .Where(p => p.ClrType == typeof(decimal) || p.ClrType == typeof(decimal?)))
            //{
            //    property.SetColumnType("decimal(19, 2)");
            //}

            //modelBuilder.Entity<Discount>().ToTable("Discount");
            //modelBuilder.Entity<Invoice>().ToTable("Invoice");
            //modelBuilder.Entity<User>().ToTable("User");

            modelBuilder.ApplyConfiguration(new UserData());
            modelBuilder.ApplyConfiguration(new DiscountData());
            modelBuilder.ApplyConfiguration(new InvoiceData());
            modelBuilder.ApplyConfiguration(new InvoiceDetailsData());
        }

        public virtual DbSet<Discounts> Discounts { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<InvoiceDetails> InvoiceDetails { get; set; }
    }
}
