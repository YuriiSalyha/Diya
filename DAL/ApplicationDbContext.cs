using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;

namespace DAL
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Document> Documents { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Password> Passwords { get; set; }
        public DbSet<Person> People { get; set; }
        public DbSet<RealEstate> RealEstates { get; set; }
        public DbSet<TaxPayerCard> TaxPayerCards { get; set; }
        public DbSet<Transport> Transports { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(@"DATA SOURCE=DESKTOP-1LHBQ4A\MSSQLSERVER01; DATABASE=diiaDatabase; UID=yura; PWD=123; TrustServerCertificate=True;");
        }
    }
}
