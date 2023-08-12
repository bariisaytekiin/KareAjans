using KareAjans.DAL.Seed;
using KareAjans.Entity.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace KareAjans.DAL.Context
{
    public class KareAjansContext : IdentityDbContext
    {
        //public KareAjansContext(DbContextOptions<KareAjansContext> options):base(options)//Program.cs den gelen bağlantı isteğini karşılıyoruz.
        //{
                
        //}
        //Tablolar
        public DbSet<Adres> Adresler { get; set; }
        public DbSet<Fotograf> Fotograflar { get; set; }
        public DbSet<Manken> Mankenler { get; set; }
        public DbSet<Organizasyon> Organizasyonlar { get; set; }
        public DbSet<OrganizasyonGelir> OrganizasyonGelirler { get; set; }
        public DbSet<OrganizasyonGider> OrganizasyonGiderler { get; set; }
        public DbSet<Yorum> Yorumlar { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

        //ÖrnekDatalar

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Adres>().HasData(AdresSeed.adresler);

            builder.Entity<Fotograf>().HasData(FotografSeed.fotograflar);

            builder.Entity<Manken>().HasData(MankenSeed.mankenler);

            builder.Entity<Organizasyon>().HasData(OrganizasyonSeed.organizasyonlar);

            builder.Entity<OrganizasyonGelir>().HasData(OrganizasyonGelirSeed.organizasyonGelirleri);

            builder.Entity<OrganizasyonGider>().HasData(OrganizasyonGiderSeed.organizasyonGiderleri);

            builder.Entity<Yorum>().HasData(YorumSeed.yorumlar);


            base.OnModelCreating(builder);
        }

        //ConnectionString
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=PEACE\\BARIS;Database=KareAjansDB;User Id=sa;Password=1234;");
            }
        }

    }
}
