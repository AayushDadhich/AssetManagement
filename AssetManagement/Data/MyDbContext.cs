using Microsoft.EntityFrameworkCore;

namespace AssetManagement.Models
{
    public class MyDbContext : DbContext
    {

        private const string connectionString = "Server=(localdb)\\mssqllocaldb;Database=EFCore;Trusted_Connection=True;";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

        public DbSet<Users> Users { get; set; }

    }
}