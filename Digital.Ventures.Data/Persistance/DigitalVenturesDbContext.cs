using Digital.Ventures.Data.Core.Domain;
using Digital.Ventures.Data.Persistance.EntityConfiguration;
using Microsoft.EntityFrameworkCore;
using System;

namespace Digital.Ventures.Data.Persistance
{
    public class DigitalVenturesDbContext : DbContext
    {
        public DbSet<Player> Players { get; set; }

        public DigitalVenturesDbContext(DbContextOptions<DigitalVenturesDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //custom configs here
            modelBuilder.ApplyConfiguration(new PlayerConfiguration());

            modelBuilder.Entity<Player>().HasData(
                new Player
                {
                    Id = Guid.NewGuid(),
                    Name = "Harry Kane",
                    Country = "England",
                    BirthDate = new DateTime()
                }
            );

            modelBuilder.Entity<Player>().HasData(
                new Player
                {
                    Id = Guid.NewGuid(),
                    Name = "Mohamed Salah",
                    Country = "Egypt",
                    BirthDate = new DateTime()
                }
            );

            modelBuilder.Entity<Player>().HasData(
                new Player
                {
                    Id = Guid.NewGuid(),
                    Name = "Sadio Mane",
                    Country = "Senegal",
                    BirthDate = new DateTime()
                }
            );

            modelBuilder.Entity<Player>().HasData(
                new Player
                {
                    Id = Guid.NewGuid(),
                    Name = "Son Heung-Min",
                    Country = "South Korea",
                    BirthDate = new DateTime()
                }
            );

            modelBuilder.Entity<Player>().HasData(
                new Player
                {
                    Id = Guid.NewGuid(),
                    Name = "Trent Alexander-Arnold",
                    Country = "England",
                    BirthDate = new DateTime()
                }
            );

            modelBuilder.Entity<Player>().HasData(
                new Player
                {
                    Id = Guid.NewGuid(),
                    Name = "Harry Maguire",
                    Country = "England",
                    BirthDate = new DateTime()
                }
            );

            modelBuilder.Entity<Player>().HasData(
                new Player
                {
                    Id = Guid.NewGuid(),
                    Name = "Ben Chilwell",
                    Country = "England",
                    BirthDate = new DateTime()
                }
            );

            modelBuilder.Entity<Player>().HasData(
                new Player
                {
                    Id = Guid.NewGuid(),
                    Name = "Ross Barkley",
                    Country = "England",
                    BirthDate = new DateTime()
                }
            );

            modelBuilder.Entity<Player>().HasData(
                new Player
                {
                    Id = Guid.NewGuid(),
                    Name = "Jack Grealish",
                    Country = "England",
                    BirthDate = new DateTime()
                }
            );

            modelBuilder.Entity<Player>().HasData(
                new Player
                {
                    Id = Guid.NewGuid(),
                    Name = "Tyrone Mings",
                    Country = "England",
                    BirthDate = new DateTime()
                }
            );

            modelBuilder.Entity<Player>().HasData(
                new Player
                {
                    Id = Guid.NewGuid(),
                    Name = "Jack Tarkowski",
                    Country = "England",
                    BirthDate = new DateTime()
                }
            );

            modelBuilder.Entity<Player>().HasData(
                new Player
                {
                    Id = Guid.NewGuid(),
                    Name = "Nick Pope",
                    Country = "England",
                    BirthDate = new DateTime()
                }
            );
        }
    }
}
