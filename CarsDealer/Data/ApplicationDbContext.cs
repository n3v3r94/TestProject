

namespace CarsssDealer.Data
{

    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using CarsssDealer.Models;
    using CarsssDealer.Models.CarsssModels;
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
       public DbSet<Suppliers> Suppliers { get; set; }
        public DbSet<Parts> Parts { get; set; }
        public DbSet<Carsss> Carsss { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Suppliers>()
                .HasMany(p => p.Parts)
                .WithOne(s => s.Suppliers)
                .HasForeignKey(fk=>fk.SupplierId);

            builder.Entity<Customers>()
                .HasMany(s => s.Sales)
                .WithOne(c => c.Customers)
                .HasForeignKey(fk => fk.CustomerId);
 
           builder.Entity<Carsss>()
                .HasMany(s => s.Sales)
                .WithOne(c => c.Carsss)
                .HasForeignKey(fk => fk.CarId);

            builder.Entity<PartCarsss>().HasKey(pc => new { pc.PartId, pc.CarId });

            builder.Entity<PartCarsss>().HasOne(c => c.Carsss).WithMany(p => p.Parts).HasForeignKey(fk => fk.PartId);

            builder.Entity<PartCarsss>().HasOne(p => p.Parts).WithMany(c => c.PartCarsss).HasForeignKey(fk => fk.CarId);

            base.OnModelCreating(builder);
          
        }
    }
}
