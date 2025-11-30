using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement2.Domain;
using CarRentalManagement2.Configurations.Entities;

namespace CarRentalManagement2.Data
{
    public class CarRentalManagement2Context : DbContext
    {
        public CarRentalManagement2Context (DbContextOptions<CarRentalManagement2Context> options)
            : base(options)
        {
        }

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
