using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // DataSeed: Agregamos unos datos iniciales

            modelBuilder.Entity<User>().HasData(
                                        new User { Id = 1, Name = "Gabriel", LastName = "Furrer", Password = "1234", Email = "hola@gmail.com", UserName = "gfurrer", UserType = "professor" },
                                        new User { Id = 2, Name = "Carlos", LastName = "Perez", Password = "1234", Email = "hola@gmail.com", UserName = "cperez", UserType = "student" },
                                         new User { Id = 3, Name = "Pedro", LastName = "Rodriguez", Password = "1234", Email = "hola@gmail.com", UserName = "prodriguez", UserType = "professor" }

                );

        }
    }
}
