using Microsoft.EntityFrameworkCore;

namespace PhysicalInsight.AISDatabase
{
    public class AISDataContext : DbContext
    {
        public DbSet<AISData> AISData { get; set; }

        public string ConnectionString { get; set; }

        public AISDataContext()
        {
            ConnectionString = "Server=localhost;Database=AIS;Trusted_Connection=True;";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(ConnectionString);
    }
}