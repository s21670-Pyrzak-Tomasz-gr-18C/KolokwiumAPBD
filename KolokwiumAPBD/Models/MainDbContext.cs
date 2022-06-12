using Microsoft.EntityFrameworkCore;

namespace KolokwiumAPBD.Models
{
    public class MainDbContext : DbContext
    {
        public MainDbContext()
        {
        }

        public MainDbContext(DbContextOptions options) : base(options)
        {
        }

        //  public DbSet<> Klient { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            //modelBuilder.Entity<Klient>(e =>
            //{
            //    e.HasKey(e => e.IdKlient);
            //    e.Property(e => e.Imie).IsRequired().HasMaxLength(50);
            //    e.Property(e => e.Nazwisko).IsRequired().HasMaxLength(60);

            //    e.HasData(
            //        new Klient
            //        {
            //            IdKlient = 1,
            //            Imie = "Jan",
            //            Nazwisko = "Kowalski"
            //        },
            //        new Klient
            //        {
            //            IdKlient = 2,
            //            Imie = "Anna",
            //            Nazwisko = "Nowak"
            //        }
            //    );
            //});
        }
    }
}
