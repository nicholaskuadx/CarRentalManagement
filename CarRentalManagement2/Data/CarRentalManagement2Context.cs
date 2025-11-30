using CarRentalManagement2.Configurations.Entities;
using CarRentalManagement2.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CarRentalManagement2.Data
{
    public class CarRentalManagement2Context(DbContextOptions<CarRentalManagement2Context> options) : IdentityDbContext<CarRentalManagement2User>(options)
    {
        public DbSet<CarRentalManagement2.Domain.Make> Make { get; set; } = default!;
        public DbSet<CarRentalManagement2.Domain.Model> Model { get; set; } = default!;
        public DbSet<CarRentalManagement2.Domain.Colour> Colour { get; set; } = default!;
        public DbSet<CarRentalManagement2.Domain.Vehicle> Vehicle { get; set; } = default!;
        public DbSet<CarRentalManagement2.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<CarRentalManagement2.Domain.Customer> Customer { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ColourSeed());
            builder.ApplyConfiguration(new MakeSeed());
            builder.ApplyConfiguration(new ModelSeed());

        }
    }
}