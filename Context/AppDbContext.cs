using HotelCalifornia.API.Models;
using Microsoft.EntityFrameworkCore;

namespace HotelCalifornia.API.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base (options)
        {
        }
        public DbSet<Guest> Guests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Guest>().HasData(
                 new Guest
                 {
                     Id = 1,
                     Name = "Patrick Richard Cruz",
                     Email = "prc@example.com",
                     Address = "Rua Bela Vista N 900 Funcionários",
                     CellNumber = "31988809090",
                     Cpf = "1234556"
                 },
                 new Guest 
                 {
                     Id = 2,
                     Name = "Ricardo Teixeira",
                     Email = "prc@example.com",
                     Address = "Rua Bela Vista N 900 Funcionários",
                     CellNumber = "31988809090",
                     Cpf = "12345677",
                 }
              );
            }
        }
    }

